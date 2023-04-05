/*5. Crie um programa para calcular o volume de uma esfera*/

namespace Exercicio05
{
    public class Esfera
    {
        public double Raio { get; set; }
        public double volume { get => CalcularVolumeEsfera(); }

        private double CalcularVolumeEsfera()
        {
            return Math.Round((4 / 3) * Math.PI * (this.Raio * this.Raio * this.Raio), 2);
        }

    }

}


