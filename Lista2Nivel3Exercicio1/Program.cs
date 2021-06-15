using System;

namespace Lista2Nivel3Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            imprimeMenu();
            int opcaoUsuario = Convert.ToInt32(Console.ReadLine());

            switch (opcaoUsuario)
            {
                case 1: // adição
                    Console.WriteLine("Informe o primeiro número");
                    double n1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Informe o segundo número");
                    double n2 = Convert.ToDouble(Console.ReadLine());
                    double soma = n1 + n2;
                    Console.WriteLine($"Resultado {n1} + {n2} = {soma}");       
                    break;
                case 2: // subtração
                    Console.WriteLine("Informe o primeiro número");
                    n1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Informe o segundo número");
                    n2 = Convert.ToDouble(Console.ReadLine());
                    double subtracao = n1 - n2;
                    Console.WriteLine($"Resultado {n1} + {n2} = {subtracao}");
                    break;
                case 3: // multiplicação
                    Console.WriteLine("Informe o primeiro número");
                    n1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Informe o segundo número");
                    n2 = Convert.ToDouble(Console.ReadLine());
                    double multiplicacao = n1 * n2;
                    Console.WriteLine($"Resultado {n1} * {n2} = {multiplicacao}");
                    break;
                case 4: // divisão
                    Console.WriteLine("Informe o primeiro número");
                    n1 = Convert.ToDouble(Console.ReadLine());
                    while (n1 == 0)
                    {
                        Console.WriteLine("Impossível dividir por 0");
                        Console.WriteLine();
                        Console.WriteLine("Informe um número diferente de \"0\" ");
                        n1 = Convert.ToDouble(Console.ReadLine());
                    }
                    Console.WriteLine("Informe o segundo número");
                    n2 = Convert.ToDouble(Console.ReadLine());
                    double divisao = n1 / n2;
                    Console.WriteLine($"Resultado {n1} * {n2} = {divisao:N2}");
                    break;

                default:
                    Console.WriteLine("Essa opção não existe");
                    Console.WriteLine();
                    break;
            }

            Console.WriteLine("Obrigado por ter utilizado o sistema");
            Console.ReadLine();
        }

        private static void imprimeMenu()
        {
            Console.WriteLine("Escolha uma operação a ser realizada: ");
            Console.WriteLine("1- Adição");
            Console.WriteLine("2- Subtração");
            Console.WriteLine("3- Multiplicação");
            Console.WriteLine("4- Divisão");
        }
    }
}
