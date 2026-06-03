public class Banca
{
    public event Action<string> OnPost;

    public EventManager em = new();

    public void Post(string jornal)
    {
        OnPost.Invoke(jornal);
    }

    public void Venda()
    {
        em.Notify("venda");
    }

}