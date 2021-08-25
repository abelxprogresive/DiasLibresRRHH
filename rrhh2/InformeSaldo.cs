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
    public partial class InformeSaldo : Form
    {
        SqlConnection cn = Conexion.getConexion();
        public InformeSaldo()
        {
            InitializeComponent();
            
        }

        private void txtCenCos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
            DataTable dt = new DataTable();
            if (e.KeyChar == Convert.ToInt32(Keys.Enter))
            {
                dgw2.DataSource = null;
                Buscar_Registro(txtCenCos.Text);

            }
        }
        private bool Buscar_Registro(string cencos)
        {
            //convertir cadena a numero            
            int ccosto = Convert.ToInt32(cencos);

            //Cadenas SQL            
            string consulta = "SELECT ccosto FROM ccosto WHERE id_cos = " + ccosto;
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
                // ds.Dispose();
                DialogResult resultado;
                resultado = MessageBox.Show("Centro de costo no existe");
                txtCenCos.Text = "";
                return false; //el registro no fue encontrado
            }
            else
            {
                lblCos.Text = ds.Tables[0].Rows[0]["ccosto"].ToString();
                SqlDataAdapter myDataAdapter = new SqlDataAdapter("SELECT RUT, NOMBRE, APATERNO, AMATERNO, IDCOS, CENCOS, SALDO, DIASUSADOS FROM EMPLEADO WHERE IDCOS = "+ccosto, cn);
                DataTable myTable;
                myTable = new DataTable();
                myDataAdapter.Fill(myTable);
                dgw2.DataSource = myTable;

            }
            //conIngreso.Close();
            //ds.Dispose();
            return true; //el registro existe
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            SqlDataAdapter myDataAdapter = new SqlDataAdapter("SELECT RUT, NOMBRE, APATERNO, AMATERNO, IDCOS, CENCOS, SALDO, DIASUSADOS FROM EMPLEADO WHERE SALDO > 0 or DIASUSADOS >= 1", cn);
            DataTable myTable;
            myTable = new DataTable();
            myDataAdapter.Fill(myTable);
            dgw2.DataSource = myTable;
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
                hoja_trabajo = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                //titulo                
                hoja_trabajo.Cells[1, 1] = "RUT";
                hoja_trabajo.Cells[1, 2] = "NOMBRE";
                hoja_trabajo.Cells[1, 3] = "APATERNO";
                hoja_trabajo.Cells[1, 4] = "AMATERNO";
                hoja_trabajo.Cells[1, 5] = "IDCOS";
                hoja_trabajo.Cells[1, 6] = "CENCOS";
                hoja_trabajo.Cells[1, 7] = "SALDO";
                hoja_trabajo.Cells[1, 8] = "DIASUSADOS";

                //Recorremos el DataGridView rellenando la hoja de trabajo
                for (int i = 0; i < dgw2.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgw2.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[i + 2, j + 1] = dgw2.Rows[i].Cells[j].Value.ToString();
                    }
                }
                libros_trabajo.SaveAs(fichero.FileName,
                    Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }

        private void GeneraExcelGeneral_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewExcel1(dgw2);
        }

        private void GeneraExcelCC_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewExcel1(dgw2);
        }

        private void InformeSaldo_Load(object sender, EventArgs e)
        {
            lblCos.Text = "";
        }
    }
}
