namespace rrhh2
{
    partial class ConsultaCcostocs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaCcostocs));
            this.dgw2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hastaRut = new System.Windows.Forms.DateTimePicker();
            this.desdeRut = new System.Windows.Forms.DateTimePicker();
            this.lblCos = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.GeneraExcelCC = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCenCos = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgw2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgw2
            // 
            this.dgw2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgw2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw2.Location = new System.Drawing.Point(12, 151);
            this.dgw2.Name = "dgw2";
            this.dgw2.Size = new System.Drawing.Size(825, 327);
            this.dgw2.TabIndex = 105;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hastaRut);
            this.groupBox1.Controls.Add(this.desdeRut);
            this.groupBox1.Controls.Add(this.lblCos);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.GeneraExcelCC);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtCenCos);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(826, 133);
            this.groupBox1.TabIndex = 104;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta por Centro de Costo";
            // 
            // hastaRut
            // 
            this.hastaRut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.hastaRut.Location = new System.Drawing.Point(129, 51);
            this.hastaRut.Name = "hastaRut";
            this.hastaRut.Size = new System.Drawing.Size(110, 23);
            this.hastaRut.TabIndex = 154;
            // 
            // desdeRut
            // 
            this.desdeRut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.desdeRut.Location = new System.Drawing.Point(129, 20);
            this.desdeRut.Name = "desdeRut";
            this.desdeRut.Size = new System.Drawing.Size(110, 23);
            this.desdeRut.TabIndex = 153;
            // 
            // lblCos
            // 
            this.lblCos.AutoSize = true;
            this.lblCos.Location = new System.Drawing.Point(244, 99);
            this.lblCos.Name = "lblCos";
            this.lblCos.Size = new System.Drawing.Size(39, 15);
            this.lblCos.TabIndex = 108;
            this.lblCos.Text = "lblCos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(731, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 15);
            this.label7.TabIndex = 107;
            this.label7.Text = "Genera Excel";
            // 
            // GeneraExcelCC
            // 
            this.GeneraExcelCC.Image = ((System.Drawing.Image)(resources.GetObject("GeneraExcelCC.Image")));
            this.GeneraExcelCC.Location = new System.Drawing.Point(734, 33);
            this.GeneraExcelCC.Name = "GeneraExcelCC";
            this.GeneraExcelCC.Size = new System.Drawing.Size(75, 58);
            this.GeneraExcelCC.TabIndex = 106;
            this.GeneraExcelCC.UseVisualStyleBackColor = true;
            this.GeneraExcelCC.Click += new System.EventHandler(this.GeneraExcelCC_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 15);
            this.label4.TabIndex = 100;
            this.label4.Text = "Centro de Costo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 15);
            this.label9.TabIndex = 104;
            this.label9.Text = "Hasta el Día";
            // 
            // txtCenCos
            // 
            this.txtCenCos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCenCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCenCos.Location = new System.Drawing.Point(166, 96);
            this.txtCenCos.MaxLength = 8;
            this.txtCenCos.Name = "txtCenCos";
            this.txtCenCos.Size = new System.Drawing.Size(71, 20);
            this.txtCenCos.TabIndex = 90;
            this.txtCenCos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCenCos_KeyPress);
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
            // ConsultaCcostocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 490);
            this.Controls.Add(this.dgw2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultaCcostocs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Días por Centro de Costo";
            this.Load += new System.EventHandler(this.ConsultaCcostocs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button GeneraExcelCC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCenCos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCos;
        private System.Windows.Forms.DateTimePicker hastaRut;
        private System.Windows.Forms.DateTimePicker desdeRut;
    }
}