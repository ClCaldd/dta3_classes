
Trainer trainer = new();
Boss enemy = new("Red Dragon"); // SET ENEMY

trainer.NewTraining("mage", () => new Mage());
trainer.NewTraining("warrior", () => new Warrior());

Guild guild = new Guild(trainer, enemy);

Console.WriteLine("\n===== PREPARE FOR WAR =====");

guild.Recruit("mage");
guild.Recruit("mage");
guild.Recruit("mage");
// guild.Recruit("mage");
// guild.Recruit("warrior");

enemy.eventManager.NewTarget(guild);

Console.WriteLine("\n===== BATTLE STARTED =====");
for (int i=0; i < 5; i++)
{
    Console.WriteLine($"\n------ {enemy.Name} ------");
    Console.WriteLine($"....... HP: {enemy.hp} .......");
    guild.Attack();
    enemy.Act();

    if(guild.players.Count <= 0)
    {
        Console.WriteLine($"====== DEFEAT ======");
        System.Console.WriteLine("Your team was slayered....");
        break;
    }
        


    if(enemy.hp <= 0)
    {
        Console.WriteLine($"====== CONGRATULATIONS ======");
        Console.WriteLine($"Your team slayered {enemy.Name}!");
        Console.WriteLine($"Players: {guild.players}");
        break;
    }
}
