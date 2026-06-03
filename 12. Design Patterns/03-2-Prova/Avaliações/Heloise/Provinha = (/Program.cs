using System.Runtime.CompilerServices;

Console.WriteLine(new string('=',30) + " Batalha HA Ha HA HA HA help " + new string('=',30));


var guilda = new Guilda();
guilda.Add( new( "Tanque", 100, 15 ));
guilda.Add( new( "Guerreiro",60, 30 ));
guilda.Add( new( "Mago",40, 60 ));


var Boss = new Combatente("Boss ", 800, Random.Shared.Next(0, 30));



while(true)
{
    foreach( var name in guilda.Aventureiros)
    {
        // Guilda ataca
        Boss.Hp = name.Attack(Boss, name);
        Console.WriteLine($"Boss - {Boss.Name} HP: {Boss.Hp}");

        // Boss ataca
        name.Hp = Boss.Attack(name, Boss);
        Console.WriteLine($"Guilda - {name.Name} HP: {name.Hp}");

        if (name.Hp < 0)
        {
            guilda.Aventureiros.Remove(name);
            Console.WriteLine($"Guilda - {name.Name} morreu");
            break;
        }
    
    }
}

