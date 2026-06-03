public class Guerreiro : IAdventure
{
    public Adventure adventure {get; set;}
    public void Action(Adventure a)
    {
        adventure.Name = "Guerreiro";
        adventure.Hp = 60;
        adventure.Damage = 30;

        adventure.Attack(adventure.Damage, a);
    }
}