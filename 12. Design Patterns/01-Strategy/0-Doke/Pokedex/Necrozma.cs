using Doke.Pokedex;
using Doke.Pokedex.Enum;

public class NecrozmaStrategy : IStrategy
{
    public List<Attack> Attacks { get;set; } = [
        new Attack("Photon Geyser", 10, PokemonType.Psychic),
        new Attack("Prismatic Laser", 16, PokemonType.Psychic),
        new Attack("Night Slash", 7, PokemonType.Dark),
        new Attack("Iron Defense", 0, PokemonType.Steel),
        new Attack("Light That Burns the Sky", 20, PokemonType.Psychic)
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