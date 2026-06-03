public class Boss
{
    public int HP { get; set; } = 800;
    public int Damage { get; set; } = Random.Shared.Next(0,31);
    public int DamageFurioso { get; set; } = 60;
    public EventManager em {get;set;} = new();
}