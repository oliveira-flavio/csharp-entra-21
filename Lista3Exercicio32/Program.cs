using System;

namespace Lista3Exercicio32
{
    class Program
    {
        static void Main(string[] args)
        {
            int imparQuadrado = 0;
            int imparSoma = 0;
            Console.WriteLine("Informe um número entre 0 e 10");
            int numero = Convert.ToInt32(Console.ReadLine());

            for (int i = numero; i < 20; i++)
            {
                if (i % 2 == 1)
                {
                    imparQuadrado = i * i;
                    imparSoma += imparQuadrado;
                }
            }
            Console.WriteLine(imparSoma);
        }
    }
}
