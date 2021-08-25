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
    public partial class Consulta_Usuario : Form
    {
        //SqlConnection conIngreso = new SqlConnection(@"Data Source=10.10.231.70;Initial Catalog=rrhh;Persist Security Info=True;User ID=sa;Password=Sa2011");
        SqlConnection cn = Conexion.getConexion();
        public Consulta_Usuario()
        {
            InitializeComponent();
        }

        private void Consulta_Usuario_Load(object sender, EventArgs e)
        {
            //carga los combo box con las tablas de la base de datos para tener las AREAS y CARGOS respectivamente.
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("SELECT USUARIO FROM USUARIOS", cn);
            da.Fill(ds, "USUARIO");
            cmbUsu.DataSource = ds.Tables[0].DefaultView;
            cmbUsu.ValueMember = "USUARIO";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            //Cadenas SQL
            string motivo = "SELECT GENUSU, RUT, DIASUSADOS, DESDE, HASTA, MOTIVO1 FROM MOTIVO WHERE GENUSU ='" + cmbUsu.Text + "'order by idmotivo";
                SqlDataAdapter myDataAdapter = new SqlDataAdapter(motivo, cn);
                DataTable myTable;
            cn.Open();
                myTable = new DataTable();
                myDataAdapter.Fill(myTable);
                dgw2.DataSource = myTable;
            cn.Close();

        }

        private void GeneraExcelCC_Click(object sender, EventArgs e)
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
                //GENUSU, RUT, DIASUSADOS, DESDE, HASTA, MOTIVO1, MOTIVO2, MOTIVO3, MOTIVO4, MOTIVO5


                hoja_trabajo.Cells[1, 1] = "GENUSU";
                hoja_trabajo.Cells[1, 2] = "RUT";
                hoja_trabajo.Cells[1, 3] = "DIASUSADOS";
                hoja_trabajo.Cells[1, 4] = "DESDE";
                hoja_trabajo.Cells[1, 5] = "HASTA";
                hoja_trabajo.Cells[1, 6] = "MOTIVO";
                


                //Recorremos el DataGridView rellenando la hoja de trabajo
                for (int i = 0; i < dgw2.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgw2.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[i + 2, j + 1] = dgw2.Rows[i].Cells[j].Value.ToString();
                    }
                }
                libros_trabajo.SaveAs(fichero.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
