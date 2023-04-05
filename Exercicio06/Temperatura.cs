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
            return this.Valor * 1.8M + 32M;
        }

        private decimal ConverterParaFahrenheit()
        {
            return this.Valor - 32 / 1.8M;
        }

        public enum Tipo
        {
            CELSIUS,
            FAHRENHEIT,
        }
    }
}