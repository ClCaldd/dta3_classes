namespace robot;

public class Robot (IComportamento comportamento)
{        
    
    public IComportamento Strategy { get; set; } = comportamento;

    public void Agir()
    {
        Strategy.Probality(this);
    }
}