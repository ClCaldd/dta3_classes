public interface IStrategy
{
    public int HP { get; set; }
    public int Dano { get; set; }

    void Execute(Boss boss, Aventureiro aventureiro);
}