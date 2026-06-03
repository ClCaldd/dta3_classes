public class Grupo
{
    //================PROPERTIES================
    public int Id {get;set;}
    public required string Nome {get;set;}
    public required bool Estado {get;set;}

    //================RELATIONS================
    public ICollection<Lampada> Lampadas {get;set;} = [];
}