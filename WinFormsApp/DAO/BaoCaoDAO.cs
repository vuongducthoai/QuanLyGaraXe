using System;
using System.Collections.Generic;
using System.Data;
using WinFormsApp.Models;

namespace WinFormsApp.DAO
{
    public class BaoCaoDAO
    {
        private static BaoCaoDAO instance;

        public static BaoCaoDAO Instance
        {
            get
            {
                if (instance == null) instance = new BaoCaoDAO();
                return instance;
            }
            private set => instance = value;
        }

        private BaoCaoDAO()
        {
        }

        public List<BaoCaoDoanhSo> GetBaoCaoDoanhSo(int thang, int nam)
        {
            string query = $@"
                SELECT 
                    x.HieuXe,
                    COUNT(DISTINCT psc.MaPSC) as SoLuotSua,
                    SUM(ct.ThanhTien) as ThanhTien,
                    CAST(COUNT(DISTINCT psc.MaPSC) * 100.0 / 
                        NULLIF((SELECT COUNT(DISTINCT MaPSC) FROM PHIEUSUACHUA 
                         WHERE MONTH(NgaySuaChua) = {thang} AND YEAR(NgaySuaChua) = {nam}), 0)
                    AS float) as TiLe
                FROM XE x
                JOIN PHIEUSUACHUA psc ON x.BienSo = psc.BienSo
                JOIN CT_PSC ct ON psc.MaPSC = ct.MaPSC
                WHERE MONTH(psc.NgaySuaChua) = {thang} AND YEAR(psc.NgaySuaChua) = {nam}
                GROUP BY x.HieuXe";

            DataTable data = DataProvider.instance.ExecuteQuery(query);
            List<BaoCaoDoanhSo> result = new List<BaoCaoDoanhSo>();

            foreach (DataRow row in data.Rows)
            {
                BaoCaoDoanhSo baoCao = new BaoCaoDoanhSo
                {
                    HieuXe = row["HieuXe"].ToString(),
                    SoLuotSua = Convert.ToInt32(row["SoLuotSua"]),
                    ThanhTien = Convert.ToDecimal(row["ThanhTien"]),
                    TiLe = Convert.ToDouble(row["TiLe"])
                };
                result.Add(baoCao);
            }

            return result;
        }

        public decimal GetTongDoanhThu(int thang, int nam)
        {
            string query = $@"
                SELECT ISNULL(SUM(ct.ThanhTien), 0) as TongDoanhThu
                FROM PHIEUSUACHUA psc
                JOIN CT_PSC ct ON psc.MaPSC = ct.MaPSC
                WHERE MONTH(psc.NgaySuaChua) = {thang} AND YEAR(psc.NgaySuaChua) = {nam}";

            DataTable result = DataProvider.instance.ExecuteQuery(query);

            if (result.Rows.Count > 0)
            {
                return Convert.ToDecimal(result.Rows[0]["TongDoanhThu"]);
            }

            return 0;
        }

