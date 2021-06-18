using System;

namespace Lista3Exercicio49Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamanho = 50;
            int valorIgual = 0;
            int[] vet1 = new int[tamanho];
            int[] vet2 = new int[tamanho];

            Random randNum = new Random();

            for (int i = 0; i < tamanho; i++)
            {
                //Console.WriteLine("Informe um valor para vetor 1");
                //vet1[i] = int.Parse(Console.ReadLine());
                //Console.WriteLine("Informe um valor para vetor 2");
                //vet2[i] = int.Parse(Console.ReadLine());
                vet1[i] = randNum.Next(1, 10);
                vet2[i] = randNum.Next(1, 10);
            }

            for (int i = 0; i < tamanho; i++)
            {
                if (vet1[i] == vet2[i])
                {
                    valorIgual++;
                }
            }
            Console.WriteLine($"Vetor 1 e 2 possuem {valorIgual} números iguais nas mesmas posições");
        }
    }
}
