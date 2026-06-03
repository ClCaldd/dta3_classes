
namespace combate_;

using System;
using IComportamento;
using Robo_;
using Hackeando_;

public class Combate : IComportamento
{
    public void fazer(Robo robo)
    {
        
        int chance = Random.Shared.Next(1,21);
        Console.WriteLine("Combate....");
        if (chance == 1)
        {
             robo.comportamento = new Hackeando();

        }

        return;
    }
}