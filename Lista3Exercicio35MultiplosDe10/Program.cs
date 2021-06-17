using System;

namespace Lista3Exercicio35MultiplosDe10
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 101; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine("Multiplo de 10");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
