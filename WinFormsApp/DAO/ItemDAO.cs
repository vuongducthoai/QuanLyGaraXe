using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;

namespace WinFormsApp.DAO
{
    internal class ItemDAO
    {
        public static ItemDAO instance = new ItemDAO();
        SqlDataAdapter da;
        public bool Xoa(string mavtpt)
        {
            SqlConnection con = DataProvider.instance.getConnect();
            try
            {
                con.Open();

                string sql = "DELETE FROM PHUTUNG WHERE MaVTPT = @mavtpt";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@mavtpt", mavtpt);
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public string LoadMAVTPT()
        {
            SqlConnection con = DataProvider.instance.getConnect();
            con.Open();
            string sql = "SELECT COUNT(*) + 1 AS SO FROM PHUTUNG";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            string l = "";
            if (dr.Read())
                l = dr["SO"].ToString();
            return "PT" + l;
        }
        public bool Them(string ma, string ten)
        {
            string sql = "INSERT INTO PhuTung (MaVTPT, TenVTPT, SoLuongTon, DonGia)" +
                "VALUES (@ma, @ten, 0, 0)";
            SqlConnection con = DataProvider.instance.getConnect();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);

                con.Open();
                cmd.Parameters.AddWithValue("@ma", ma);
                cmd.Parameters.AddWithValue("@ten", ten);

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public SqlDataReader LoadVTPT()
        {
            SqlConnection con = DataProvider.instance.getConnect();
            con.Open();
            string sql = "SELECT * FROM PHUTUNG";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dt = cmd.ExecuteReader();
            return dt;
        }
        public SqlDataReader LoadVTPTTheoTen(string ten)
        {

            SqlConnection con = DataProvider.instance.getConnect();
            con.Open();
            string sql = "SELECT * FROM PHUTUNG WHERE TenVTPT = @ten";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@ten", ten);
            SqlDataReader dt = cmd.ExecuteReader();
            return dt;

        }
        public bool SuaSL(string ma, int sl)
        {
            string sql = "UPDATE PHUTUNG SET SoLuongTon = @sl WHERE MaVTPT = @ma";
            SqlConnection con = DataProvider.instance.getConnect();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);

                con.Open();
                cmd.Parameters.AddWithValue("@ma", ma);
                cmd.Parameters.AddWithValue("@sl", sl);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public bool SuaSLDG(string ma, int sl, double dg)
        {
            string sql = "UPDATE PHUTUNG SET SoLuongTon = @sl, DonGia = @dg WHERE MaVTPT = @ma";
            SqlConnection con = DataProvider.instance.getConnect();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);

                con.Open();
                cmd.Parameters.AddWithValue("@ma", ma);
                cmd.Parameters.AddWithValue("@sl", sl);
                cmd.Parameters.AddWithValue("@dg", dg);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public bool Sua(string ma, string ten, double dg)
        {
            string sql = "UPDATE PHUTUNG SET TenVTPT = @ten, DonGia = @dg WHERE MaVTPT = @ma";
            SqlConnection con = DataProvider.instance.getConnect();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);

                con.Open();
                cmd.Parameters.AddWithValue("@ma", ma);
                cmd.Parameters.AddWithValue("@ten", ten);
                cmd.Parameters.AddWithValue("@dg", dg);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public DataTable TimKiemTheoMa(string s)
        {
            SqlConnection con = DataProvider.instance.getConnect();
            con.Open();
            string sql = "SELECT * FROM PHUTUNG WHERE MaVTPT LIKE CONCAT('%', @ten, '%')";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@ten", s);
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;


        }
    }
}
