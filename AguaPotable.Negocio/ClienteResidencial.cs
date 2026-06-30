using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AguaPotable.Negocio
{
    public class ClienteResidencial : Cliente
    {
        public int CantPersonas { get; set; }

        //Constructor
        public ClienteResidencial(int id, string cedula, string nombre,
            string apellido, string telefono, string direccion, int cantPersonas)
            : base(id, cedula, nombre, apellido, telefono, direccion)
        {
            CantPersonas = cantPersonas;
        }

        //Constructor sobrecg
        public ClienteResidencial() : base()
        {
        }

        // Implementa el metodo abstracto ahora a tarifa residencial
        public override decimal CalcularConsumo(decimal m3)
        {
            return (m3 * 85m) + 250m;
        }

        public override string ObtenerTipo()
        {
            return "Residencial";
        }
    }
}
