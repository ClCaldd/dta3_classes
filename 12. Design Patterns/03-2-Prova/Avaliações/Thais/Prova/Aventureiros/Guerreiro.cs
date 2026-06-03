public class GuerreiroStrategy : IStrategy
{
    public int HP { get; set; } = 60;
    public int Dano { get; set; } = 30;

    void IStrategy.Execute(Boss boss, Aventureiro aventureiro)
    {
        throw new NotImplementedException();
    }
}