namespace rrhh2
{
    partial class ConsultaRut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaRut));
            this.txtRutSolicitud = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hastaRut = new System.Windows.Forms.DateTimePicker();
            this.desdeRut = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.GeneraExcelRut = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgw2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRutSolicitud
            // 
            this.txtRutSolicitud.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRutSolicitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRutSolicitud.Location = new System.Drawing.Point(166, 71);
            this.txtRutSolicitud.MaxLength = 8;
            this.txtRutSolicitud.Name = "txtRutSolicitud";
            this.txtRutSolicitud.Size = new System.Drawing.Size(71, 20);
            this.txtRutSolicitud.TabIndex = 90;
            this.txtRutSolicitud.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRutSolicitud_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 89;
            this.label3.Text = "EMPLEADO";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(165, 136);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(64, 15);
            this.lblArea.TabIndex = 95;
            this.lblArea.Text = "lblSucursal";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(165, 114);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(58, 15);
            this.lblCargo.TabIndex = 94;
            this.lblCargo.Text = "lblUnidad";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(165, 94);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(74, 15);
            this.lblEmpleado.TabIndex = 93;
            this.lblEmpleado.Text = "lblEmpleado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 99;
            this.label1.Text = "SUCURSAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 15);
            this.label2.TabIndex = 98;
            this.label2.Text = "UNIDAD ADMINISTRATIVA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hastaRut);
            this.groupBox1.Controls.Add(this.desdeRut);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.GeneraExcelRut);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtRutSolicitud);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblEmpleado);
            this.groupBox1.Controls.Add(this.lblCargo);
            this.groupBox1.Controls.Add(this.lblArea);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(824, 160);
            this.groupBox1.TabIndex = 100;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta por Rut";
            // 
            // hastaRut
            // 
            this.hastaRut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.hastaRut.Location = new System.Drawing.Point(129, 46);
            this.hastaRut.Name = "hastaRut";
            this.hastaRut.Size = new System.Drawing.Size(110, 23);
            this.hastaRut.TabIndex = 152;
            // 
            // desdeRut
            // 
            this.desdeRut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.desdeRut.Location = new System.Drawing.Point(129, 20);
            this.desdeRut.Name = "desdeRut";
            this.desdeRut.Size = new System.Drawing.Size(110, 23);
            this.desdeRut.TabIndex = 151;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(741, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 15);
            this.label7.TabIndex = 107;
            this.label7.Text = "Genera Excel";
            // 
            // GeneraExcelRut
            // 
            this.GeneraExcelRut.Image = ((System.Drawing.Image)(resources.GetObject("GeneraExcelRut.Image")));
            this.GeneraExcelRut.Location = new System.Drawing.Point(743, 33);
            this.GeneraExcelRut.Name = "GeneraExcelRut";
            this.GeneraExcelRut.Size = new System.Drawing.Size(75, 58);
            this.GeneraExcelRut.TabIndex = 106;
            this.GeneraExcelRut.UseVisualStyleBackColor = true;
            this.GeneraExcelRut.Click += new System.EventHandler(this.GeneraExcelRut_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 100;
            this.label4.Text = "RUT";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 15);
            this.label9.TabIndex = 104;
            this.label9.Text = "Hasta el Día";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 15);
            this.label10.TabIndex = 105;
            this.label10.Text = "Desde el Día";
            // 
            // dgw2
            // 
            this.dgw2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgw2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw2.Location = new System.Drawing.Point(12, 178);
            this.dgw2.Name = "dgw2";
            this.dgw2.Size = new System.Drawing.Size(824, 300);
            this.dgw2.TabIndex = 102;
            // 
            // ConsultaRut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 490);
            this.Controls.Add(this.dgw2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultaRut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta por Rut";
            this.Load += new System.EventHandler(this.ConsultaRut_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtRutSolicitud;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblCargo;
        public System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgw2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button GeneraExcelRut;
        private System.Windows.Forms.DateTimePicker hastaRut;
        private System.Windows.Forms.DateTimePicker desdeRut;

    }
}