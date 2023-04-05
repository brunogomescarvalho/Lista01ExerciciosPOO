/*6. Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit*/

namespace Exercicio06
{
    public class Program
    {
        public static void Main()
        {
            Temperatura temperatura = new Temperatura();

            temperatura.tipo = Temperatura.Tipo.CELSIUS;

            temperatura.Valor = 50;

            decimal temperaturaEmFahrenheit = temperatura.ConverterTemperatura();

            Console.WriteLine($"A temperatura está em {temperaturaEmFahrenheit} graus Fahrenheit.");
        }
    }
}