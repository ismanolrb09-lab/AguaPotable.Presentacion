using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AguaPotable.Negocio
{
    public class CicloFacturacion
    {
        public int Anio { get; set; }
        public int Mes { get; set; }
        public bool Cerrado { get; set; }

        //Constructor
        public CicloFacturacion(int anio, int mes)
        {
            Anio = anio;
            Mes = mes;
            Cerrado = false;
        }

        //Constructor pa la sobrecargar 
        public CicloFacturacion()
        {
            Anio = DateTime.Now.Year;
            Mes = DateTime.Now.Month;
            Cerrado = false;
        }

        //Metodo voidd
        public void CerrarCiclo()
        {
            Cerrado = true;
        }

        //Destructor
        ~CicloFacturacion()
        {
            if (!Cerrado)
            {
                System.Diagnostics.Debug.WriteLine(
                    "Ciclo " + Mes + "/" + Anio + " cerrado automaticamente al destruirse.");
            }
        }
    }
}
