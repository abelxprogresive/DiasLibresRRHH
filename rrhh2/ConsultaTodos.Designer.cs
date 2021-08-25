namespace rrhh2
{
    partial class ConsultaTodos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaTodos));
            this.dgw2 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fechaHasta = new System.Windows.Forms.DateTimePicker();
            this.fechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.GeneraExcelTodos = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConsultaFecha = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgw2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgw2
            // 
            this.dgw2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgw2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw2.Location = new System.Drawing.Point(12, 131);
            this.dgw2.Name = "dgw2";
            this.dgw2.Size = new System.Drawing.Size(818, 347);
            this.dgw2.TabIndex = 105;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fechaHasta);
            this.groupBox2.Controls.Add(this.fechaDesde);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.GeneraExcelTodos);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnConsultaFecha);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(825, 113);
            this.groupBox2.TabIndex = 104;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consulta por Fechas, Muestra a Todos los Empleados";
            // 
            // fechaHasta
            // 
            this.fechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaHasta.Location = new System.Drawing.Point(120, 46);
            this.fechaHasta.Name = "fechaHasta";
            this.fechaHasta.Size = new System.Drawing.Size(110, 23);
            this.fechaHasta.TabIndex = 151;
            // 
            // fechaDesde
            // 
            this.fechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDesde.Location = new System.Drawing.Point(120, 20);
            this.fechaDesde.Name = "fechaDesde";
            this.fechaDesde.Size = new System.Drawing.Size(110, 23);
            this.fechaDesde.TabIndex = 150;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(740, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 15);
            this.label8.TabIndex = 108;
            this.label8.Text = "Genera Excel";
            // 
            // GeneraExcelTodos
            // 
            this.GeneraExcelTodos.Image = ((System.Drawing.Image)(resources.GetObject("GeneraExcelTodos.Image")));
            this.GeneraExcelTodos.Location = new System.Drawing.Point(743, 30);
            this.GeneraExcelTodos.Name = "GeneraExcelTodos";
            this.GeneraExcelTodos.Size = new System.Drawing.Size(75, 58);
            this.GeneraExcelTodos.TabIndex = 107;
            this.GeneraExcelTodos.UseVisualStyleBackColor = true;
            this.GeneraExcelTodos.Click += new System.EventHandler(this.GeneraExcelTodos_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 108;
            this.label5.Text = "Hasta el Día";
            // 
            // btnConsultaFecha
            // 
            this.btnConsultaFecha.Location = new System.Drawing.Point(236, 20);
            this.btnConsultaFecha.Name = "btnConsultaFecha";
            this.btnConsultaFecha.Size = new System.Drawing.Size(104, 35);
            this.btnConsultaFecha.TabIndex = 106;
            this.btnConsultaFecha.Text = "Consultar";
            this.btnConsultaFecha.UseVisualStyleBackColor = true;
            this.btnConsultaFecha.Click += new System.EventHandler(this.btnConsultaFecha_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 109;
            this.label6.Text = "Desde el Día";
            // 
            // ConsultaTodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 490);
            this.Controls.Add(this.dgw2);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultaTodos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Todos";
            ((System.ComponentModel.ISupportInitialize)(this.dgw2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button GeneraExcelTodos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConsultaFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker fechaHasta;
        private System.Windows.Forms.DateTimePicker fechaDesde;

    }
}