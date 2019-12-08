using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstablecimientosGeoReferenciados.modelo
{
    public class Posicion
    {


        public Posicion(double latidud, double longitud)
        {
            this.Longitud = longitud;
            this.Latitud = latidud;
        }


        public double Latitud { get; set; }
        public double Longitud { get; set; }
    }
}
