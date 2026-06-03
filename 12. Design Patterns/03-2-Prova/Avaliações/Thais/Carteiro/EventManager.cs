public class EventManager
{
    // List<IInscrito> inscritos = [];
    // List<string> tipos = ["assasinato", "emprego"];
    private Dictionary<string, List<IInscrito>> users = [];

    public void EntregaJornal(string jornal)
    {
        if(!users.ContainsKey(jornal))
            throw new Exception("n tem n");
        
        foreach (var i in users[jornal])
            i.Update(jornal);
    }
    public void Inscrever(string jornal ,IInscrito insc)
    {
        // if(users.TryGetValue(fav, out var list))
        // {
        //     list.Add();    
        // }

        if(!users.ContainsKey(jornal))
            users.Add(jornal, []);

        users[jornal].Add(insc);
    }
}