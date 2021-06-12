using System;

namespace Lista2Exercicio10
{
    class Program
    {
        // Escrever um programa declarando três variáveis do tipo inteiro(a, b e c). Ler um valor maior que zero
        //para cada variável(se o valor digitado não é válido, mostrar mensagem e ler novamente). Exibe o menor
        //valor lido multiplicado pelo maior e o maior valor dividido pelo menor.
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um valor inteiro");
            var n1 = Convert.ToInt32(Console.ReadLine());
            if (n1 < 0)
            {
                Console.WriteLine("Valor precisa ser maior que 0");
                Console.WriteLine("Informe um valor inteiro");
                n1 = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Informe outro valor inteiro");
            var n2 = Convert.ToInt32(Console.ReadLine());
            if (n2 < 0)
            {
                Console.WriteLine("Valor precisa ser maior que 0");
                Console.WriteLine("Informe outro valor inteiro");
                n2 = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Informe mais um valor inteiro");
            var n3 = Convert.ToInt32(Console.ReadLine());
            if (n3 < 0)
            {
                Console.WriteLine("Valor precisa ser maior que 0");
                Console.WriteLine("Informe um valor inteiro");
                n3 = Convert.ToInt32(Console.ReadLine());
            }
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

            Console.WriteLine($"Maior x menor: {maior * menor}");
            Console.WriteLine($"Maior / menor {maior / menor}");
        }
    }
}
