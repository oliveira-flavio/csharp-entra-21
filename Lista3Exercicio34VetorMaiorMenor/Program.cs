using System;
using System.Linq;

namespace Lista3Exercicio34VetorMaiorMenor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a quantidade de números");
            int tamanho = Convert.ToInt32(Console.ReadLine());
            int[] numeros = new int[tamanho];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Informe um número");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                if (numeros[i] < 0)
                {
                    break;
                }

            }
            int min = numeros.Min();
            int max = numeros.Max();

            Console.WriteLine($"Menor número informado: {min}");
            Console.WriteLine($"Maior número informado: {max}");
        }
    }
}
