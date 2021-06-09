using System;

namespace Exercicio4PropriedadeDistributiva
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            int d;
            Console.WriteLine("Informe o valor de A:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de B:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de C:");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de D:");
            d = int.Parse(Console.ReadLine());

            int resultSomaAB = a + b;
            int resultSomaAC = a + c;
            int resultSomaAD = a + d;
            int resultMultAB = a * b;
            int resultMultAC = a * c;
            int resultMultAD = a * d;
            int resultSomaBC = b + c;
            int resultSomaBD = b + d;
            int resultMultBC = b * c;
            int resultMultBD = b * d;
            int resultSomaCD = c + d;
            int resultMultCD = c * d;

            Console.WriteLine($"A + B {resultSomaAB} e A x B {resultMultAB}");
           //Console.ReadLine();
            Console.WriteLine($"A + C {resultSomaAC} e A x C {resultMultAC}");
           // Console.ReadLine();
            Console.WriteLine($"A + D {resultSomaAD} e A x D {resultMultAD}");
           // Console.ReadLine();
            Console.WriteLine($"B + C {resultSomaBC} e B x C {resultMultBC}");
          //  Console.ReadLine();
            Console.WriteLine($"B + D {resultSomaBD} e B x D {resultMultBD}");
          //  Console.ReadLine();
            Console.WriteLine($"C + D {resultSomaCD} e C x D {resultMultCD}");
        }
    }
}
