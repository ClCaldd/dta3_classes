public class EventManager (int attack)
{
    Guild guild {get; set;}


    public void Send()
    {
        guild.Update(attack);
    }
}