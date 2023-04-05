/*7. Crie um programa para calcular o salário total de um vendedor. Deverá ser informado o salário base e o total de
vendas. A comissão é calculada com um percentual (informado pelo usuário) sobre o total de vendas.*/

namespace Exercicio07;

public class Salario
{
    public decimal SalarioFixo { get; set; }
    public decimal TotalVendas { get; set; }
    public decimal PercentualGanho { get; set; }
    public decimal SalarioTotal { get => this.CalcularSalarioTotal(); }

    private decimal CalcularSalarioTotal()
    {
        return Math.Round((SalarioFixo + (TotalVendas * (PercentualGanho / 100))), 2);
    }
}