public class MacButtonFactory : ButtonFactory
{
    public Button Create()
    {
        Console.WriteLine("MacButton");
        return new MacButton();
    }
}