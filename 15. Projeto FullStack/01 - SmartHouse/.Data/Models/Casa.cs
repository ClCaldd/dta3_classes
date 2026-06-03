public class Casa
{
    //================PROPERTIES================
    public int Id {get;set;}
    public required string Nome {get;set;}

    //================RELATIONS================
    public ICollection<Participante> Participantes {get;set;} = [];
    public ICollection<Quarto> Quartos {get;set;} = [];
}