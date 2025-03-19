using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sistema_de_facturación
{
    class Conexion
    {
        private static readonly string StringCon = "SERVER= JEFFERSON\\SQLEXPRESS; DATABASE= Facturacion; Integrated security= true";

        public static SqlConnection Conectar()
        {
            return new SqlConnection(StringCon);
        }
    }
}
