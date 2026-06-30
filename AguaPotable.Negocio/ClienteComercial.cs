using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AguaPotable.Negocio
{
    public class ClienteComercial : Cliente
    {
        public string NombreNegocio { get; set; }
        public string RNC { get; set; }

        // Constructor
        public ClienteComercial(int id, string cedula, string nombre,
            string apellido, string telefono, string direccion,
            string nombreNegocio, string rnc)
            : base(id, cedula, nombre, apellido, telefono, direccion)
        {
            NombreNegocio = nombreNegocio;
            RNC = rnc;
        }

        // Constructor sobrecg
        public ClienteComercial() : base()
        {
        }

        // uso del metodo abstracto tarifa comercial
        public override decimal CalcularConsumo(decimal m3)
        {
            decimal subtotal = (m3 * 140m) + 750m;
            return subtotal * 1.18m;
        }

        public override string ObtenerTipo()
        {
            return "Comercial";
        }
    }
}

