
public class Application(string type, Factory factory)
{

    public void Logic()
    {
        var fabrica = factory.Criar(type);
        fabrica.vozes();
    }
}