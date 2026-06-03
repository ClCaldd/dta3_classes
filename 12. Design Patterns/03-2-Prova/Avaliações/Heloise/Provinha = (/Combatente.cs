
public class Combatente(string name, int HP, int damage)
{

    public string Name = name;
    public int Hp = HP;
    public int Damage = damage;

    public int Attack(Combatente alvo, Combatente atacante)
    {
        return alvo.Hp -= atacante.Damage;
    }


};



    // Factory fac = factory;
    // public void Logic()
    // {
    //     var fabrica = factory.Criar(type);
    //     fabrica.vozes();
    // }

    // public void Add(string a)
    // {
    //     fac.Criar(a);
    // }


