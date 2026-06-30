using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AguaPotable.Datos
{
    public class Conexion
    {
        private static readonly string _cadena =
            "Server=.;Database=AguaPotableDB;Integrated Security=True;TrustServerCertificate=True;";

        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(_cadena);
        }
    }
}