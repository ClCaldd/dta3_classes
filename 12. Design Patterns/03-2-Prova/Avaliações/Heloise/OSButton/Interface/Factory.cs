public class Factory
{
    private Dictionary<string, Func<IButton>> Factories = [];

    public void Add(string key, Func<IButton> func)
    {
        Factories.Add(key, func);

        Console.WriteLine($"{key} -> {Factories[key]}");        
    }   

    public IButton Criar(string key) => Factories[key].Invoke();
        
}