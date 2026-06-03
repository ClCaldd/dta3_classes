using Doke.Pokedex;
using Doke.Pokedex.Enum;

public class DittoStrategy : IStrategy
{
    public List<Attack> Attacks { get;set; } = [
        new Attack("Transform", 0, PokemonType.Psychic),
    ];

    public Attack Execute(Pokemon atacando, Pokemon sendoAtacado)
    {
        atacando.Strategy = sendoAtacado.Strategy;
        atacando.Name = sendoAtacado.Name;
        return Attacks[0];
    }
}