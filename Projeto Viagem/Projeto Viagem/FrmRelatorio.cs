using System;
using System.Windows.Forms;

namespace Projeto_Viagem
{
    public partial class FrmRelatorio : Form
    {
        private Viagem viagem;
        public FrmRelatorio(Viagem viagem)
        {
            this.viagem = viagem;
            InitializeComponent();
        }

        private void FrmRelatorio_Load(object sender, EventArgs e)
        {
            rtbRelatorio.AppendText("Dados informados:" + Environment.NewLine);
            rtbRelatorio.AppendText(" > Distância: " + viagem.Distancia + Environment.NewLine);
            rtbRelatorio.AppendText(" > Consumo: " + viagem.Consumo + Environment.NewLine);

        }
    }
}
