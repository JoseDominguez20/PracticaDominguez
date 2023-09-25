using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capamodelo
{
    public class Conexion
    {
        
        
            private string connectionString;

            public Conexion()
            {
                // Asignar el nombre de la base de datos directamente
                string nombreBase = "Jose";
                connectionString = $"Dsn={nombreBase}";
            }
            public OdbcConnection AbrirConexion()
            {
                OdbcConnection conn = new OdbcConnection(connectionString);
                try
                {
                    conn.Open();
                    return conn;
                }
                catch (OdbcException ex)
                {
                    Console.WriteLine($"Error al abrir la conexión: {ex.Message}");
                    return null;
                }
            }
    }
}
