// FACTORY

public class Factory
{
    private Dictionary<string, Func<Personagem>> Dict = [];
    public void Add(string chave, Func<Personagem> fac)
    => Dict.Add(chave, fac);

    public Personagem Create(string chave)
    {
        if(!Dict.ContainsKey(chave))
            throw new Exception("esse personagem nao esta cadastrado");
        return Dict[chave].Invoke();
    }
}