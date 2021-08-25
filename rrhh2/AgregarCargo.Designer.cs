namespace rrhh2
{
    partial class AgregarCargo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarCargo));
            this.label9 = new System.Windows.Forms.Label();
            this.txtNuevoCargo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(39, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 15);
            this.label9.TabIndex = 36;
            this.label9.Text = "AGREGAR NUEVO CARGO";
            // 
            // txtNuevoCargo
            // 
            this.txtNuevoCargo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNuevoCargo.Location = new System.Drawing.Point(15, 49);
            this.txtNuevoCargo.Name = "txtNuevoCargo";
            this.txtNuevoCargo.Size = new System.Drawing.Size(215, 20);
            this.txtNuevoCargo.TabIndex = 43;
            this.txtNuevoCargo.Text = "TXTNUEVOCARGO";
            this.txtNuevoCargo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNuevoCargo_KeyPress);
            // 
            // AgregarCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 97);
            this.Controls.Add(this.txtNuevoCargo);
            this.Controls.Add(this.label9);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgregarCargo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Cargo";
            this.Load += new System.EventHandler(this.AgregarCargo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNuevoCargo;
    }
}