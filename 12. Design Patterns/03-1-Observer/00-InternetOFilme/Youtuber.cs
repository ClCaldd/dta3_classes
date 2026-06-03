public class Youtuber
{
    public EventManager em {get;set;} = new();

    public void PublicarVideo()
    {
        em.AtivaOSininhoGalera();
    }
}