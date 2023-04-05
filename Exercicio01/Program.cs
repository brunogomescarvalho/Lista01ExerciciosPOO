/*1. Crie um programa para calcular o volume de uma caixa retangular*/

namespace Exercicio01
{
    public class Program
    {
        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("--- Calcular Volume de uma Caixa Retangular ---\n");

            try
            {
                decimal[] dimensoes = new decimal[3];

                dimensoes[0] = 98;

                dimensoes[1] = 110;

                dimensoes[2] = 90;

                CaixaRetangular caixa = new CaixaRetangular();
                caixa.Dimensoes = dimensoes;

                Console.WriteLine($"\nO volume da caixa retangular é {caixa.Volume} m³\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }
}
