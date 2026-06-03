using System.Reflection.Metadata;

public class EventManager
{
    private Dictionary<string, List<IAssinante>> Assinatura =[];
    public void notificacao(string type)
    {
        if(!Assinatura.ContainsKey(type))
            throw new Exception("tem nao fi");
        foreach(var u in Assinatura[type])
            u.Update(type);
        
    }
    public void Subcribe(string type, IAssinante Ass)
    {
        if (!Assinatura.ContainsKey(type)){
            Assinatura.Add(type,[]);
        }
        Assinatura[type].Add(Ass);
    }
}