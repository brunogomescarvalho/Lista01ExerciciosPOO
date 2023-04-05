/*3. Crie um programa para calcular o volume de um Cilindro*/

namespace Exercicio03
{
    public class Cilindro
    {
        public double raio;
        public double altura;
        public double volume { get => CalcularVolume(); }

        private double CalcularAreaBase()
        {
            return Math.PI * Math.Pow(this.raio, 2);
        }

        private double CalcularVolume()
        {
            return this.CalcularAreaBase() * this.altura;
        }
    }

}