using System;

namespace Lista2Exercicio8Switch
{
    class Program
    {
        //Escreva um programa que leia um número inteiro(variável CODIGO). Verificar se o código é igual a 1,
        //igual a 2 ou igual a 3. Caso não seja, apresentar a mensagem “Código inválido”. Ao ser verificado o
        //código e constatado que é um valor válido, o programa deve verificar cada código em separado para
        //determinar seu valor por extenso, ou seja, apresentar a mensagem “um”,” dois” ou “três”. (Utilizar o
        //comando Switch).
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o código 1, 2 ou 3");
            var codigo = Convert.ToInt32(Console.ReadLine());

            switch (codigo)
            {
                case 1:
                    Console.WriteLine("Um");
                    break;
                case 2:
                    Console.WriteLine("Dois");
                    break;
                case 3:
                    Console.WriteLine("Três");
                    break;
                default:
                    Console.WriteLine("Código inválido!");
                    break;
            }
        }
    }
}
