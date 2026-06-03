public class Battle (Guild guild, Boss boss)
{
    public void Start()
    {
        Console.WriteLine("\nBattle started!\n-------------------------------");
        while (guild.adventurers.Count > 0 && boss.Hp > 0)
        {
            guild.Attack(boss);
            Console.WriteLine($"Guild attacked! Boss HP: {boss.Hp}");
            boss.Attack();
            Console.WriteLine($"Boss attacked! Guild lifestatus: ");
            foreach (IAdventurous adventurous in guild.adventurers)
            {
                Console.WriteLine($"{adventurous.Name}: {adventurous.Hp}");
            }
            Console.WriteLine("---------------------------\n");
            Thread.Sleep(1000);
        }
    }
}