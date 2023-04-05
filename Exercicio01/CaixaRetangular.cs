public class CaixaRetangular
{
    private decimal comprimento;
    private decimal largura;
    private decimal altura;
    public decimal Volume
    {
        get => CalcularVolume();
    }
    public decimal[] Dimensoes
    {
        set
        {
            if (this.ValidarInput(value))
            {
                comprimento = value[0];
                largura = value[1];
                altura = value[2];
            }
            else
            {
                throw new Exception("Valores informados Inválidos\n");
            }
        }
    }


    private decimal CalcularVolume()
    {
        return Math.Round(comprimento * largura * altura, 2);
    }

    private bool ValidarInput(decimal[] valores)
    {
        return (valores[0] <= 0 || valores[1] <= 0 || valores[2] <= 0) ? false : true;
    }
}

