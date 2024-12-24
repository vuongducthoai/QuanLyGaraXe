using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using WinFormsApp.Models;

namespace WinFormsApp.DAO
{
    internal class RepairDAO
    {
        public static RepairDAO instance = new RepairDAO();

        public void SearchRepairByLicensePlate(string licensePlate)
        {
            string query = "SELECT * FROM PHIEUSUACHUA WHERE BienSo = @bienso ";
            SqlConnection con = DataProvider.instance.getConnect();
            using (con)
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@bienso", licensePlate);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        public DataTable SearchRepairByDate(string query, string parameterName, string parameterValue)
        {
            try
            {
                using (SqlConnection conn = DataProvider.instance.getConnect())
                {
                    conn.Open();

                    // Điều chỉnh truy vấn để sử dụng CONVERT
                    string adjustedQuery = query.Replace(parameterName, $"CONVERT(DATE, NgaySuaChua) = @date");

                    SqlCommand cmd = new SqlCommand(adjustedQuery, conn);
                    cmd.Parameters.AddWithValue("@date", parameterValue);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    return table;
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu cần
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }

        public string LoadIdRepair()
        {
            SqlConnection con = DataProvider.instance.getConnect();
            using (con)
            {
                con.Open();
                string sql = "SELECT COUNT(*) + 1 AS SO FROM PHIEUSUACHUA";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dr = cmd.ExecuteReader();
                string l = "";
                if (dr.Read())
                    l = dr["SO"].ToString();
                con.Close();
                return "SC" + l;
            }
        }

        public void AddRepair(PhieuSuaChua repair)
        {
            string sql = "INSERT INTO PHIEUSUACHUA (MaPSC, BienSo, NgaySuaChua, TongTien) VALUES (@masc, @bienso, GETDATE(), @tongtien)";
            SqlConnection con = DataProvider.instance.getConnect();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                using (con)
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@masc", repair.MaPSC);
                    cmd.Parameters.AddWithValue("@bienso", repair.BienSo);
                    cmd.Parameters.AddWithValue("@tongtien", repair.TongTien);
                    //cmd.Parameters.AddWithValue("@ngaysuachua", repair.NgaySuaChua);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        public void AddRepair_Detail(CT_PSC repair_Detail)
        {
            string sql = "INSERT INTO CT_PHIEUSUACHUA (MaPSC, NoiDung, MaVTPT, TenVTPT, SoLuong, DonGia, MaTienCong, TienCong, ThanhTien) " +
                "VALUES (@masc, @noidung, @mavtpt, @tenvtpt, @soluong, @dongia, @matiencong, @tiencong, @thanhtien)";
            SqlConnection con = DataProvider.instance.getConnect();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                using (con)
                {
                    con.Open();

                    cmd.Parameters.AddWithValue("@masc", repair_Detail.MaPSC);
                    cmd.Parameters.AddWithValue("@noidung", repair_Detail.NoiDung);
                    cmd.Parameters.AddWithValue("@mavtpt", repair_Detail.MaVTPT);
                    cmd.Parameters.AddWithValue("@tenvtpt", repair_Detail.TenVTPT);
                    cmd.Parameters.AddWithValue("@soluong", repair_Detail.SoLuong);
                    cmd.Parameters.AddWithValue("@dongia", repair_Detail.DonGia);
                    cmd.Parameters.AddWithValue("@matiencong", repair_Detail.MaTienCong);
                    cmd.Parameters.AddWithValue("@tiencong", repair_Detail.TienCong);
                    cmd.Parameters.AddWithValue("@thanhtien", repair_Detail.ThanhTien);

                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
