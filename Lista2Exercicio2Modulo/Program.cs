using System;

namespace Lista2Exercicio2Modulo
{
    class Program
    {
        // Escreva um programa que leia um número inteiro e exiba o seu módulo.O módulo de um número x é:
        //x se x for maior ou igual a zero
        //x* (-1) se x é menor que zero
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número inteiro: ");
            var numero = Convert.ToInt32(Console.ReadLine());

            var result = numero > 0 ? numero : numero * -1;

            Console.WriteLine(result);
        }
    }
}
