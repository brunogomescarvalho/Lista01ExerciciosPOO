namespace Exercicio02
{
    public class TemperaturaFahrenheit
    {
        public decimal Graus { get; set; }

        public decimal ConverterFahrenheitCelsius()
        {
            return Math.Round((Graus - 32) * 5 / 9, 2);
        }

    }
}



