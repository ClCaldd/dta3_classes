public class Quarto
{
    //================PROPERTIES================
    public int Id {get;set;}
    public required string Nome {get;set;}

    //================MY-RELATIONS================
    public required Casa Casa {get;set;}
    public required int CasaId {get;set;}

    //================RELATIONS================
    public ICollection<Lampada> Lampadas {get;set;} = [];
}