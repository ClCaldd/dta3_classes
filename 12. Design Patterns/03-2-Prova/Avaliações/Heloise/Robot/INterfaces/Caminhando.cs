using robot;

public class Caminhando : IComportamento
{
    public void Probality(Robot robot )
    {
        Console.WriteLine("Andando...");
       
        int probablidade = Random.Shared.Next(0,100);

       if(probablidade <= 5)
            robot.Strategy = new Hackeado();
        
        
        if(probablidade > 5 && probablidade <= 20)
            robot.Strategy = new Combate();
        
        
    }
}