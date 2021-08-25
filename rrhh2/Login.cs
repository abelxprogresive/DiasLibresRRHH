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
    public partial class Login : Form
    {
        public static string idUsu;
        public static int u = 0;


        SqlConnection cn = Conexion.getConexion();        

        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Buscar_Registro(txtUsu.Text, txtClave.Text);
                idUsu = txtUsu.Text;
            }
            catch (Exception) { MessageBox.Show("Error de Conexión. Parámetros de conexión inválidos, contacte a soporte."); }
        }
        //le pasa el foco al text box Clave el presionar Enter
        private void txtUsu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToInt32(Keys.Enter))
            {
                txtClave.Focus();
            }
        }
        //activa la funcion Buscar Registro para activar la pantalla principal 
        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToInt32(Keys.Enter))
            {
                try
                {
                    Buscar_Registro(txtUsu.Text, txtClave.Text);
                    idUsu = txtUsu.Text;
                }
                catch (Exception) { MessageBox.Show("Error al conectar a la Base de Datos, contacte a Soporte.", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }
        //busca el registro en la base de datos, si este existe el programa se eqjecuta si no existe envia un mensaje indicando que no existe el usuario o clave
        public bool Buscar_Registro(string usu, string clave)
        {
            string conectado;
            string bloqueado;
            //Cadena SQL
            string cadenaSQL = "SELECT usuario, clave, conectado, bloqueado from usuarios WHERE usuario =" + "'" + usu + "'" + " and clave =" + "'" + clave + "'";
            //Adaptador
            SqlDataAdapter Adaptador = new SqlDataAdapter(cadenaSQL, cn);
            //dataset
            DataSet ds = new DataSet();
            //llenar dataset
            cn.Open();
            Adaptador.Fill(ds);
            cn.Close();
            //contar registros
            idUsu = txtUsu.Text;
            

            if (ds.Tables[0].Rows.Count == 0)
            {

                MessageBox.Show("Usuario y contraseña no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtClave.Text = "";
                txtClave.Focus();

                u++;

                if (u == 3)
                {

                    SqlCommand bloquear = new SqlCommand("update USUARIOS set bloqueado =1 where usuario ='" + usu + "'", cn);
                    cn.Open();
                    bloquear.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Usuario bloqueado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

                return false; //el registro no fue encontrado 

            }
            else
            {

                conectado = ds.Tables[0].Rows[0]["conectado"].ToString();
                bloqueado = ds.Tables[0].Rows[0]["bloqueado"].ToString();

                if (conectado == "1")
                {
                    MessageBox.Show("Usuario ya esta conectado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    if (bloqueado == "1")
                    {
                        MessageBox.Show("Usuario bloqueado por intentos fallidos de inicio de sesión. Contacte a Soporte.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        SqlCommand desbloquear = new SqlCommand("update USUARIOS set bloqueado = '0' where usuario = '" + usu + "'", cn);
                        cn.Open();
                        desbloquear.ExecuteNonQuery();
                        cn.Close();
                        SqlCommand update = new SqlCommand("update USUARIOS set conectado = '1' where usuario = '" + usu + "'", cn);
                        cn.Open();
                        update.ExecuteNonQuery();
                        Principal form = new Principal();
                        form.Show();
                        idUsu = txtUsu.Text;
                        cn.Close();
                        this.Hide();
                        //conIngreso.Close();
                        //ds.Dispose();

                    }
                }

                return true;
            }
        } //el registro existe


        //al recibir un caracter el txt Clave este activa de inmediato el boton Aceptar
        private void txtClave_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

    }

    }


