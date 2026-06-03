using System.Drawing;
using System.Windows.Forms;

namespace GrandeIrmaoBrasileiro.Util;

public static class Console
{
    public static void WriteLine(object message)
    {
        var g = GloboPlay.GetCurrent();
        g?.AddLog($"{message}");
    }
}