/*6. Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit*/

namespace Exercicio06
{
    public class Temperatura
    {
        public decimal Valor { get; set; }
        public Tipo tipo { get; set; }

        public decimal ConverterTemperatura()
        {
            return this.tipo == Tipo.FAHRENHEIT ? ConverterParaFahrenheit() : ConverterParaCelsius();
        }

        private decimal ConverterParaCelsius()
        {
            return Math.Round((this.Valor * 9 / 5) + 32, 2);
        }

        private decimal ConverterParaFahrenheit()
        {
            return Math.Round((this.Valor - 32) * 5 / 9, 2);
        }

        public enum Tipo
        {
            CELSIUS,
            FAHRENHEIT,
        }
    }
}