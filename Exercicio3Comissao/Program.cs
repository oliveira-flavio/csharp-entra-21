using System;

namespace Exercicio3Comissao
{
    class Program
    {
        static void Main(string[] args)
        {
            const double porcentagemComissao = 0.05;
            string vendedor;
            int codPeca;
            double valorUnitario;
            int quantidadeVendida;

            Console.WriteLine("Informe o nome do vendedor: ");
            vendedor = Console.ReadLine();

            Console.WriteLine("Informe o código da peça:");
            codPeca = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor unitário da peça");
            valorUnitario = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade vendida: ");
            quantidadeVendida = int.Parse(Console.ReadLine());

            double comissaoVendedor = (valorUnitario * quantidadeVendida) * porcentagemComissao;

            Console.WriteLine($"A comissão foi de R${comissaoVendedor} reais");
        }
    }
}
