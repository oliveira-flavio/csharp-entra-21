using System;

namespace Lista3Exercicio46Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o tamanho do vetor");
            int tamanho = Convert.ToInt32(Console.ReadLine());

            int[] vetorX = new int[tamanho];
            int[] vetorY = new int[tamanho];
            int[] vetorSoma = new int[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine("Informe um número para vetorX");
                vetorX[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Informe um número para vetorY");
                vetorY[i] = Convert.ToInt32(Console.ReadLine());
            }
            // Multiplicação de vetores e soma dos resultados
            for (int i = 0; i < vetorX.Length; i++)
            {
                
                int resultado = vetorX[i] * vetorY[i];
                vetorSoma[i] += resultado;
            }
            // Impressão do vetor de resultados das somas
            Console.WriteLine("Resultados das somas das multiplicações dos vetores");
            Console.WriteLine(" ");
            for (int i = 0; i < vetorSoma.Length; i++)
            {
                Console.Write($" {vetorSoma[i]} ");
            }
            Console.WriteLine(" ");
        }
    }
}
