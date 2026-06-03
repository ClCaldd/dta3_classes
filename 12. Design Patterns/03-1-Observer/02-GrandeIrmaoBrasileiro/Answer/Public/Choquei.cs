using GrandeIrmaoBrasileiro.Util;

namespace GrandeIrmaoBrasileiro.Public;

public class Choquei : IListener
{
    public void Postar() => Console.WriteLine($"[CHOQUEI] Novo post");

    public void Update() => Postar();
}