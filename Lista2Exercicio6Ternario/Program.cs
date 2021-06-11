using System;

namespace Lista2Exercicio6Ternario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número:");
            var n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe outro número:");
            var n2 = Convert.ToInt32(Console.ReadLine());

            var result = n1 > n2 ? "O primeiro número é maior que o segundo" :
                    n1 < n2 ? "O segundo número é maior que o primeiro" :
                        n1 == n2 ? "Número 1 é igual ao número 2" : "No result";

            Console.WriteLine(result);
        }
    }
}
