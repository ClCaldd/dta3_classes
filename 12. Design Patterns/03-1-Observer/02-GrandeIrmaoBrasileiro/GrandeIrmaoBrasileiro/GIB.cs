using GrandeIrmaoBrasileiro.Public;

namespace GrandeIrmaoBrasileiro;

public class GIB
{
    private AnaMariaBraga AnaMariaBraga {get;set;} = new();
    private Choquei Choquei {get;set;} = new();
    private Dummy Dummy {get;set;} = new();
    private PoliciaFederal PoliciaFederal {get;set;} = new();
    private Tadeu Tadeu {get;set;} = new();
    private WilliamBonner WilliamBonner {get;set;} = new();
    public void Terremoto()
    {
        Choquei.Postar();
        Dummy.Evacuar();
        WilliamBonner.ReportarANoticia();
    }
    
    public void Assassinato()
    {
        Choquei.Postar();
        WilliamBonner.ReportarANoticia();
        PoliciaFederal.Prender();
    }

    public void VotacaoEncerrada()
    {
        Choquei.Postar();
        Tadeu.AnunciarEliminado();
    }

    public void Eliminacao()
    {
        Choquei.Postar();
        AnaMariaBraga.Entrevistar();
    }
}