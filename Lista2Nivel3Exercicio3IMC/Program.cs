using System;

namespace Lista2Nivel3Exercicio3IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha a opção abaixo: ");
            Console.WriteLine("1- Masculino");
            Console.WriteLine("2- Feminino");
            Console.WriteLine("3- Sair");
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Informe a sua altura:");
                    double altura = Convert.ToDouble(Console.ReadLine());
                    double pesoIdeal = (72.7 * altura) - 58;
                    Console.WriteLine($"O seu peso ideal é {pesoIdeal:F2}");
                    break;
                case 2:
                    Console.WriteLine("Informe a sua altura:");
                    altura = Convert.ToDouble(Console.ReadLine());
                    pesoIdeal = (62.1 * altura) - 44.7;
                    Console.WriteLine($"O seu peso ideal é {pesoIdeal:F2}");
                    break;
                case 3:
                    Console.WriteLine("Obrigado por utilizar o sistema");
                    break;
                default:
                    break;
            }
        }
    }
}
