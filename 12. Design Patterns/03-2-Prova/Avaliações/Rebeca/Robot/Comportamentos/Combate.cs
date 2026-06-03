public class Combate : IComportamento
{
    public void Execute(Robo robo)
    {
        var chanceHackeado = Random.Shared.Next(1, 100);

        Console.WriteLine(" COMBATE...");

        if(chanceHackeado <= 5)
            robo.Comportamento = new Hackeado();
        
    }
}