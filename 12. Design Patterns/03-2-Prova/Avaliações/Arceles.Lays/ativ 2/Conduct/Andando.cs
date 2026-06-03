namespace Andando_;
using IComportamento;
using Robo_;
using combate_;
using Hackeando_;

public class Andando : IComportamento
{
    public void fazer(Robo robo)
    {

      int chance_combate = Random.Shared.Next(1,21);
      int chance_Hackendo = Random.Shared.Next(1, 6 );
    
        Console.WriteLine("Andando....");
        if (chance_combate == 1)
        {
            robo.comportamento = new Combate();
        }
        else if (chance_Hackendo == 1)
        {
             robo.comportamento = new Hackeando();
        }

        return;
    }
}