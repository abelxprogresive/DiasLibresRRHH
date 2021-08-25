namespace rrhh2
{
    partial class AgregaMotivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregaMotivo));
            this.label1 = new System.Windows.Forms.Label();
            this.txtMotivoNuevo = new System.Windows.Forms.TextBox();
            this.btnAgrega = new System.Windows.Forms.Button();
            this.cmbMotivo = new System.Windows.Forms.ComboBox();
            this.btnElimina = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 15);
            this.label1.TabIndex = 44;
            this.label1.Text = "AGREGAR NUEVO MOTIVO";
            // 
            // txtMotivoNuevo
            // 
            this.txtMotivoNuevo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMotivoNuevo.Location = new System.Drawing.Point(26, 42);
            this.txtMotivoNuevo.Name = "txtMotivoNuevo";
            this.txtMotivoNuevo.Size = new System.Drawing.Size(215, 20);
            this.txtMotivoNuevo.TabIndex = 43;
            // 
            // btnAgrega
            // 
            this.btnAgrega.Location = new System.Drawing.Point(256, 40);
            this.btnAgrega.Name = "btnAgrega";
            this.btnAgrega.Size = new System.Drawing.Size(75, 23);
            this.btnAgrega.TabIndex = 46;
            this.btnAgrega.Text = "Agregar";
            this.btnAgrega.UseVisualStyleBackColor = true;
            this.btnAgrega.Click += new System.EventHandler(this.btnAgrega_Click);
            // 
            // cmbMotivo
            // 
            this.cmbMotivo.FormattingEnabled = true;
            this.cmbMotivo.Location = new System.Drawing.Point(26, 96);
            this.cmbMotivo.Name = "cmbMotivo";
            this.cmbMotivo.Size = new System.Drawing.Size(215, 21);
            this.cmbMotivo.TabIndex = 47;
            // 
            // btnElimina
            // 
            this.btnElimina.Location = new System.Drawing.Point(256, 94);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(75, 23);
            this.btnElimina.TabIndex = 48;
            this.btnElimina.Text = "Elimina";
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // AgregaMotivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 142);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.cmbMotivo);
            this.Controls.Add(this.btnAgrega);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMotivoNuevo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgregaMotivo";
            this.Text = "Agrega Motivo";
            this.Load += new System.EventHandler(this.AgregaMotivo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMotivoNuevo;
        private System.Windows.Forms.Button btnAgrega;
        private System.Windows.Forms.ComboBox cmbMotivo;
        private System.Windows.Forms.Button btnElimina;
    }
}