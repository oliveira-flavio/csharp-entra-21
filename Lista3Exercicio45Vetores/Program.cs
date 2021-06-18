using System;

namespace Lista3Exercicio45Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Informe o tamanho do array");
            int tamanho = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[tamanho];
            // Fazendo leitura do array
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Informe um número qualquer");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            // Imprime array original
            Console.WriteLine("Array desorganizado");
            Console.WriteLine(" ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($" {array[i]} ");
            }
           
            Console.WriteLine("Array ascendente");
            Console.WriteLine(" ");

            // Organiza e imprime array ascendente
            Array.Sort(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($" {array[i]} ");
            }
            
            Console.WriteLine("Array descendente");
            Console.WriteLine(" ");
            // Imprime array descendente
            Array.Reverse(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($" {array[i]} ");
            } 
        }
    }
}
