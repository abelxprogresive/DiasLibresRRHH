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
    public partial class CrearUsuario : Form
    {
        SqlConnection cn = Conexion.getConexion();
        public CrearUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buscarUsuario(txtbxUsuario.Text);
            
        }

        public bool buscarUsuario(string rutt)
        {
            //convertir cadena a numero
            string usu = txtbxUsuario.Text;
            SqlDataAdapter estado = new SqlDataAdapter("SELECT usuario FROM usuarios WHERE usuario = '" +usu+"'", cn);
            DataSet dsEstado = new DataSet();
            //llenar dataset
            cn.Open();
            estado.Fill(dsEstado);
            cn.Close();


            if (dsEstado.Tables[0].Rows.Count == 1)
            {               
                    MessageBox.Show(usu + " Existe, revise.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtbxUsuario.Text = "";                                         
            }
            else
            {
                string usuario = txtbxUsuario.Text;
                string cadenaSQL = "INSERT INTO USUARIOS (usuario, clave, conectado, bloqueado) VALUES ('" + usuario + "','" + usuario + "',0,0)";
                SqlCommand guardaRegistro = new SqlCommand(cadenaSQL, cn);
                cn.Open();
                guardaRegistro.ExecuteNonQuery();
                MessageBox.Show("Usuario " + usuario + " creado.", "Crear usuario", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtbxUsuario.Text = "";
                cn.Close();
                
                return false; //el registro no fue encontrado
            }
            return true; //el registro existe
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
