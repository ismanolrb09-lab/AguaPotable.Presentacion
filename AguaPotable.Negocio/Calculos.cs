using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AguaPotable.Negocio
{
    public class Calculos
    {
        // Delegate recibe decimal y lo devuelve tambien
        public delegate decimal OperacionTarifa(decimal m3);

        // Lambda asignada al delegate la formula para clientes residenciales
        public OperacionTarifa TarifaResidencial =
            m3 => (m3 * 85m) + 250m;

        //Lambda asignada al delegate lo mismo de antes, pero ahora para lo clientes comerciale
        public OperacionTarifa TarifaComercial =
            m3 => ((m3 * 140m) + 750m) * 1.18m;
    }
}
