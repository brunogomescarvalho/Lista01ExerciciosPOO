/*8. Crie um programa para calcular o volume de uma lata de óleo*/

namespace Exercicio08
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LataDeOleo lataDeOleo = new LataDeOleo();
            lataDeOleo.Altura = 150;
            lataDeOleo.Raio = 40;

            Console.Clear();
            Console.WriteLine($"O volume da lata de óleo é {lataDeOleo.Volume} cm³.");

        }
    }

}