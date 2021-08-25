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
    public partial class AgregarCargo : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=10.10.231.70;Initial Catalog=rrhh;Persist Security Info=True;User ID=sa;Password=Sa2011");
        SqlConnection cn = Conexion.getConexion();
        public AgregarCargo()
        {
            InitializeComponent();
        }
        private void AgregarCargo_Load(object sender, EventArgs e)
        {
            txtNuevoCargo.Text = "";
        }
        private void txtNuevoCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToInt32(Keys.Enter))
            {
                //llama a la funcion 
                buscarCargo(txtNuevoCargo.Text);
            }

        }

        private bool buscarCargo(string NuevoCargo)
        {
            string cargo = NuevoCargo;
            //buscara areas y devolvera los tipos verdaderos o falsos
            //Cadena SQL
            string cadenaSQL = "SELECT CARGO FROM CARGOS WHERE CARGO =" + "'" + cargo + "'";
            //Adaptador
            SqlDataAdapter Adaptador = new SqlDataAdapter(cadenaSQL, cn);
            //dataset
            DataSet ds = new DataSet();

            //llenar dataset
            cn.Open();
            Adaptador.Fill(ds);
            cn.Close();

            //contar registros
            if (ds.Tables[0].Rows.Count == 1)
            {
                ds.Dispose();
                MessageBox.Show("Cargo existe. Revise", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false; //el registro fue encontrado
            }
            else
            {
                //contar registros 
                //esta es la parte en la que valida si existe o no el digito contado si no existe cae en la instruncion else
                //la cual genera el insert into a la base de datos, si no existe devuelve un valor false dejando el mensaje box en pantalla
                SqlCommand guarda = new SqlCommand("INSERT INTO CARGOS (CARGO) VALUES ('" + cargo + "')", cn);
                cn.Open();
                guarda.ExecuteNonQuery();
                MessageBox.Show("REGISTRO GUARDADO", "Agregar Cargo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cn.Close();
                this.Close();

            }
            cn.Close();

            return true;
            
        }
        private void btnCargoNew_Click_1(object sender, EventArgs e)
        {
            //Boton Agregar Nuevo Cargo
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
