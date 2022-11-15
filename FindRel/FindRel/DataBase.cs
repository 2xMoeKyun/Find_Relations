using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Data.SqlClient;

namespace FindRel
{
    public class DataBase
    {
        private string connectionString { get; } = @"Data Source=DESKTOP-8SMT9BF\SQLEXPRESS;Initial Catalog=ProductsDBtest;Integrated Security=True;TrustServerCertificate=Yes";//;TrustServerCertificate=Yes
        public SqlConnection sqlConnection { get; set; }

        public DataBase()
        {
            sqlConnection = new(connectionString);
        }

        public string GetConnectionString()
        {
            return connectionString;
        }

        public void openConnection()
        {
            if(sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }
        public void closeConnection()
        {
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
    }
}
