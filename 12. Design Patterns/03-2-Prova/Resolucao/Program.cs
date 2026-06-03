Factory factory = new();

factory.Add("mago", () => new Personagem("mago",40,60, new AtaqueNormal()));
factory.Add("guerreiro", () => new Personagem("guerreiro",60,30, new AtaqueNormal()));
factory.Add("tanque", () => new Personagem("tanque",100,15, new AtaqueNormal()));


var boss = new Personagem("boss", 800, 30, new Boss());
var guilda = new Guilda(factory);  
guilda.Add("guerreiro");
guilda.Add("guerreiro");
guilda.Add("mago");
guilda.Add("tanque");

guilda.OlharLista();

boss.gerenciadorDeEventos.Inscrever(guilda);

while(guilda.Alive && boss.Hp>0)
{
    Console.Write($"{boss.Name}: {boss.Hp}\t| ");
    foreach(var g in guilda.Aventureiros)
        Console.Write($"{g.Name}: {g.Hp} ");
    Console.WriteLine();

    guilda.Attack(boss);
    boss.Attack(guilda.Aventureiros[Random.Shared.Next(0, guilda.Aventureiros.Count)]);
}