namespace Exercicio02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Temperatura temperatura = new Temperatura();

            temperatura.ValorFahrenheit = 35;

            temperatura.ConverterFahrenheitCelsius();

            Console.WriteLine($"{temperatura.ValorFahrenheit}° Fahrenheit = {temperatura.ValorCelsius}° Celsius");
        }
    }
}



