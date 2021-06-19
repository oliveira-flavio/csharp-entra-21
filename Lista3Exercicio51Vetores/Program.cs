using System;

namespace Lista3Exercicio51Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a quantidade de alunos:");
            int tamanho = int.Parse(Console.ReadLine());
            int contAcimaMedia = 0;
            string mediaMenor = "";
            string[] alunos = new string[tamanho];
            double[] notas1 = new double[tamanho];
            double[] notas2 = new double[tamanho];
            double[] notas3 = new double[tamanho];
            double[] medias = new double[tamanho];

            for (int i = 0; i < alunos.Length; i++)
            {
                Console.WriteLine("Informe o nome do aluno:");
                alunos[i] = Console.ReadLine();
                Console.WriteLine("Informe a primeira nota");
                notas1[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Informe a segunda nota");
                notas2[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Informe a terceira nota");
                notas3[i] = double.Parse(Console.ReadLine());

                medias[i] = (notas1[i] + notas2[i] + notas3[i]) / 3;
                if (medias[i] > 7)
                {
                    contAcimaMedia++;
                }
                if (medias[i] < 5)
                {
                    mediaMenor = "Não há nenhum aluno com média cima de 5.0";
                }
            }
            if (contAcimaMedia > 0)
            {
                Console.WriteLine($"Alunos com média acima de 7.0 = {contAcimaMedia}");
            }
            else if (mediaMenor.Length > 0)
            {
                Console.WriteLine(mediaMenor);
            }
        }
    }
}
