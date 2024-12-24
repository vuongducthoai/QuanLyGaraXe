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
    internal class NhaCungCapDAO
    {
        public static NhaCungCapDAO Instance  = new NhaCungCapDAO();
        public List<Supplier> GetAllNhaCungCap()
        {
            string query = "SELECT MaNCC, TenNCC, SDT, Email FROM NHACUNGCAP";

            List<Supplier> nhaCungCapList = new List<Supplier>();

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
                                Supplier supplier = new Supplier
                                {
                                    maNCC = reader["MaNCC"].ToString(),
                                    tenNCC = reader["TenNCC"].ToString(),
                                    soDT = reader["SDT"].ToString(),
                                    email = reader["Email"].ToString()
                                };

                                nhaCungCapList.Add(supplier);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException("Error retrieving PhuTung data: " + ex.Message, ex);
                }
            }

            return nhaCungCapList;
        }
    }
}
