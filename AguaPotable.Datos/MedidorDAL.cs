using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace AguaPotable.Datos
{
    public class MedidorDAL
    {
        public DataTable ObtenerTodos()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = Conexion.ObtenerConexion();
                SqlDataAdapter da = new SqlDataAdapter(
                    @"SELECT m.MedidorID, m.NumeroSerial, m.Estado,
                      c.Nombre + ' ' + c.Apellido AS Cliente
                      FROM Medidores m
                      LEFT JOIN Clientes c ON m.ClienteID = c.ClienteID", con);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener medidores: " + ex.Message);
            }
            return dt;
        }

        public bool Insertar(string serial, int clienteID)
        {
            try
            {
                SqlConnection con = Conexion.ObtenerConexion();
                SqlCommand cmd = new SqlCommand(
                    @"INSERT INTO Medidores (NumeroSerial, ClienteID, Estado)
                      VALUES (@Serial, @ClienteID, 'Activo')", con);

                cmd.Parameters.AddWithValue("@Serial", serial);
                cmd.Parameters.AddWithValue("@ClienteID", clienteID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar medidor: " + ex.Message);
            }
        }

        public bool CambiarEstado(int id, string estado)
        {
            try
            {
                SqlConnection con = Conexion.ObtenerConexion();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Medidores SET Estado = @Estado WHERE MedidorID = @ID", con);

                cmd.Parameters.AddWithValue("@Estado", estado);
                cmd.Parameters.AddWithValue("@ID", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cambiar estado: " + ex.Message);
            }
        }
    }
}
