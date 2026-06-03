public class Usuario
{
    //================PROPERTIES================
    public int Id {get;set;}
    public required string Nome {get;set;}

    //================RELATIONS================
    public ICollection<Participante> Participantes {get;set;} = [];
}