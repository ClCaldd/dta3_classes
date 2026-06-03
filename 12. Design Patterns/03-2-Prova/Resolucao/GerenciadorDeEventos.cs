public class GerenciadorDeEventos
{
    private List<IObservador> Observadores = [];

    public void Inscrever(IObservador observador)
    => Observadores.Add(observador);

    public void Notificar()
    {
        foreach(var observador in Observadores)
            observador.Atualizar();
    }
}