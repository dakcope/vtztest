using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using Npgsql;

namespace WinFormsApp3
{
    internal class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dakco\source\repos\WinFormsApp3\WinFormsApp3\Database1.mdf;Integrated Security=True");
       //NpgsqlConnection sqlConnection = new NpgsqlConnection(@"User Id=postgres;Host=localhost;Database=vtz;Password=123;Persist Security Info=True;Initial Schema=public");

        

        
        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            
        }

        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }

        }

        public SqlConnection getConnection()
        //public NpgsqlConnection getConnection()
        {
            return sqlConnection;
        }


    }
}
