using CDatos.Gestion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacio.Gestion
{
    public partial class frmAdminInmobilaria: Form
    {
        public frmAdminInmobilaria()
        {
            InitializeComponent();
            CargarVisitar();
        }

        private void CargarVisitar()
        {
            dataGridView1.DataSource = VisitasCD.listarVisitas();
        }
    }
}
