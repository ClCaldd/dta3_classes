
using System.Threading;
public class Robo(IComportamento comportamento)
{
    public IComportamento Comportamento { get; set; } = comportamento;

    public void Execute()
    {
        for(int i = 0; i < 20; i++)
        {
            Console.Write($"[0{i+1}] [Robô] ");
            Comportamento.Execute(this);
            Thread.Sleep(1000); 
        }
    }
}