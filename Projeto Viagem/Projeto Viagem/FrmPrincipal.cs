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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Viagem viagem = new Viagem();

            viagem.Distancia = Convert.ToInt32(nudDistancia.Value);
            viagem.Consumo = (float)nudConsumo.Value;
            viagem.VCombustivel = (float)nudCombustivel.Value;
            viagem.VPedagio = chkGastoPedagio.Checked ? (float)nudPedagio.Value : 0;

            viagem.CalculaViagem();

            FrmRelatorio frmRelatorio = new FrmRelatorio(viagem);
            frmRelatorio.Show();
        }
    }
}
