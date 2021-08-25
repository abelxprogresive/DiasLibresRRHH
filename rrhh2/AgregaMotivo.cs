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
    public partial class AgregaMotivo : Form
    {
        SqlConnection cn = Conexion.getConexion();
        public AgregaMotivo()
        {
            InitializeComponent();

        }

        private void btnAgrega_Click(object sender, EventArgs e)
        {
            if (txtMotivoNuevo.Text !="")
            {
                buscarMotivo(txtMotivoNuevo.Text);
            }
            else
            {
                MessageBox.Show("Debe crear el motivo antes de guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }
        private bool buscarMotivo(string NuevoMotivo)
        {
            string Motivo = NuevoMotivo;

            //buscara areas y devolvera los tipos verdaderos o falsos
            //Cadena SQL
            string cadenaSQL = "SELECT MOTIVO FROM MOTIVOSTRABAJO WHERE MOTIVO =" + "'" + Motivo + "'";
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
                MessageBox.Show("Motivo existe. Revise", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false; //el registro fue encontrado
            }
            else
            {
                SqlCommand guardaRegistro = new SqlCommand("insert into MOTIVOSTRABAJO  (MOTIVO) values ('" + txtMotivoNuevo.Text + "')", cn);
                cn.Open();
                guardaRegistro.ExecuteNonQuery();
                cn.Close();
                refreshComboBox(); 
                MessageBox.Show("Se ha Agregado Correctamente " + txtMotivoNuevo.Text, "Agregar motivo de trabajo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtMotivoNuevo.Text = "";
            }
            cn.Close();
            return true;
        }

        private void refreshComboBox()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT MOTIVO FROM MOTIVOSTRABAJO", cn);
            da.Fill(ds, "MOTIVO");
            cmbMotivo.DataSource = ds.Tables[0].DefaultView;
            cmbMotivo.ValueMember = "MOTIVO";
        }

        private void AgregaMotivo_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT MOTIVO FROM MOTIVOSTRABAJO", cn);
            da.Fill(ds, "MOTIVO");
            cmbMotivo.DataSource = ds.Tables[0].DefaultView;
            cmbMotivo.ValueMember = "MOTIVO";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {

            DialogResult resultado;
            resultado = MessageBox.Show("¿Desea realmente eliminar el motivo?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.Yes)
            {
                SqlCommand elimina = new SqlCommand("delete from MOTIVOSTRABAJO where motivo ='" + cmbMotivo.Text + "'", cn);
                cn.Open();
                elimina.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Se ha eliminado correctamente " + cmbMotivo.Text, "Eliminar moivo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                refreshComboBox(); 
                //this.Close();
            }

            
            

        }
    }
}
