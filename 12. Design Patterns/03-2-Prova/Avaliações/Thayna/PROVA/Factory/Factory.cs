using personagem;

public class Factory
{
    private Dictionary<string, Func<IPersonagens>> Factories = [];

    public void Add(string key, Func<IPersonagens> pers)
    {
        Factories.Add(key, pers);

        Console.WriteLine($"{key} -> {Factories[key]}");        
    }

}