
using GrandeIrmaoBrasileiro.Util;

namespace GrandeIrmaoBrasileiro.Public;

public class WilliamBonner : IListener
{
    public void ReportarANoticia() => Console.WriteLine($"[WILLIAM BONNER] Anuncia a noticia");

    public void Update() => ReportarANoticia();
}