using System;

namespace Exercicio9ConversorIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            const int diasPorAno = 360;

            Console.WriteLine("Informe a sua idade completa conforme abaixo:");
            Console.WriteLine("Anos de idade: ");
            int anosIdade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Meses de idade: ");
            int mesesIdade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dias de idade: ");
            int diasIdade = Convert.ToInt32(Console.ReadLine());

            int diasIdadeTotal = (anosIdade * diasPorAno) + (mesesIdade * 30) + diasIdade;

            Console.WriteLine($"Você tem ao todo {diasIdadeTotal} dias de idade");
        }
    }
}
