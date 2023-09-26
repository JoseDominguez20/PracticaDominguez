using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capamodelo
{
    public class sentencias
    {
        Conexion conexion = new Conexion();

        public OdbcDataAdapter usuarios()
        {
            string dabe= "SELECT * FROM tblusuario";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(dabe,conexion.AbrirConexion());
            return dataTable;
        }
    }
}
