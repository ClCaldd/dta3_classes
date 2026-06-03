using GrandeIrmaoBrasileiro.Util;

namespace GrandeIrmaoBrasileiro.Public;

public class AnaMariaBraga : IListener
{
    public void Entrevistar() => Console.WriteLine($"[ANA MARIA BRAGA] Bom dia com Mais Você. Hoje entrevistaremos o eliminado fulano do BBB");

    public void Update() => Entrevistar();
    
}