using System;

namespace Lista2Exercicio11While
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "";
            do
            {
                Console.WriteLine("Informe um valor qualquer: ");
                var numero = Convert.ToInt32(Console.ReadLine());
                if (numero < 0)
                {
                    Console.WriteLine("O número é negativo");
                }
                else
                {
                    Console.WriteLine("O número é positivo");
                }

                Console.WriteLine("Digite \"c\" para continuar ou \"s\" para sair");
                opcao = Console.ReadLine();
            } while (opcao != "s");
        }
    }
}
