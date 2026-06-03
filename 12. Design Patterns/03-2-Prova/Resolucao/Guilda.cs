public class Guilda(Factory factory) : IObservador
{
    public List<Personagem> Aventureiros {get;set;} = [];
    private Factory Factory = factory;

    public void Add(string personagem)
    {
        var novoPersonagem = Factory.Create(personagem);
        Aventureiros.Add(novoPersonagem);   
    }
    public void Attack(Personagem alvo)
    {
        foreach(var aventureiro in Aventureiros)
            aventureiro.Attack(alvo);
    }

    public bool Alive => Aventureiros.Any(a => a.Hp>0);

    public void OlharLista()
    {
        foreach(var aventureiro in Aventureiros)
            Console.WriteLine(aventureiro.Name);
    }


    public void Atualizar()
    {
        Aventureiros = Aventureiros.Where(a => a.Hp>0).ToList();
    }
}