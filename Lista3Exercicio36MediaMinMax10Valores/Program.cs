using System;
using System.Linq;

namespace Lista3Exercicio36MediaMinMax10Valores
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            int[] numeros = new int[10];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Informe um valor");
                numeros[i] = Convert.ToInt32(Console.ReadLine());

                soma += numeros[i];
            }

            int min = numeros.Min();
            int max = numeros.Max();

            int media = soma / numeros.Length;

            Console.WriteLine($"Menor número: {min}");
            Console.WriteLine($"Maior número: {max}");
            Console.WriteLine($"Media: {media}");
        }
    }
}
