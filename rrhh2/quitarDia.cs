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
    public partial class quitarDia : Form
    {
        SqlConnection cn = Conexion.getConexion();
        public static int saldo = 0;
        public quitarDia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRutElimina_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
            // key press
            if (e.KeyChar == Convert.ToInt32(Keys.Enter))
            {
                //llama la funcion buscar Registro al dar ENTER y ademas envia el dato ingresado en el txtRUT
                Buscar(txtRutElimina.Text);

            }
        }

        private bool Buscar(string p)
        {
            int rut = Convert.ToInt32(p);
            SqlDataAdapter Adaptador = new SqlDataAdapter("SELECT RUT, NOMBRE, APATERNO, AMATERNO, CARGO, AREA, CENCOS, IDCOS, SALDO FROM EMPLEADO WHERE RUT =" + rut + " and ESTADO = 1", cn);
            //dataset
            DataSet ds = new DataSet();
            //llenar dataset
            cn.Open();
            Adaptador.Fill(ds);
            cn.Close();

            //contar registros
            if (ds.Tables[0].Rows.Count == 0)
            {
                //al validar si existe el dato y este es true, te envia al else si es false te pregunta si quieres crear el registro nuevo o no.
                ds.Dispose();
                MessageBox.Show("El rut "+rut+" ingresado no existe en el sistema favor verifique");
                return false; //el registro no fue encontrado
            }
            else
            {
                //te muesta en los lebel la informacion obtenida del select en la cadena de estring
                lblEmpleado.Text = ds.Tables[0].Rows[0]["NOMBRE"].ToString() + " " + ds.Tables[0].Rows[0]["APATERNO"].ToString() + " " + ds.Tables[0].Rows[0]["AMATERNO"].ToString();
                lblCargo.Text = ds.Tables[0].Rows[0]["CARGO"].ToString();
                lblArea.Text = ds.Tables[0].Rows[0]["AREA"].ToString();
                lblCcosto.Text = ds.Tables[0].Rows[0]["CENCOS"].ToString();
                lblNroCC.Text = ds.Tables[0].Rows[0]["IDCOS"].ToString();
                saldo = Convert.ToInt32(ds.Tables[0].Rows[0]["SALDO"].ToString());
                
                //carga de informacion en el data gridview
                SqlCommand comando = new SqlCommand();
                //variable SqlDataReader para leer los datos
                SqlDataReader dr;
                comando.Connection = cn;
                //declaramos el comando para realizar la busqueda
                comando.CommandText = "SELECT ID, RUT, MOTIVO, FECHA FROM ADICIONAL WHERE RUT =" + rut + "";
                //especificamos que es de tipo Text
                comando.CommandType = CommandType.Text;
                //se abre la conexion
                cn.Open();
                //limpiamos los renglones de la datagridview
                dgwMuestra.Rows.Clear();
                //a la variable DataReader asignamos  el la variable de tipo SqlCommand
                dr = comando.ExecuteReader();
                //el ciclo while se ejecutará mientras lea registros en la tabla
                while (dr.Read())
                {
                    //variable de tipo entero para ir enumerando los la filas del datagridview
                    int renglon = dgwMuestra.Rows.Add();
                    dgwMuestra.Rows[renglon].Cells["ID"].Value = dr.GetInt32(dr.GetOrdinal("ID"));
                    dgwMuestra.Rows[renglon].Cells["RUT"].Value = dr.GetInt32(dr.GetOrdinal("RUT"));
                    dgwMuestra.Rows[renglon].Cells["MOTIVO"].Value = dr.GetString(dr.GetOrdinal("MOTIVO"));
                    dgwMuestra.Rows[renglon].Cells["FECHA"].Value = dr.GetDateTime(dr.GetOrdinal("FECHA"));

                }
                //cierra la conexión
                cn.Close();
                //te llama a la funcion de mostrar datos y envia el rut en la misma funcion
            }
            cn.Close();
            ds.Dispose();
            return true; //el registro existe
            
        }

        private void quitarDia_Load(object sender, EventArgs e)
        {
            
            lblEmpleado.Text = "";
            lblArea.Text = "";
            lblCargo.Text = "";
            lblCcosto.Text = "";
            lblNroCC.Text = "";
        }

        private void btnAgregarSolicitud_Click(object sender, EventArgs e)
        {
            int valorrow = 0;
            DialogResult resultado;
            resultado = MessageBox.Show("Realmente ¿Desea eliminar lo(s) día(s) al empleado?", "", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                DataGridViewRow row = new DataGridViewRow();
                for (int i = 0; i < dgwMuestra.Rows.Count; i++)
                {
                    row = dgwMuestra.Rows[i];
                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                    {
                        int id = Convert.ToInt32(row.Cells[4].Value);
                        //borra en la tabla adicional datos correspondientes a la cantidad de dias que usara
                        SqlCommand deleterow = new SqlCommand("delete from adicional where id = " + id + "", cn);
                        cn.Open();
                        deleterow.ExecuteNonQuery();
                        cn.Close();
                        dgwMuestra.Rows.Remove(row);
                        i--;
                        valorrow++;
                    }
                }
            }
            int resta = saldo - valorrow;
            SqlCommand update = new SqlCommand("update EMPLEADO set SALDO = " + resta + " where RUT= " + Convert.ToInt32(txtRutElimina.Text) + "", cn);
            cn.Open();
            update.ExecuteNonQuery();
            cn.Close();
            
        }

      
    }
}
