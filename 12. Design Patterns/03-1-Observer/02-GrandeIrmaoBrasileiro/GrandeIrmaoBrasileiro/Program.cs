using System;
using System.Windows.Forms;
 
namespace GrandeIrmaoBrasileiro;
 
static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        GIB g = new GIB();
        GloboPlay gp = GloboPlay.GetInstance(g);
        Application.Run(gp);
    }    
}