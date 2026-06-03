public class Lampada
{
    //================PROPERTIES================
    public int Id {get;set;}
    public required string Nome {get;set;}
    public required bool Estado {get;set;}
    public required TipoLampada Tipo {get;set;}
    public required string Cor {get;set;}

    //================MY-RELATIONS================    
    public required Quarto Quarto {get;set;}
    public required int QuartoId {get;set;}

    //================RELATIONS================
    public ICollection<Grupo> Grupos {get;set;} = [];
}