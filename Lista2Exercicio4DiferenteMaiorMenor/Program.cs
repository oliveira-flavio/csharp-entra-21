using System;

namespace Lista2Exercicio4DiferenteMaiorMenor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número: ");
            var n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe outro número: ");
            var n2 = Convert.ToInt32(Console.ReadLine());

            var result = n1 > n2 ? n1 - n2 : n2 - n1;

            Console.WriteLine($"A diferença do maior para o menor é {result}");
        }
    }
}
