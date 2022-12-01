using MySql.Data.MySqlClient;
using System;

namespace UniLocadora.DAO
{
    class Conexao
    {
        const String server = "localhost";
        const String user = "root";
        const String pass = null;
        const String database = "uni_locadora_4n";

        public static MySqlConnection GetConnection()
        {
            try
            {
                String connStr = $"server={server};uid={user};pwd={pass};databse={database}";
                MySqlConnection conn = new MySqlConnection
                {
                    ConnectionString = connStr
                };
                return conn;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
