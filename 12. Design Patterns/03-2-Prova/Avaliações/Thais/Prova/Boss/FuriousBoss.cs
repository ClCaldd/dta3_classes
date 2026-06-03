public class FuriousBossStrategy : IStrategy
{
    public int HP { get; set; } = 800;
    public int Dano { get; set; } = Random.Shared.Next(0, 2); //depois implementar: se for 0 == 0, se for 1 == 60

    public void Execute(Boss boss, Aventureiro aventureiro)
    {
        if(Dano == 1)
            Dano = 60;
    }
}