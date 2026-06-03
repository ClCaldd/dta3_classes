public class Aplication(string key, Factory factory)
{
    private string Key = key;
    private Factory factory = factory;

    public void Create()
    {
        factory.CreateButton(Key);
    }
}