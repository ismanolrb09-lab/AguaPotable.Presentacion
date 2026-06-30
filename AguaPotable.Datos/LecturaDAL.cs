using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AguaPotable.Datos
{
    public class LecturaDAL
    {
        public DataTable ObtenerTodas()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = Conexion.ObtenerConexion();
                SqlDataAdapter da = new SqlDataAdapter(
                    @"SELECT l.LecturaID, l.MedidorID, l.FechaLectura,
                      l.LecturaAnterior, l.LecturaActual, l.ConsumoM3
                      FROM Lecturas l", con);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener lecturas: " + ex.Message);
            }
            return dt;
        }

        public decimal ObtenerUltimaLectura(int medidorID)
        {
            decimal ultima = 0;
            try
            {
                SqlConnection con = Conexion.ObtenerConexion();
                SqlCommand cmd = new SqlCommand(
                    @"SELECT TOP 1 LecturaActual FROM Lecturas
                      WHERE MedidorID = @MedidorID
                      ORDER BY FechaLectura DESC, LecturaID DESC", con);
                cmd.Parameters.AddWithValue("@MedidorID", medidorID);

                con.Open();
                object resultado = cmd.ExecuteScalar();
                con.Close();

                if (resultado != null)
                    ultima = Convert.ToDecimal(resultado);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener ultima lectura: " + ex.Message);
            }
            return ultima;
        }

        public int ObtenerMedidorPorCliente(int clienteID)
        {
            int medidorID = 0;
            try
            {
                SqlConnection con = Conexion.ObtenerConexion();
                SqlCommand cmd = new SqlCommand(
                    @"SELECT TOP 1 MedidorID FROM Medidores
                      WHERE ClienteID = @ClienteID AND Estado = 'Activo'", con);
                cmd.Parameters.AddWithValue("@ClienteID", clienteID);

                con.Open();
                object resultado = cmd.ExecuteScalar();
                con.Close();

                if (resultado != null)
                    medidorID = Convert.ToInt32(resultado);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener medidor del cliente: " + ex.Message);
            }
            return medidorID;
        }

        public int Insertar(int medidorID, decimal lecturaActual)
        {
            try
            {
                decimal lecturaAnterior = ObtenerUltimaLectura(medidorID);

                SqlConnection con = Conexion.ObtenerConexion();
                SqlCommand cmd = new SqlCommand(
                    @"INSERT INTO Lecturas (MedidorID, LecturaAnterior, LecturaActual)
                      VALUES (@MedidorID, @Anterior, @Actual);
                      SELECT CAST(SCOPE_IDENTITY() AS INT);", con);

                cmd.Parameters.AddWithValue("@MedidorID", medidorID);
                cmd.Parameters.AddWithValue("@Anterior", lecturaAnterior);
                cmd.Parameters.AddWithValue("@Actual", lecturaActual);

                con.Open();
                int nuevoID = (int)cmd.ExecuteScalar();
                con.Close();

                return nuevoID;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar lectura: " + ex.Message);
            }
        }
    }
}