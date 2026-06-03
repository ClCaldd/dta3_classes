using GrandeIrmaoBrasileiro.Util;

namespace GrandeIrmaoBrasileiro.Public;

public class Dummy : IListener
{
    public void Evacuar() => Console.WriteLine("[DUMMY] Evacuando a casa");

    public void Update() => Evacuar();
}