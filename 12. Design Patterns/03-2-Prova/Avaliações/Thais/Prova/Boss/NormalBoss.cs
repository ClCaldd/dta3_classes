using System.Diagnostics;

public class NormalBossStrategy : IStrategy
{
    public int HP { get; set; } = 800;
    public int Dano { get; set; } = Random.Shared.Next(0, 31);

    public void Execute(Boss boss, Aventureiro aventureiro)
    {
        if(aventureiro.Name == "mago")
            boss.Strategy = new FuriousBossStrategy();
    }
}