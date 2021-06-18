using System;

namespace Lista3Exercicio47Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            int maior = 0, menor = 0, igual = 0;

            // leitura de dados do vetor
            for (int i = 0; i < numeros.Length ; i++)
            {
                Console.WriteLine("Informe um número inteiro positivo");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Informe outro número qualquer");
            int numX = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > numX)
                {
                    maior++;
                }
                else if (numeros[i] < numX)
                {
                    menor++;
                }
                else
                {
                    igual++;
                }
            }

            Console.WriteLine($"Numeros maiores que {numX} = {maior}");
            Console.WriteLine(" ");
            Console.WriteLine($"Números menores que {numX} = {menor}");
            Console.WriteLine(" ");
            Console.WriteLine($"Números iguais a {numX} = {igual}");
        }
    }
}
