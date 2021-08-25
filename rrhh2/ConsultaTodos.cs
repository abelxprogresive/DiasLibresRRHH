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
    public partial class ConsultaTodos : Form
    {
        //SqlConnection conIngreso = new SqlConnection(@"Data Source=10.10.231.70;Initial Catalog=rrhh;Persist Security Info=True;User ID=sa;Password=Sa2011");
        SqlConnection cn = Conexion.getConexion();
        public ConsultaTodos()
        {
            InitializeComponent();
        }

        private void btnConsultaFecha_Click(object sender, EventArgs e)
        {
            dgw2.DataSource = null;          


            string consultaFecha = "SELECT MOTIVO.FECHASOLICITUD, MOTIVO.RUT ,EMPLEADO.NOMBRE, EMPLEADO.APATERNO, EMPLEADO.AMATERNO ,MOTIVO.DIASUSADOS, MOTIVO.DESDE, MOTIVO.HASTA, MOTIVO.MOTIVO1 FROM MOTIVO INNER JOIN EMPLEADO ON MOTIVO.RUT=EMPLEADO.RUT WHERE MOTIVO.FECHASOLICITUD BETWEEN '" + fechaDesde.Text + "' AND '" + fechaHasta.Text + "'ORDER BY idmotivo";
            SqlDataAdapter myDataAdapter = new SqlDataAdapter(consultaFecha, cn);
            DataTable myTable;

            myTable = new DataTable();
            myDataAdapter.Fill(myTable);
            dgw2.DataSource = myTable;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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
                hoja_trabajo.Cells[1, 9] = "MOTIVO";
                
                //Recorremos el DataGridView rellenando la hoja de trabajo
                for (int i = 0; i < dgw2.Rows.Count -1; i++)
                {
                    for (int j = 0; j < dgw2.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[i +2, j + 1] = dgw2.Rows[i].Cells[j].Value.ToString();
                    }
                }
                libros_trabajo.SaveAs(fichero.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);                    
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }
    }
}
