/*3. Crie um programa para calcular o volume de um Cilindro*/

namespace Exercicio03
{
    public class Program
    {
        public static void Main()
        {

            Cilindro cilindro = new Cilindro();

            cilindro.altura = 80;
            cilindro.raio = 30;

            Console.WriteLine($"O volume do cilindro é {cilindro.volume} cm³.");

        }
    }

}