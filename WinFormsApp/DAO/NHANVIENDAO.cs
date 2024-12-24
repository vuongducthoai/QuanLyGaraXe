using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WinFormsApp.Models;

namespace WinFormsApp.DAO
{
    internal class NHANVIENDAO
    {       
        private static NHANVIENDAO instane;
        private NHANVIENDAO() 
        {
        }
        public static NHANVIENDAO Instane
        {
            get 
            {
                if (instane == null)
                    instane = new NHANVIENDAO();
                return instane;
            }
            set { instane = value; }
        }

        public DataTable HienThi()
        {
            string query = @"
        SELECT 
            TenDangNhap , 
            MatKhau , 
            TenNV , 
            DienThoai , 
            Email , 
            DiaChi , 
            ChucVu 
        FROM NHANVIEN";
            return DataProviderLocal.Instance.ExecuteQuery(query);

        }

        public bool Them (NhanVien nhanVien)
        {
            string sql = "INSERT INTO NHANVIEN (TenDangNhap, MatKhau, TenNV, DienThoai, Email, DiaChi, ChucVu) " +
                "VALUES( @tdn , @mk , @ten , @dth , @email , @dc , @cv )";
            try
            {
                DataProviderLocal.Instance.ExecuteQuery(sql, new object[] {nhanVien.TenDangNhap , nhanVien.MatKhau,nhanVien.TenNV, nhanVien.DienThoai ,  nhanVien.Email , nhanVien.DiaChi   , nhanVien.ChucVu });
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;

        }


        public void LoadComboBoxData(ComboBox comboBox)
        {
            string sql = "SELECT ChucVu FROM CHUCVU";
            DataTable dt = DataProviderLocal.Instance.ExecuteQuery(sql);
            comboBox.DataSource = dt;             // Gán DataTable làm nguồn dữ liệu
            comboBox.DisplayMember = "ChucVu";    // Cột hiển thị trong ComboBox
            comboBox.ValueMember = "ChucVu";      // Cột lưu giá trị của mục
        }

        public void Xoa(string tdn)
        {
            string query = $"DELETE FROM NHANVIEN WHERE TenDangNhap = @TenDangNhap";
            DataProviderLocal.Instance.ExecuteQuery(query, new object[] { tdn });
        }
        public DataTable TiemKiem(string TuKhoa)
        {
            string query = $"select * from NhanVien Where  " +
                $" TenNV Like N'%{TuKhoa}%' " +
                $"OR ChucVu Like N'%{TuKhoa}%'";
            return DataProviderLocal.Instance.ExecuteQuery(query);
        }

        public bool Sua (NhanVien nhanVien)
        {
            
            string query = "UPDATE NHANVIEN SET  TenNV = @ten , DienThoai = @dth , Email = @email , DiaChi = @diaChi , ChucVu = @cv " +
                " WHERE TenDangNhap = @tdn ";
            try
            {
                DataProviderLocal.Instance.ExecuteQuery(query , new object[] { nhanVien.TenNV, nhanVien.DienThoai, nhanVien.Email, nhanVien.DiaChi, nhanVien.ChucVu, nhanVien.TenDangNhap });
            }
            catch (Exception ex) { return false; }
            return true;
        }
        public bool DatLaiMatKhau (NhanVien nv)
        {
            string query = "UPDATE NHANVIEN SET  MatKhau = @mk " +
                " WHERE TenDangNhap = @tdn ";
            try
            {
                DataProviderLocal.Instance.ExecuteQuery(query, new object[] { "" , nv.TenDangNhap });
            }
            catch (Exception ex) { return false; }
            return true;

        }
        public bool KiemTraTenDangNhapTrung(string tenDangNhap)
        {
            string query = "SELECT COUNT(*) FROM NhanVien WHERE TenDangNhap = @TenDangNhap";
            DataTable result = DataProviderLocal.Instance.ExecuteQuery(query, new object[] { tenDangNhap });

            if (result.Rows.Count > 0)
            {
                int count = Convert.ToInt32(result.Rows[0][0]);
                return count > 0; // Nếu có ít nhất 1 bản ghi, tên đăng nhập đã tồn tại
            }

            return false;
        }







    }
}
