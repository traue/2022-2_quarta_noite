using System;
using System.Windows.Forms;

namespace Projeto_Viagem
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void chkGastoPedagio_CheckedChanged(object sender, EventArgs e)
        {
            lblPedagio.Visible = nudPedagio.Visible = chkGastoPedagio.Checked;
        }
    }
}
