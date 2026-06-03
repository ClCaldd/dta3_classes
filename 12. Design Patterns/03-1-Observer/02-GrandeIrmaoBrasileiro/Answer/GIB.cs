using GrandeIrmaoBrasileiro.Public;

namespace GrandeIrmaoBrasileiro;

public class GIB
{
    public EventManager em = new();
    
    public void Terremoto() => em.Notify("terremoto");
    public void Assassinato() => em.Notify("assassinato");
    public void VotacaoEncerrada() => em.Notify("votacaoencerrada");
    public void Eliminacao() => em.Notify("eliminacao");
}