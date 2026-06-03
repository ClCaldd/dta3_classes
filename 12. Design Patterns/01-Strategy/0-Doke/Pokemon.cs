using Doke.Pokedex;
using Doke.Pokedex.Enum;

public class Pokemon(string name, int hp, PokemonType type, IStrategy strategy)
{
    public IStrategy Strategy {get;set;} = strategy;
    public int Hp {get;set;}= hp;
    public string Name {get;set;}= name;
    public PokemonType Type {get;set;} = type;

    public Attack Attack(Pokemon alvo)
    {
        return Strategy.Execute(this, alvo);
    } 
}