
public class Guild (Factory factory)
{
    public List<IAdventurous> adventurers = [];
    public void Attack(Boss boss)
    {
        int attackvalue = 0;

        foreach(IAdventurous adventurous in adventurers)
        {
            attackvalue += adventurous.Dano;
        }

        boss.Hp -= attackvalue;
    }

    public void Add(string adventurous)
    {
        IAdventurous adventurous1 = factory.Create(adventurous);
        adventurers.Add(adventurous1);
    }

    public void Update(int attack)
    {
        for (int i = 0; i < adventurers.Count; i ++)
        {
            adventurers[i].Hp -= attack;
            if (adventurers[i].Hp <= 0)
            {
                Console.WriteLine($"{adventurers[i].Name} died!");
                adventurers.Remove(adventurers[i]);
            }
        }
    }
}