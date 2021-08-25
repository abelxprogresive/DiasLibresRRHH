namespace rrhh2
{
    partial class AgregarArea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarArea));
            this.label1 = new System.Windows.Forms.Label();
            this.txtAreaNueva = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 15);
            this.label1.TabIndex = 41;
            this.label1.Text = "AGREGAR NUEVA AREA";
            // 
            // txtAreaNueva
            // 
            this.txtAreaNueva.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAreaNueva.Location = new System.Drawing.Point(15, 53);
            this.txtAreaNueva.Name = "txtAreaNueva";
            this.txtAreaNueva.Size = new System.Drawing.Size(215, 20);
            this.txtAreaNueva.TabIndex = 40;
            this.txtAreaNueva.Text = "TXTAREANUEVA";
            this.txtAreaNueva.TextChanged += new System.EventHandler(this.txtAreaNueva_TextChanged);
            this.txtAreaNueva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAreaNueva_KeyPress);
            // 
            // AgregarArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 98);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAreaNueva);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgregarArea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarArea";
            this.Load += new System.EventHandler(this.AgregarArea_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAreaNueva;
    }
}