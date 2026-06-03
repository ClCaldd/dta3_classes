using System.Collections.Generic;
using GrandeIrmaoBrasileiro.Public;

namespace GrandeIrmaoBrasileiro;

public class EventManager
{
    private Dictionary<string, List<IListener>> listenMap = [];

    public void Subscribe(string key, IListener listener)
    {
        if(!listenMap.ContainsKey(key))
            listenMap.Add(key, new());
        listenMap[key].Add(listener);
    } 

    public void Notify(string key)
    {
        if(listenMap.TryGetValue(key, out var listeners))
        {
            foreach(var l in listeners)
                l.Update(); 
        }
    }
}