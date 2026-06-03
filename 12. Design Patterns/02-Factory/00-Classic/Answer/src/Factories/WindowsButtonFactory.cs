public class WindowsButtonFactory : ButtonFactory
{
    public Button Create()
    {
        Console.WriteLine("WindowsButton");
        return new WindowsButton();
    }
}