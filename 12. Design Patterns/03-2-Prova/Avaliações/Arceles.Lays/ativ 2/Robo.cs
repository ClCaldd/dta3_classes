namespace Robo_;
using IComportamento;
using Andando_;
public class Robo ( IComportamento conduta)
{
    public IComportamento comportamento = conduta; 
    public void Agir(Robo robo)
    {
        robo.comportamento = new Andando();
        
    }
}