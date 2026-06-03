public class Aplication(string type, Factory factory)
{
    private string Type = type;
    private Factory Factory = factory;

    public void Logic()
    {
        Factory.CreateButton(Type);
        // Factory.CreateCheckbox();
    } 
}