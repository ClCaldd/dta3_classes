public class Banca
{
    public EventManager em {get; set;} = new();
    public void Publicar(string tipo)
    {
        em.EntregaJornal(tipo);
    }
}