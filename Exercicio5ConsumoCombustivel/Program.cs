using System;

namespace Exercicio5ConsumoCombustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Efetuar o cálculo da quantidade de litros de combustível gasta em uma viagem, utilizando um
            //automóvel que faz 12 Km por litro.Para obter o cálculo, o usuário deve fornecer o tempo gasto na
            //viagem e a velocidade média. Desta forma, será possível obter a distância percorrida com a fórmula
            //DISTANCIA = TEMPO * VELOCIDADE.Tendo o valor da distância, basta calcular a quantidade de litros
            //de combustível utilizada na viagem com a fórmula: LITROS_USADOS = DISTANCIA / 12.O programa
            //deve apresentar os valores da velocidade média, tempo gasto, a distância percorrida e a quantidade
            //de litros utilizada na viagem.Dica: trabalhe com valores reais. 

            const double consumoVeiculo = 12;
            double tempoVigagem;
            double velocidadeMedia;
            double distancia;
            double combustivelUtilizado;

            Console.WriteLine("Informe o tempo total da viagem: ");
            tempoVigagem = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a velocidade média: ");
            velocidadeMedia = double.Parse(Console.ReadLine());

            distancia = tempoVigagem * velocidadeMedia;

            combustivelUtilizado = distancia / consumoVeiculo;

            Console.WriteLine($"Velocidade média: {velocidadeMedia} km/h");
            Console.WriteLine($"Tempo gasto: {tempoVigagem} ");
            Console.WriteLine($"Distância percorrida: {distancia} Km");
            Console.WriteLine($"Quantidade de combustível utilizado: {combustivelUtilizado:F2} Litros");
        }
    }
}
