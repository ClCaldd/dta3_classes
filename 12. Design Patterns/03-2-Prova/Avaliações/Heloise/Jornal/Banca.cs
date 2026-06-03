public class Banca
{
    public EventManager em {get;set;} = new();

    public void PublicarMateria()
    {
        em.AtivaOSininhoGalera();
    }
}