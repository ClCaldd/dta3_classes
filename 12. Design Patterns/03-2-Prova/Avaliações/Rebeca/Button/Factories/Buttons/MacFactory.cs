public class MacButtonFactory : IFactory
{

    public IButton CreateButton()
    {
        Console.WriteLine("Botãozinho do Mac");
        return new MacButton();
    }

    public ICheckBox CreateCheckBox()
    {
        Console.WriteLine("CheckBox do Mac");
        return new MacCheckBox();
    }
}