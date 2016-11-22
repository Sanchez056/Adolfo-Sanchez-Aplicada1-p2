using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aplicada1_p2.UI;

namespace Aplicada1_p2
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Registros.RegistrosCliente res = new UI.Registros.RegistrosCliente();
            res.MdiParent = this;
            res.Show();
        }

        private void tiposTelefonosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Registros.RegistrosTipoTelefono res = new UI.Registros.RegistrosTipoTelefono();
            res.MdiParent = this;
            res.Show();
        }
    }
}
