using System;

namespace Lista2Exercicio1TrocarValores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor de A: ");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o valor de B: ");
            var b = Convert.ToInt32(Console.ReadLine());

            var aux = a;
            a = b;
            b = aux;

            Console.WriteLine($"Valores trocados A = {a} e B = {b}");
        }
    }
}
