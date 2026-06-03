using robot;

public class Combate : IComportamento
{
    public void Probality(Robot robot)
    {
        Console.WriteLine("COMBATE!");
        
        int probablidade = Random.Shared.Next(0,100);

        if(probablidade <= 5)
            robot.Strategy = new Hackeado();
        
        
    }
}