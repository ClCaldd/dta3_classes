public class Guilda
{
    private List<Aventureiro> Aventureiros { get; set; } = [];
    public void Add(string name)
    {
        if(name == "guerreiro")
            Aventureiros.Add(GuerreiroFactory.Create("guerreiro")); 
    }

    public void Attack(Boss boss)
    {
        foreach (var i in Aventureiros)
        {
            
        }
    }
}