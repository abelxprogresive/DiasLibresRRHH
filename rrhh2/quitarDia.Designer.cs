namespace rrhh2
{
    partial class quitarDia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quitarDia));
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
            this.dgwMuestra = new System.Windows.Forms.DataGridView();
            this.sel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTIVO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarSolicitud = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMuestra)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNroCC
            // 
            this.lblNroCC.AutoSize = true;
            this.lblNroCC.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroCC.Location = new System.Drawing.Point(160, 105);
            this.lblNroCC.Name = "lblNroCC";
            this.lblNroCC.Size = new System.Drawing.Size(64, 15);
            this.lblNroCC.TabIndex = 126;
            this.lblNroCC.Text = "nroCCosto";
            // 
            // lblCcosto
            // 
            this.lblCcosto.AutoSize = true;
            this.lblCcosto.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCcosto.Location = new System.Drawing.Point(217, 105);
            this.lblCcosto.Name = "lblCcosto";
            this.lblCcosto.Size = new System.Drawing.Size(56, 15);
            this.lblCcosto.TabIndex = 125;
            this.lblCcosto.Text = "lblCcosto";
            // 
            // CCOSTOlbl
            // 
            this.CCOSTOlbl.AutoSize = true;
            this.CCOSTOlbl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCOSTOlbl.Location = new System.Drawing.Point(12, 105);
            this.CCOSTOlbl.Name = "CCOSTOlbl";
            this.CCOSTOlbl.Size = new System.Drawing.Size(108, 15);
            this.CCOSTOlbl.TabIndex = 124;
            this.CCOSTOlbl.Text = "CENTRO DE COSTO";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(160, 80);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(64, 15);
            this.lblArea.TabIndex = 123;
            this.lblArea.Text = "lblSucursal";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(160, 58);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(58, 15);
            this.lblCargo.TabIndex = 122;
            this.lblCargo.Text = "lblUnidad";
            // 
            // txtRutElimina
            // 
            this.txtRutElimina.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRutElimina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRutElimina.Location = new System.Drawing.Point(163, 31);
            this.txtRutElimina.MaxLength = 8;
            this.txtRutElimina.Name = "txtRutElimina";
            this.txtRutElimina.Size = new System.Drawing.Size(71, 20);
            this.txtRutElimina.TabIndex = 121;
            this.txtRutElimina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRutElimina_KeyPress);
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(240, 36);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(74, 15);
            this.lblEmpleado.TabIndex = 120;
            this.lblEmpleado.Text = "lblEmpleado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 119;
            this.label4.Text = "SUCURSAL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 15);
            this.label5.TabIndex = 118;
            this.label5.Text = "UNIDAD ADMINISTRATIVA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 117;
            this.label3.Text = "RUT EMPLEADO";
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
            this.dgwMuestra.Location = new System.Drawing.Point(15, 145);
            this.dgwMuestra.Name = "dgwMuestra";
            this.dgwMuestra.Size = new System.Drawing.Size(564, 238);
            this.dgwMuestra.TabIndex = 127;
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
            this.MOTIVO.Width = 200;
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
            // btnAgregarSolicitud
            // 
            this.btnAgregarSolicitud.Location = new System.Drawing.Point(414, 389);
            this.btnAgregarSolicitud.Name = "btnAgregarSolicitud";
            this.btnAgregarSolicitud.Size = new System.Drawing.Size(165, 49);
            this.btnAgregarSolicitud.TabIndex = 128;
            this.btnAgregarSolicitud.Text = "Eliminar";
            this.btnAgregarSolicitud.UseVisualStyleBackColor = true;
            this.btnAgregarSolicitud.Click += new System.EventHandler(this.btnAgregarSolicitud_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(217, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(215, 15);
            this.lbl_titulo.TabIndex = 130;
            this.lbl_titulo.Text = "ELIMINA DÍA SI POR ERROR SE AGREGA";
            // 
            // quitarDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 450);
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
            this.Name = "quitarDia";
            this.Text = "ELIMINA DÍA SI POR ERROR SE AGREGA";
            this.Load += new System.EventHandler(this.quitarDia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMuestra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.DataGridView dgwMuestra;
        private System.Windows.Forms.Button btnAgregarSolicitud;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sel;
        private System.Windows.Forms.DataGridViewTextBoxColumn RUT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOTIVO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;

    }
}