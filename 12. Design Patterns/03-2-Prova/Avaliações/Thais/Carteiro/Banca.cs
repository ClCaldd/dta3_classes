public class Banca
{
    public EventManager em { get; set; } = new();

    public void PublicarJornal(string tipo)
    {
        em.EntregaJornal(tipo);
    }
}