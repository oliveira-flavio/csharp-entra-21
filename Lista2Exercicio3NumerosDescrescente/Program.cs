using System;

namespace Lista2Exercicio3NumerosDescrescente
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o primeiro número: ");
            var n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o segundo número: ");
            var n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o terceiro número: ");
            var n3 = Convert.ToInt32(Console.ReadLine());

            int maior;
            int meio;
            int menor;

            if (n1 > n2)
            {
                meio = n1;
                menor = n2;
            }
            else
            {
                meio = n2;
                menor = n1;
            }
            if (meio > n3)
            {
                maior = meio;
                if (menor > n3)
                {
                    meio = menor;
                    menor = n3;
                }
                else
                {
                    meio = n3;
                }
            }
            else
            {
                maior = n3;
            }

            Console.WriteLine(maior);
            Console.WriteLine(meio);
            Console.WriteLine(menor);
        }
    }
}
