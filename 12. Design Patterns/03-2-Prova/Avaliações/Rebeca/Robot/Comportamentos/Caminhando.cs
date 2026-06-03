public class Caminhando : IComportamento
{
    public void Execute(Robo robo)
    {
        var chanceCombate = Random.Shared.Next(1, 100);
        var chanceHackeado = Random.Shared.Next(1, 100);

        Console.WriteLine(" andando...");

        if(chanceCombate <= 20)
            robo.Comportamento = new Combate();
        else if(chanceHackeado <= 25)
            robo.Comportamento = new Hackeado();
    }
}