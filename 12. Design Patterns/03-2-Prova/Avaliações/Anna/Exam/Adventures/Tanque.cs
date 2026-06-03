public class Tanque : IAdventure
{
    public Adventure adventure {get; set;}
    public void Action(Adventure a)
    {
        adventure.Name = "Tanque";
        adventure.Hp = 100;
        adventure.Damage = 15;

        adventure.Attack(adventure.Damage, a);
    }
}