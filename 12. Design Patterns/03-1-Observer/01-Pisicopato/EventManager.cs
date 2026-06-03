public class EventManager
{
    private Dictionary<string, List<IUser>> users = [];
    public void Notify(string jornal)
    {
        if(!users.ContainsKey(jornal))
            throw new Exception("tem nao fi");
        foreach(var u in users[jornal])
            u.Update(jornal);
    }

    public void Subscribe(string jornal, IUser  user)
    {
        if(!users.ContainsKey(jornal))
            users.Add(jornal, []);
        users[jornal].Add(user);
    }
}