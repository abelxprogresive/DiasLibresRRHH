namespace rrhh2
{
    partial class CambiaClave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambiaClave));
            this.txtUSuario = new System.Windows.Forms.TextBox();
            this.txtContra1 = new System.Windows.Forms.TextBox();
            this.txtContra2 = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CClaveAceptar_btn = new System.Windows.Forms.Button();
            this.CClaveCancelar_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUSuario
            // 
            this.txtUSuario.Enabled = false;
            this.txtUSuario.Location = new System.Drawing.Point(138, 6);
            this.txtUSuario.Name = "txtUSuario";
            this.txtUSuario.Size = new System.Drawing.Size(100, 20);
            this.txtUSuario.TabIndex = 0;
            // 
            // txtContra1
            // 
            this.txtContra1.Location = new System.Drawing.Point(138, 37);
            this.txtContra1.Name = "txtContra1";
            this.txtContra1.Size = new System.Drawing.Size(100, 20);
            this.txtContra1.TabIndex = 1;
            this.txtContra1.UseSystemPasswordChar = true;
            // 
            // txtContra2
            // 
            this.txtContra2.Location = new System.Drawing.Point(138, 69);
            this.txtContra2.Name = "txtContra2";
            this.txtContra2.Size = new System.Drawing.Size(100, 20);
            this.txtContra2.TabIndex = 2;
            this.txtContra2.UseSystemPasswordChar = true;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(27, 9);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña nueva";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirmar contraseña";
            // 
            // CClaveAceptar_btn
            // 
            this.CClaveAceptar_btn.Location = new System.Drawing.Point(82, 95);
            this.CClaveAceptar_btn.Name = "CClaveAceptar_btn";
            this.CClaveAceptar_btn.Size = new System.Drawing.Size(75, 23);
            this.CClaveAceptar_btn.TabIndex = 6;
            this.CClaveAceptar_btn.Text = "Guardar";
            this.CClaveAceptar_btn.UseVisualStyleBackColor = true;
            this.CClaveAceptar_btn.Click += new System.EventHandler(this.CClaveAceptar_btn_Click);
            // 
            // CClaveCancelar_btn
            // 
            this.CClaveCancelar_btn.Location = new System.Drawing.Point(163, 95);
            this.CClaveCancelar_btn.Name = "CClaveCancelar_btn";
            this.CClaveCancelar_btn.Size = new System.Drawing.Size(75, 23);
            this.CClaveCancelar_btn.TabIndex = 7;
            this.CClaveCancelar_btn.Text = "Cancelar";
            this.CClaveCancelar_btn.UseVisualStyleBackColor = true;
            this.CClaveCancelar_btn.Click += new System.EventHandler(this.CClaveCancelar_btn_Click);
            // 
            // CambiaClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 133);
            this.Controls.Add(this.CClaveCancelar_btn);
            this.Controls.Add(this.CClaveAceptar_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtContra2);
            this.Controls.Add(this.txtContra1);
            this.Controls.Add(this.txtUSuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CambiaClave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambia Clave";
            this.Load += new System.EventHandler(this.CambiaClave_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUSuario;
        private System.Windows.Forms.TextBox txtContra1;
        private System.Windows.Forms.TextBox txtContra2;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CClaveAceptar_btn;
        private System.Windows.Forms.Button CClaveCancelar_btn;
    }
}