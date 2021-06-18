using System;

namespace Lista3Exercicio50Sorteio
{
    class Program
    {
        static void Main(string[] args)
        {
            int tentativas = 0;
            int tentativaUsuario = 0;
            Random rand = new Random();
            int numeroSorteio = rand.Next(0, 100);

            Console.WriteLine("Tente adivinhar o número");
            tentativaUsuario = int.Parse(Console.ReadLine());

            while (tentativaUsuario != numeroSorteio )
            {
                if (tentativaUsuario > numeroSorteio)
                {
                    Console.WriteLine("O número mágico é menor");
                    Console.WriteLine(" ");
                    Console.WriteLine("Tente novamente");
                    tentativaUsuario = int.Parse(Console.ReadLine());
                }
                if (tentativaUsuario < numeroSorteio)
                {
                    Console.WriteLine("O número mágico é maior");
                    Console.WriteLine(" ");
                    Console.WriteLine("Tente novamente");
                    tentativaUsuario = int.Parse(Console.ReadLine());
                }
               
                tentativas++;
            }
            Console.WriteLine($"Parabéns! Você acertou com {tentativas} tentativas");
        }
    }
}
