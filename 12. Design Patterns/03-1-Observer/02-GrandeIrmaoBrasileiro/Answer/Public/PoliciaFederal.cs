using GrandeIrmaoBrasileiro.Util;

namespace GrandeIrmaoBrasileiro.Public;

public class PoliciaFederal : IListener
{
    public void Prender() => Console.WriteLine($"[POLICIA FEDERAL] Autor do crime \"fulano\" acaba de ser preso");

    public void Update() => Prender();
}