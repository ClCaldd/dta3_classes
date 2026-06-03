public class Factory()
{
    public Dictionary<string, Func<IAdventure>> adv = [];

    public void Add(string a, Func<IAdventure> obj)
    {
        adv.Add(a, obj);
    }

    public IAdventure Create(string obj)
    {
        return adv[obj].Invoke();
    }

    public int Attack(List<Adventure> ad)
    {
        foreach(var a in ad)
        {
           
        }
    }
}