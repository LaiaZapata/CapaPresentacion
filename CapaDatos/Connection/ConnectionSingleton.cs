using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Connection
{
    internal class ConnectionSingleton
    {
        /**private Connection_Database()
        {
            connection = new SqlConnection("Data Source=DESKTOP-Q3F047L\\ELIEZERSQL;Initial Catalog=Practica;Integrated Security=True");
        }

        public static Connection_Database GetInstance()
        {
            if (instance == null)
            {
                instance = new Connection_Database();
            }

            return instance;
        }

        public SqlConnection OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            return connection;
        }

        public SqlConnection CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }

            return connection;
        }**/
    }
}
