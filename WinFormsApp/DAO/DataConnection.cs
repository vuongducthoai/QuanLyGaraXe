using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.DAO
{
    internal class DataConnection
    {
        public static DataConnection instance;

        public string connectionSTR;

        public DataConnection()
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
    }
}
