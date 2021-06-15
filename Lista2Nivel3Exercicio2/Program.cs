using System;

namespace Lista2Nivel3Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número inteiro qualquer: ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe outro número qualquer:");
            double n2 = Convert.ToDouble(Console.ReadLine());

            imprimeMenu();
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1: // números múltilplos
                    if (n1 % n2 == 0)
                    {
                        Console.WriteLine($"{n1} e {n2} são múltiplos");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} e {n2} não são múltiplos");
                    }
                    break;
                case 2: // números pares
                    if (n1 % 2 == 0 && n2 % 2 == 0)
                    {
                        Console.WriteLine($"{n1} e {n2} são pares");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} e {n2} são ímpares");
                    }
                    break;
                case 3: // media dos dois números
                    double media = (n1 + n2) / 2;
                    if (media < 7)
                    {
                        Console.WriteLine($"A media dos número {n1} e {n2} é menor do que 7");
                    }
                    else
                    {
                        Console.WriteLine($"Os dois números {n1} e {n2} tem média {media}");
                    }
                    break;
                case 4:
                    Console.WriteLine("Obrigado por ter utilizado o sistema");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
        private static void imprimeMenu()
        {
            Console.WriteLine("Conforme os números informados, escolha uma opção abaixo: ");
            Console.WriteLine("1- Verificar se os números são multiplos um do outro");
            Console.WriteLine("2- Verifique se os dois números informados são pares");
            Console.WriteLine("3- Verifique se a média dos dois números é maior ou igual a 7");
            Console.WriteLine("4- Sair");
        }
    }
}
