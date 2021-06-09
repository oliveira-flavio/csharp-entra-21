using System;
using System.Globalization;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a cotação do dollar hoje:");
            double cotacaoDolar = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de dólares: ");
            double quantidadeDolares = double.Parse(Console.ReadLine());
            double dolarConvertido = quantidadeDolares * cotacaoDolar;

            Console.WriteLine($"O valor {quantidadeDolares} foi convertido para {dolarConvertido}");
        }
    }
}
