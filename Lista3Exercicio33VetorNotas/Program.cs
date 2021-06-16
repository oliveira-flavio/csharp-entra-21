using System;

namespace Lista3Exercicio33VetorNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            double soma = 0;
            Console.WriteLine("Quantos alunos fizeram a prova?");
            int qtdeAlunos = Convert.ToInt32(Console.ReadLine());

            string[] arrayMatricula = new string[qtdeAlunos];
            double[] arrayNotas = new double[qtdeAlunos];

            for (int i = 0; i < qtdeAlunos; i++)
            {
                Console.WriteLine("Informe a matricula do aluno");
                arrayMatricula[i] = Console.ReadLine();
                Console.WriteLine("Informe a nota do aluno");
                arrayNotas[i] = Convert.ToDouble(Console.ReadLine());

                soma += arrayNotas[i];
            }
            var media = soma / qtdeAlunos;

            Console.WriteLine($"Média das notas {media}");
        }
    }
}
