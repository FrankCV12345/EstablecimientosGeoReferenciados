using EstablecimientosGeoReferenciados.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstablecimientosGeoReferenciados.utilidades
{
    public static class Utilidades
    {

        public static List<Establecimiento> CSVtoListEstablecimiento(DataGridView dataGridView, string[] lineas)
        {
            List<Establecimiento> establecimientos = new List<Establecimiento>();
            for (int i = 0; i < lineas.Length; i++)
            {
                string[] lineaItems = lineas[i].Split(',');
                if (i >= 1)
                {
                    try
                    {
                        Establecimiento establecimiento = new Establecimiento(lineaItems[1], Double.Parse(lineaItems[7]), Double.Parse(lineaItems[8]));

                        establecimientos.Add(establecimiento);
                        llenaDGV(dataGridView, establecimiento);
                    }
                    catch
                    {

                    }

                }
                else {
                    dataGridView.ColumnCount = 3;
                    dataGridView.Columns[0].Name = lineaItems[1];
                    dataGridView.Columns[1].Name = lineaItems[7];
                    dataGridView.Columns[2].Name = lineaItems[8];
                }

                //dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }

            return establecimientos;
        }


  
        public static void llenaDGV(DataGridView dataGridView , Establecimiento establecimiento) {
            try
            {
                    DataGridViewRow Row = new DataGridViewRow();
                    Row.CreateCells(dataGridView);
                    Row.Cells[0].Value = establecimiento.ESTNUMEINS;
                    Row.Cells[1].Value = establecimiento.ESTDIRLATITUD;
                    Row.Cells[2].Value = establecimiento.ESTDIRLONGITUD;
                    dataGridView.Rows.Add(Row);
            }
            catch {
            
            }
            
        
        }


        public static Establecimiento RetornaEstablecientoYLennaresultados(DataGridView dataGridView , List<Establecimiento> establecimientos,string idEstablecimiento , Double rangoKM)
        {
            Establecimiento establecimientoReferencia = (from establecimiento
                                                        in establecimientos
                                                   where establecimiento.ESTNUMEINS == idEstablecimiento
                                                   select establecimiento).FirstOrDefault();
            if (establecimientoReferencia != null) {

                Posicion origen = new Posicion(establecimientoReferencia.ESTDIRLATITUD, establecimientoReferencia.ESTDIRLONGITUD);

                var establecimientosDentroDelRango = (from establecimiento
                                                     in establecimientos
                                                      where
                                                      (
                                                         establecimiento.distanciaKMs = distanciaKM(
                                                          origen,
                                                          new Posicion(establecimiento.ESTDIRLATITUD, establecimiento.ESTDIRLONGITUD)
                                                          )
                                                      ) < rangoKM
                                                      where
                                                      establecimiento.ESTNUMEINS != establecimientoReferencia.ESTNUMEINS

                                                      select establecimiento).OrderByDescending(establecimiento => establecimiento.distanciaKMs);



                dataGridView.ColumnCount = 4;
                dataGridView.Columns[0].Name = "ESTNUMEINS";
                dataGridView.Columns[1].Name = "ESTDIRLATITUD";
                dataGridView.Columns[2].Name = "ESTDIRLONGITUD";
                dataGridView.Columns[3].Name = "Disancia en KM";
                dataGridView.Rows.Clear();
                dataGridView.Refresh();
                foreach (Establecimiento establecimiento in establecimientosDentroDelRango)
                {
                    DataGridViewRow Row = new DataGridViewRow();
                    Row.CreateCells(dataGridView);
                    Row.Cells[0].Value = establecimiento.ESTNUMEINS;
                    Row.Cells[1].Value = establecimiento.ESTDIRLATITUD;
                    Row.Cells[2].Value = establecimiento.ESTDIRLONGITUD;
                    Row.Cells[3].Value = establecimiento.distanciaKMs;

                    dataGridView.Rows.Add(Row);

                }
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            return establecimientoReferencia;

        }




        const float RadioKmTierraKM = 6378.0f;
        private static double distanciaKM(Posicion origen, Posicion destino)
        {
            var diferenciaLatitud = enRadiantes(origen.Latitud - destino.Latitud);
            var diferenciaLongitud = enRadiantes(origen.Longitud - destino.Longitud);
            var a = alCuadrado(Math.Sin(diferenciaLatitud / 2))
                    + Math.Cos(enRadiantes(origen.Latitud))
                    * Math.Cos(enRadiantes(destino.Latitud))
                    * alCuadrado(Math.Sin(diferenciaLongitud / 2));
            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            return RadioKmTierraKM * Convert.ToDouble(c);

        }
        private static double enRadiantes(double valor)
        {
            return Convert.ToSingle(Math.PI / 180) * valor;
        }
        private static double alCuadrado(double valor)
        {
            return Math.Pow(valor, 2);
        }
    }
}
