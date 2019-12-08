namespace EstablecimientosGeoReferenciados
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvRegistros = new System.Windows.Forms.DataGridView();
            this.txtIdEstablecimiento = new System.Windows.Forms.TextBox();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRangoEnKM = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnSubirCsv = new System.Windows.Forms.Button();
            this.lblMensajeCargando = new System.Windows.Forms.Label();
            this.lblCantidaRegistros = new System.Windows.Forms.Label();
            this.lblCoordenadasEstab = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtCoordenadasEstab = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRegistros
            // 
            this.dgvRegistros.AllowUserToAddRows = false;
            this.dgvRegistros.AllowUserToDeleteRows = false;
            this.dgvRegistros.BackgroundColor = System.Drawing.Color.White;
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistros.Location = new System.Drawing.Point(380, 90);
            this.dgvRegistros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.ReadOnly = true;
            this.dgvRegistros.Size = new System.Drawing.Size(943, 470);
            this.dgvRegistros.TabIndex = 0;
            // 
            // txtIdEstablecimiento
            // 
            this.txtIdEstablecimiento.Location = new System.Drawing.Point(50, 71);
            this.txtIdEstablecimiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdEstablecimiento.Name = "txtIdEstablecimiento";
            this.txtIdEstablecimiento.Size = new System.Drawing.Size(166, 32);
            this.txtIdEstablecimiento.TabIndex = 4;
            this.txtIdEstablecimiento.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Controls.Add(this.label1);
            this.gbDatos.Controls.Add(this.txtRangoEnKM);
            this.gbDatos.Controls.Add(this.txtIdEstablecimiento);
            this.gbDatos.Controls.Add(this.btnBuscar);
            this.gbDatos.Enabled = false;
            this.gbDatos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbDatos.Location = new System.Drawing.Point(38, 226);
            this.gbDatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbDatos.Size = new System.Drawing.Size(267, 266);
            this.gbDatos.TabIndex = 6;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(45, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Distancia en KM : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(45, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID de Establecimiento :";
            // 
            // txtRangoEnKM
            // 
            this.txtRangoEnKM.Location = new System.Drawing.Point(50, 131);
            this.txtRangoEnKM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRangoEnKM.Name = "txtRangoEnKM";
            this.txtRangoEnKM.Size = new System.Drawing.Size(166, 32);
            this.txtRangoEnKM.TabIndex = 6;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscar.Image = global::EstablecimientosGeoReferenciados.Properties.Resources.outline_search_black_18dp;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(48, 186);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(170, 35);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::EstablecimientosGeoReferenciados.Properties.Resources.outline_minimize_white_24dp;
            this.button1.Location = new System.Drawing.Point(1237, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 69);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::EstablecimientosGeoReferenciados.Properties.Resources.baseline_close_white_24dp;
            this.btnCerrar.Location = new System.Drawing.Point(1307, 11);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(62, 69);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnSubirCsv
            // 
            this.btnSubirCsv.BackColor = System.Drawing.Color.White;
            this.btnSubirCsv.FlatAppearance.BorderSize = 0;
            this.btnSubirCsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubirCsv.Image = global::EstablecimientosGeoReferenciados.Properties.Resources.baseline_cloud_upload_black_24dp;
            this.btnSubirCsv.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSubirCsv.Location = new System.Drawing.Point(108, 98);
            this.btnSubirCsv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubirCsv.Name = "btnSubirCsv";
            this.btnSubirCsv.Size = new System.Drawing.Size(94, 76);
            this.btnSubirCsv.TabIndex = 1;
            this.btnSubirCsv.Text = "Subir CSV";
            this.btnSubirCsv.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSubirCsv.UseVisualStyleBackColor = false;
            this.btnSubirCsv.Click += new System.EventHandler(this.btnSubirCsv_Click);
            // 
            // lblMensajeCargando
            // 
            this.lblMensajeCargando.AutoSize = true;
            this.lblMensajeCargando.BackColor = System.Drawing.Color.Transparent;
            this.lblMensajeCargando.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblMensajeCargando.Location = new System.Drawing.Point(437, 44);
            this.lblMensajeCargando.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensajeCargando.Name = "lblMensajeCargando";
            this.lblMensajeCargando.Padding = new System.Windows.Forms.Padding(8);
            this.lblMensajeCargando.Size = new System.Drawing.Size(769, 36);
            this.lblMensajeCargando.TabIndex = 7;
            this.lblMensajeCargando.Text = "Cargando Archivo , esto puede tardar varios minutos dependiento de numero de regi" +
    "stro que tenga el . CSV ...";
            this.lblMensajeCargando.Visible = false;
            this.lblMensajeCargando.Click += new System.EventHandler(this.lblMensajeCargando_Click);
            // 
            // lblCantidaRegistros
            // 
            this.lblCantidaRegistros.AutoSize = true;
            this.lblCantidaRegistros.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidaRegistros.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblCantidaRegistros.Location = new System.Drawing.Point(376, 565);
            this.lblCantidaRegistros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidaRegistros.Name = "lblCantidaRegistros";
            this.lblCantidaRegistros.Padding = new System.Windows.Forms.Padding(8);
            this.lblCantidaRegistros.Size = new System.Drawing.Size(260, 36);
            this.lblCantidaRegistros.TabIndex = 8;
            this.lblCantidaRegistros.Text = "Cantidad de Establecimientos  : --";
            this.lblCantidaRegistros.Click += new System.EventHandler(this.lblCantidaRegistros_Click);
            // 
            // lblCoordenadasEstab
            // 
            this.lblCoordenadasEstab.AutoSize = true;
            this.lblCoordenadasEstab.BackColor = System.Drawing.Color.Transparent;
            this.lblCoordenadasEstab.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblCoordenadasEstab.Location = new System.Drawing.Point(676, 565);
            this.lblCoordenadasEstab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoordenadasEstab.Name = "lblCoordenadasEstab";
            this.lblCoordenadasEstab.Padding = new System.Windows.Forms.Padding(8);
            this.lblCoordenadasEstab.Size = new System.Drawing.Size(265, 36);
            this.lblCoordenadasEstab.TabIndex = 9;
            this.lblCoordenadasEstab.Text = "Coordenadas del establecimiento : ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Navy;
            this.linkLabel1.Location = new System.Drawing.Point(1210, 592);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(159, 20);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sobre el Desarrollador";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtCoordenadasEstab
            // 
            this.txtCoordenadasEstab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCoordenadasEstab.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCoordenadasEstab.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txtCoordenadasEstab.Location = new System.Drawing.Point(935, 576);
            this.txtCoordenadasEstab.Name = "txtCoordenadasEstab";
            this.txtCoordenadasEstab.Size = new System.Drawing.Size(271, 25);
            this.txtCoordenadasEstab.TabIndex = 11;
            this.txtCoordenadasEstab.Text = "--,--";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1382, 621);
            this.Controls.Add(this.txtCoordenadasEstab);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblCoordenadasEstab);
            this.Controls.Add(this.lblCantidaRegistros);
            this.Controls.Add(this.lblMensajeCargando);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnSubirCsv);
            this.Controls.Add(this.dgvRegistros);
            this.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Estableciminetos Georeferenciados";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRegistros;
        private System.Windows.Forms.Button btnSubirCsv;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtIdEstablecimiento;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRangoEnKM;
        private System.Windows.Forms.Label lblMensajeCargando;
        private System.Windows.Forms.Label lblCantidaRegistros;
        private System.Windows.Forms.Label lblCoordenadasEstab;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox txtCoordenadasEstab;
    }
}

