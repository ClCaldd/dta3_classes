public class BossStrategy : IStrategy
{
    public int Attack()
    {
        return Random.Shared.Next(0,30);

    }
}