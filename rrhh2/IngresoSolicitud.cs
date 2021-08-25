using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
//libreria para generar PDF 
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
//Using para generar Documentos con creacion de estos.
using System.IO;
using System.Diagnostics;


namespace rrhh2
{
    public partial class IngresoSolicitud : Form
    {
        SqlConnection cn = Conexion.getConexion();

        public IngresoSolicitud()
        {
            InitializeComponent();
        }
        private void IngresoSolicitud_Load(object sender, EventArgs e)
        {
            lblMes.Text = "";
            lblFecSol.Text = "";
            lblEmpleado.Text = "";
            lblArea.Text = "";
            lblCargo.Text = "";
            lblDbase.Text = "";
            lblDsaldo.Text = "";
            lblDuso.Text = "";
            lblCcosto.Text = "";
            lblNroCC.Text = "";
            
                        
            DateTime hoy = DateTime.Today;
            lblMes.Text = hoy.ToString("MMMM") + " de " + hoy.ToString("yyyy");
            lblFecSol.Text = hoy.ToString("dd/MM/yyyy");
        }
        public void txtRutSolicitud_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
            DataTable dt = new DataTable();
            if (e.KeyChar == Convert.ToInt32(Keys.Enter))
            {
                //llama la funcion buscar Registro al dar ENTER y ademas envia el dato ingresado en el txtRUT
                Buscar_Registro(txtRutSolicitud.Text);

            }

        }
        private bool Buscar_Registro(string a)
        {// a es el nombre que le puse para almacenar el dato recivido por txtRutSolicitud_KeyPress

            int rut = Convert.ToInt32(a);//convertir cadena recibida por el txtRutSolicitud_KeyPress  a numero
            
            //Adaptador
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
                lblDbase.Text = ds.Tables[0].Rows[0]["SALDO"].ToString();
                //carga de informacion en el data gridview
                SqlCommand comando = new SqlCommand();
                //variable SqlDataReader para leer los datos
                SqlDataReader dr;
                comando.Connection = cn;
                //declaramos el comando para realizar la busqueda
                comando.CommandText = "SELECT TOP 5 ID, RUT, MOTIVO, FECHA FROM ADICIONAL WHERE RUT =" + rut + "";
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
                mostrarDatos(txtRutSolicitud.Text);
            }
            cn.Close();
            ds.Dispose();
            return true; //el registro existe
            //fin codigo Buscar_Registro
        }

        

        public void mostrarDatos(string txtRutSol)
        {
            //txtDiasUso.Enabled = true;
            btnAgregarSolicitud.Enabled = true;
            fechaDesdeDia.Enabled = true;
            fechaHastaDia.Enabled = true;                     
        }

        private void btnAgregarSolicitud_Click_1(object sender, EventArgs e)
        {
            int valorrow = 0;
            DateTime hoy = DateTime.Today;
            string fecha = hoy.ToString("dd/MM/yyyy");
            //inicio codigo para poder generar pdf e imprimir
  
            //string C = @"C:\SOLICITUDES\" + txtRutSolicitud.Text + "\\"; // ruta de almacenado de archivo final (ruta de prueba para no alterar informacion en servidor)
            string C = @"\\10.10.231.70\rrhh\SOLICITUDES\" + txtRutSolicitud.Text + "\\"; // ruta de almacenado de archivo final
            
            if (!Directory.Exists(C))
            {
                Directory.CreateDirectory(C);
            }

            if (Directory.Exists(C))
            {
                //fecha para el pdf mas el rut
                string fechaPDF = hoy.ToString("dd-MM-yyyy");
                // prueba de codigo para generar PDF del ingreso de solicitud
                string fileName = C + txtRutSolicitud.Text + "_" + fechaPDF + ".pdf";

                //string fileName = C+txtRutSolicitud.Text+"_"+fechaPDF + ".pdf";
                Document document = new Document(PageSize.LETTER, 60, 50, 25, 25);
                PdfWriter.GetInstance(document, new FileStream(fileName, FileMode.Create));
                document.Open();

                Paragraph Cabecera = new Paragraph();
                Cabecera.Alignment = Element.ALIGN_LEFT;
                Cabecera.Font = FontFactory.GetFont("Verdana", 9);
                Cabecera.Add("DIMEIGGS S.A.\n" + lblMes.Text);
                document.Add(Cabecera);

                Paragraph Titulo = new Paragraph();
                Titulo.Alignment = Element.ALIGN_CENTER;
                Titulo.Font = FontFactory.GetFont("Verdana", 10);
                Titulo.Add("COMPROBANTE DIA LIBRE\n\n");
                document.Add(Titulo);

                Paragraph Encabezado = new Paragraph();
                Encabezado.Alignment = Element.ALIGN_LEFT;
                Encabezado.Font = FontFactory.GetFont("Verdana", 9);
                Encabezado.Add("FECHA SOLICITUD              : " + lblFecSol.Text + "\n");
                Encabezado.Add("RUT EMPLEADO                  : " + txtRutSolicitud.Text + " " + lblEmpleado.Text + "\n");
                Encabezado.Add("UNIDAD ADMINISTRATIVA : " + lblCargo.Text + "\n");
                Encabezado.Add("SUCURSAL                           : " + lblArea.Text + "\n");
                Encabezado.Add("CENTRO DE COSTO           : " + lblNroCC.Text + " " + lblCcosto.Text + "\n\n");
                document.Add(Encabezado);

                //cuerpo para el uso de los dias mas el llenado de informacion de este
                Paragraph Cuerpo = new Paragraph();
                Cuerpo.Alignment = Element.ALIGN_LEFT;
                Cuerpo.Font = FontFactory.GetFont("Verdana", 9);
                Cuerpo.Add("Se Autoriza el uso de días Libres por concepto de Día Trabajados de Forma Extraordinaria por:\n");

                //inicio codigo
                string idUsu = Login.idUsu;
                DataGridViewRow row = new DataGridViewRow();
                //con este for recorro el DataGridView para saber que ID selecciono el usuario para poder eliminar
                for (int i = 0; i < dgwMuestra.Rows.Count; i++)
                {
                    row = dgwMuestra.Rows[i];
                    // primero pregunto si estan seleccionados para no borrar todo el datagredview

                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                    {//una vez identificado que se seleccionaron datos del datagred comienza a recorrer la consulta y procesa los datos que fueron seleccionados
                        // en este ind id se almacena el id seleccionado del selec del datagred para poder ejecutar las query mas el elimina del dgw
                        int id = Convert.ToInt32(row.Cells[4].Value);
                        SqlCommand agregaPDF = new SqlCommand("SELECT ID, RUT, MOTIVO, FECHA, VALOR  FROM ADICIONAL WHERE ID=" + id, cn);
                        cn.Open();
                        agregaPDF.ExecuteNonQuery();
                        cn.Close();
                        //debe cargar los motivos en la parte que corresponde.
                        string motivoAdicional = Convert.ToString(row.Cells[2].Value);
                        string fechaAdicional = Convert.ToString(row.Cells[3].Value);
                        Cuerpo.Add(motivoAdicional + " - " + fechaAdicional + "\n");

                        //inserta motivo por unidad no en campo lineal completo prueba 
                        string motivo = Convert.ToString(row.Cells[2].Value);
                        string cadenaSQL = "insert into motivo (RUT,IDCOS, DIASUSADOS,DESDE,HASTA,FECHASOLICITUD,MOTIVO1,GENUSU) values ('" + txtRutSolicitud.Text + "','" + lblNroCC.Text + "','" + 1 + "','" + fechaDesdeDia.Text + "','" + fechaHastaDia.Text + "','" + fecha + "','" + motivoAdicional + "','" + idUsu + "')";
                        string updateEmp = "update empleado set diasusados set = (SELECT sum(DIASUSADOS+1) FROM motivo WHERE RUT= '" + txtRutSolicitud.Text + "') where rut = '" + Convert.ToInt32(txtRutSolicitud.Text) + "'";
                        SqlCommand guardaRegistro = new SqlCommand(cadenaSQL, cn);
                        SqlCommand actualizaEmpleado = new SqlCommand(updateEmp, cn);
                        cn.Open();
                        guardaRegistro.ExecuteNonQuery();
                        cn.Close();
                        //borra en la tabla adicional datos correspondientes a la cantidad de dias que usara
                        SqlCommand deleterow = new SqlCommand("delete from adicional where id = " + id + "", cn);
                        cn.Open();
                        //elimina visualmente del datagredview las opciones seleccionadas
                        deleterow.ExecuteNonQuery();
                        cn.Close();
                        dgwMuestra.Rows.Remove(row);
                        i--;
                        valorrow++;
                    }

                }
                
                //muestra la informacion de saldos y detalles para cargar el archivo word que se imprime.
                lblDuso.Text = Convert.ToString(valorrow);
                int saldo = Convert.ToInt32(lblDbase.Text) - valorrow;
                lblDsaldo.Text = Convert.ToString(saldo);
                //cuerpo para el llenado de la informacion de los dias usados 
                Cuerpo.Add("\nInformacion de Días:\n");
                Cuerpo.Add("Días Base  : " + lblDbase.Text+"\n");
                Cuerpo.Add("Días Uso    : " + lblDuso.Text + "\n");
                Cuerpo.Add("Días Saldo : " + lblDsaldo.Text+ "\n\n");

                //se hara efectivo se agregara los campor de las fechas de llenado
                Cuerpo.Add("Esto se hará efectivo en las siguientes fechas:\n");
                Cuerpo.Add("Desde el Día : " + fechaDesdeDia.Text + "\n");
                Cuerpo.Add("Hasta El Día  : " + fechaHastaDia.Text + "\n\n\n\n\n");
                document.Add(Cuerpo);

                //armar pie de pagina para las firmas respectivas esto podria quedar en una sola linea
                Paragraph raya1 = new Paragraph();
                raya1.Alignment = Element.ALIGN_LEFT;
                raya1.Font = FontFactory.GetFont("Verdana", 9);
                raya1.Add("_________________________                                                                               _________________________\n");
                raya1.Add("  V° B° Jefe Directo                                                                                                    V° B° Jefe Departamento\n\n\n\n");
                document.Add(raya1);

                Paragraph autoriza = new Paragraph();
                autoriza.Alignment = Element.ALIGN_CENTER;
                autoriza.Font = FontFactory.GetFont("Verdana", 9);
                autoriza.Add("Autorizan el período correspondiente\n\n");
                document.Add(autoriza);

                Paragraph jRRHH = new Paragraph();
                jRRHH.Alignment = Element.ALIGN_LEFT;
                jRRHH.Font = FontFactory.GetFont("Verdana", 9);
                jRRHH.Add("_________________________\n");
                jRRHH.Add(" V° B° Recursos Humanos\n\n");
                document.Add(jRRHH);

                Paragraph pie = new Paragraph();
                pie.Alignment = Element.ALIGN_LEFT;
                pie.Font = FontFactory.GetFont("Verdana", 9);
                pie.Add("Declaro haber hecho uso del feriado indicado en este documento\n\n\n\n");
                document.Add(pie);

                Paragraph trabajador = new Paragraph();
                trabajador.Alignment = Element.ALIGN_RIGHT;
                trabajador.Font = FontFactory.GetFont("Verdana", 9);
                trabajador.Add("_________________________                       \n");
                trabajador.Add("   Firma del Trabajador                       ");
                document.Add(trabajador);
                
                //terminar y lanzar el pdf
                document.Close();
                //Y para lanzarlo vamos a hacer uso de Process (Que esta en System.Diagnostics)
                Process prc = new System.Diagnostics.Process();
                prc.StartInfo.FileName = fileName;
                prc.Start();

                //en estas instrucciones es donde se insertan y actualizan las tablas 
                //veo cuando dias tengo guardados y hago un selec para guardarlos en la variable INT dUso 
                DataSet dsEmpleado = new DataSet();
                SqlDataAdapter dusoEmpleado = new SqlDataAdapter("SELECT DIASUSADOS FROM EMPLEADO WHERE RUT= '" + Convert.ToInt32(txtRutSolicitud.Text) + "'", cn);
                cn.Open();
                dusoEmpleado.Fill(dsEmpleado);
                int dUso = Convert.ToInt32(dsEmpleado.Tables[0].Rows[0]["DIASUSADOS"]);
                cn.Close();
                //sumo el valor de la consulta que genere en dusoEmpleado y esta guardada en dUso y a esta le sumo el resultante del valor obtenido en valorrow (este numero lo obtengo del for que elimina los datos del DataGredView)
                //se genera la suma y se almacena en la variable listo
                int listo = dUso + valorrow;
                //el resultado de listo lo agrego a mi update para que actualize el total de los dias que ha usado (este dato siempre se incrementara es la idea del campo)
                SqlCommand upDiasUso = new SqlCommand("UPDATE EMPLEADO SET DIASUSADOS = '" + listo + "' WHERE RUT =" + Convert.ToInt32(txtRutSolicitud.Text) + "", cn);
                cn.Open();
                upDiasUso.ExecuteNonQuery();
                cn.Close();
                //en esta query se actualiza el resultado de los dias restantes que el emplado puede utilizar (es el saldo que le quedan al empleado de dias libres)
                string CadUpdate = "update EMPLEADO set SALDO = " + saldo + " where RUT= " + Convert.ToInt32(txtRutSolicitud.Text) + "";
                SqlCommand update = new SqlCommand(CadUpdate, cn);
                cn.Open();
                update.ExecuteNonQuery();
                cn.Close();

                //fin codigo btnAgregarSolicitud_Click_1 
                
            }
            this.Close();
        }
     
    }
}
