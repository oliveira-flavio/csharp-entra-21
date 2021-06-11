using System;

namespace Lista2Exercicio5MediaAluno
{
    class Program
    {
        // Escreva um programa que leia quatro notas escolares de um aluno e apresentar uma mensagem que o
        //aluno foi aprovado se o valor da média escolar for maior ou igual a 7. Se o valor da média for menor
        //que 7, solicitar a nota da recuperação, somar com o valor da média e obter a nova média.Se a nova
        //média for maior ou igual a 7, apresentar uma mensagem informando que o aluno foi aprovado na
        //recuperação.Se o aluno não foi aprovado, apresentar uma mensagem informando esta condição.
        //Apresentar junto com as mensagens o valor da média do aluno.

        static void Main(string[] args)
        {
            Console.WriteLine("Informe a primeira nota: ");
            var nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a segunda nota: ");
            var nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a terceira nota: ");
            var nota3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a quarta nota: ");
            var nota4 = Convert.ToDouble(Console.ReadLine());

            var media1 = (nota1 + nota2 + nota3 + nota4) / 4;

            if (media1 < 7)
            {
                Console.WriteLine("Informe a nota obtida na prova de recuperação");
                var notaRecuperacao = Convert.ToDouble(Console.ReadLine());

                var mediaFinal = (media1 + notaRecuperacao) / 2;

                if (mediaFinal < 7)
                {
                    Console.WriteLine($"Aluno está reprovado com média de {mediaFinal}");
                }
                else
                {
                    Console.WriteLine($"Aluno aprovado com média {mediaFinal}");
                }
            }
            else
            {
                Console.WriteLine($"Aluno aprovado com média {media1}");
            }
        }
    }
}
