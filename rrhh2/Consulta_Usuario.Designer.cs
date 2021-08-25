namespace rrhh2
{
    partial class Consulta_Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_Usuario));
            this.dgw2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.cmbUsu = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.GeneraExcelCC = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgw2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgw2
            // 
            this.dgw2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgw2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw2.Location = new System.Drawing.Point(13, 117);
            this.dgw2.Name = "dgw2";
            this.dgw2.Size = new System.Drawing.Size(825, 355);
            this.dgw2.TabIndex = 108;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConsulta);
            this.groupBox1.Controls.Add(this.cmbUsu);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.GeneraExcelCC);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(826, 99);
            this.groupBox1.TabIndex = 107;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta por Usuario Logeado";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(337, 26);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(121, 23);
            this.btnConsulta.TabIndex = 113;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // cmbUsu
            // 
            this.cmbUsu.FormattingEnabled = true;
            this.cmbUsu.Location = new System.Drawing.Point(120, 26);
            this.cmbUsu.Name = "cmbUsu";
            this.cmbUsu.Size = new System.Drawing.Size(196, 23);
            this.cmbUsu.TabIndex = 112;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(734, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 15);
            this.label7.TabIndex = 107;
            this.label7.Text = "Genera Excel";
            // 
            // GeneraExcelCC
            // 
            this.GeneraExcelCC.Image = ((System.Drawing.Image)(resources.GetObject("GeneraExcelCC.Image")));
            this.GeneraExcelCC.Location = new System.Drawing.Point(734, 29);
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
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 15);
            this.label4.TabIndex = 100;
            this.label4.Text = "Seleccione Usuario";
            // 
            // Consulta_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 485);
            this.Controls.Add(this.dgw2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Consulta_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Usuario";
            this.Load += new System.EventHandler(this.Consulta_Usuario_Load);
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
        private System.Windows.Forms.ComboBox cmbUsu;
        private System.Windows.Forms.Button btnConsulta;
    }
}