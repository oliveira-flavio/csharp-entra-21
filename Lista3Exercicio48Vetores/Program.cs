using System;

namespace Lista3Exercicio48Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamanho = 5;
            string [] nomes = new string [tamanho];
            int[] idades = new int[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine("Informe o nome da candidata: ");
                nomes[i] = Console.ReadLine();
                Console.WriteLine("Informe a idade da candidata: ");
                idades[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Candidatas aprovadas");
            Console.WriteLine(" ");
            for (int i = 0; i < idades.Length; i++)
            {
                if (idades[i] >=18 && idades[i] <= 20)
                {
                    Console.WriteLine($"Nome: {nomes[i]}");
                    Console.WriteLine($"Idade: {idades[i]}");
                }
            }
        }
    }
}
