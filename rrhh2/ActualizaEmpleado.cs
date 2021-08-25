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
    public partial class ActualizaEmpleado : Form
    {
        SqlConnection cn = Conexion.getConexion();
        int data, idcos = 0;

        public ActualizaEmpleado()
        {
            InitializeComponent();
        }
              
        private void txtRUT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
            if (e.KeyChar == Convert.ToInt32(Keys.Enter))
            {
                //carga los combo box con las tablas de la base de datos para tener las AREAS y CARGOS respectivamente.
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter("SELECT CARGO FROM CARGOS", cn);
                da.Fill(ds, "CARGOS");
                cbCargo.DataSource = ds.Tables[0].DefaultView;
                cbCargo.ValueMember = "CARGO";

                DataSet ds1 = new DataSet();
                SqlDataAdapter da1 = new SqlDataAdapter("SELECT AREA FROM AREAS", cn);
                da1.Fill(ds1, "AREAS");
                cbArea.DataSource = ds1.Tables[0].DefaultView;
                cbArea.ValueMember = "AREA";

                DataSet dsCC = new DataSet();
                SqlDataAdapter daCC = new SqlDataAdapter("SELECT CCOSTO FROM CCOSTO", cn);
                daCC.Fill(dsCC, "CCOSTO");
                cmbCC.DataSource = dsCC.Tables[0].DefaultView;
                cmbCC.ValueMember = "CCOSTO";


                SqlCommand comando = new SqlCommand("SELECT RUT, DV, NOMBRE, APATERNO, AMATERNO, CARGO, AREA, CENCOS FROM EMPLEADO WHERE RUT ='" + txtRUT.Text + "' ", cn);
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
                        //activacion del formulario solo si corresponde el rut a la informacion de la BD
                        txtRUT.Enabled = false;
                        cbCargo.Enabled = true;
                        cbArea.Enabled = true;
                        cmbCC.Enabled = true;
                        btnGuardaCambios.Enabled = true;
                                              
                    }                      
                }
                cn.Close();
            }   
        }
        

        private void btnGuardaCambios_Click(object sender, EventArgs e)
        {   //llena el id y ccosto para luego hacer un insert
            DataSet dsCosto = new DataSet();
            SqlDataAdapter costo = new SqlDataAdapter("SELECT ID_COS FROM CCOSTO WHERE CCOSTO=   '" + cmbCC.Text + "'", cn);
            cn.Open();
            costo.Fill(dsCosto);
            idcos = Convert.ToInt32(dsCosto.Tables[0].Rows[0]["ID_COS"].ToString());
            cn.Close();

            SqlCommand guarda = new SqlCommand("update EMPLEADO set NOMBRE = '" + txtNombre.Text + "', APATERNO= '" + txtPaterno.Text + "', AMATERNO= '" + txtMaterno.Text + "', CARGO= '" + cbCargo.Text + "', AREA= '" + cbArea.Text + "', IDCOS= '" + idcos + "', CENCOS= '" + cmbCC.Text + "' where RUT = " + txtRUT.Text + "", cn);
            cn.Open();
            guarda.ExecuteNonQuery();
            MessageBox.Show("Cambios Guardados", "Actualizar empleado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            cn.Close();
            this.Close();

        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbCargoActualiza_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbAreaActualiza_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

      

      

        
    }
}
