using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AguaPotable.Negocio
{
    public abstract class Cliente
    {
        public int ClienteID { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public bool Activo { get; set; }

        public Cliente(int id, string cedula, string nombre,
                       string apellido, string telefono, string direccion)
        {
            ClienteID = id;
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Direccion = direccion;
            Activo = true;
        }

        //Constructor otro
        public Cliente()
        {
            Activo = true;
        }

        // Metodo norma
        public string ObtenerNombreCompleto()
        {
            return Nombre + " " + Apellido;
        }

        // Metodo abstracto
        public abstract decimal CalcularConsumo(decimal m3);

        // Metodo virtual
        public virtual string ObtenerTipo()
        {
            return "Cliente General";
        }

        // Destructor
        ~Cliente()
        {
            // Libera referencia y registra evento de cierre en consola de depuracion
            System.Diagnostics.Debug.WriteLine("Cliente " + Nombre + " liberado de memoria.");
        }
    }
}
