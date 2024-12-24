using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using WinFormsApp.Model;
using WinFormsApp.Models;

namespace WinFormsApp.DAO
{
    internal class PhieuNhapKhoVTPTDAO
    {
        public static PhieuNhapKhoVTPTDAO Instance = new PhieuNhapKhoVTPTDAO();

        public string AddPhieuNhapKho(PhieuNhapKhoVTPT phieuNhapKhoVTPT)
        {
            string maNKVTPT = getNextPhieuNhapKhoCode();
            string query = "INSERT INTO dbo.PHIEUNHAPKHOVTPT (MaNKVTPT, NgayNhap, MaNCC) " +
                           "VALUES (@MaNKVTPT, @NgayNhap, @MaNCC)";
            using (SqlConnection connection = DataProvider.instance.getConnect())
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        cmd.Parameters.AddWithValue("@MaNKVTPT", maNKVTPT);
                        cmd.Parameters.AddWithValue("@NgayNhap", phieuNhapKhoVTPT.ngayNhap);
                        cmd.Parameters.AddWithValue("@MaNCC", phieuNhapKhoVTPT.supplier.maNCC); 

                        cmd.ExecuteNonQuery();
                        return maNKVTPT;
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

        public string GetMaVTPTByTenVTPT(string tenVTPT)
        {
            string query = "SELECT MaVTPT FROM PHUTUNG WHERE TenVTPT = @TenVTPT";
            using (SqlConnection connection = DataProvider.instance.getConnect())
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TenVTPT", tenVTPT);

                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        return result.ToString();
                    }

                    return null; 
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException("Lỗi khi tìm MaVTPT: " + ex.Message, ex);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }


        public void addCT_PNKVTPTAndUpdatePhuTung(List<CT_PNKVTPT> cT_PNKVTPTs)
        {
           
            string insertQuery = "INSERT INTO CT_PNKVTPT (MaNKVTPT, MaVTPT, TenVTPT, SoLuong, GiaNhap) " +
                                 "VALUES (@MaNKVTPT, @MaVTPT, @TenVTPT, @SoLuong, @GiaNhap)";

            string updateQuery = "UPDATE PHUTUNG SET SoLuongTon = SoLuongTon + @SoLuong WHERE MaVTPT = @MaVTPT";

            using (SqlConnection connection = DataProvider.instance.getConnect())
            {
                SqlTransaction transaction = null;

                try
                {
                    connection.Open();
                    transaction = connection.BeginTransaction();

                    foreach (var item in cT_PNKVTPTs)
                    {
                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection, transaction))
                        {
                            insertCommand.Parameters.AddWithValue("@MaNKVTPT", item.phieuNhapKhoVTPT.maNKVTPT);
                            insertCommand.Parameters.AddWithValue("@MaVTPT", item.phuTung.MaVTPT);
                            insertCommand.Parameters.AddWithValue("@TenVTPT", item.phuTung.TenVTPT);
                            insertCommand.Parameters.AddWithValue("@SoLuong", item.SoLuong);
                            insertCommand.Parameters.AddWithValue("@GiaNhap", item.GiaNhap);

                            insertCommand.ExecuteNonQuery();
                        }

                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection, transaction))
                        {
                            updateCommand.Parameters.AddWithValue("@MaVTPT", item.phuTung.MaVTPT);
                            updateCommand.Parameters.AddWithValue("@SoLuong", item.SoLuong);

                            updateCommand.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction?.Rollback(); 
                    throw new InvalidOperationException("Lỗi khi thêm dữ liệu và cập nhật SoLuongTon: " + ex.Message, ex);
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


        public string getNextPhieuNhapKhoCode()
        {
            string query = "SELECT TOP 1 MaNKVTPT FROM PHIEUNHAPKHOVTPT ORDER BY MaNKVTPT DESC";
            using (SqlConnection connection = DataProvider.instance.getConnect())
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();

                    object result = command.ExecuteScalar();
                    connection.Close();

                    if (result != null && result is string lastCode && lastCode.StartsWith("NK"))
                    {
                        string numberPart = lastCode.Substring(2); 
                        if (int.TryParse(numberPart, out int currentNumber))
                        {
                            int nextNumber = currentNumber + 1; 
                            return "NK" + nextNumber.ToString("D3"); 
                        }
                    }

                    return "NK001";
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException("Lỗi kết nối: " + ex.Message, ex);
                }
            }
        }

