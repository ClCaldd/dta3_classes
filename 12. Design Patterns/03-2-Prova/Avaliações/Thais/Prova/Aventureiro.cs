public class Aventureiro(string name, IStrategy strategy): IAventureiro
{
    public string Name { get; set; } = name;
    public IStrategy Strategy { get; set; } = strategy;
}