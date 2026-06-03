public class Participante
{
    //================PROPERTIES================
    public int Id {get;set;}
    public required bool Admin {get;set;}

    //================MY-RELATIONS================
    public required Usuario Usuario {get;set;}
    public required int UsuarioId {get;set;}
    public required Casa Casa {get;set;}
    public required int CasaId {get;set;}
}