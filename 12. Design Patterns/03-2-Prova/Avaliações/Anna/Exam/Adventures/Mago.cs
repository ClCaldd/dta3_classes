public class Mago : IAdventure
{
    public Adventure adventure {get; set;}
    public void Action(Adventure a)
    {
        adventure.Name = "Mago";
        adventure.Hp = 40;
        adventure.Damage = 60;

        adventure.Attack(adventure.Damage, a);
    }
}