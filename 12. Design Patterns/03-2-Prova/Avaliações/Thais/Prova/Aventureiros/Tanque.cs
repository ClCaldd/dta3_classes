public class TanqueStrategy : IStrategy
{
    public int HP { get; set; } = 100;
    public int Dano { get; set; } = 15;

    public void Execute(Boss boss, Aventureiro aventureiro)
    {
        throw new NotImplementedException();
    }
}