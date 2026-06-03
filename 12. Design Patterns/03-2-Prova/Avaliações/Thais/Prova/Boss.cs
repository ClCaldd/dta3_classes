public class Boss: IBoss
{
    public string Name { get; set; }
    public IStrategy Strategy { get; set; }
    public EventManager em { get; set; } = new();

    public void NotifyAttack()
    {
        
    }
}