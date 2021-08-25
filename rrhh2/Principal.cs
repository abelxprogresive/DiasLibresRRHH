using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace rrhh2
{
    public partial class Principal : Form
    {
        SqlConnection cn = Conexion.getConexion();
        public Principal()
        {
            InitializeComponent();
        }

        private void ingresoSolicitudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresoSolicitud form = new IngresoSolicitud();
            form.MdiParent = this;
            form.Show();
        }

        private void agregarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregaEmpleado form = new AgregaEmpleado();
            form.MdiParent = this;
            form.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            resultado = MessageBox.Show("Realmente ¿desea salir de la aplicación?", "", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                SqlCommand update = new SqlCommand("update USUARIOS set conectado = '0' where usuario ='"+lblUsuario.Text+"'",cn);
                cn.Open();
                update.ExecuteNonQuery();                
                System.Environment.Exit(1);
            }
        }

        private void actualizarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizaEmpleado form = new ActualizaEmpleado();
            form.MdiParent = this;
            form.Show();
        }

        private void consultaDiaRutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaRut form = new ConsultaRut();
            form.MdiParent = this;
            form.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = Login.idUsu;
            if(lblUsuario.Text == "ADMIN")
            {
                menúSistemasToolStripMenuItem.Enabled = true;
            }

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acerca form = new Acerca();
            form.Show();
        }

        private void crearUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiaClave cclave = new CambiaClave();
            cclave.Show();
        }

        private void consultaDiaTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaTodos form = new ConsultaTodos();
            form.MdiParent = this;
            form.Show();
        }

        private void consultaDíasPorCentroDeCostoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaCcostocs ccosto = new ConsultaCcostocs();
            ccosto.MdiParent = this;
            ccosto.Show();
        }

        private void desvincularEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* NO USADO
            DesvinculaEmpleado demp = new DesvinculaEmpleado();
            demp.MdiParent = this;
            demp.Show();*/
        }

        private void agregarDíaDeTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agregaDia agD = new agregaDia();
            agD.MdiParent = this;
            agD.Show();
        }

        private void solicitudesGeneradasPorUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta_Usuario usu = new Consulta_Usuario();
            usu.MdiParent = this;
            usu.Show();
        }

        private void agregarMotivosDeTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregaMotivo usu = new AgregaMotivo();
            usu.MdiParent = this;
            usu.Show();
        }

        private void desvincularEmpleadoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DesvinculaEmpleado demp = new DesvinculaEmpleado();
            demp.MdiParent = this;
            demp.Show();
        }

        private void quitarDiaAgregadoPorErrorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quitarDia dia = new quitarDia();
            dia.MdiParent = this;
            dia.Show();
        }

        private void informeDeSaldosYDíasUsadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformeSaldo informe = new InformeSaldo();
            informe.MdiParent = this;
            informe.Show();

        }

        private void quitarRegistroDeDíaLibreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quitarRegistro reg = new quitarRegistro();
            reg.MdiParent = this;
            reg.Show();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult op;
            op = MessageBox.Show("Realmente ¿desea salir de la aplicación?", "", MessageBoxButtons.YesNo);
            if (op == DialogResult.Yes)
            {
                SqlCommand update = new SqlCommand("update USUARIOS set conectado = '0' where usuario ='" + lblUsuario.Text + "'", cn);
                cn.Open();
                update.ExecuteNonQuery();
                System.Environment.Exit(1);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void desbloquarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Desbloquear_Usuario desq = new Desbloquear_Usuario();
            desq.MdiParent = this;
            desq.Show();
        }

        private void reestablecerContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReestableceContraseña rest = new ReestableceContraseña();
            rest.MdiParent = this;
            rest.Show();
        }

        private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearUsuario crea = new CrearUsuario();
            crea.MdiParent = this;
            crea.Show();
        }

        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminaUsuario eli = new EliminaUsuario();
            eli.MdiParent = this;
            eli.Show();
        }
        }
 }

