using System;

namespace Lista2Exercicio9Triangulo
{
    class Program
    {
        // Escreva um programa que leia três valores para os lados de um triângulo(variáveis A, B e C). Verificar
        //se cada lado é menor que a soma dos outros dois lados.Se sim, saber de A==B e se B==C, sendo verdade
        //o triângulo é equilátero; se não, verificar de A==B ou se A==C ou se B==C, sendo verdade o triângulo é
        //isóscele; e caso contrário, o triângulo será escaleno.Caso os lados fornecidos não caracterizarem um
        //triângulo, avisar a ocorrência.
        static void Main(string[] args)
        {
            Console.WriteLine("Informe os 3 lados do triângulo:");
            Console.WriteLine("Informe o lado A: ");
            var ladoA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o lado B: ");
            var ladoB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o lado C: ");
            var ladoC = Convert.ToInt32(Console.ReadLine());

            if (ladoA == ladoB && ladoB == ladoC)
            {
                Console.WriteLine("Este triângulo é equilátero");
            }
            else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
            {
                Console.WriteLine("Este triângulo é isósceles");
            }
            else
            {
                Console.WriteLine("Este triângulo é escaleno");
            }
        }
    }
}
