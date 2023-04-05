/*7. Crie um programa para calcular o salário total de um vendedor. Deverá ser informado o salário base e o total de
vendas. A comissão é calculada com um percentual (informado pelo usuário) sobre o total de vendas.*/

namespace Exercicio07;
public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();

        Salario salario = new Salario();

        salario.SalarioFixo = 2500;
        salario.TotalVendas = 150000;
        salario.PercentualGanho = 2;

        Console.WriteLine($"Salário Total de R$ {salario.SalarioTotal}.");

    }
}
