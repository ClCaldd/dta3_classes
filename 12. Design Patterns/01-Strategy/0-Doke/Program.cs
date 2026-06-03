using Doke.Pokedex.Enum;

Console.WriteLine(new string('=',40) + "Poke Battle!" + new string('=',40));

var poke1 = new Pokemon("Squirtle", 100, PokemonType.Water, new SquirtleStrategy());
var poke2 = new Pokemon("Ditto", 100, PokemonType.Psychic, new DittoStrategy());

while(poke1.Hp > 0 && poke2.Hp > 0)
{
    var ataque1 = poke1.Attack(poke2);
    var ataque2 = poke2.Attack(poke1);

    Console.WriteLine($"{poke1.Name} | {poke2.Name}");
    Console.WriteLine($"{poke1.Hp} | {poke2.Hp}");
    Console.WriteLine($"{ataque1.Name} | {ataque2.Name}");
}