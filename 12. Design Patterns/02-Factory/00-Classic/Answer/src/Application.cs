public class Application
{
    private readonly ButtonFactory buttonFactory;
    public Application(ButtonFactory bf)
    {
        buttonFactory = bf;
    }

    public void CreateButton() => buttonFactory.Create();
    
}