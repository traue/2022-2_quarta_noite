using System;
using System.IO;
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
            rtbRelatorio.AppendText($"Dados informados:{Environment.NewLine}");
            rtbRelatorio.AppendText($"------------------------{Environment.NewLine}");
            rtbRelatorio.AppendText($" > Distância: {viagem.Distancia}Km{Environment.NewLine}");
            rtbRelatorio.AppendText($" > Consumo: {viagem.Consumo}Km/L{Environment.NewLine}");
            rtbRelatorio.AppendText($" > Valor médio do combustível:R${viagem.VCombustivel}{Environment.NewLine}");
            rtbRelatorio.AppendText(viagem.VPedagio == 0 
                ? " > Não houve gasto com pédágios"  + Environment.NewLine
                : $" > Pedágios: R${viagem.VPedagio}{Environment.NewLine}");

            rtbRelatorio.AppendText($"------------------------{Environment.NewLine}");

            rtbRelatorio.AppendText($"Resultados desta viagem:{Environment.NewLine}");
            rtbRelatorio.AppendText($" > Qtd. de litros de combustível: {viagem.QtdLitros}L{Environment.NewLine}");
            rtbRelatorio.AppendText($" > Valor gasto com combustível: R${viagem.VGasto}{Environment.NewLine}");

            rtbRelatorio.AppendText($"------------------------{Environment.NewLine}");
            rtbRelatorio.AppendText($" > Valor médio por Km rodado: R${viagem.VPorKm}{Environment.NewLine}");
            rtbRelatorio.AppendText($" > Valor total da viagem: R${viagem.VTotal}{Environment.NewLine}");
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExportarTxt_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Arquivo de Texto | *.txt";
                saveFileDialog.FileName = $"Relatorio_{DateTime.Now}";
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter writer = new StreamWriter(saveFileDialog.OpenFile());
                    for (int i = 0; i < rtbRelatorio.Lines.Length; i++)
                    {
                        writer.WriteLine(rtbRelatorio.Lines[i]);
                    }

                    writer.Dispose();
                    writer.Close();
                }
            } catch
            {
                MessageBox.Show("Ops.. algo deu errado!");
            }
        }
    }
}
