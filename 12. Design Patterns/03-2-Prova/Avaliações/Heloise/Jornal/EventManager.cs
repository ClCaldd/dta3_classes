public class EventManager
{
    List<IInscrito> inscritos = [];
    private Dictionary<string, List<inscritos>> Dic_Inscritos = [];

    public void Notificacao(string jornal)
    {
        if(!Dic_Inscritos.ContainsKey(jornal))
            throw new Exception("Key not found!");
            
        foreach(var i in inscritos)
            i.Update();
    }
    public void Inscrever(string jornal, IInscrito insc)
    {
        if(inscritos.TryGetValue(insc, out var lista))
        {
            inscritos.Add(insc);
        }
    }
}