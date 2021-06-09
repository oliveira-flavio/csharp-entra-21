using System;

namespace ExerciciosEntradaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o estoque mínimo:");
            double estoqueMinimo = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o estoque máximo: ");
            double estoqueMaximo = double.Parse(Console.ReadLine());

            double estoqueMedio = (estoqueMinimo + estoqueMaximo) / 2;

            Console.WriteLine($"O estoque médio é {estoqueMedio}");
            Console.ReadLine();
        }
    }
}
