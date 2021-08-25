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
    public partial class AgregaEmpleado : Form 
    {
        //SqlConnection conIngreso = new SqlConnection(@"Data Source=10.10.231.70;Initial Catalog=rrhh;Persist Security Info=True;User ID=sa;Password=Sa2011");
        SqlConnection cn = Conexion.getConexion();
        //int data = 0;
        public static int rut, idcos;
        public static string dv, usu; 
        
        //string usu,idcos ,ccos;

        public AgregaEmpleado()
        {
            InitializeComponent();
        }
        private void AgregaEmpleado_Load(object sender, EventArgs e)
        {
            
        }
        public void btnAgregarCargo_Click(object sender, EventArgs e)
        {
            //Boton LLAMAR Agregar Nuevo Cargo
            AgregarCargo form = new AgregarCargo();
            form.Show();
        }

        public void btnAgregaArea_Click(object sender, EventArgs e)
        {
            //Boton LLAMAR Agregar Area Nueva 
            AgregarArea form = new AgregarArea();
            form.Show();
        }

        private void btnAgregaEmpleado_Click(object sender, EventArgs e)
        {
            //llena el id y ccosto para luego hacer un insert
            DataSet dsCosto = new DataSet();
            SqlDataAdapter costo = new SqlDataAdapter("SELECT ID_COS FROM CCOSTO WHERE CCOSTO=   '" + cmbCC.Text + "'", cn);
            cn.Open();
            costo.Fill(dsCosto);
            idcos = Convert.ToInt32(dsCosto.Tables[0].Rows[0]["ID_COS"].ToString());
            cn.Close();

            //inserta el empleado nuevo a la base de datos, validado que no exista un campo vacio para no guardar null
            if (txtRUT.Text != "" && txtNombre.Text != "" && txtPaterno.Text != "" && txtMaterno.Text != "")
            {
                                                                                                                                                                        // ingresa RUT                     ingresa DV     ingresa nombre        ingresa apaterno                    ingresa amaterno        ingresa cargo           ingresa area       ingresa id cos   ingresa ccos
                SqlCommand guarda = new SqlCommand("INSERT INTO EMPLEADO (RUT, DV, NOMBRE, APATERNO, AMATERNO, CARGO, AREA, IDCOS, CENCOS, SALDO, ESTADO,DIASUSADOS ) VALUES ( " + Convert.ToInt32(txtRUT.Text) + ", '" + dv + "', '" + txtNombre.Text + "', '" + txtPaterno.Text + "', '" + txtMaterno.Text + "', '" + cbCargo.Text + "', '" + cbArea.Text + "','" + idcos + "','" + cmbCC.Text + "' , 0, 1,0 )", cn);
                cn.Open();
                guarda.ExecuteNonQuery();
                MessageBox.Show("EMPLEADO GUARDADO", "Agrega Empleado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cn.Close();
                this.Close();


            }

            else
            {
                MessageBox.Show("PORFAVOR COMPLETE TODOS LOS CAMPOS", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            this.Close();
        }

         //Creacion del Digito Verificador
         public static string digitoVerificador(int rut)
         {
             int Digito;
             int Contador;
             int Multiplo;
             int Acumulador;
             
             Contador = 2;
             Acumulador = 0;
             while (rut != 0)
             {
                 Multiplo = (rut % 10) * Contador;
                 Acumulador = Acumulador + Multiplo;
                 rut = rut / 10;
                 Contador = Contador + 1;
                 if (Contador == 8)
                 {
                     Contador = 2;
                 }
             }
             Digito = 11 - (Acumulador % 11);
            
             dv = Digito.ToString().Trim();
             if (Digito == 10)
             {
                 dv = "K";
             }
             if (Digito == 11)
             {
                 dv = "0";
             }
             return (dv);
         }

         private void txtRUT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
             if (e.KeyChar == Convert.ToInt32(Keys.Enter))
             {
                 buscarRut(txtRUT.Text);
                 txtNombre.Focus();
             }
         }

         public bool buscarRut(string rutt)
         {
             //convertir cadena a numero
             int rut = Convert.ToInt32(rutt);
             SqlDataAdapter estado = new SqlDataAdapter("SELECT RUT, NOMBRE, APATERNO, AMATERNO, CARGO, AREA, CENCOS, IDCOS, SALDO, ESTADO FROM EMPLEADO WHERE RUT =" + rut, cn);
             DataSet dsEstado = new DataSet();
             //llenar dataset
             cn.Open();
             estado.Fill(dsEstado);
             cn.Close();




             if (dsEstado.Tables[0].Rows.Count == 1)
             {
                 usu = dsEstado.Tables[0].Rows[0]["NOMBRE"].ToString();
                 string p = dsEstado.Tables[0].Rows[0]["ESTADO"].ToString();
                 if (p == "1" )
                 {
                     MessageBox.Show(usu+ " EXISTE, POR FAVOR VALIDE", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                     this.Close();
                 }
                 if (p=="0")
                 {
                         DialogResult resultado;
                         resultado = MessageBox.Show(dsEstado.Tables[0].Rows[0]["NOMBRE"].ToString() + " " + dsEstado.Tables[0].Rows[0]["APATERNO"].ToString() + " " + dsEstado.Tables[0].Rows[0]["AMATERNO"].ToString() + "\nInactivo por desvinculación, ¿Desea activar a: " + dsEstado.Tables[0].Rows[0]["NOMBRE"].ToString() + " ?", "REACTIVAR EMPLEADO", MessageBoxButtons.YesNo);
                         if (resultado == DialogResult.Yes)
                         {
                             
                             txtNombre.Text = dsEstado.Tables[0].Rows[0]["NOMBRE"].ToString();
                             txtPaterno.Text = dsEstado.Tables[0].Rows[0]["APATERNO"].ToString();
                             txtMaterno.Text = dsEstado.Tables[0].Rows[0]["AMATERNO"].ToString();
                             cbCargo.Text = dsEstado.Tables[0].Rows[0]["CARGO"].ToString();
                             cbArea.Text = dsEstado.Tables[0].Rows[0]["AREA"].ToString();
                             cmbCC.Text = dsEstado.Tables[0].Rows[0]["CENCOS"].ToString();
                             btnAgregaEmpleado.Enabled = false;
                             btnActiva.Enabled = true;
                         }
                 }

             }
             else
             {
                 DialogResult res;
                 res = MessageBox.Show("Rut no existe, ¿desea crear nuevo empleado?”", "Rut no existente", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                 if (res == DialogResult.Yes)
                 {
                     //envia el txtRut al la calculadora de digito verificador para agregarlo al campo txtDv
                     digitoVerificador(Convert.ToInt32(txtRUT.Text));
                     txtDv.Text = dv;
                     btnAgregaArea.Enabled = true;
                     btnAgregarCargo.Enabled = true;
                     btnAgregaEmpleado.Enabled = true;
                     btnActiva.Enabled = false;
                     btnCentroCosto.Visible = false;
                     txtNombre.Enabled = true;
                     txtPaterno.Enabled = true;
                     txtMaterno.Enabled = true;
                     cbArea.Enabled = true;
                     cbCargo.Enabled = true;
                     cmbCC.Enabled = true;

                     //carga los combo box con las tablas de la base de datos para tener las AREAS y CARGOS respectivamente.
                     DataSet dsCARGO = new DataSet();
                     SqlDataAdapter daCARGO = new SqlDataAdapter("SELECT CARGO FROM CARGOS", cn);
                     daCARGO.Fill(dsCARGO, "CARGOS");
                     cbCargo.DataSource = dsCARGO.Tables[0].DefaultView;
                     cbCargo.ValueMember = "CARGO";
                     //carga los combo box con las tablas de la base de datos para tener las AREAS y CARGOS respectivamente.
                     DataSet dsAREA = new DataSet();
                     SqlDataAdapter daAREA = new SqlDataAdapter("SELECT AREA FROM AREAS", cn);
                     daAREA.Fill(dsAREA, "AREAS");
                     cbArea.DataSource = dsAREA.Tables[0].DefaultView;
                     cbArea.ValueMember = "AREA";
                     //carga los combo box con las tablas de la base de datos para tener las AREAS y CARGOS respectivamente.
                     DataSet dsCC = new DataSet();
                     SqlDataAdapter daCC = new SqlDataAdapter("SELECT CCOSTO FROM CCOSTO", cn);
                     daCC.Fill(dsCC, "CCOSTO");
                     cmbCC.DataSource = dsCC.Tables[0].DefaultView;
                     cmbCC.ValueMember = "CCOSTO";




                 }
                 return false; //el registro no fue encontrado
             }
             return true; //el registro existe
         }

         private void button1_Click(object sender, EventArgs e)
         {
             this.Close();
         }

         private void button1_Click_1(object sender, EventArgs e)
         {
             this.Close();
         }

         private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
         {
             if (e.KeyChar == Convert.ToInt32(Keys.Enter))
             {
                 txtPaterno.Focus();
             }
         }

         private void txtPaterno_KeyPress(object sender, KeyPressEventArgs e)
         {
             if (e.KeyChar == Convert.ToInt32(Keys.Enter))
             {
                 txtMaterno.Focus();
             }
         }

         private void btnActiva_Click(object sender, EventArgs e)
         {
             //este hace el update de estado de 0 a 1 para activar al empleado
             SqlCommand update = new SqlCommand("UPDATE EMPLEADO SET ESTADO = 1 WHERE RUT =" + Convert.ToInt32(txtRUT.Text), cn);
             cn.Open();
             update.ExecuteNonQuery();
             MessageBox.Show(usu+ " Ha sido activado correctamente", "Reactivar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
             cn.Close();
             this.Close();
         }

         private void btnCentroCosto_Click(object sender, EventArgs e)
         {
             AgregaCC form = new AgregaCC();
             form.Show();
         }

    }
}
