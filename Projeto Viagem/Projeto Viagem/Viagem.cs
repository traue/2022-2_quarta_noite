using System;

namespace Projeto_Viagem
{
    public class Viagem
    {
        private int distancia; //representará a distância a percorrer (entrada)
        private float consumo; //representará o consumo médio do veículo (entrada)
        private float vCombustivel; //representará o valor médio do combustível (entrada)
        private float vPedagio; //representará o valor gasto com pedágios (entrada)

        private float qtdLitros; //representará a qtd. de litros de combustível usada (saída)
        private float vGasto; //representará o valor gasto com combustível (saída)
        private float vTotal; //representará o valor TOTAL da viagem (saída)
        private float vPorKm; //representará o valor médio por Km rodadado

        public int Distancia { get => distancia; set => distancia = value; }
        public float Consumo { get => consumo; set => consumo = value; }
        public float VCombustivel { get => vCombustivel; set => vCombustivel = value; }
        public float VPedagio { get => vPedagio; set => vPedagio = value; }
        public float VGasto { get => vGasto; set => vGasto = value; }
        public float QtdLitros { get => qtdLitros; set => qtdLitros=value; }
        public float VTotal { get => vTotal; set => vTotal=value; }
        public float VPorKm { get => vPorKm; set => vPorKm = value; }

        public void CalculaViagem()
        {
            qtdLitros = distancia / consumo;
            vGasto = qtdLitros * vCombustivel;
            vTotal = vGasto + vPedagio;
            vPorKm = vTotal / distancia;
        }
    }
}
