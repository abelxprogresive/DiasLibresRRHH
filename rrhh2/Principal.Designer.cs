namespace rrhh2
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.solicitudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoSolicitudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarMotivosDeTrabajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarDíaDeTrabajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desvincularEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitarDiaAgregadoPorErrorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitarRegistroDeDíaLibreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDiaRutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDiaTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDíasPorCentroDeCostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitudesGeneradasPorUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informeDeSaldosYDíasUsadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menúSistemasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desbloquarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reestablecerContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solicitudToolStripMenuItem,
            this.ingresosToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.sistemasToolStripMenuItem,
            this.menúSistemasToolStripMenuItem,
            this.acercaDeToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // solicitudToolStripMenuItem
            // 
            this.solicitudToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoSolicitudToolStripMenuItem});
            this.solicitudToolStripMenuItem.Name = "solicitudToolStripMenuItem";
            this.solicitudToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.solicitudToolStripMenuItem.Text = "Solicitud";
            // 
            // ingresoSolicitudToolStripMenuItem
            // 
            this.ingresoSolicitudToolStripMenuItem.Name = "ingresoSolicitudToolStripMenuItem";
            this.ingresoSolicitudToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.ingresoSolicitudToolStripMenuItem.Text = "Solicitud dia Libre";
            this.ingresoSolicitudToolStripMenuItem.Click += new System.EventHandler(this.ingresoSolicitudToolStripMenuItem_Click);
            // 
            // ingresosToolStripMenuItem
            // 
            this.ingresosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarEmpleadoToolStripMenuItem,
            this.actualizarEmpleadoToolStripMenuItem,
            this.agregarMotivosDeTrabajoToolStripMenuItem,
            this.agregarDíaDeTrabajoToolStripMenuItem});
            this.ingresosToolStripMenuItem.Name = "ingresosToolStripMenuItem";
            this.ingresosToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.ingresosToolStripMenuItem.Text = "Ingresos";
            // 
            // agregarEmpleadoToolStripMenuItem
            // 
            this.agregarEmpleadoToolStripMenuItem.Name = "agregarEmpleadoToolStripMenuItem";
            this.agregarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.agregarEmpleadoToolStripMenuItem.Text = "Agregar Empleado";
            this.agregarEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.agregarEmpleadoToolStripMenuItem_Click);
            // 
            // actualizarEmpleadoToolStripMenuItem
            // 
            this.actualizarEmpleadoToolStripMenuItem.Name = "actualizarEmpleadoToolStripMenuItem";
            this.actualizarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.actualizarEmpleadoToolStripMenuItem.Text = "Actualizar Empleado";
            this.actualizarEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.actualizarEmpleadoToolStripMenuItem_Click);
            // 
            // agregarMotivosDeTrabajoToolStripMenuItem
            // 
            this.agregarMotivosDeTrabajoToolStripMenuItem.Name = "agregarMotivosDeTrabajoToolStripMenuItem";
            this.agregarMotivosDeTrabajoToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.agregarMotivosDeTrabajoToolStripMenuItem.Text = "Agregar Motivos de Trabajo";
            this.agregarMotivosDeTrabajoToolStripMenuItem.Click += new System.EventHandler(this.agregarMotivosDeTrabajoToolStripMenuItem_Click);
            // 
            // agregarDíaDeTrabajoToolStripMenuItem
            // 
            this.agregarDíaDeTrabajoToolStripMenuItem.Name = "agregarDíaDeTrabajoToolStripMenuItem";
            this.agregarDíaDeTrabajoToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.agregarDíaDeTrabajoToolStripMenuItem.Text = "Agregar Día de Trabajo";
            this.agregarDíaDeTrabajoToolStripMenuItem.Click += new System.EventHandler(this.agregarDíaDeTrabajoToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desvincularEmpleadoToolStripMenuItem,
            this.quitarDiaAgregadoPorErrorToolStripMenuItem,
            this.quitarRegistroDeDíaLibreToolStripMenuItem});
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // desvincularEmpleadoToolStripMenuItem
            // 
            this.desvincularEmpleadoToolStripMenuItem.Name = "desvincularEmpleadoToolStripMenuItem";
            this.desvincularEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.desvincularEmpleadoToolStripMenuItem.Text = "Desvincular Empleado";
            this.desvincularEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.desvincularEmpleadoToolStripMenuItem_Click_1);
            // 
            // quitarDiaAgregadoPorErrorToolStripMenuItem
            // 
            this.quitarDiaAgregadoPorErrorToolStripMenuItem.Name = "quitarDiaAgregadoPorErrorToolStripMenuItem";
            this.quitarDiaAgregadoPorErrorToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.quitarDiaAgregadoPorErrorToolStripMenuItem.Text = "Quitar Dia Agregado por Error";
            this.quitarDiaAgregadoPorErrorToolStripMenuItem.Click += new System.EventHandler(this.quitarDiaAgregadoPorErrorToolStripMenuItem_Click);
            // 
            // quitarRegistroDeDíaLibreToolStripMenuItem
            // 
            this.quitarRegistroDeDíaLibreToolStripMenuItem.Name = "quitarRegistroDeDíaLibreToolStripMenuItem";
            this.quitarRegistroDeDíaLibreToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.quitarRegistroDeDíaLibreToolStripMenuItem.Text = "Quitar registro de día libre";
            this.quitarRegistroDeDíaLibreToolStripMenuItem.Click += new System.EventHandler(this.quitarRegistroDeDíaLibreToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaDiaRutToolStripMenuItem,
            this.consultaDiaTodosToolStripMenuItem,
            this.consultaDíasPorCentroDeCostoToolStripMenuItem,
            this.solicitudesGeneradasPorUsuarioToolStripMenuItem,
            this.informeDeSaldosYDíasUsadosToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // consultaDiaRutToolStripMenuItem
            // 
            this.consultaDiaRutToolStripMenuItem.Name = "consultaDiaRutToolStripMenuItem";
            this.consultaDiaRutToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.consultaDiaRutToolStripMenuItem.Text = "Consulta días Rut";
            this.consultaDiaRutToolStripMenuItem.Click += new System.EventHandler(this.consultaDiaRutToolStripMenuItem_Click);
            // 
            // consultaDiaTodosToolStripMenuItem
            // 
            this.consultaDiaTodosToolStripMenuItem.Name = "consultaDiaTodosToolStripMenuItem";
            this.consultaDiaTodosToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.consultaDiaTodosToolStripMenuItem.Text = "Consulta días Todos";
            this.consultaDiaTodosToolStripMenuItem.Click += new System.EventHandler(this.consultaDiaTodosToolStripMenuItem_Click);
            // 
            // consultaDíasPorCentroDeCostoToolStripMenuItem
            // 
            this.consultaDíasPorCentroDeCostoToolStripMenuItem.Name = "consultaDíasPorCentroDeCostoToolStripMenuItem";
            this.consultaDíasPorCentroDeCostoToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.consultaDíasPorCentroDeCostoToolStripMenuItem.Text = "Consulta días por Centro de Costo";
            this.consultaDíasPorCentroDeCostoToolStripMenuItem.Click += new System.EventHandler(this.consultaDíasPorCentroDeCostoToolStripMenuItem_Click);
            // 
            // solicitudesGeneradasPorUsuarioToolStripMenuItem
            // 
            this.solicitudesGeneradasPorUsuarioToolStripMenuItem.Name = "solicitudesGeneradasPorUsuarioToolStripMenuItem";
            this.solicitudesGeneradasPorUsuarioToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.solicitudesGeneradasPorUsuarioToolStripMenuItem.Text = "Solicitudes Generadas por Usuario";
            this.solicitudesGeneradasPorUsuarioToolStripMenuItem.Click += new System.EventHandler(this.solicitudesGeneradasPorUsuarioToolStripMenuItem_Click);
            // 
            // informeDeSaldosYDíasUsadosToolStripMenuItem
            // 
            this.informeDeSaldosYDíasUsadosToolStripMenuItem.Name = "informeDeSaldosYDíasUsadosToolStripMenuItem";
            this.informeDeSaldosYDíasUsadosToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.informeDeSaldosYDíasUsadosToolStripMenuItem.Text = "Informe de Saldos y Días Usados";
            this.informeDeSaldosYDíasUsadosToolStripMenuItem.Click += new System.EventHandler(this.informeDeSaldosYDíasUsadosToolStripMenuItem_Click);
            // 
            // sistemasToolStripMenuItem
            // 
            this.sistemasToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.sistemasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearUsuariosToolStripMenuItem});
            this.sistemasToolStripMenuItem.Name = "sistemasToolStripMenuItem";
            this.sistemasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.sistemasToolStripMenuItem.Text = "Utilidades";
            // 
            // crearUsuariosToolStripMenuItem
            // 
            this.crearUsuariosToolStripMenuItem.Name = "crearUsuariosToolStripMenuItem";
            this.crearUsuariosToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.crearUsuariosToolStripMenuItem.Text = "Cambiar Clave";
            this.crearUsuariosToolStripMenuItem.Click += new System.EventHandler(this.crearUsuariosToolStripMenuItem_Click);
            // 
            // menúSistemasToolStripMenuItem
            // 
            this.menúSistemasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearUsuarioToolStripMenuItem,
            this.eliminarUsuarioToolStripMenuItem,
            this.desbloquarUsuarioToolStripMenuItem,
            this.reestablecerContraseñaToolStripMenuItem});
            this.menúSistemasToolStripMenuItem.Enabled = false;
            this.menúSistemasToolStripMenuItem.Name = "menúSistemasToolStripMenuItem";
            this.menúSistemasToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.menúSistemasToolStripMenuItem.Text = "Menú sistemas";
            // 
            // crearUsuarioToolStripMenuItem
            // 
            this.crearUsuarioToolStripMenuItem.Name = "crearUsuarioToolStripMenuItem";
            this.crearUsuarioToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.crearUsuarioToolStripMenuItem.Text = "Crear Usuario";
            this.crearUsuarioToolStripMenuItem.Click += new System.EventHandler(this.crearUsuarioToolStripMenuItem_Click);
            // 
            // eliminarUsuarioToolStripMenuItem
            // 
            this.eliminarUsuarioToolStripMenuItem.Name = "eliminarUsuarioToolStripMenuItem";
            this.eliminarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.eliminarUsuarioToolStripMenuItem.Text = "Eliminar Usuario";
            this.eliminarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.eliminarUsuarioToolStripMenuItem_Click);
            // 
            // desbloquarUsuarioToolStripMenuItem
            // 
            this.desbloquarUsuarioToolStripMenuItem.Name = "desbloquarUsuarioToolStripMenuItem";
            this.desbloquarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.desbloquarUsuarioToolStripMenuItem.Text = "Desbloquear Usuario";
            this.desbloquarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.desbloquarUsuarioToolStripMenuItem_Click);
            // 
            // reestablecerContraseñaToolStripMenuItem
            // 
            this.reestablecerContraseñaToolStripMenuItem.Name = "reestablecerContraseñaToolStripMenuItem";
            this.reestablecerContraseñaToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.reestablecerContraseñaToolStripMenuItem.Text = "Reestablecer Contraseña";
            this.reestablecerContraseñaToolStripMenuItem.Click += new System.EventHandler(this.reestablecerContraseñaToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(613, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Iniciado como: ";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(719, 9);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(77, 15);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "lblUsuario";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Powered by Operaciones, Software de Gestion RRHH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem solicitudToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoSolicitudToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDiaRutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearUsuariosToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ToolStripMenuItem consultaDiaTodosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDíasPorCentroDeCostoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarDíaDeTrabajoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitudesGeneradasPorUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarMotivosDeTrabajoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desvincularEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitarDiaAgregadoPorErrorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informeDeSaldosYDíasUsadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitarRegistroDeDíaLibreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menúSistemasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desbloquarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reestablecerContraseñaToolStripMenuItem;
    }
}

