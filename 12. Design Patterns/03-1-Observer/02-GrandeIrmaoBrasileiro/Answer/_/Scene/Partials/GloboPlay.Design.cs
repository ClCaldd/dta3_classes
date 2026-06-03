using System.ComponentModel;
using System.Drawing;

namespace GrandeIrmaoBrasileiro;

partial class GloboPlay
{
    private IContainer? components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }
    private void InitializeComponent()
    {
        this.components = new Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new Size(800, 450);
        this.Text = "GloboPlay";
    }
}
