namespace rrhh2
{
    partial class AgregaCargo
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
            this.label9 = new System.Windows.Forms.Label();
            this.txtCargoNuevo = new System.Windows.Forms.TextBox();
            this.btnAgregaNewCargo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 15);
            this.label9.TabIndex = 36;
            this.label9.Text = "AGREGAR NUEVO CARGO";
            // 
            // txtCargoNuevo
            // 
            this.txtCargoNuevo.Location = new System.Drawing.Point(15, 27);
            this.txtCargoNuevo.Name = "txtCargoNuevo";
            this.txtCargoNuevo.Size = new System.Drawing.Size(215, 20);
            this.txtCargoNuevo.TabIndex = 35;
            // 
            // btnAgregaNewCargo
            // 
            this.btnAgregaNewCargo.Location = new System.Drawing.Point(15, 53);
            this.btnAgregaNewCargo.Name = "btnAgregaNewCargo";
            this.btnAgregaNewCargo.Size = new System.Drawing.Size(109, 43);
            this.btnAgregaNewCargo.TabIndex = 34;
            this.btnAgregaNewCargo.Text = "AGREGAR";
            this.btnAgregaNewCargo.UseVisualStyleBackColor = true;
            this.btnAgregaNewCargo.Click += new System.EventHandler(this.btnAgregaNewCargo_Click);
            // 
            // AgregaCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 108);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCargoNuevo);
            this.Controls.Add(this.btnAgregaNewCargo);
            this.Name = "AgregaCargo";
            this.Text = "AgregaCargo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCargoNuevo;
        private System.Windows.Forms.Button btnAgregaNewCargo;
    }
}