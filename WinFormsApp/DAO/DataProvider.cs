using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace WinFormsApp.DAO
{
    internal class DataProvider
    {
        public readonly string connectionSTR;
        public static DataProvider instance { get; private set; } = new DataProvider();

        public DataProvider()
        {
            try
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json")
                    .Build();

                connectionSTR = configuration.GetConnectionString("DefaultConnection")
                                ?? throw new InvalidOperationException(
                                    "Connection string not found.");


                Console.WriteLine("Connected to AWS database."); // Log để kiểm tra kết nối
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Lỗi khởi tạo DataProvider: " + ex.Message, ex);
            }
        }

        public SqlConnection getConnect()
        {
            if (connectionSTR == null)
            {
                throw new InvalidOperationException("Cannot connect to the database.");
            }
            return new SqlConnection(connectionSTR);
        }

        public DataTable ExecuteQuery(string query)
        {
            SqlConnection connection = this.getConnect();
            using (connection)
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                return data;
            }
        }
    }
}