namespace rrhh2
{
    partial class quitarRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quitarRegistro));
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btnAgregarSolicitud = new System.Windows.Forms.Button();
            this.dgwMuestra = new System.Windows.Forms.DataGridView();
            this.sel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTIVO1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHASOLICITUD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDMOTIVO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNroCC = new System.Windows.Forms.Label();
            this.lblCcosto = new System.Windows.Forms.Label();
            this.CCOSTOlbl = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtRutElimina = new System.Windows.Forms.TextBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMuestra)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(208, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(179, 15);
            this.lbl_titulo.TabIndex = 143;
            this.lbl_titulo.Text = "ELIMINA REGISTRO DE DÍA LIBRE";
            // 
            // btnAgregarSolicitud
            // 
            this.btnAgregarSolicitud.Location = new System.Drawing.Point(413, 389);
            this.btnAgregarSolicitud.Name = "btnAgregarSolicitud";
            this.btnAgregarSolicitud.Size = new System.Drawing.Size(165, 49);
            this.btnAgregarSolicitud.TabIndex = 142;
            this.btnAgregarSolicitud.Text = "Eliminar";
            this.btnAgregarSolicitud.UseVisualStyleBackColor = true;
            this.btnAgregarSolicitud.Click += new System.EventHandler(this.btnAgregarSolicitud_Click);
            // 
            // dgwMuestra
            // 
            this.dgwMuestra.AllowUserToAddRows = false;
            this.dgwMuestra.AllowUserToDeleteRows = false;
            this.dgwMuestra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMuestra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sel,
            this.RUT,
            this.MOTIVO1,
            this.FECHASOLICITUD,
            this.IDMOTIVO});
            this.dgwMuestra.Location = new System.Drawing.Point(14, 145);
            this.dgwMuestra.Name = "dgwMuestra";
            this.dgwMuestra.Size = new System.Drawing.Size(564, 238);
            this.dgwMuestra.TabIndex = 141;
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
            // MOTIVO1
            // 
            this.MOTIVO1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MOTIVO1.HeaderText = "MOTIVO";
            this.MOTIVO1.Name = "MOTIVO1";
            this.MOTIVO1.Width = 74;
            // 
            // FECHASOLICITUD
            // 
            this.FECHASOLICITUD.HeaderText = "FECHA DE LA SOLICITUD";
            this.FECHASOLICITUD.Name = "FECHASOLICITUD";
            this.FECHASOLICITUD.Width = 150;
            // 
            // IDMOTIVO
            // 
            this.IDMOTIVO.HeaderText = "ID";
            this.IDMOTIVO.Name = "IDMOTIVO";
            this.IDMOTIVO.ReadOnly = true;
            this.IDMOTIVO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IDMOTIVO.Width = 50;
            // 
            // lblNroCC
            // 
            this.lblNroCC.AutoSize = true;
            this.lblNroCC.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroCC.Location = new System.Drawing.Point(159, 105);
            this.lblNroCC.Name = "lblNroCC";
            this.lblNroCC.Size = new System.Drawing.Size(64, 15);
            this.lblNroCC.TabIndex = 140;
            this.lblNroCC.Text = "nroCCosto";
            // 
            // lblCcosto
            // 
            this.lblCcosto.AutoSize = true;
            this.lblCcosto.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCcosto.Location = new System.Drawing.Point(216, 105);
            this.lblCcosto.Name = "lblCcosto";
            this.lblCcosto.Size = new System.Drawing.Size(56, 15);
            this.lblCcosto.TabIndex = 139;
            this.lblCcosto.Text = "lblCcosto";
            // 
            // CCOSTOlbl
            // 
            this.CCOSTOlbl.AutoSize = true;
            this.CCOSTOlbl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCOSTOlbl.Location = new System.Drawing.Point(11, 105);
            this.CCOSTOlbl.Name = "CCOSTOlbl";
            this.CCOSTOlbl.Size = new System.Drawing.Size(108, 15);
            this.CCOSTOlbl.TabIndex = 138;
            this.CCOSTOlbl.Text = "CENTRO DE COSTO";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(159, 80);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(64, 15);
            this.lblArea.TabIndex = 137;
            this.lblArea.Text = "lblSucursal";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(159, 58);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(58, 15);
            this.lblCargo.TabIndex = 136;
            this.lblCargo.Text = "lblUnidad";
            // 
            // txtRutElimina
            // 
            this.txtRutElimina.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRutElimina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRutElimina.Location = new System.Drawing.Point(162, 31);
            this.txtRutElimina.MaxLength = 8;
            this.txtRutElimina.Name = "txtRutElimina";
            this.txtRutElimina.Size = new System.Drawing.Size(71, 20);
            this.txtRutElimina.TabIndex = 135;
            this.txtRutElimina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRutElimina_KeyPress_1);
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(239, 36);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(74, 15);
            this.lblEmpleado.TabIndex = 134;
            this.lblEmpleado.Text = "lblEmpleado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 133;
            this.label4.Text = "SUCURSAL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 15);
            this.label5.TabIndex = 132;
            this.label5.Text = "UNIDAD ADMINISTRATIVA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 131;
            this.label3.Text = "RUT EMPLEADO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(280, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 144;
            this.label1.Text = "*USAR CON CRITERIO*";
            // 
            // quitarRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.btnAgregarSolicitud);
            this.Controls.Add(this.dgwMuestra);
            this.Controls.Add(this.lblNroCC);
            this.Controls.Add(this.lblCcosto);
            this.Controls.Add(this.CCOSTOlbl);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.txtRutElimina);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "quitarRegistro";
            this.Text = "Quitar Registro";
            this.Load += new System.EventHandler(this.quitarRegistro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMuestra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btnAgregarSolicitud;
        private System.Windows.Forms.DataGridView dgwMuestra;
        private System.Windows.Forms.Label lblNroCC;
        private System.Windows.Forms.Label lblCcosto;
        private System.Windows.Forms.Label CCOSTOlbl;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtRutElimina;
        public System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sel;
        private System.Windows.Forms.DataGridViewTextBoxColumn RUT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOTIVO1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHASOLICITUD;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMOTIVO;
    }
}