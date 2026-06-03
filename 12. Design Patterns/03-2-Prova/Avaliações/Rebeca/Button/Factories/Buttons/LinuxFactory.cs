public class LinuxButtonFactory : IFactory
{
    public IButton CreateButton()
    {
        Console.WriteLine("Botãozinho do Linux");
        return new LinuxButton();
    }
    public ICheckBox CreateCheckBox()
    {
        Console.WriteLine("CheckBox do Linux");
        return new LinuxCheckBox();
    }
}