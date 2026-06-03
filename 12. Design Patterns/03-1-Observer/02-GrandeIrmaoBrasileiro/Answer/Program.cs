using System;
using System.Windows.Forms;
using GrandeIrmaoBrasileiro.Public;

namespace GrandeIrmaoBrasileiro;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        GIB g = new GIB();

        AnaMariaBraga anaMariaBraga = new AnaMariaBraga();
        Choquei choquei = new Choquei();
        Dummy dummy = new Dummy();
        PoliciaFederal policiaFederal = new PoliciaFederal();
        Tadeu tadeu = new Tadeu();
        WilliamBonner williamBonner = new WilliamBonner();
              
        g.em.Subscribe("terremoto", choquei);
        g.em.Subscribe("terremoto", dummy);
        g.em.Subscribe("terremoto", williamBonner);

        g.em.Subscribe("assassinato", choquei);
        g.em.Subscribe("assassinato", williamBonner);
        g.em.Subscribe("assassinato", policiaFederal);

        g.em.Subscribe("votacaoencerrada", choquei);
        g.em.Subscribe("votacaoencerrada", tadeu);

        g.em.Subscribe("eliminacao", choquei);
        g.em.Subscribe("eliminacao", anaMariaBraga);

        GloboPlay gp = GloboPlay.GetInstance(g);
        Application.Run(gp);
    }    
}