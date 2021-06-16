using System;

namespace Lista3Exercicio30Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine($"Tabuada de {numero} : {numero} x {i} = {numero * i}");
            }
        }
    }
}