        public List<CT_PNKVTPT> getPNKVTPTList(string maNKVTPT)
        {
            string sql = "SELECT MaVTPT AS 'Mã VTPT', TenVTPT AS 'Tên VTPT', SoLuong AS 'Số lượng', GiaNhap AS 'Đơn giá nhập' " +
                         "FROM CT_PNKVTPT WHERE MaNKVTPT = @maNKVTPT";

            List<CT_PNKVTPT> ctPnkvtptList = new List<CT_PNKVTPT>();

            using (SqlConnection connection = DataProvider.instance.getConnect())
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@maNKVTPT", maNKVTPT); 

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CT_PNKVTPT ctPnk = new CT_PNKVTPT
                            {
                                phuTung = new PhuTung
                                {
                                    MaVTPT = reader["Mã VTPT"].ToString(),
                                    TenVTPT = reader["Tên VTPT"].ToString()
                                },
                                SoLuong = int.Parse(reader["Số lượng"].ToString()),
                                GiaNhap = decimal.Parse(reader["Đơn giá nhập"].ToString())
                            };

                            ctPnkvtptList.Add(ctPnk);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException("Lỗi khi lấy danh sách CT_PNKVTPT: " + ex.Message, ex);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }

            return ctPnkvtptList;
        }


        public DataTable getPhieuNhapListByTerm(string term)
        {
            string sql = "SELECT c.MaNKVTPT AS 'ID', NgayNhap AS 'Ngày nhập hàng', " +
                         "SUM(SoLuong * GiaNhap) AS 'Tổng tiền thanh toán', TenNCC AS 'Đơn vị cung cấp' " +
                         "FROM PHIEUNHAPKHOVTPT AS p " +
                         "INNER JOIN CT_PNKVTPT AS c ON p.MaNKVTPT = c.MaNKVTPT " +
                         "INNER JOIN NHACUNGCAP AS n ON p.MaNCC = n.MaNCC " +
                         "WHERE TenNCC = @term OR c.MaNKVTPT = @term " +
                         "GROUP BY c.MaNKVTPT, NgayNhap, TenNCC";

            using (SqlConnection connection = DataProvider.instance.getConnect())
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@term", term);     

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    return dataTable;
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException("Lỗi khi lấy danh sách phiếu nhập: " + ex.Message, ex);
                }
            }
        }

        public DataTable getPhieuNhapListByDateRange(DateTime startDate, DateTime endDate)
        {
            string sql = "SELECT c.MaNKVTPT AS 'ID', NgayNhap AS 'Ngày nhập hàng', " +
                         "SUM(SoLuong * GiaNhap) AS 'Tổng tiền thanh toán', TenNCC AS 'Đơn vị cung cấp' " +
                         "FROM PHIEUNHAPKHOVTPT AS p " +
                         "INNER JOIN CT_PNKVTPT AS c ON p.MaNKVTPT = c.MaNKVTPT " +
                         "INNER JOIN NHACUNGCAP AS n ON p.MaNCC = n.MaNCC " +
                         "WHERE NgayNhap BETWEEN @startDate AND @endDate " +
                         "GROUP BY c.MaNKVTPT, NgayNhap, TenNCC";

            using (SqlConnection connection = DataProvider.instance.getConnect())
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@startDate", startDate); // Add start date parameter
                    command.Parameters.AddWithValue("@endDate", endDate); // Add end date parameter

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    return dataTable;
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException("Lỗi khi lấy danh sách phiếu nhập theo ngày: " + ex.Message, ex);
                }
            }
        }
    }
}
