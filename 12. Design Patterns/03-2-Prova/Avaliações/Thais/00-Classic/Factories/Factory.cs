public class Factory
{
    private Dictionary<string, Func<IButton>> options = [];
    public void Define(string type, Func<IButton> func)
    {
        options.Add(type, func);
    }

    public IButton CreateButton(string type)
    {
        Console.WriteLine("Botão criado: " + type.ToUpper());
        return options[type].Invoke();
    }
    // public ICheckbox CreateCheckbox();
}