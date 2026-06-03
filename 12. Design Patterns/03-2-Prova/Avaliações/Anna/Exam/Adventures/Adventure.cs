public class Adventure : Factory
{
    public string Name {get; set;}
    public int Hp {get; set;}
    public int Damage {get; set;}



    public int Attack(int damage, Adventure adventure)
    {
        var d = adventure.Hp - damage ;
        if(d < 0)
            d = 0;
            
        return d;
    }
}