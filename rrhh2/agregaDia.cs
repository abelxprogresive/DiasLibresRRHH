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
    public partial class agregaDia : Form
    {
        //SqlConnection conIngreso = new SqlConnection(@"Data Source=10.10.231.70;Initial Catalog=rrhh;Persist Security Info=True;User ID=sa;Password=Sa2011");
        SqlConnection cn = Conexion.getConexion();
        //public static int saldo;
        public agregaDia()
        {
            InitializeComponent();
        }

        private void btnAgregarSolicitud_Click(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Today;
            string fecha = hoy.ToString("dd-MM-yyyy");
            string fecMo1 = fecha1.Text;
            
            if (motivo1.Text == "")
            { fecMo1 = " "; }

            int suma = (Convert.ToInt32(lblDsaldo.Text)) + (Convert.ToInt32(cmbDia.Text));


            if (cmbDia.Text == "1" && motivo1.Text != "") 
            {
                string cadenaSQL = "INSERT INTO ADICIONAL (RUT, MOTIVO, FECHA, VALOR) VALUES ('" + Convert.ToInt32(txtRutSolicitud.Text) + "','" + motivo1.Text + "','" + fecha1.Text + "', 1)";
                SqlCommand guardaRegistro = new SqlCommand(cadenaSQL, cn);
                cn.Open();
                guardaRegistro.ExecuteNonQuery();
                cn.Close();
                
                //ACTUALIZA LA CANTIDAD DE DIAS DE SALDO DEL EMPLEADO
                string cadenaUpdate = "update empleado set SALDO = (select sum (valor) as suma from ADICIONAL where rut= " + Convert.ToInt32(txtRutSolicitud.Text) + ") where RUT= " + Convert.ToInt32(txtRutSolicitud.Text) + "";
                SqlCommand guardaUpdate = new SqlCommand(cadenaUpdate, cn);
                cn.Open();
                guardaUpdate.ExecuteNonQuery();
                MessageBox.Show("Guardado OK", "Agrega día", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cn.Close();
                //menu para no cerrar el agrega dia limpia actualiza y bloquea
                cerrar();

                //this.Close();
            }
            //inserta cuando hay 2 motivos y fechas activos
            if (cmbDia.Text == "2" && motivo2.Text != "" )
            {
                string cadenaSQL = "INSERT INTO ADICIONAL (RUT, MOTIVO, FECHA, VALOR) VALUES ('" + Convert.ToInt32(txtRutSolicitud.Text) + "','" + motivo1.Text + "','" + fecha1.Text + "', 1)";
                SqlCommand guardaRegistro = new SqlCommand(cadenaSQL, cn);
                cn.Open();
                guardaRegistro.ExecuteNonQuery();
                cn.Close();
                string cadenaSQL2 = "INSERT INTO ADICIONAL (RUT, MOTIVO, FECHA, VALOR) VALUES ('" + Convert.ToInt32(txtRutSolicitud.Text) + "','" + motivo2.Text + "','" + fecha2.Text + "', 1)";
                SqlCommand guardaRegistro2 = new SqlCommand(cadenaSQL2, cn);
                cn.Open();
                guardaRegistro2.ExecuteNonQuery();
                cn.Close();

                //ACTUALIZA LA CANTIDAD DE DIAS DE SALDO DEL EMPLEADO
                string cadenaUpdate = "update empleado set SALDO = (select sum (valor) as suma from ADICIONAL where rut= " + Convert.ToInt32(txtRutSolicitud.Text) + ") where RUT= " + Convert.ToInt32(txtRutSolicitud.Text) + "";
                SqlCommand guardaUpdate = new SqlCommand(cadenaUpdate, cn);
                cn.Open();
                guardaUpdate.ExecuteNonQuery();
                MessageBox.Show("Guardado OK", "Agrega día", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cn.Close();
                //menu para no cerrar el agrega dia limpia actualiza y bloquea
                cerrar();
                //this.Close();
            }
            //inserta cuando hay 3 motivos y fechas activos
            if (cmbDia.Text == "3" && motivo3.Text != "")
            {
                string cadenaSQL = "INSERT INTO ADICIONAL (RUT, MOTIVO, FECHA, VALOR) VALUES ('" + Convert.ToInt32(txtRutSolicitud.Text) + "','" + motivo1.Text + "','" + fecha1.Text + "', 1)";
                SqlCommand guardaRegistro = new SqlCommand(cadenaSQL, cn);
                cn.Open();
                guardaRegistro.ExecuteNonQuery();
                cn.Close();
                string cadenaSQL2 = "INSERT INTO ADICIONAL (RUT, MOTIVO, FECHA, VALOR) VALUES ('" + Convert.ToInt32(txtRutSolicitud.Text) + "','" + motivo2.Text + "','" + fecha2.Text + "', 1)";
                SqlCommand guardaRegistro2 = new SqlCommand(cadenaSQL2, cn);
                cn.Open();
                guardaRegistro2.ExecuteNonQuery();
                cn.Close();
                string cadenaSQL3 = "INSERT INTO ADICIONAL (RUT, MOTIVO, FECHA, VALOR) VALUES ('" + Convert.ToInt32(txtRutSolicitud.Text) + "','" + motivo3.Text + "','" + fecha3.Text + "', 1)";
                SqlCommand guardaRegistro3 = new SqlCommand(cadenaSQL3, cn);
                cn.Open();
                guardaRegistro3.ExecuteNonQuery();
                cn.Close();

                //ACTUALIZA LA CANTIDAD DE DIAS DE SALDO DEL EMPLEADO
                string cadenaUpdate = "update empleado set SALDO = (select sum (valor) as suma from ADICIONAL where rut= " + Convert.ToInt32(txtRutSolicitud.Text) + ") where RUT= " + Convert.ToInt32(txtRutSolicitud.Text) + "";
                SqlCommand guardaUpdate = new SqlCommand(cadenaUpdate, cn);
                cn.Open();
                guardaUpdate.ExecuteNonQuery();
                MessageBox.Show("Guardado OK", "Agrega día", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cn.Close();
                //menu para no cerrar el agrega dia limpia actualiza y bloquea
                cerrar();
               // this.Close();
            }
            //inserta cuando hay 4 motivos y fechas activos
            if (cmbDia.Text == "4" && motivo4.Text != "")
            {
                string cadenaSQL = "INSERT INTO ADICIONAL (RUT, MOTIVO, FECHA, VALOR) VALUES ('" + Convert.ToInt32(txtRutSolicitud.Text) + "','" + motivo1.Text + "','" + fecha1.Text + "', 1)";
                SqlCommand guardaRegistro = new SqlCommand(cadenaSQL, cn);
                cn.Open();
                guardaRegistro.ExecuteNonQuery();
                cn.Close();
                string cadenaSQL2 = "INSERT INTO ADICIONAL (RUT, MOTIVO, FECHA, VALOR) VALUES ('" + Convert.ToInt32(txtRutSolicitud.Text) + "','" + motivo2.Text + "','" + fecha2.Text + "', 1)";
                SqlCommand guardaRegistro2 = new SqlCommand(cadenaSQL2, cn);
                cn.Open();
                guardaRegistro2.ExecuteNonQuery();
                cn.Close();
                string cadenaSQL3 = "INSERT INTO ADICIONAL (RUT, MOTIVO, FECHA, VALOR) VALUES ('" + Convert.ToInt32(txtRutSolicitud.Text) + "','" + motivo3.Text + "','" + fecha3.Text + "', 1)";
                SqlCommand guardaRegistro3 = new SqlCommand(cadenaSQL3, cn);
                cn.Open();
                guardaRegistro3.ExecuteNonQuery();
                cn.Close();
                string cadenaSQL4 = "INSERT INTO ADICIONAL (RUT, MOTIVO, FECHA, VALOR) VALUES ('" + Convert.ToInt32(txtRutSolicitud.Text) + "','" + motivo4.Text + "','" + fecha4.Text + "', 1)";
                SqlCommand guardaRegistro4 = new SqlCommand(cadenaSQL4, cn);
                cn.Open();
                guardaRegistro4.ExecuteNonQuery();
                cn.Close();

                //ACTUALIZA LA CANTIDAD DE DIAS DE SALDO DEL EMPLEADO
                string cadenaUpdate = "update empleado set SALDO = (select sum (valor) as suma from ADICIONAL where rut= " + Convert.ToInt32(txtRutSolicitud.Text) + ") where RUT= " + Convert.ToInt32(txtRutSolicitud.Text) + "";
                SqlCommand guardaUpdate = new SqlCommand(cadenaUpdate, cn);
                cn.Open();
                guardaUpdate.ExecuteNonQuery();
                MessageBox.Show("Guardado OK", "Agrega día", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cn.Close();
                //menu para no cerrar el agrega dia limpia actualiza y bloquea
                cerrar();
                //this.Close();
            }
            //inserta cuando hay 5 motivos y fechas activos
            if (cmbDia.Text == "5" && motivo5.Text != "")
            {
                string cadenaSQL = "INSERT INTO ADICIONAL (RUT, MOTIVO, FECHA, VALOR) VALUES ('" + Convert.ToInt32(txtRutSolicitud.Text) + "','" + motivo1.Text + "','" + fecha1.Text + "', 1)";
                SqlCommand guardaRegistro = new SqlCommand(cadenaSQL, cn);
                cn.Open();
                guardaRegistro.ExecuteNonQuery();
                cn.Close();
                string cadenaSQL2 = "INSERT INTO ADICIONAL (RUT, MOTIVO, FECHA, VALOR) VALUES ('" + Convert.ToInt32(txtRutSolicitud.Text) + "','" + motivo2.Text + "','" + fecha2.Text + "', 1)";
                SqlCommand guardaRegistro2 = new SqlCommand(cadenaSQL2, cn);
                cn.Open();
                guardaRegistro2.ExecuteNonQuery();
                cn.Close();
                string cadenaSQL3 = "INSERT INTO ADICIONAL (RUT, MOTIVO, FECHA, VALOR) VALUES ('" + Convert.ToInt32(txtRutSolicitud.Text) + "','" + motivo3.Text + "','" + fecha3.Text + "', 1)";
                SqlCommand guardaRegistro3 = new SqlCommand(cadenaSQL3, cn);
                cn.Open();
                guardaRegistro3.ExecuteNonQuery();
                cn.Close();
                string cadenaSQL4 = "INSERT INTO ADICIONAL (RUT, MOTIVO, FECHA, VALOR) VALUES ('" + Convert.ToInt32(txtRutSolicitud.Text) + "','" + motivo4.Text + "','" + fecha4.Text + "', 1)";
                SqlCommand guardaRegistro4 = new SqlCommand(cadenaSQL4, cn);
                cn.Open();
                guardaRegistro4.ExecuteNonQuery();
                cn.Close();
                string cadenaSQL5 = "INSERT INTO ADICIONAL (RUT, MOTIVO, FECHA, VALOR) VALUES ('" + Convert.ToInt32(txtRutSolicitud.Text) + "','" + motivo5.Text + "','" + fecha5.Text + "', 1)";
                SqlCommand guardaRegistro5 = new SqlCommand(cadenaSQL5, cn);
                cn.Open();
                guardaRegistro5.ExecuteNonQuery();
                cn.Close();

                //ACTUALIZA LA CANTIDAD DE DIAS DE SALDO DEL EMPLEADO
                string cadenaUpdate = "update empleado set SALDO = (select sum (valor) as suma from ADICIONAL where rut= " + Convert.ToInt32(txtRutSolicitud.Text) + ") where RUT= " + Convert.ToInt32(txtRutSolicitud.Text) + "";
                SqlCommand guardaUpdate = new SqlCommand(cadenaUpdate, cn);
                cn.Open();
                guardaUpdate.ExecuteNonQuery();
                MessageBox.Show("Guardado OK", "Agrega día", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cn.Close();
                //menu para no cerrar el agrega dia limpia actualiza y bloquea
                cerrar();
                //this.Close();
            }

        }

        private void cerrar()
        {
            cmbDia.Text="0";
            motivo1.Enabled = false;
            fecha1.Enabled = false;
            motivo2.Enabled = false;
            fecha2.Enabled = false;
            motivo3.Enabled = false;
            fecha3.Enabled = false;
            motivo4.Enabled = false;
            fecha4.Enabled = false;
            motivo5.Enabled = false;
            fecha5.Enabled = false;
            btnAgregarSolicitud.Enabled = false;
            Buscar_Registro(txtRutSolicitud.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void agregaDia_Load(object sender, EventArgs e)
        {
            btnAgregarSolicitud.Enabled = false;
            lblMes.Text = "";
            lblFecSol.Text = "";
            lblEmpleado.Text = "";
            lblArea.Text = "";
            lblCargo.Text = "";
            fecha1.CustomFormat = "";            
            lblDsaldo.Text = "";            
            lblCcosto.Text = "";
            lblNroCC.Text = "";

            DateTime hoy = DateTime.Today;
            lblMes.Text = hoy.ToString("MMMM") + " de " + hoy.ToString("yyyy");
            lblFecSol.Text = hoy.ToString("dd/MM/yyyy");
            
            //carga de combobox1
            DataSet ds1 = new DataSet();
            SqlDataAdapter da1 = new SqlDataAdapter("SELECT MOTIVO FROM MOTIVOSTRABAJO", cn);
            da1.Fill(ds1, "MOTIVO");
            motivo1.DataSource = ds1.Tables[0].DefaultView;
            motivo1.ValueMember = "MOTIVO";
            //carga de combobox2
            DataSet ds2 = new DataSet();
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT MOTIVO FROM MOTIVOSTRABAJO", cn);
            da2.Fill(ds2, "MOTIVO");
            motivo2.DataSource = ds2.Tables[0].DefaultView;
            motivo2.ValueMember = "MOTIVO";
            //carga de combobox3
            DataSet ds3 = new DataSet();
            SqlDataAdapter da3 = new SqlDataAdapter("SELECT MOTIVO FROM MOTIVOSTRABAJO", cn);
            da3.Fill(ds3, "MOTIVO");
            motivo3.DataSource = ds3.Tables[0].DefaultView;
            motivo3.ValueMember = "MOTIVO";
            //carga de combobox4
            DataSet ds4 = new DataSet();
            SqlDataAdapter da4 = new SqlDataAdapter("SELECT MOTIVO FROM MOTIVOSTRABAJO", cn);
            da4.Fill(ds4, "MOTIVO");
            motivo4.DataSource = ds4.Tables[0].DefaultView;
            motivo4.ValueMember = "MOTIVO";
            //carga de combobox5
            DataSet ds5 = new DataSet();
            SqlDataAdapter da5 = new SqlDataAdapter("SELECT MOTIVO FROM MOTIVOSTRABAJO", cn);
            da5.Fill(ds5, "MOTIVO");
            motivo5.DataSource = ds5.Tables[0].DefaultView;
            motivo5.ValueMember = "MOTIVO";

        }
        private bool Buscar_Registro(string rutt)
        {
            //convertir cadena a numero
            int rut = Convert.ToInt32(rutt);

            //Conexión con la base de datos
            //SqlConnection conIngreso = new SqlConnection(@"Data Source=10.10.231.70;Initial Catalog=rrhh;Persist Security Info=True;User ID=sa;Password=Sa2011");

            //Cadena SQL
            string cadenaSQL = "SELECT RUT, NOMBRE, APATERNO, AMATERNO, CARGO, AREA, CENCOS, IDCOS, SALDO FROM EMPLEADO WHERE RUT =" + rut+" and ESTADO = 1";

            //Adaptador
            SqlDataAdapter Adaptador = new SqlDataAdapter(cadenaSQL, cn);

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
                DialogResult resultado;
                resultado = MessageBox.Show("Rut no existe, ¿desea crear nuevo empleado?”", "Rut no existente", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resultado == DialogResult.Yes)
                {
                    AgregaEmpleado agr_emp = new AgregaEmpleado();
                    agr_emp.Show();
                    this.Close();
                }
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
                lblDsaldo.Text = ds.Tables[0].Rows[0]["SALDO"].ToString();
                //te llama a la funcion de mostrar datos y envia el rut en la misma funcion
                mostrarDatos(txtRutSolicitud.Text);

            }
            cn.Close();
            ds.Dispose();
            return true; //el registro existe

        }
        public void mostrarDatos(string txtRutSol)
        {
            //txtDiasUso.Enabled = true;
            cmbDia.Enabled = true;
            
        }

        private void txtRutSolicitud_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
            DataTable dt = new DataTable();
            if (e.KeyChar == Convert.ToInt32(Keys.Enter))
            {
                //llama la funcion buscar Registro al dar ENTER y ademas envia el dato ingresado en el txtRUT
                Buscar_Registro(txtRutSolicitud.Text);

            }
        }

        public void cmbDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            int saldo = Convert.ToInt16(lblDsaldo.Text);
            if (saldo < 1000000)
            {
                motivo1.Enabled = true;
                                    fecha1.Enabled = true;
                                    motivo2.Enabled = true;
                                    fecha2.Enabled = true;
                                    motivo3.Enabled = true;
                                    fecha3.Enabled = true;
                                    motivo4.Enabled = true;
                                    fecha4.Enabled = true;
                                    motivo5.Enabled = true;
                                    fecha5.Enabled = true;
                                    btnAgregarSolicitud.Enabled = true;
                //if (cmbDia.Text == "1" && saldo <= 4)
                //{
                //    motivo1.Enabled = true;
                //    fecha1.Enabled = true;
                //    motivo2.Enabled = false;
                //    fecha2.Enabled = false;
                //    motivo3.Enabled = false;
                //    fecha3.Enabled = false;
                //    motivo4.Enabled = false;
                //    fecha4.Enabled = false;
                //    motivo5.Enabled = false;
                //    fecha5.Enabled = false;
                //    btnAgregarSolicitud.Enabled = true;
                //}

                //if (cmbDia.Text == "2" && saldo <= 3)
                //    {
                //        motivo1.Enabled = true;
                //        fecha1.Enabled = true;
                //        motivo2.Enabled = true;
                //        fecha2.Enabled = true;
                //        motivo3.Enabled = false;
                //        fecha3.Enabled = false;
                //        motivo4.Enabled = false;
                //        fecha4.Enabled = false;
                //        motivo5.Enabled = false;
                //        fecha5.Enabled = false;
                //        btnAgregarSolicitud.Enabled = true;
                //    }
                //if (cmbDia.Text == "3" && saldo <= 2)
                //        {
                //            motivo1.Enabled = true;
                //            fecha1.Enabled = true;
                //            motivo2.Enabled = true;
                //            fecha2.Enabled = true;
                //            motivo3.Enabled = true;
                //            fecha3.Enabled = true;
                //            motivo4.Enabled = false;
                //            fecha4.Enabled = false;
                //            motivo5.Enabled = false;
                //            fecha5.Enabled = false;
                //            btnAgregarSolicitud.Enabled = true;
                //        }
                //if (cmbDia.Text == "4" && saldo <= 1)
                //            {
                //                motivo1.Enabled = true;
                //                fecha1.Enabled = true;
                //                motivo2.Enabled = true;
                //                fecha2.Enabled = true;
                //                motivo3.Enabled = true;
                //                fecha3.Enabled = true;
                //                motivo4.Enabled = true;
                //                fecha4.Enabled = true;
                //                motivo5.Enabled = false;
                //                fecha5.Enabled = false;
                //                btnAgregarSolicitud.Enabled = true;
                //            }
                //                if (cmbDia.Text == "5" && saldo==0)
                //                {
                //                    motivo1.Enabled = true;
                //                    fecha1.Enabled = true;
                //                    motivo2.Enabled = true;
                //                    fecha2.Enabled = true;
                //                    motivo3.Enabled = true;
                //                    fecha3.Enabled = true;
                //                    motivo4.Enabled = true;
                //                    fecha4.Enabled = true;
                //                    motivo5.Enabled = true;
                //                    fecha5.Enabled = true;
                //                    btnAgregarSolicitud.Enabled = true;
                //                }
  
                  }

            //if(saldo + Convert.ToInt16(cmbDia.Text) > 5 )
            //{
            //    MessageBox.Show("Excede días para agregar\nVerifique el saldo vs los días que ingresará", "Ojo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    //this.Close();
            //    //IngresoSolicitud form = new IngresoSolicitud();
            //    //form.Show();
            //}

                

            }
             
        }
    }

