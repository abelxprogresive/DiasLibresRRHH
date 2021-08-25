namespace rrhh2
{
    partial class IngresoSolicitud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngresoSolicitud));
            this.btnAgregarSolicitud = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtRutSolicitud = new System.Windows.Forms.TextBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblFecSol = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_fecha_sol = new System.Windows.Forms.Label();
            this.dimeiggs = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.CCOSTOlbl = new System.Windows.Forms.Label();
            this.lblCcosto = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDsaldo = new System.Windows.Forms.Label();
            this.lblDuso = new System.Windows.Forms.Label();
            this.lblDbase = new System.Windows.Forms.Label();
            this.DSaldo = new System.Windows.Forms.Label();
            this.DUso = new System.Windows.Forms.Label();
            this.DBase = new System.Windows.Forms.Label();
            this.lblNroCC = new System.Windows.Forms.Label();
            this.dgwMuestra = new System.Windows.Forms.DataGridView();
            this.sel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTIVO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblefectivo = new System.Windows.Forms.GroupBox();
            this.fechaDesdeDia = new System.Windows.Forms.DateTimePicker();
            this.fechaHastaDia = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMuestra)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.lblefectivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarSolicitud
            // 
            this.btnAgregarSolicitud.Enabled = false;
            this.btnAgregarSolicitud.Location = new System.Drawing.Point(498, 90);
            this.btnAgregarSolicitud.Name = "btnAgregarSolicitud";
            this.btnAgregarSolicitud.Size = new System.Drawing.Size(165, 49);
            this.btnAgregarSolicitud.TabIndex = 97;
            this.btnAgregarSolicitud.Text = "Agregar Solicitud";
            this.btnAgregarSolicitud.UseVisualStyleBackColor = true;
            this.btnAgregarSolicitud.Click += new System.EventHandler(this.btnAgregarSolicitud_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 15);
            this.label10.TabIndex = 94;
            this.label10.Text = "Desde el Día";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(334, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 15);
            this.label9.TabIndex = 91;
            this.label9.Text = "Hasta el Día";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(156, 101);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(64, 15);
            this.lblArea.TabIndex = 90;
            this.lblArea.Text = "lblSucursal";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(156, 79);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(58, 15);
            this.lblCargo.TabIndex = 89;
            this.lblCargo.Text = "lblUnidad";
            // 
            // txtRutSolicitud
            // 
            this.txtRutSolicitud.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRutSolicitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRutSolicitud.Location = new System.Drawing.Point(159, 52);
            this.txtRutSolicitud.MaxLength = 8;
            this.txtRutSolicitud.Name = "txtRutSolicitud";
            this.txtRutSolicitud.Size = new System.Drawing.Size(71, 20);
            this.txtRutSolicitud.TabIndex = 0;
            this.txtRutSolicitud.Tag = "";
            this.txtRutSolicitud.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRutSolicitud_KeyPress);
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(236, 57);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(74, 15);
            this.lblEmpleado.TabIndex = 86;
            this.lblEmpleado.Text = "lblEmpleado";
            // 
            // lblFecSol
            // 
            this.lblFecSol.AutoSize = true;
            this.lblFecSol.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecSol.Location = new System.Drawing.Point(156, 27);
            this.lblFecSol.Name = "lblFecSol";
            this.lblFecSol.Size = new System.Drawing.Size(54, 15);
            this.lblFecSol.TabIndex = 85;
            this.lblFecSol.Text = "lblFecSol";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 84;
            this.label4.Text = "SUCURSAL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 15);
            this.label5.TabIndex = 83;
            this.label5.Text = "UNIDAD ADMINISTRATIVA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 82;
            this.label3.Text = "RUT EMPLEADO";
            // 
            // lbl_fecha_sol
            // 
            this.lbl_fecha_sol.AutoSize = true;
            this.lbl_fecha_sol.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_sol.Location = new System.Drawing.Point(8, 27);
            this.lbl_fecha_sol.Name = "lbl_fecha_sol";
            this.lbl_fecha_sol.Size = new System.Drawing.Size(101, 15);
            this.lbl_fecha_sol.TabIndex = 81;
            this.lbl_fecha_sol.Text = "FECHA SOLICITUD";
            // 
            // dimeiggs
            // 
            this.dimeiggs.AutoSize = true;
            this.dimeiggs.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dimeiggs.Location = new System.Drawing.Point(609, 9);
            this.dimeiggs.Name = "dimeiggs";
            this.dimeiggs.Size = new System.Drawing.Size(79, 15);
            this.dimeiggs.TabIndex = 80;
            this.dimeiggs.Text = "Dimeiggs S.A.";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.Location = new System.Drawing.Point(609, 27);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(43, 15);
            this.lblMes.TabIndex = 79;
            this.lblMes.Text = "lblMes";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(236, 3);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(219, 23);
            this.lbl_titulo.TabIndex = 78;
            this.lbl_titulo.Text = "COMPROBANTE DIA LIBRE";
            // 
            // CCOSTOlbl
            // 
            this.CCOSTOlbl.AutoSize = true;
            this.CCOSTOlbl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCOSTOlbl.Location = new System.Drawing.Point(8, 126);
            this.CCOSTOlbl.Name = "CCOSTOlbl";
            this.CCOSTOlbl.Size = new System.Drawing.Size(108, 15);
            this.CCOSTOlbl.TabIndex = 113;
            this.CCOSTOlbl.Text = "CENTRO DE COSTO";
            // 
            // lblCcosto
            // 
            this.lblCcosto.AutoSize = true;
            this.lblCcosto.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCcosto.Location = new System.Drawing.Point(213, 126);
            this.lblCcosto.Name = "lblCcosto";
            this.lblCcosto.Size = new System.Drawing.Size(56, 15);
            this.lblCcosto.TabIndex = 114;
            this.lblCcosto.Text = "lblCcosto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDsaldo);
            this.groupBox1.Controls.Add(this.lblDuso);
            this.groupBox1.Controls.Add(this.lblDbase);
            this.groupBox1.Controls.Add(this.DSaldo);
            this.groupBox1.Controls.Add(this.DUso);
            this.groupBox1.Controls.Add(this.DBase);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(498, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 100);
            this.groupBox1.TabIndex = 115;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de Días:";
            // 
            // lblDsaldo
            // 
            this.lblDsaldo.AutoSize = true;
            this.lblDsaldo.Location = new System.Drawing.Point(98, 68);
            this.lblDsaldo.Name = "lblDsaldo";
            this.lblDsaldo.Size = new System.Drawing.Size(68, 15);
            this.lblDsaldo.TabIndex = 5;
            this.lblDsaldo.Text = "lblDsaldo";
            this.lblDsaldo.Visible = false;
            // 
            // lblDuso
            // 
            this.lblDuso.AutoSize = true;
            this.lblDuso.Location = new System.Drawing.Point(98, 44);
            this.lblDuso.Name = "lblDuso";
            this.lblDuso.Size = new System.Drawing.Size(56, 15);
            this.lblDuso.TabIndex = 4;
            this.lblDuso.Text = "lblDuso";
            this.lblDuso.Visible = false;
            // 
            // lblDbase
            // 
            this.lblDbase.AutoSize = true;
            this.lblDbase.Location = new System.Drawing.Point(98, 22);
            this.lblDbase.Name = "lblDbase";
            this.lblDbase.Size = new System.Drawing.Size(64, 15);
            this.lblDbase.TabIndex = 3;
            this.lblDbase.Text = "lblDbase";
            // 
            // DSaldo
            // 
            this.DSaldo.AutoSize = true;
            this.DSaldo.Location = new System.Drawing.Point(7, 68);
            this.DSaldo.Name = "DSaldo";
            this.DSaldo.Size = new System.Drawing.Size(85, 15);
            this.DSaldo.TabIndex = 2;
            this.DSaldo.Text = "Días Saldo :";
            this.DSaldo.Visible = false;
            // 
            // DUso
            // 
            this.DUso.AutoSize = true;
            this.DUso.Location = new System.Drawing.Point(7, 44);
            this.DUso.Name = "DUso";
            this.DUso.Size = new System.Drawing.Size(81, 15);
            this.DUso.TabIndex = 1;
            this.DUso.Text = "Días Uso   :";
            this.DUso.Visible = false;
            // 
            // DBase
            // 
            this.DBase.AutoSize = true;
            this.DBase.Location = new System.Drawing.Point(7, 22);
            this.DBase.Name = "DBase";
            this.DBase.Size = new System.Drawing.Size(84, 15);
            this.DBase.TabIndex = 0;
            this.DBase.Text = "Días Base  :";
            // 
            // lblNroCC
            // 
            this.lblNroCC.AutoSize = true;
            this.lblNroCC.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroCC.Location = new System.Drawing.Point(156, 126);
            this.lblNroCC.Name = "lblNroCC";
            this.lblNroCC.Size = new System.Drawing.Size(64, 15);
            this.lblNroCC.TabIndex = 116;
            this.lblNroCC.Text = "nroCCosto";
            // 
            // dgwMuestra
            // 
            this.dgwMuestra.AllowUserToAddRows = false;
            this.dgwMuestra.AllowUserToDeleteRows = false;
            this.dgwMuestra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMuestra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sel,
            this.RUT,
            this.MOTIVO,
            this.FECHA,
            this.ID});
            this.dgwMuestra.Location = new System.Drawing.Point(28, 183);
            this.dgwMuestra.Name = "dgwMuestra";
            this.dgwMuestra.Size = new System.Drawing.Size(666, 207);
            this.dgwMuestra.TabIndex = 117;
            // 
            // sel
            // 
            this.sel.HeaderText = "Sel";
            this.sel.Name = "sel";
            this.sel.Width = 30;
            // 
            // RUT
            // 
            this.RUT.HeaderText = "RUT";
            this.RUT.Name = "RUT";
            this.RUT.Width = 80;
            // 
            // MOTIVO
            // 
            this.MOTIVO.HeaderText = "MOTIVO";
            this.MOTIVO.Name = "MOTIVO";
            this.MOTIVO.Width = 300;
            // 
            // FECHA
            // 
            this.FECHA.HeaderText = "FECHA MOTIVO";
            this.FECHA.Name = "FECHA";
            this.FECHA.Width = 150;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ID.Width = 50;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblNroCC);
            this.groupBox2.Controls.Add(this.lblCcosto);
            this.groupBox2.Controls.Add(this.CCOSTOlbl);
            this.groupBox2.Controls.Add(this.lblArea);
            this.groupBox2.Controls.Add(this.lblCargo);
            this.groupBox2.Controls.Add(this.txtRutSolicitud);
            this.groupBox2.Controls.Add(this.lblEmpleado);
            this.groupBox2.Controls.Add(this.lblFecSol);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lbl_fecha_sol);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(24, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(468, 149);
            this.groupBox2.TabIndex = 118;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion del Empleado";
            // 
            // lblefectivo
            // 
            this.lblefectivo.Controls.Add(this.fechaDesdeDia);
            this.lblefectivo.Controls.Add(this.fechaHastaDia);
            this.lblefectivo.Controls.Add(this.label10);
            this.lblefectivo.Controls.Add(this.label9);
            this.lblefectivo.Controls.Add(this.btnAgregarSolicitud);
            this.lblefectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblefectivo.Location = new System.Drawing.Point(28, 396);
            this.lblefectivo.Name = "lblefectivo";
            this.lblefectivo.Size = new System.Drawing.Size(669, 145);
            this.lblefectivo.TabIndex = 119;
            this.lblefectivo.TabStop = false;
            this.lblefectivo.Text = "ESTE SE HARÁ EFECTIVO EN LAS SIGUIENTES FECHAS";
            // 
            // fechaDesdeDia
            // 
            this.fechaDesdeDia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDesdeDia.Location = new System.Drawing.Point(89, 33);
            this.fechaDesdeDia.Name = "fechaDesdeDia";
            this.fechaDesdeDia.Size = new System.Drawing.Size(176, 21);
            this.fechaDesdeDia.TabIndex = 153;
            // 
            // fechaHastaDia
            // 
            this.fechaHastaDia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaHastaDia.Location = new System.Drawing.Point(410, 33);
            this.fechaHastaDia.Name = "fechaHastaDia";
            this.fechaHastaDia.Size = new System.Drawing.Size(148, 21);
            this.fechaHastaDia.TabIndex = 152;
            // 
            // IngresoSolicitud
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(709, 552);
            this.Controls.Add(this.lblefectivo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgwMuestra);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dimeiggs);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.lbl_titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IngresoSolicitud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso Solicitud";
            this.Load += new System.EventHandler(this.IngresoSolicitud_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMuestra)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.lblefectivo.ResumeLayout(false);
            this.lblefectivo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarSolicitud;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtRutSolicitud;
        private System.Windows.Forms.Label lblFecSol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_fecha_sol;
        private System.Windows.Forms.Label dimeiggs;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lbl_titulo;
        public System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label CCOSTOlbl;
        private System.Windows.Forms.Label lblCcosto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDsaldo;
        private System.Windows.Forms.Label lblDuso;
        private System.Windows.Forms.Label lblDbase;
        private System.Windows.Forms.Label DSaldo;
        private System.Windows.Forms.Label DUso;
        private System.Windows.Forms.Label DBase;
        private System.Windows.Forms.Label lblNroCC;
        private System.Windows.Forms.DataGridView dgwMuestra;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sel;
        private System.Windows.Forms.DataGridViewTextBoxColumn RUT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOTIVO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox lblefectivo;
        private System.Windows.Forms.DateTimePicker fechaDesdeDia;
        private System.Windows.Forms.DateTimePicker fechaHastaDia;
    }
}