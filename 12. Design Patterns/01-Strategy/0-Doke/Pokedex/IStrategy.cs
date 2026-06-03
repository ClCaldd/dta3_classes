using Doke.Pokedex;

public interface IStrategy
{
    List<Attack> Attacks {get;set;}
    Attack Execute(Pokemon atacando, Pokemon sendoAtacado);
}