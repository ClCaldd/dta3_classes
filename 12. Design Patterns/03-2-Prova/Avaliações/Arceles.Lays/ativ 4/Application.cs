
using Microsoft.VisualBasic;

public class Application(String msg, IFactory factory)
{
    public IFactory factory = factory;

    private string msg = msg;

    public void Create()
    {
        factory.Create(msg);
    }
}