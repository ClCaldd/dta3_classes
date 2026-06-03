public class MagoStrategy : IStrategy
{
    public int HP { get; set; } = 40;
    public int Dano { get; set; } = 60;

    public void Execute(Boss boss, Aventureiro aventureiro)
    {
        throw new NotImplementedException();
    }
}