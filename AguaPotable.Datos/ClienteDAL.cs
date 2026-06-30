using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace AguaPotable.Datos
{
    public class ClienteDAL
    {
        //OBTENER TODOS
        public DataTable ObtenerTodos()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = Conexion.ObtenerConexion();
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT * FROM Clientes WHERE Activo = 1", con);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener clientes: " + ex.Message);
            }
            return dt;
        }

        //INSERTAR
        public bool Insertar(string cedula, string nombre, string apellido,
                             string telefono, string direccion, string tipo)
        {
            try
            {
                SqlConnection con = Conexion.ObtenerConexion();
                SqlCommand cmd = new SqlCommand(
                    @"INSERT INTO Clientes
                    (Cedula, Nombre, Apellido, Telefono, Direccion, TipoCliente)
                    VALUES (@Cedula, @Nombre, @Apellido, @Telefono, @Direccion, @Tipo)",
                    con);

                cmd.Parameters.AddWithValue("@Cedula", cedula);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Apellido", apellido);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                cmd.Parameters.AddWithValue("@Direccion", direccion);
                cmd.Parameters.AddWithValue("@Tipo", tipo);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar cliente: " + ex.Message);
            }
        }

        //ACTUALIZAR
        public bool Actualizar(int id, string nombre, string apellido,
                               string telefono, string direccion)
        {
            try
            {
                SqlConnection con = Conexion.ObtenerConexion();
                SqlCommand cmd = new SqlCommand(
                    @"UPDATE Clientes SET
                    Nombre    = @Nombre,
                    Apellido  = @Apellido,
                    Telefono  = @Telefono,
                    Direccion = @Direccion
                    WHERE ClienteID = @ID",
                    con);

                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Apellido", apellido);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                cmd.Parameters.AddWithValue("@Direccion", direccion);
                cmd.Parameters.AddWithValue("@ID", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar cliente: " + ex.Message);
            }
        }

        //ELIMINAR
        public bool Eliminar(int id)
        {
            try
            {
                SqlConnection con = Conexion.ObtenerConexion();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Clientes SET Activo = 0 WHERE ClienteID = @ID", con);

                cmd.Parameters.AddWithValue("@ID", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar cliente: " + ex.Message);
            }
        }

        //BUSCAR POR CEDULA
        public DataTable Buscar(string cedula)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = Conexion.ObtenerConexion();
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT * FROM Clientes WHERE Cedula = @Cedula AND Activo = 1", con);
                da.SelectCommand.Parameters.AddWithValue("@Cedula", cedula);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar cliente: " + ex.Message);
            }
            return dt;
        }
    }
}

