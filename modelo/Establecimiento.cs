using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstablecimientosGeoReferenciados.modelo
{
    public class Establecimiento
    {

        public Establecimiento(string ESTNUMEINS, double ESTDIRLONGITUD, double ESTDIRLATITUD)
        {
            this.ESTNUMEINS = ESTNUMEINS;
            this.ESTDIRLATITUD = ESTDIRLATITUD;
            this.ESTDIRLONGITUD = ESTDIRLONGITUD;
        }
        public string ESTNUMEINS { get; set; } 
        public double ESTDIRLONGITUD { get; set; }
        public double ESTDIRLATITUD { get; set; }
        public double distanciaKMs { get; set; }


        
    }
}
