using System.Security.Cryptography.X509Certificates;

public class Boss : IAdventure
{
    public Adventure adventure {get; set;}

    public void Action(Adventure a)
    {
        if(a.Name == "Mago")
        {
            adventure.Name = "Boss Furious";
            adventure.Hp = 800;

            int value = Random.Shared.Next(0, 1);
            if(value == 0)
                adventure.Damage = value;
            else
                adventure.Damage = 60;
                

            adventure.Attack(adventure.Damage, a);

        }
        else
        {
            adventure.Name = "Boss";
            adventure.Hp = 800;
            int value = Random.Shared.Next(0, 30);
            adventure.Damage = value;

            adventure.Attack(adventure.Damage, a);
        }  
    }

}