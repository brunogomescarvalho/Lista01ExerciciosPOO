/*5. Crie um programa para calcular o volume de uma esfera*/

namespace Exercicio05
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.Clear();

            Esfera esfera = new Esfera();
            esfera.Raio = 10;

            Console.WriteLine($"O volume da esfera é de: {esfera.volume}");
        }
    }

}


