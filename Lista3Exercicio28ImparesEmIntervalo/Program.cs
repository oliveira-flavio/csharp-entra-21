using System;

namespace Lista3Exercicio28ImparesEmIntervalo
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i < 200; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            };
        }
    }
}
