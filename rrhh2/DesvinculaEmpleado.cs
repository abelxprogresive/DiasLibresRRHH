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
    public partial class DesvinculaEmpleado : Form
    {
        //SqlConnection conIngreso = new SqlConnection(@"Data Source=10.10.231.70;Initial Catalog=rrhh;Persist Security Info=True;User ID=sa;Password=Sa2011");
        SqlConnection cn = Conexion.getConexion();
        int data = 0;
        public DesvinculaEmpleado()
        {
            InitializeComponent();
        }

        private void txtRUT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
            if (e.KeyChar == Convert.ToInt32(Keys.Enter))
            {
                //carga los combo box con las tablas de la base de datos para tener las AREAS y CARGOS respectivamente.
                /*DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("SELECT CARGO FROM CARGOS", conIngreso);
                da.Fill(ds, "CARGOS");
                cbCargo.DataSource = ds.Tables[0].DefaultView;
                cbCargo.ValueMember = "CARGO";

                DataSet ds1 = new DataSet();
                SqlDataAdapter da1 = new SqlDataAdapter("SELECT AREA FROM AREAS", conIngreso);
                da1.Fill(ds1, "AREAS");
                cbArea.DataSource = ds1.Tables[0].DefaultView;
                cbArea.ValueMember = "AREA";*/
                SqlCommand comando = new SqlCommand("SELECT RUT, DV, NOMBRE, APATERNO, AMATERNO, CARGO, AREA, CENCOS FROM EMPLEADO WHERE RUT ='" + txtRUT.Text + "' and estado = 1 ", cn);
                cn.Open();
                SqlDataReader ver = comando.ExecuteReader();
                while (ver.Read())
                {
                    data = ver.GetInt32(0);

                    if (txtRUT.Text == ver["RUT"].ToString())
                    {
                        txtNombre.Text = ver["NOMBRE"].ToString();
                        txtDV.Text = ver["DV"].ToString();
                        txtPaterno.Text = ver["APATERNO"].ToString();
                        txtMaterno.Text = ver["AMATERNO"].ToString();
                        cbCargo.Text = ver["CARGO"].ToString();
                        cbArea.Text = ver["AREA"].ToString();
                        cmbCC.Text = ver["CENCOS"].ToString();
                        txtRUT.Enabled = false;
                        //txtDV.Enabled = false;
                        cbCargo.Enabled = false;
                        cbArea.Enabled = false;
                        cmbCC.Enabled = false;

                    }
                }
                cn.Close();
            }   
        }

        private void btnDesVin_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            resultado = MessageBox.Show("¿Desea realmente desvincular a este empleado?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(resultado==DialogResult.Yes)
            {
                SqlCommand guarda = new SqlCommand("update EMPLEADO set ESTADO = 0 where RUT = '" + txtRUT.Text + "'", cn);
                cn.Open();
                guarda.ExecuteNonQuery();
                MessageBox.Show("Empleado Desvinculado", "Desvincular empleado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cn.Close();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
