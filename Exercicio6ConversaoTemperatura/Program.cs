using System;

namespace Exercicio6ConversaoTemperatura
{
    class Program
    {
        // Ler uma temperatura em graus Celsius e apresentá-Ia convertida em graus Fahrenheit.A fórmula de
        //conversão de temperatura a ser utilizada é F = (9 * C + 160) / 5, em que a variável F representa é a
        //temperatura em graus Fahrenheit e a variável C representa é a temperatura em graus Celsius.
        static void Main(string[] args)
        {
            double temperaturaCelsius;
            double temperaturaFahrenheit;

            Console.WriteLine("Informe a temperatura em Celsius");
            temperaturaCelsius = double.Parse(Console.ReadLine());

            temperaturaFahrenheit = (9 + temperaturaCelsius + 160) / 5;

            Console.WriteLine($"Temperatura em Celsius {temperaturaCelsius} ºC");
            Console.WriteLine($"Temperatura convertida em Fahrenheit {temperaturaFahrenheit} ºF");
        }
    }
}
