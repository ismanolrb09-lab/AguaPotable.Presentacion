using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace AguaPotable.Datos
{
    public class OrdenCorteDAL
    {
        public DataTable ObtenerTodas()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = Conexion.ObtenerConexion();
                SqlDataAdapter da = new SqlDataAdapter(
                    @"SELECT o.OrdenID, c.Nombre + ' ' + c.Apellido AS Cliente,
                      o.TipoOrden, o.FechaOrden, o.Estado, o.Motivo
                      FROM OrdenesCorte o
                      JOIN Clientes c ON o.ClienteID = c.ClienteID", con);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener ordenes de corte: " + ex.Message);
            }
            return dt;
        }

        public DataTable ObtenerPendientesCorte()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = Conexion.ObtenerConexion();
                SqlDataAdapter da = new SqlDataAdapter(
                    @"SELECT c.Nombre + ' ' + c.Apellido AS Cliente,
                      o.TipoOrden, o.FechaOrden, o.Motivo
                      FROM Clientes c
                      JOIN OrdenesCorte o ON c.ClienteID = o.ClienteID
                      WHERE o.Estado = 'Pendiente'
                      AND o.TipoOrden = 'Corte'
                      AND c.Activo = 1", con);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener cortes pendientes: " + ex.Message);
            }
            return dt;
        }

        public bool Insertar(int clienteID, int medidorID, string tipoOrden, string motivo)
        {
            try
            {
                SqlConnection con = Conexion.ObtenerConexion();
                SqlCommand cmd = new SqlCommand(
                    @"INSERT INTO OrdenesCorte
                      (ClienteID, MedidorID, TipoOrden, FechaOrden, Estado, Motivo)
                      VALUES (@ClienteID, @MedidorID, @Tipo, GETDATE(), 'Pendiente', @Motivo)",
                    con);

                cmd.Parameters.AddWithValue("@ClienteID", clienteID);
                cmd.Parameters.AddWithValue("@MedidorID", medidorID);
                cmd.Parameters.AddWithValue("@Tipo", tipoOrden);
                cmd.Parameters.AddWithValue("@Motivo", motivo);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar orden: " + ex.Message);
            }
        }

        public bool Ejecutar(int ordenID)
        {
            try
            {
                SqlConnection con = Conexion.ObtenerConexion();
                SqlCommand cmd = new SqlCommand(
                    @"UPDATE OrdenesCorte SET Estado = 'Ejecutada',
                      FechaEjecucion = GETDATE() WHERE OrdenID = @ID", con);

                cmd.Parameters.AddWithValue("@ID", ordenID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar orden: " + ex.Message);
            }
        }
    }
}
