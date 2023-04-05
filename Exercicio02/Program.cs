namespace Exercicio02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TemperaturaFahrenheit temperatura = new TemperaturaFahrenheit();

            temperatura.Graus = 35;

            decimal celsius = temperatura.ConverterFahrenheitCelsius();

            Console.WriteLine($"{temperatura.Graus}° Fahrenheit = {celsius}° Celsius");
        }
    }
}



