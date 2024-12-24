using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp.Model;

namespace WinFormsApp.DAO
{
    internal class OptionDAO
    {
        public static OptionDAO Instance = new OptionDAO();

        public void AddWage(Wage wage)
        {
            string query = "INSERT INTO dbo.TIENCONG (MaTienCong, NoiDung, TienCong) " +
                           "VALUES (@MaTienCong, @NoiDung, @TienCong)";
            using (SqlConnection connection = DataProvider.instance.getConnect())
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    command.Parameters.AddWithValue("@MaTienCong", wage.MaTienCong);
                    command.Parameters.AddWithValue("@NoiDung", wage.NoiDung);
                    command.Parameters.AddWithValue("@TienCong", wage.TienCong);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException("Lỗi kết nối: " + ex.Message, ex);
                }
            }
        }

        public void AddBrand(Brand brand)
        {
            string query = "INSERT INTO dbo.HIEUXE (HieuXe) " +
                           "VALUES (@HieuXe)";
            using (SqlConnection connection = DataProvider.instance.getConnect())
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    command.Parameters.AddWithValue("@HieuXe", brand.HieuXe);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException("Lỗi kết nối: " + ex.Message, ex);
                }
            }
        }

        public void AddSupplier(Supplier supplier) { }

        
    }
}
