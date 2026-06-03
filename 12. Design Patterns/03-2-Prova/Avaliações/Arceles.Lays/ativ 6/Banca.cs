using System.Runtime.InteropServices.Marshalling;

public class Banca
{
   public EventManager em = new();

   public void Post(string type)
    {
        em.notificacao(type);
    }
    public void Venda()
    {
        em.notificacao("Venda")
    }
}