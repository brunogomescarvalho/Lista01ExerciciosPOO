namespace Exercicio02
{
    public class Temperatura
    {
        public decimal ValorEmCelsius { get; private set; }
        public decimal ValorEmFahrenheit { get; set; }

        public void ConverterValorFahrenheitParaCelsius()
        {
            this.ValorEmCelsius = this.ValorEmFahrenheit - 32 / 1.8M;
        }

    }
}



