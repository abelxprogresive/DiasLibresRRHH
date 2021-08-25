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
    public partial class AgregarArea : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=10.10.231.70;Initial Catalog=rrhh;Persist Security Info=True;User ID=sa;Password=Sa2011");
        SqlConnection cn = Conexion.getConexion();
        public AgregarArea()
        {
            InitializeComponent();
        }
        private void AgregarArea_Load(object sender, EventArgs e)
        {
            txtAreaNueva.Text = "";
        }

        private void txtAreaNueva_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToInt32(Keys.Enter))
            {
                //llama a la funcion 
                buscarArea(txtAreaNueva.Text);

            }
        }

        private bool buscarArea(string AreaNueva)
        {
            string area = AreaNueva;
            //buscara areas y devolvera los tipos verdaderos o falsos
            //Cadena SQL
            string cadenaSQL = "SELECT AREA FROM AREAS WHERE AREA =" + "'"+area+"'";
            //Adaptador
            SqlDataAdapter Adaptador = new SqlDataAdapter(cadenaSQL, cn);
            //dataset
            DataSet ds = new DataSet();

            //llenar dataset
            cn.Open();
            Adaptador.Fill(ds);
            cn.Close();

            //contar registros 
            //esta es la parte en la que valida si existe o no el digito contado si no existe cae en la instruncion else
            //la cual genera el insert into a la base de datos, si no existe devuelve un valor false dejando el mensaje box en pantalla
            if (ds.Tables[0].Rows.Count == 1)
            {
                ds.Dispose();
                MessageBox.Show("Area existe Revise", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false; //el registro fue encontrado
            }
            else
             {
                //insert into para el registro de las areas
                 SqlCommand guarda = new SqlCommand("INSERT INTO AREAS (AREA) VALUES ('" + area + "')", cn);
                 cn.Open();
                 guarda.ExecuteNonQuery();
                 MessageBox.Show("REGISTRO GUARDADO", "Agregar Area", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                 cn.Close();
                 this.Close();

             }
             cn.Close();

            return true;


        }

        private void btnNewArea_Click(object sender, EventArgs e)
        {
        }
        private void txtAreaNueva_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
