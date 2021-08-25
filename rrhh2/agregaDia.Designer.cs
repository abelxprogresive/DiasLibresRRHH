namespace rrhh2
{
    partial class agregaDia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agregaDia));
            this.lblNroCC = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDsaldo = new System.Windows.Forms.Label();
            this.DSaldo = new System.Windows.Forms.Label();
            this.lblCcosto = new System.Windows.Forms.Label();
            this.CCOSTOlbl = new System.Windows.Forms.Label();
            this.cmbDia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.motivo1 = new System.Windows.Forms.ComboBox();
            this.lblMotivoTrabajo = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtRutSolicitud = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblFecSol = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_fecha_sol = new System.Windows.Forms.Label();
            this.dimeiggs = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btnAgregarSolicitud = new System.Windows.Forms.Button();
            this.fecha2 = new System.Windows.Forms.DateTimePicker();
            this.motivo2 = new System.Windows.Forms.ComboBox();
            this.fecha3 = new System.Windows.Forms.DateTimePicker();
            this.motivo3 = new System.Windows.Forms.ComboBox();
            this.fecha4 = new System.Windows.Forms.DateTimePicker();
            this.motivo4 = new System.Windows.Forms.ComboBox();
            this.fecha5 = new System.Windows.Forms.DateTimePicker();
            this.motivo5 = new System.Windows.Forms.ComboBox();
            this.fecha1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNroCC
            // 
            this.lblNroCC.AutoSize = true;
            this.lblNroCC.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroCC.Location = new System.Drawing.Point(161, 142);
            this.lblNroCC.Name = "lblNroCC";
            this.lblNroCC.Size = new System.Drawing.Size(64, 15);
            this.lblNroCC.TabIndex = 138;
            this.lblNroCC.Text = "nroCCosto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDsaldo);
            this.groupBox1.Controls.Add(this.DSaldo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(418, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 100);
            this.groupBox1.TabIndex = 137;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de Días:";
            // 
            // lblDsaldo
            // 
            this.lblDsaldo.AutoSize = true;
            this.lblDsaldo.Location = new System.Drawing.Point(97, 26);
            this.lblDsaldo.Name = "lblDsaldo";
            this.lblDsaldo.Size = new System.Drawing.Size(68, 15);
            this.lblDsaldo.TabIndex = 5;
            this.lblDsaldo.Text = "lblDsaldo";
            // 
            // DSaldo
            // 
            this.DSaldo.AutoSize = true;
            this.DSaldo.Location = new System.Drawing.Point(6, 26);
            this.DSaldo.Name = "DSaldo";
            this.DSaldo.Size = new System.Drawing.Size(85, 15);
            this.DSaldo.TabIndex = 2;
            this.DSaldo.Text = "Días Saldo :";
            // 
            // lblCcosto
            // 
            this.lblCcosto.AutoSize = true;
            this.lblCcosto.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCcosto.Location = new System.Drawing.Point(218, 142);
            this.lblCcosto.Name = "lblCcosto";
            this.lblCcosto.Size = new System.Drawing.Size(56, 15);
            this.lblCcosto.TabIndex = 136;
            this.lblCcosto.Text = "lblCcosto";
            // 
            // CCOSTOlbl
            // 
            this.CCOSTOlbl.AutoSize = true;
            this.CCOSTOlbl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCOSTOlbl.Location = new System.Drawing.Point(17, 142);
            this.CCOSTOlbl.Name = "CCOSTOlbl";
            this.CCOSTOlbl.Size = new System.Drawing.Size(108, 15);
            this.CCOSTOlbl.TabIndex = 135;
            this.CCOSTOlbl.Text = "CENTRO DE COSTO";
            // 
            // cmbDia
            // 
            this.cmbDia.Enabled = false;
            this.cmbDia.FormattingEnabled = true;
            this.cmbDia.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbDia.Location = new System.Drawing.Point(164, 172);
            this.cmbDia.Name = "cmbDia";
            this.cmbDia.Size = new System.Drawing.Size(37, 21);
            this.cmbDia.TabIndex = 134;
            this.cmbDia.SelectedIndexChanged += new System.EventHandler(this.cmbDia_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 133;
            this.label1.Text = "Fechas del Motivo";
            // 
            // motivo1
            // 
            this.motivo1.Enabled = false;
            this.motivo1.FormattingEnabled = true;
            this.motivo1.Location = new System.Drawing.Point(20, 215);
            this.motivo1.Name = "motivo1";
            this.motivo1.Size = new System.Drawing.Size(282, 21);
            this.motivo1.TabIndex = 131;
            // 
            // lblMotivoTrabajo
            // 
            this.lblMotivoTrabajo.AutoSize = true;
            this.lblMotivoTrabajo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivoTrabajo.Location = new System.Drawing.Point(17, 197);
            this.lblMotivoTrabajo.Name = "lblMotivoTrabajo";
            this.lblMotivoTrabajo.Size = new System.Drawing.Size(88, 15);
            this.lblMotivoTrabajo.TabIndex = 130;
            this.lblMotivoTrabajo.Text = "Motivo Trabajo";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(161, 117);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(64, 15);
            this.lblArea.TabIndex = 129;
            this.lblArea.Text = "lblSucursal";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(161, 95);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(58, 15);
            this.lblCargo.TabIndex = 128;
            this.lblCargo.Text = "lblUnidad";
            // 
            // txtRutSolicitud
            // 
            this.txtRutSolicitud.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRutSolicitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRutSolicitud.Location = new System.Drawing.Point(164, 68);
            this.txtRutSolicitud.MaxLength = 8;
            this.txtRutSolicitud.Name = "txtRutSolicitud";
            this.txtRutSolicitud.Size = new System.Drawing.Size(71, 20);
            this.txtRutSolicitud.TabIndex = 127;
            this.txtRutSolicitud.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRutSolicitud_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 15);
            this.label6.TabIndex = 126;
            this.label6.Text = "DIAS A AGREGAR";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(241, 73);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(74, 15);
            this.lblEmpleado.TabIndex = 125;
            this.lblEmpleado.Text = "lblEmpleado";
            // 
            // lblFecSol
            // 
            this.lblFecSol.AutoSize = true;
            this.lblFecSol.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecSol.Location = new System.Drawing.Point(161, 43);
            this.lblFecSol.Name = "lblFecSol";
            this.lblFecSol.Size = new System.Drawing.Size(54, 15);
            this.lblFecSol.TabIndex = 124;
            this.lblFecSol.Text = "lblFecSol";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 123;
            this.label4.Text = "SUCURSAL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 15);
            this.label5.TabIndex = 122;
            this.label5.Text = "UNIDAD ADMINISTRATIVA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 121;
            this.label3.Text = "RUT EMPLEADO";
            // 
            // lbl_fecha_sol
            // 
            this.lbl_fecha_sol.AutoSize = true;
            this.lbl_fecha_sol.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_sol.Location = new System.Drawing.Point(17, 43);
            this.lbl_fecha_sol.Name = "lbl_fecha_sol";
            this.lbl_fecha_sol.Size = new System.Drawing.Size(101, 15);
            this.lbl_fecha_sol.TabIndex = 120;
            this.lbl_fecha_sol.Text = "FECHA SOLICITUD";
            // 
            // dimeiggs
            // 
            this.dimeiggs.AutoSize = true;
            this.dimeiggs.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dimeiggs.Location = new System.Drawing.Point(515, 14);
            this.dimeiggs.Name = "dimeiggs";
            this.dimeiggs.Size = new System.Drawing.Size(79, 15);
            this.dimeiggs.TabIndex = 119;
            this.dimeiggs.Text = "Dimeiggs S.A.";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.Location = new System.Drawing.Point(515, 32);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(43, 15);
            this.lblMes.TabIndex = 118;
            this.lblMes.Text = "lblMes";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(252, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(150, 15);
            this.lbl_titulo.TabIndex = 117;
            this.lbl_titulo.Text = "AGREGAR DÍA DE TRABAJO";
            // 
            // btnAgregarSolicitud
            // 
            this.btnAgregarSolicitud.Enabled = false;
            this.btnAgregarSolicitud.Location = new System.Drawing.Point(449, 371);
            this.btnAgregarSolicitud.Name = "btnAgregarSolicitud";
            this.btnAgregarSolicitud.Size = new System.Drawing.Size(165, 49);
            this.btnAgregarSolicitud.TabIndex = 139;
            this.btnAgregarSolicitud.Text = "Guardar";
            this.btnAgregarSolicitud.UseVisualStyleBackColor = true;
            this.btnAgregarSolicitud.Click += new System.EventHandler(this.btnAgregarSolicitud_Click);
            // 
            // fecha2
            // 
            this.fecha2.Enabled = false;
            this.fecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha2.Location = new System.Drawing.Point(323, 243);
            this.fecha2.Name = "fecha2";
            this.fecha2.Size = new System.Drawing.Size(130, 20);
            this.fecha2.TabIndex = 142;
            // 
            // motivo2
            // 
            this.motivo2.Enabled = false;
            this.motivo2.FormattingEnabled = true;
            this.motivo2.Location = new System.Drawing.Point(20, 242);
            this.motivo2.Name = "motivo2";
            this.motivo2.Size = new System.Drawing.Size(282, 21);
            this.motivo2.TabIndex = 141;
            // 
            // fecha3
            // 
            this.fecha3.Enabled = false;
            this.fecha3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha3.Location = new System.Drawing.Point(323, 270);
            this.fecha3.Name = "fecha3";
            this.fecha3.Size = new System.Drawing.Size(130, 20);
            this.fecha3.TabIndex = 144;
            // 
            // motivo3
            // 
            this.motivo3.Enabled = false;
            this.motivo3.FormattingEnabled = true;
            this.motivo3.Location = new System.Drawing.Point(20, 269);
            this.motivo3.Name = "motivo3";
            this.motivo3.Size = new System.Drawing.Size(282, 21);
            this.motivo3.TabIndex = 143;
            // 
            // fecha4
            // 
            this.fecha4.Enabled = false;
            this.fecha4.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha4.Location = new System.Drawing.Point(323, 297);
            this.fecha4.Name = "fecha4";
            this.fecha4.Size = new System.Drawing.Size(130, 20);
            this.fecha4.TabIndex = 146;
            // 
            // motivo4
            // 
            this.motivo4.Enabled = false;
            this.motivo4.FormattingEnabled = true;
            this.motivo4.Location = new System.Drawing.Point(20, 296);
            this.motivo4.Name = "motivo4";
            this.motivo4.Size = new System.Drawing.Size(282, 21);
            this.motivo4.TabIndex = 145;
            // 
            // fecha5
            // 
            this.fecha5.Enabled = false;
            this.fecha5.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha5.Location = new System.Drawing.Point(323, 324);
            this.fecha5.Name = "fecha5";
            this.fecha5.Size = new System.Drawing.Size(130, 20);
            this.fecha5.TabIndex = 148;
            // 
            // motivo5
            // 
            this.motivo5.Enabled = false;
            this.motivo5.FormattingEnabled = true;
            this.motivo5.Location = new System.Drawing.Point(20, 323);
            this.motivo5.Name = "motivo5";
            this.motivo5.Size = new System.Drawing.Size(282, 21);
            this.motivo5.TabIndex = 147;
            // 
            // fecha1
            // 
            this.fecha1.Enabled = false;
            this.fecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha1.Location = new System.Drawing.Point(323, 215);
            this.fecha1.Name = "fecha1";
            this.fecha1.Size = new System.Drawing.Size(130, 20);
            this.fecha1.TabIndex = 149;
            // 
            // agregaDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 432);
            this.Controls.Add(this.fecha1);
            this.Controls.Add(this.fecha5);
            this.Controls.Add(this.motivo5);
            this.Controls.Add(this.fecha4);
            this.Controls.Add(this.motivo4);
            this.Controls.Add(this.fecha3);
            this.Controls.Add(this.motivo3);
            this.Controls.Add(this.fecha2);
            this.Controls.Add(this.motivo2);
            this.Controls.Add(this.btnAgregarSolicitud);
            this.Controls.Add(this.lblNroCC);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCcosto);
            this.Controls.Add(this.CCOSTOlbl);
            this.Controls.Add(this.cmbDia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.motivo1);
            this.Controls.Add(this.lblMotivoTrabajo);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.txtRutSolicitud);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.lblFecSol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_fecha_sol);
            this.Controls.Add(this.dimeiggs);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.lbl_titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "agregaDia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Día de Trabajo";
            this.Load += new System.EventHandler(this.agregaDia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNroCC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDsaldo;
        private System.Windows.Forms.Label DSaldo;
        private System.Windows.Forms.Label lblCcosto;
        private System.Windows.Forms.Label CCOSTOlbl;
        private System.Windows.Forms.ComboBox cmbDia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox motivo1;
        private System.Windows.Forms.Label lblMotivoTrabajo;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtRutSolicitud;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblFecSol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_fecha_sol;
        private System.Windows.Forms.Label dimeiggs;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btnAgregarSolicitud;
        private System.Windows.Forms.DateTimePicker fecha2;
        private System.Windows.Forms.ComboBox motivo2;
        private System.Windows.Forms.DateTimePicker fecha3;
        private System.Windows.Forms.ComboBox motivo3;
        private System.Windows.Forms.DateTimePicker fecha4;
        private System.Windows.Forms.ComboBox motivo4;
        private System.Windows.Forms.DateTimePicker fecha5;
        private System.Windows.Forms.ComboBox motivo5;
        private System.Windows.Forms.DateTimePicker fecha1;
    }
}