public class CaixaRetangular
{

    private decimal comprimento;
    private decimal largura;
    private decimal altura;

    private decimal[] Dimensoes
    {
        set
        {
            comprimento = value[0];
            largura = value[1];
            altura = value[2];
        }
    }
    public decimal Volume
    {
        get => CalcularVolume();
    }

    public bool ReceberDados(decimal[] dimensoes)
    {
        if (ValidarDimensoes(dimensoes))
        {
            this.Dimensoes = dimensoes; return true;
        }

        return false;
    }

    private bool ValidarDimensoes(decimal[] dimensoes)
    {
        return (dimensoes[0] <= 0 || dimensoes[1] <= 0 || dimensoes[2] <= 0) ? false : true;
    }

    private decimal CalcularVolume()
    {
        return comprimento * largura * altura;
    }
}

