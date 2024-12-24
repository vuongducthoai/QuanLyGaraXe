using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp.Models;

namespace WinFormsApp.DAO
{
    internal class PhuTungDAO
    {
        public static PhuTungDAO Instance = new PhuTungDAO();

        public List<PhuTung> GetAllPhuTung()
        {
            string query = "SELECT MaVTPT, TenVTPT, SoLuongTon, DonGia FROM PHUTUNG";

            List<PhuTung> phuTungList = new List<PhuTung>();

            using (SqlConnection connection = DataProvider.instance.getConnect())
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                PhuTung phuTung = new PhuTung
                                {
                                    MaVTPT = reader["MaVTPT"].ToString(),
                                    TenVTPT = reader["TenVTPT"].ToString(),
                                    SoLuongTon = Convert.ToInt32(reader["SoLuongTon"]),
                                    DonGia = Convert.ToDecimal(reader["DonGia"])
                                };

                                phuTungList.Add(phuTung);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException("Error retrieving PhuTung data: " + ex.Message, ex);
                }
            }

            return phuTungList;
        }
        public bool FindPhuTungByName(PhuTung phuTung)
        {
            string query = "SELECT COUNT(*) FROM PHUTUNG WHERE TenVTPT = @tenPT";
            using (SqlConnection connection = DataProvider.instance.getConnect())
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@tenPT", phuTung.TenVTPT);

                        connection.Open();

                        object result = command.ExecuteScalar();
                        int count = Convert.ToInt32(result);

                        return count > 0;
                    }
                }
                catch (SqlException sqlEx)
                {
                    throw new InvalidOperationException("SQL error occurred while checking PhuTung by name: " + sqlEx.Message, sqlEx);
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException("Unexpected error occurred: " + ex.Message, ex);
                }
                finally
                {
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }


        public bool FindPhuTungByMaVTPT(string maPT)
        {
            string query = "SELECT COUNT(*) FROM PHUTUNG WHERE MaVTPT = @maVTPT";
            using (SqlConnection connection = DataProvider.instance.getConnect())
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@maVTPT", maPT);

                        connection.Open();

                        object result = command.ExecuteScalar();
                        int count = Convert.ToInt32(result);

                        return count > 0;
                    }
                }
                catch (SqlException sqlEx)
                {
                    throw new InvalidOperationException("SQL error occurred while checking PhuTung by MaVTPT: " + sqlEx.Message, sqlEx);
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException("Unexpected error occurred: " + ex.Message, ex);
                }
                finally
                {
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }


        public string getNextPhuTungCode()
        {
            string query = "SELECT TOP 1 MaVTPT FROM PHUTUNG ORDER BY MaVTPT DESC";
            using (SqlConnection connection = DataProvider.instance.getConnect())
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();

                    object result = command.ExecuteScalar();
                    connection.Close();

                    if (result != null && result is string lastCode && lastCode.StartsWith("PT"))
                    {
                        string numberPart = lastCode.Substring(2); // Extract the numeric part (e.g., "001")
                        if (int.TryParse(numberPart, out int currentNumber))
                        {
                            int nextNumber = currentNumber + 1; // Increment the numeric part
                            return "PT" + nextNumber.ToString("D3"); // Ensure the new code is zero-padded (e.g., "PT002")
                        }
                    }

                    // If no code exists or invalid format, start with "PT001"
                    return "PT001";
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException("Lỗi kết nối: " + ex.Message, ex);
                }
            }
        }



        public void AddPhuTung(PhuTung phuTung)
        {
            string maVTPT = getNextPhuTungCode();
            string query = "INSERT INTO dbo.PHUTUNG (MaVTPT, TenVTPT, SoLuongTon, DonGia) " +
                           "VALUES (@MaVTPT, @TenVTPT, @SoLuongTon, @DonGia)";
            using (SqlConnection connection = DataProvider.instance.getConnect())
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        cmd.Parameters.AddWithValue("@MaVTPT", maVTPT);
                        cmd.Parameters.AddWithValue("@TenVTPT", phuTung.TenVTPT);
                        cmd.Parameters.AddWithValue("@SoLuongTon", 0); // Default initial quantity
                        cmd.Parameters.AddWithValue("@DonGia", phuTung.DonGia);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (SqlException sqlEx)
                {
                    throw new InvalidOperationException("SQL error occurred: " + sqlEx.Message, sqlEx);
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException("Unexpected error occurred: " + ex.Message, ex);
                }
            }
        }


        public DataTable GetPhuTungByName(string term)
        {
            string sql = "SELECT p.TenVTPT AS 'Phụ Tùng', " +
                         "ISNULL(c.GiaNhap, 0) AS 'Giá Nhập', " +
                         "p.SoLuongTon AS 'Số lượng', " +
                         "p.DonGia AS 'Đơn giá' " +
                         "FROM PHUTUNG AS p " +
                         "LEFT JOIN CT_PNKVTPT AS c ON p.MaVTPT = c.MaVTPT " +
                         "WHERE p.TenVTPT LIKE '%' + @term + '%'";

            using (SqlConnection connection = DataProvider.instance.getConnect())
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@term", term); // Add the parameter

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    return dataTable;
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException("Lỗi khi tìm kiếm phụ tùng: " + ex.Message, ex);
                }
            }
        }
    }
}
