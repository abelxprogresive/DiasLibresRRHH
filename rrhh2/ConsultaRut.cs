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
    public partial class ConsultaRut : Form
    {
        //Conexión con la base de datos
        //SqlConnection conIngreso = new SqlConnection(@"Data Source=10.10.231.70;Initial Catalog=rrhh;Persist Security Info=True;User ID=sa;Password=Sa2011");
        SqlConnection cn = Conexion.getConexion();
        public ConsultaRut()
        {
            InitializeComponent();
        }

        private void txtRutSolicitud_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
            DataTable dt = new DataTable();
            if (e.KeyChar == Convert.ToInt32(Keys.Enter))
            {
                dgw2.DataSource = null;
                Buscar_Registro(txtRutSolicitud.Text);

            }
        }

        private bool Buscar_Registro(string rutt)
        {
            //convertir cadena a numero
            //int salto;
            int rut = Convert.ToInt32(rutt);

            //Cadenas SQL
            //string consulta = "SELECT EMPLEADO.NOMBRE, EMPLEADO.APATERNO, EMPLEADO.AMATERNO, EMPLEADO.CARGO, EMPLEADO.AREA, MOTIVO.IDMOTIVO, MOTIVO.DIASUSADOS, MOTIVO.DESDE, MOTIVO.HASTA, MOTIVO.MOTIVO1, MOTIVO.MOTIVO2, MOTIVO.MOTIVO3, MOTIVO.MOTIVO4, MOTIVO.MOTIVO5 FROM MOTIVO INNER JOIN EMPLEADO ON MOTIVO.RUT = EMPLEADO.RUT WHERE EMPLEADO.RUT = " + rut;
            string consulta = "SELECT NOMBRE, APATERNO, AMATERNO, CARGO, AREA FROM EMPLEADO WHERE RUT = " + rut;
            //Adaptador
            SqlDataAdapter Adaptador = new SqlDataAdapter(consulta, cn);

            //dataset
            DataSet ds = new DataSet();

            //llenar dataset
            cn.Open();
            Adaptador.Fill(ds);
            cn.Close();

            //contar registros
            if (ds.Tables[0].Rows.Count == 0)
            {
                ds.Dispose();
                DialogResult resultado;
                resultado = MessageBox.Show("Rut no existe");
                txtRutSolicitud.Text = "";
                return false; //el registro no fue encontrado
            }
            else
            {
                lblEmpleado.Text = ds.Tables[0].Rows[0]["NOMBRE"].ToString() + " " + ds.Tables[0].Rows[0]["APATERNO"].ToString() + " " + ds.Tables[0].Rows[0]["AMATERNO"].ToString();
                lblCargo.Text = ds.Tables[0].Rows[0]["CARGO"].ToString();
                lblArea.Text = ds.Tables[0].Rows[0]["AREA"].ToString();

                string motivo = "SELECT RUT,IDCOS, DIASUSADOS,GENUSU, DESDE, HASTA, MOTIVO1 FROM MOTIVO WHERE FECHASOLICITUD BETWEEN '"+desdeRut.Text +"' AND '"+hastaRut.Text+"' AND RUT = " + rut+" order by idmotivo";
                SqlDataAdapter myDataAdapter = new SqlDataAdapter(motivo, cn);
                DataTable myTable;
                
                myTable = new DataTable();
                myDataAdapter.Fill(myTable);
                dgw2.DataSource = myTable;

            }
            cn.Close();
            ds.Dispose();
            return true; //el registro existe
        }

        private void ConsultaRut_Load(object sender, EventArgs e)
        {
            lblArea.Text = "";
            lblCargo.Text = "";
            lblEmpleado.Text = "";
            

        }
                

        private void GeneraExcelRut_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewExcel(dgw2);
        }

        private void ExportarDataGridViewExcel(DataGridView dgw2)
        {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                hoja_trabajo =
                    (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                //titulo
                //IDMOTIVO, DIASUSADOS, DESDE, HASTA, MOTIVO1, MOTIVO2, MOTIVO3, MOTIVO4, MOTIVO5
                

                hoja_trabajo.Cells[1, 1] = "RUT";
                hoja_trabajo.Cells[1, 2] = "CCOSTO";
                hoja_trabajo.Cells[1, 3] = "DIASUSADOS";
                hoja_trabajo.Cells[1, 4] = "GENERADO POR";
                hoja_trabajo.Cells[1, 5] = "DESDE";
                hoja_trabajo.Cells[1, 6] = "HASTA";
                hoja_trabajo.Cells[1, 7] = "MOTIVO";
                


                //Recorremos el DataGridView rellenando la hoja de trabajo
                for (int i = 0; i < dgw2.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgw2.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[i + 2, j + 1] = dgw2.Rows[i].Cells[j].Value.ToString();
                    }
                }
                libros_trabajo.SaveAs(fichero.FileName,Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
            


        }

        private void GeneraExcelTodos_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewExcel1(dgw2);
        }

        private void ExportarDataGridViewExcel1(DataGridView dgw2)
        {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                hoja_trabajo =
                    (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                //titulo
                // .FECHASOLICITUD, .RUT ,.NOMBRE, .APATERNO, .AMATERNO ,    .DIASUSADOS,       .DESDE, .HASTA, .MOTIVO1, .MOTIVO2, .MOTIVO3, .MOTIVO4, .MOTIVO5 
                hoja_trabajo.Cells[1, 1] = "FECHASOLICITUD";
                hoja_trabajo.Cells[1, 2] = "RUT";
                hoja_trabajo.Cells[1, 3] = "NOMBRE";
                hoja_trabajo.Cells[1, 4] = "APATERNO";
                hoja_trabajo.Cells[1, 5] = "AMATERNO";
                hoja_trabajo.Cells[1, 6] = "DIASUSADOS";
                hoja_trabajo.Cells[1, 7] = "DESDE";
                hoja_trabajo.Cells[1, 8] = "HASTA";
                hoja_trabajo.Cells[1, 9] = "MOTIVO1";
                hoja_trabajo.Cells[1, 10] = "MOTIVO2";
                hoja_trabajo.Cells[1, 11] = "MOTIVO3";
                hoja_trabajo.Cells[1, 12] = "MOTIVO4";
                hoja_trabajo.Cells[1, 13] = "MOTIVO5";


                //Recorremos el DataGridView rellenando la hoja de trabajo
                for (int i = 1; i < dgw2.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgw2.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[i + 1, j + 1] = dgw2.Rows[i].Cells[j].Value.ToString();
                    }
                }
                libros_trabajo.SaveAs(fichero.FileName,
                    Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
