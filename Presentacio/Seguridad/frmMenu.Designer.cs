namespace Presentacio.Seguridad
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorVisitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorInmobilariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorPropietarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorCiudadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valorRecaudadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteInmobilariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administradorUsuariosToolStripMenuItem,
            this.administradorVisitasToolStripMenuItem,
            this.administradorInmobilariaToolStripMenuItem,
            this.administradorPropietarioToolStripMenuItem,
            this.administradorCiudadToolStripMenuItem});
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.gestionToolStripMenuItem.Text = "Gestion";
            // 
            // administradorUsuariosToolStripMenuItem
            // 
            this.administradorUsuariosToolStripMenuItem.Name = "administradorUsuariosToolStripMenuItem";
            this.administradorUsuariosToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.administradorUsuariosToolStripMenuItem.Text = "Administrador Usuarios";
            // 
            // administradorVisitasToolStripMenuItem
            // 
            this.administradorVisitasToolStripMenuItem.Name = "administradorVisitasToolStripMenuItem";
            this.administradorVisitasToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.administradorVisitasToolStripMenuItem.Text = "Administrador Visitas";
            // 
            // administradorInmobilariaToolStripMenuItem
            // 
            this.administradorInmobilariaToolStripMenuItem.Name = "administradorInmobilariaToolStripMenuItem";
            this.administradorInmobilariaToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.administradorInmobilariaToolStripMenuItem.Text = "Administrador Inmobilaria";
            this.administradorInmobilariaToolStripMenuItem.Click += new System.EventHandler(this.administradorInmobilariaToolStripMenuItem_Click);
            // 
            // administradorPropietarioToolStripMenuItem
            // 
            this.administradorPropietarioToolStripMenuItem.Name = "administradorPropietarioToolStripMenuItem";
            this.administradorPropietarioToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.administradorPropietarioToolStripMenuItem.Text = "Administrador Propietario";
            // 
            // administradorCiudadToolStripMenuItem
            // 
            this.administradorCiudadToolStripMenuItem.Name = "administradorCiudadToolStripMenuItem";
            this.administradorCiudadToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.administradorCiudadToolStripMenuItem.Text = "Administrador Ciudad";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.valorRecaudadoToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // valorRecaudadoToolStripMenuItem
            // 
            this.valorRecaudadoToolStripMenuItem.Name = "valorRecaudadoToolStripMenuItem";
            this.valorRecaudadoToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.valorRecaudadoToolStripMenuItem.Text = "Valor Recaudado";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteInmobilariaToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reporteInmobilariaToolStripMenuItem
            // 
            this.reporteInmobilariaToolStripMenuItem.Name = "reporteInmobilariaToolStripMenuItem";
            this.reporteInmobilariaToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.reporteInmobilariaToolStripMenuItem.Text = "Reporte Inmobilaria";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorVisitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorInmobilariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorPropietarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorCiudadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem valorRecaudadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteInmobilariaToolStripMenuItem;
    }
}