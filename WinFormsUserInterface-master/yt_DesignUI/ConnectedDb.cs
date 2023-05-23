using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace yt_DesignUI
{
    class ConnectedDb 
    {

        // подключаем базу данных

        SqlConnection sqlConnection = new SqlConnection(@"Data Source = ------------- ;Initial Catalog=NoteBd;Integrated Security = true");

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
        {
            return sqlConnection;
        }
    }
}
