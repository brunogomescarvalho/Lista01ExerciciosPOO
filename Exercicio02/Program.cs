namespace Exercicio02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Temperatura temperatura = new Temperatura();

            temperatura.ValorEmFahrenheit = 35;

            temperatura.ConverterValorFahrenheitParaCelsius();

            Console.WriteLine($"{temperatura.ValorEmFahrenheit}° Fahrenheit = {temperatura.ValorEmCelsius}° Celsius");
        }
    }
}



