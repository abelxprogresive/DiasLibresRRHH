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
    public partial class EliminaUsuario : Form
    {
        SqlConnection cn = Conexion.getConexion();
        public EliminaUsuario()
        {
            InitializeComponent();
        }

        private void EliminaUsuario_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT usuario FROM usuarios", cn);
            da.Fill(ds, "USUARIO");
            cbUsuarios.DataSource = ds.Tables[0].DefaultView;
            cbUsuarios.ValueMember = "USUARIO";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand guarda = new SqlCommand("delete from usuarios where usuario = '" + cbUsuarios.Text + "'", cn);
            cn.Open();
            guarda.ExecuteNonQuery();
            MessageBox.Show("Usuario "+cbUsuarios.Text+" eliminado.", "Reestablecer contraseña", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            cbUsuarios.Text = "";
            cn.Close();
        }
    }
}
