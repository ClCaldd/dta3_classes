public class Factory
{
    public Dictionary<string, Func<IButton>> dict = [];

    public void AddOS(string chave, Func<IButton> type)
    {
        dict.Add(chave, type);
    }

    public IButton CreateButton(string type)
    {
        Console.WriteLine(type);
        return dict[type].Invoke();
    }
}