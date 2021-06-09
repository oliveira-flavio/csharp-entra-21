using System;

namespace Exercicio7ConversaoTemperatura
{
    class Program
    {
        // Ler uma temperatura em graus Fahrenheit e apresentá-Ia convertida em graus Celsius.A fórmula de
        //conversão de temperatura a ser utilizada é C = (F - 32) * 5 / 9, em que a variável F é a temperatura
        //em graus Fahrenheit e a variável C é a temperatura em graus Celsius.
        static void Main(string[] args)
        {
            double temperaturaCelsius;
            double temperaturaFahrenheit;

            Console.WriteLine("Informe a temperatura em Fahrenheit: ");
            temperaturaFahrenheit = double.Parse(Console.ReadLine());

            temperaturaCelsius = (temperaturaFahrenheit - 32) * 5 / 9;

            Console.WriteLine($"Temperatura em Fahrenheit {temperaturaFahrenheit} ºF");
            Console.WriteLine($"Temperatura convertida em Celsius {temperaturaCelsius} ºC");
        }
    }
}
