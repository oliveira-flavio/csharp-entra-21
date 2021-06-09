using System;

namespace Exercicio8VolumeCilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio = 0;
            double altura = 0;
            double volume = 0;
            double pi = 3.14159;

            Console.WriteLine("Informe a altura da lata:");
            altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o raio da lata:");
            raio = Convert.ToDouble(Console.ReadLine());

            volume = pi * Math.Pow(raio, 2) * altura;

            Console.WriteLine($"O volume da lata é {volume:f2}");
        }
    }
}
