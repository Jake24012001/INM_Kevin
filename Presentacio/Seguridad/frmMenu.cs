using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacio.Seguridad
{
    public partial class frmMenu: Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void administradorInmobilariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmAdminInmobilaria"] == null)
            {
                Gestion.frmAdminInmobilaria fc = new Gestion.frmAdminInmobilaria
                {
                    MdiParent = this
                };
                fc.Show();
            }
        }
    }
}
