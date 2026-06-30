using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AguaPotable.Datos
{
    public class UsuarioDAL
    {
        public bool ValidarLogin(string usuario, string contrasena)
        {
            try
            {
                SqlConnection con = Conexion.ObtenerConexion();
                SqlCommand cmd = new SqlCommand(
                    @"SELECT COUNT(*) FROM Usuarios
                      WHERE NombreUsuario = @Usuario
                      AND Contrasena = @Contrasena
                      AND Activo = 1", con);

                cmd.Parameters.AddWithValue("@Usuario", usuario);
                cmd.Parameters.AddWithValue("@Contrasena", contrasena);

                con.Open();
                int resultado = (int)cmd.ExecuteScalar();
                con.Close();
                return resultado > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al validar login: " + ex.Message);
            }
        }
    }
}