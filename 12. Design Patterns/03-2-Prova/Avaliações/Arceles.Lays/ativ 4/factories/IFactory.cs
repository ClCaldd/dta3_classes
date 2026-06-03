public class IFactory
{

    Dictionary<string, Func<IButton>> dicionario = [];  
    public void Add(string Op , Func<IButton> IOp)
    {
        dicionario.Add(Op, IOp);
    }
    public IButton Create(string op)
    {
        return dicionario[op].Invoke();
    }
}