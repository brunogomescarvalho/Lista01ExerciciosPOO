/*4. Crie um programa para calcular o consumo de combustível por Km. Deverá ser informado a quilometragem
Inicial e Final do Percurso do Veículo. Deverá ser informado o Consumo de Combustível*/

namespace Exercicio04
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            try
            {
                ConsumoDeCombustivel consumo = new ConsumoDeCombustivel();

                consumo.KmInicial = 14000;
                consumo.KmFinal = 14750;
                consumo.TotalDeLitrosConsumidos = 95;

                double mediaDeConsumo = consumo.CalcularMediaDeConsumo();

                Console.WriteLine($"A média de consumo foi de {mediaDeConsumo} km por litro");

            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }

        }
    }

}
