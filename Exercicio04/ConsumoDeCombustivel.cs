/*4. Crie um programa para calcular o consumo de combustível por Km. Deverá ser informado a quilometragem
Inicial e Final do Percurso do Veículo. Deverá ser informado o Consumo de Combustível*/

namespace Exercicio04
{
    public class ConsumoDeCombustivel
    {
        private double _kmInicial;
        private double _kmFinal;
        private double _totalDeLitrosConsumidos;

        public double KmInicial
        {
            set
            {
                if (value < 0)
                {
                    throw new Exception("Valor inicial não pode ser menor que zero");
                }
                else
                {
                    _kmInicial = value;
                }
            }
        }

        public double KmFinal
        {
            set
            {
                if (_kmInicial > value)
                {
                    throw new Exception("Valor inicial não pode ser maior que o km final");
                }
                else
                {
                    _kmFinal = value;
                }

            }

        }

        public double TotalDeLitrosConsumidos
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("O total de litros consumidos não pode ser menor ou igual a zero");
                }
                else
                {
                    _totalDeLitrosConsumidos = value;
                }

            }

        }


        public double CalcularMediaDeConsumo()
        {
            return Math.Round((_kmFinal - _kmInicial) / _totalDeLitrosConsumidos, 2);
        }

    }

}
