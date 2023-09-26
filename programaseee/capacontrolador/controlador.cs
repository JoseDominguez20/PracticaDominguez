using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capamodelo;

namespace capacontrolador
{
    public class controlador
    {
        sentencias Senten = new sentencias();

        public DataTable Sentnencc()
        {
            OdbcDataAdapter jose = Senten.usuarios();
            DataTable Dablla = new DataTable();
            jose.Fill(Dablla);
            return Dablla;
        }

        public bool acceso(string usuario, string contraseña)
        {
            int contador = 0;
            bool valido = false;
            DataTable tabla = Sentnencc();
            foreach (DataRow row in tabla.Rows)
            {
                if (usuario == tabla.Rows[contador][1].ToString() && contraseña == tabla.Rows[contador][2].ToString()) 
                {
                    valido = true;
                    contador++;
                }
            }
            return valido;
        }
    }
}
