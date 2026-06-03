public class WindownsButtonFactory : IFactory
{

    public IButton CreateButton()
    {
        Console.WriteLine("Botãozinho do Windonws");
        return new WindowsButton();
    }

    public ICheckBox CreateCheckBox()
    {
        Console.WriteLine("CheckBox do Windonws");
        return new WindowsCheckBox();
    }
}