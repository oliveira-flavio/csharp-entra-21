using System;

namespace Lista2Exercicio7IntervaloNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número:");
            var n1 = Convert.ToInt32(Console.ReadLine());

            var result = n1 > 0 && n1 < 9 ? $"O Número {n1} é válido " : $"O Número {n1} é inválido!";

            Console.WriteLine(result);
        }
    }
}
