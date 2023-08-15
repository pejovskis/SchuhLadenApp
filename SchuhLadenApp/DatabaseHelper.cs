using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SchuhLadenApp
{
    internal class DatabaseHelper
    {

        string connectionString = "Data Source=schuhappdb.db;Version=3;";

        public SQLiteConnection OpenConnection()
        {
            SQLiteConnection connection = new SQLiteConnection(this.connectionString);
            connection.Open();
            return connection;
        }

        public void CloseConnection(SQLiteConnection connection)
        {
            connection.Close();
        }

    }
}
