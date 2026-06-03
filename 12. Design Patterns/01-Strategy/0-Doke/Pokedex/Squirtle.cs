using Doke.Pokedex;
using Doke.Pokedex.Enum;

public class SquirtleStrategy : IStrategy
{
    public List<Attack> Attacks { get;set; } = [
        new Attack("Water Gun", 4, PokemonType.Water),
        new Attack("Withdraw", 0, PokemonType.Water),
        new Attack("Bubble Beam", 6, PokemonType.Water),
        new Attack("Rapid Spin", 5, PokemonType.Normal),
        new Attack("Hydro Pump", 11, PokemonType.Water)
    ];

    public Attack Execute(Pokemon atacando, Pokemon sendoAtacado)
    {
        int attackIdx = Random.Shared.Next(0,Attacks.Count);
        Attack attack = Attacks[attackIdx];

        float multiplicador = Multiplier.GetMultiplier(attack.Type, sendoAtacado.Type);
        float danoCausado = attack.Damage * multiplicador;
        sendoAtacado.Hp -= (int)danoCausado;

        return attack;
    }
}