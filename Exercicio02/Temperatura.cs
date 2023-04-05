namespace Exercicio02
{
    public class Temperatura
    {
        public decimal ValorCelsius { get; private set; }
        public decimal ValorFahrenheit { get; set; }

        public void ConverterFahrenheitCelsius()
        {
            this.ValorCelsius = this.ValorFahrenheit - 32 / 1.8M;
        }

    }
}



