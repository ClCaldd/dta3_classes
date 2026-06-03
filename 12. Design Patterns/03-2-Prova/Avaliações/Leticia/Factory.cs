public class Factory()
{
    private Dictionary<string, Func<IAdventurous>> dict = [];

    public void addFunc(string key, Func<IAdventurous> func)
    {
        dict.Add(key, func);
    }

    public IAdventurous Create(string key)
    {
        Console.WriteLine($"Generated {key} element!");
        return dict[key].Invoke();
    }
}