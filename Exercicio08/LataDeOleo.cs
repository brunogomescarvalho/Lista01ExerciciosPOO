public class LataDeOleo
{
    public double Raio { get; set; }
    public double Altura { get; set; }
    public double Volume { get => CalcularVolume(); }


    private double CalcularVolume()
    {
        return Math.Round(Math.PI * Math.Pow(Raio, 2) * Altura, 2);
    }

}