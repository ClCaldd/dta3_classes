

using GrandeIrmaoBrasileiro.Util;

namespace GrandeIrmaoBrasileiro.Public;

public class Tadeu : IListener
{
    public void AnunciarEliminado() => Console.WriteLine($"[TADEU] E hoje quem vai pra casa é você..... fulano");

    public void Update() => AnunciarEliminado();
}