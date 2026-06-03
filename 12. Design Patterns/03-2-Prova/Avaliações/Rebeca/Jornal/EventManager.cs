public class EventManager
{
    List<IInscrito> inscritos = [];

    public void EntregaJornal(string tipo)
    {
        foreach(var i in inscritos)
            i.Update(tipo);
    }
    public void Inscrever(IInscrito insc)
    => inscritos.Add(insc);
}