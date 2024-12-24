using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.DAO
{
    public class DataProviderLocal

    {


        private static DataProviderLocal instance;
        public static DataProviderLocal Instance
        {
            get { if (instance == null) instance = new DataProviderLocal(); return DataProviderLocal.instance; }
            private set { DataProviderLocal.instance = value; }
        }
        private DataProviderLocal(){ }
        
        string connectionSTR = @"Data Source=.\sqlexpress;Initial Catalog=QUANLIGARA;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        public DataTable ExecuteQuery (string query , object[] parameter = null)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR)) 
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if(parameter != null)
                {
                    string[] ListPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in ListPara)
                    {
                        if(item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
                connection.Close();
            }

           
            return dataTable;
        }
        public SqlConnection getConnect()
        {
            return new SqlConnection(connectionSTR);
        }
    }
}
