using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace AguaPotable.Datos
{
    public class FacturaDAL
    {
        public DataTable ObtenerTodas()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = Conexion.ObtenerConexion();
                SqlDataAdapter da = new SqlDataAdapter(
                    @"SELECT f.FacturaID, f.NumeroFactura,
                      c.Nombre + ' ' + c.Apellido AS Cliente,
                      f.ConsumoM3, f.Total, f.Estado,
                      f.FechaEmision, f.FechaVencimiento
                      FROM Facturas f
                      JOIN Clientes c ON f.ClienteID = c.ClienteID", con);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener facturas: " + ex.Message);
            }
            return dt;
        }

        public bool Insertar(int clienteID, int lecturaID,
                             decimal consumo, decimal total)
        {
            try
            {
                string numero = "FAC-" + DateTime.Now.ToString("yyyyMMddHHmm");

                SqlConnection con = Conexion.ObtenerConexion();
                SqlCommand cmd = new SqlCommand(
                    @"INSERT INTO Facturas
                    (NumeroFactura, ClienteID, LecturaID,
                     FechaVencimiento, ConsumoM3, Total, Estado)
                    VALUES (@Numero, @ClienteID, @LecturaID,
                            DATEADD(day,15,GETDATE()), @Consumo, @Total, 'Pendiente')",
                    con);

                cmd.Parameters.AddWithValue("@Numero", numero);
                cmd.Parameters.AddWithValue("@ClienteID", clienteID);
                cmd.Parameters.AddWithValue("@LecturaID", lecturaID);
                cmd.Parameters.AddWithValue("@Consumo", consumo);
                cmd.Parameters.AddWithValue("@Total", total);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar factura: " + ex.Message);
            }
        }

        public bool MarcarPagada(int id)
        {
            try
            {
                SqlConnection con = Conexion.ObtenerConexion();
                SqlCommand cmd = new SqlCommand(
                    @"UPDATE Facturas SET Estado = 'Pagada',
                      FechaPago = GETDATE() WHERE FacturaID = @ID", con);

                cmd.Parameters.AddWithValue("@ID", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al marcar factura: " + ex.Message);
            }
        }

        public DataTable ObtenerVencidas()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = Conexion.ObtenerConexion();
                SqlDataAdapter da = new SqlDataAdapter(
                    @"SELECT f.FacturaID, f.NumeroFactura,
                      c.Nombre + ' ' + c.Apellido AS Cliente,
                      f.ConsumoM3, f.Total, f.Estado,
                      f.FechaEmision, f.FechaVencimiento
                      FROM Facturas f
                      JOIN Clientes c ON f.ClienteID = c.ClienteID
                      WHERE f.Estado = 'Vencida'", con);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener facturas vencidas: " + ex.Message);
            }
            return dt;
        }
    }
}
