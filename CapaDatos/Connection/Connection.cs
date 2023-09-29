using System.Data.SqlClient;
using System.Data;

namespace CapaDatos.Connection
{
    public class Connection_Database
    {
        private SqlConnection Conexion = new SqlConnection("Data Source=DESKTOP-Q3F047L\\ELIEZERSQL;Initial Catalog=Practica;Integrated Security=True");

        public SqlConnection OpenConnection()
        {
            if (Conexion.State == ConnectionState.Closed) Conexion.Open();
            return Conexion;
        }

        public SqlConnection CloseConnection()
        {
            if (Conexion.State == ConnectionState.Open) Conexion.Close();
            return Conexion;
        }
    }
}