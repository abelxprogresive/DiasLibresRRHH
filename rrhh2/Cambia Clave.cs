using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace rrhh2
{
    public partial class CambiaClave : Form
    {
        //SqlConnection conIngreso = new SqlConnection(@"Data Source=10.10.231.70;Initial Catalog=rrhh;Persist Security Info=True;User ID=sa;Password=Sa2011");
        SqlConnection cn = Conexion.getConexion();
        public CambiaClave()
        {
            InitializeComponent();
        }

        private void CambiaClave_Load(object sender, EventArgs e)
        {
            txtUSuario.Text = Login.idUsu;
            txtContra1.Focus();

        }

    
        private void CClaveAceptar_btn_Click(object sender, EventArgs e)
        {
            SqlCommand update = new SqlCommand("update USUARIOS set clave = '" + txtContra2.Text + "' where usuario = '" + txtUSuario.Text + "'", cn);
            if (txtContra1.Text == txtContra2.Text)
            {
                cn.Open();
                update.ExecuteNonQuery();
                MessageBox.Show("Contraseña guardada exitosamente", "Cambiar contraseña", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
            else 
            {
                MessageBox.Show("Contraseñas no coinciden. Intente nuevamente", "Cambiar contraseña", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtContra1.Text = "";
                txtContra2.Text = "";
                txtContra1.Focus();
            }
        }

        private void CClaveCancelar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        
    }
}