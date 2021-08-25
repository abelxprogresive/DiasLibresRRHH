namespace rrhh2
{
    partial class InformeSaldo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformeSaldo));
            this.dgw2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCos = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.GeneraExcelCC = new System.Windows.Forms.Button();
            this.txtCenCos = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.GeneraExcelGeneral = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgw2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgw2
            // 
            this.dgw2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgw2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw2.Location = new System.Drawing.Point(21, 157);
            this.dgw2.Name = "dgw2";
            this.dgw2.Size = new System.Drawing.Size(825, 443);
            this.dgw2.TabIndex = 107;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCos);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.GeneraExcelCC);
            this.groupBox1.Controls.Add(this.txtCenCos);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(15, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 105);
            this.groupBox1.TabIndex = 106;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informe por Centro de Costo";
            // 
            // lblCos
            // 
            this.lblCos.AutoSize = true;
            this.lblCos.Location = new System.Drawing.Point(6, 49);
            this.lblCos.Name = "lblCos";
            this.lblCos.Size = new System.Drawing.Size(39, 15);
            this.lblCos.TabIndex = 108;
            this.lblCos.Text = "lblCos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(285, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 15);
            this.label7.TabIndex = 107;
            this.label7.Text = "Genera Excel";
            // 
            // GeneraExcelCC
            // 
            this.GeneraExcelCC.Image = ((System.Drawing.Image)(resources.GetObject("GeneraExcelCC.Image")));
            this.GeneraExcelCC.Location = new System.Drawing.Point(288, 17);
            this.GeneraExcelCC.Name = "GeneraExcelCC";
            this.GeneraExcelCC.Size = new System.Drawing.Size(75, 58);
            this.GeneraExcelCC.TabIndex = 106;
            this.GeneraExcelCC.UseVisualStyleBackColor = true;
            this.GeneraExcelCC.Click += new System.EventHandler(this.GeneraExcelCC_Click);
            // 
            // txtCenCos
            // 
            this.txtCenCos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCenCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCenCos.Location = new System.Drawing.Point(9, 22);
            this.txtCenCos.MaxLength = 8;
            this.txtCenCos.Name = "txtCenCos";
            this.txtCenCos.Size = new System.Drawing.Size(155, 20);
            this.txtCenCos.TabIndex = 90;
            this.txtCenCos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCenCos_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnProcesar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.GeneraExcelGeneral);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(396, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 105);
            this.groupBox2.TabIndex = 109;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reporte General";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(63, 37);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(95, 38);
            this.btnProcesar.TabIndex = 108;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(308, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 107;
            this.label2.Text = "Genera Excel";
            // 
            // GeneraExcelGeneral
            // 
            this.GeneraExcelGeneral.Image = ((System.Drawing.Image)(resources.GetObject("GeneraExcelGeneral.Image")));
            this.GeneraExcelGeneral.Location = new System.Drawing.Point(311, 17);
            this.GeneraExcelGeneral.Name = "GeneraExcelGeneral";
            this.GeneraExcelGeneral.Size = new System.Drawing.Size(75, 58);
            this.GeneraExcelGeneral.TabIndex = 106;
            this.GeneraExcelGeneral.UseVisualStyleBackColor = true;
            this.GeneraExcelGeneral.Click += new System.EventHandler(this.GeneraExcelGeneral_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(21, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(825, 139);
            this.groupBox3.TabIndex = 110;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informe Saldos y Días Usados";
            // 
            // InformeSaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 624);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgw2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InformeSaldo";
            this.Text = "Informe Saldo";
            this.Load += new System.EventHandler(this.InformeSaldo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button GeneraExcelCC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GeneraExcelGeneral;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblCos;
        private System.Windows.Forms.TextBox txtCenCos;
    }
}