        public List<BaoCaoTon> GetBaoCaoTon(int thang, int nam)
        {
            // Xử lý tháng trước
            int thangTruoc = thang - 1;
            int namTruoc = nam;
            if (thangTruoc == 0)
            {
                thangTruoc = 12;
                namTruoc = nam - 1;
            }

            string query = $@"
                WITH TonDauKy AS (
                    -- Tính tồn đầu kỳ (là tồn cuối của tháng trước)
                    SELECT 
                        pt.MaVTPT,
                        pt.TenVTPT,
                        pt.SoLuongTon + 
                        ISNULL((
                            SELECT SUM(ct.SoLuong)
                            FROM CT_PNKVTPT ct 
                            JOIN PHIEUNHAPKHOVTPT p ON ct.MaNKVTPT = p.MaNKVTPT
                            WHERE ct.MaVTPT = pt.MaVTPT 
                            AND ((YEAR(p.NgayNhap) = {namTruoc}) OR 
                                 (YEAR(p.NgayNhap) = {nam} AND MONTH(p.NgayNhap) <= {thangTruoc}))
                        ), 0) -
                        ISNULL((
                            SELECT SUM(ct.SoLuong)
                            FROM CT_PSC ct 
                            JOIN PHIEUSUACHUA p ON ct.MaPSC = p.MaPSC
                            WHERE ct.MaVTPT = pt.MaVTPT
                            AND ((YEAR(p.NgaySuaChua) = {namTruoc}) OR 
                                 (YEAR(p.NgaySuaChua) = {nam} AND MONTH(p.NgaySuaChua) <= {thangTruoc}))
                        ), 0) as TonDau
                    FROM PHUTUNG pt
                ),
                NhapTrongKy AS (
                    -- Tính số lượng nhập trong kỳ
                    SELECT 
                        pt.MaVTPT,
                        ISNULL(SUM(ct.SoLuong), 0) as SoLuongNhap
                    FROM PHUTUNG pt
                    LEFT JOIN CT_PNKVTPT ct ON pt.MaVTPT = ct.MaVTPT
                    LEFT JOIN PHIEUNHAPKHOVTPT p ON ct.MaNKVTPT = p.MaNKVTPT
                    WHERE MONTH(p.NgayNhap) = {thang} AND YEAR(p.NgayNhap) = {nam}
                    GROUP BY pt.MaVTPT
                ),
                XuatTrongKy AS (
                    -- Tính số lượng xuất trong kỳ
                    SELECT 
                        pt.MaVTPT,
                        ISNULL(SUM(ct.SoLuong), 0) as SoLuongXuat
                    FROM PHUTUNG pt
                    LEFT JOIN CT_PSC ct ON pt.MaVTPT = ct.MaVTPT
                    LEFT JOIN PHIEUSUACHUA p ON ct.MaPSC = p.MaPSC
                    WHERE MONTH(p.NgaySuaChua) = {thang} AND YEAR(p.NgaySuaChua) = {nam}
                    GROUP BY pt.MaVTPT
                )
                SELECT 
                    t.MaVTPT,
                    t.TenVTPT,
                    t.TonDau,
                    ISNULL(n.SoLuongNhap, 0) as SoLuongNhap,
                    ISNULL(x.SoLuongXuat, 0) as SoLuongSuDung,
                    t.TonDau + ISNULL(n.SoLuongNhap, 0) - ISNULL(x.SoLuongXuat, 0) as TonCuoi
                FROM TonDauKy t
                LEFT JOIN NhapTrongKy n ON t.MaVTPT = n.MaVTPT
                LEFT JOIN XuatTrongKy x ON t.MaVTPT = x.MaVTPT
                ORDER BY t.MaVTPT;";

            try
            {
                DataTable data = DataProvider.instance.ExecuteQuery(query);
                List<BaoCaoTon> result = new List<BaoCaoTon>();

                foreach (DataRow row in data.Rows)
                {
                    BaoCaoTon baoCao = new BaoCaoTon
                    {
                        MaVTPT = row["MaVTPT"].ToString(),
                        TenVTPT = row["TenVTPT"].ToString(),
                        TonDau = Convert.ToInt32(row["TonDau"]),
                        SoLuongNhap = Convert.ToInt32(row["SoLuongNhap"]),
                        SoLuongSuDung = Convert.ToInt32(row["SoLuongSuDung"]),
                        TonCuoi = Convert.ToInt32(row["TonCuoi"])
                    };
                    result.Add(baoCao);
                }

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetBaoCaoTon: {ex.Message}");
                Console.WriteLine($"Stack trace: {ex.StackTrace}");
                throw;
            }
        }

        private int GetTonDauThang(string maVTPT, int thang, int nam)
        {
            string query = $@"
                SELECT ISNULL(
                    (SELECT SoLuongTon FROM PHUTUNG WHERE MaVTPT = '{maVTPT}') +
                    ISNULL((
                        SELECT SUM(SoLuong) 
                        FROM CT_PNKVTPT ct JOIN PHIEUNHAPKHOVTPT p ON ct.MaNKVTPT = p.MaNKVTPT
                        WHERE ct.MaVTPT = '{maVTPT}' 
                        AND (MONTH(p.NgayNhap) < {thang} AND YEAR(p.NgayNhap) = {nam})
                    ), 0) -
                    ISNULL((
                        SELECT SUM(SoLuong)
                        FROM CT_PSC ct JOIN PHIEUSUACHUA p ON ct.MaPSC = p.MaPSC
                        WHERE ct.MaVTPT = '{maVTPT}'
                        AND (MONTH(p.NgaySuaChua) < {thang} AND YEAR(p.NgaySuaChua) = {nam})
                    ), 0),
                    0
                ) AS TonDau";

            DataTable result = DataProvider.instance.ExecuteQuery(query);
            if (result.Rows.Count > 0)
            {
                return Convert.ToInt32(result.Rows[0]["TonDau"]);
            }

            return 0;
        }
    }
}