using EstablecimientosGeoReferenciados.modelo;
using EstablecimientosGeoReferenciados.utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstablecimientosGeoReferenciados
{
    public partial class Form1 : Form
    {
        List<Establecimiento> establecimientos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string idEstablecimineto = txtIdEstablecimiento.Text;
            Double num;
            if (Double.TryParse(txtRangoEnKM.Text, out num) && idEstablecimineto != "") {
                lblMensajeCargando.Visible = true;
                lblCantidaRegistros.Text = "Cantidad de Establecimientos  : --";
                txtCoordenadasEstab.Text = "--,--";
                Establecimiento establecimiento =  Utilidades.RetornaEstablecientoYLennaresultados(dgvRegistros, establecimientos, idEstablecimineto, Double.Parse(txtRangoEnKM.Text));

                if (establecimiento != null)
                {
                    lblMensajeCargando.Visible = false;
                    txtCoordenadasEstab.Text = establecimiento.ESTDIRLATITUD + "," + establecimiento.ESTDIRLONGITUD;
                    
                    lblCantidaRegistros.Text = "Cantidad de Establecimientos  : " + dgvRegistros.Rows.Count;
                }
                else {
                    lblMensajeCargando.Visible = false;
                    MessageBox.Show("No se encontraron resultados para el ID ingresado.");
                }
            }
            else
            {
                MessageBox.Show("Datos Ingresados incorrectos");
            }

         

        }

        private void btnSubirCsv_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            String RutaArchivo;
           
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                lblMensajeCargando.Visible = true;
                RutaArchivo = openFileDialog.FileName;
                string [] lineas  = System.IO.File.ReadAllLines(RutaArchivo);
                
                establecimientos = Utilidades.CSVtoListEstablecimiento(dgvRegistros,lineas);

                if (establecimientos.Count > 0 )
                {
                    lblMensajeCargando.Visible = false;
                    lblCantidaRegistros.Text = "Cantidad de Establecimientos :  "+establecimientos.Count;
                    gbDatos.Enabled = true;
                }
                else {
                    lblMensajeCargando.Visible = false;
                    MessageBox.Show("Error, el contenido del archivo contiene erores verifique");
                }
            }
            else {
                MessageBox.Show("Error al abrir el archivo");
            }
        }

        private void lblMensajeCargando_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblCantidaRegistros_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://frankcv12345.github.io/");
        }




        const int WM_SYSCOMMAND = 0x112;
        const int MOUSE_MOVE = 0xF012;

        // Declaraciones del API
        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        //
        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
    

        private void moverForm()
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, MOUSE_MOVE, 0);
        }

        private void Form1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            moverForm();
        }

    }
}
