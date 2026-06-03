using Lady.Interfaces;

namespace Lady;

public class Factory
{
    public Dictionary<string, Func<int,int,IShape>> dict = [];
    
    public void Register(string key, Func<int,int,IShape> value) => dict.Add(key, value);
    public IShape Create(string key, int x, int y) => dict[key].Invoke(x,y);
}