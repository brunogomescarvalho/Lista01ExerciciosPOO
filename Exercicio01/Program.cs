/*1. Crie um programa para calcular o volume de uma caixa retangular*/

namespace Exercicio01
{
    public class Program
    {
        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("--- Calcular Volume de uma Caixa Retangular ---");

            decimal[] dimensoes = new decimal[3];

            Console.WriteLine("Informe o comprimento:");
            dimensoes[0] = decimal.Parse(Console.ReadLine()!);

            Console.WriteLine("Informe a largura:");
            dimensoes[1] = decimal.Parse(Console.ReadLine()!);

            Console.WriteLine("Informe a altura:");
            dimensoes[2] = decimal.Parse(Console.ReadLine()!);

            CaixaRetangular caixa = new CaixaRetangular();

            bool valoresValidos = caixa.ReceberDados(dimensoes);


            if (valoresValidos)
            {
                Console.WriteLine($"O volume da caixa retangular é {caixa.Volume} m³");
            }
            else
            {
                Console.WriteLine("Valores informados inválidos");
            }
        }

    }
}
