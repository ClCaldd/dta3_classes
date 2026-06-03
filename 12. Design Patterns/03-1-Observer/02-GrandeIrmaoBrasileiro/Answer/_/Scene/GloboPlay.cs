using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace GrandeIrmaoBrasileiro;

public partial class GloboPlay : Form
{
    public List<object> Population = [];
    public List<Control> EventButtons = [];

    private readonly GIB GIB;

    private static GloboPlay? instance;
    private static List<string> logs = [];
    public static GloboPlay GetInstance(GIB gib)
    {
        if(instance == null) instance = new(gib);
        return instance;
    }

    public static GloboPlay? GetCurrent() => instance;

    private GloboPlay(GIB gib)
    {
        GIB = gib;
        InitializeComponent();
        SetButtons();
    }

    public void SetButtons()
    {
        var events = GIB.GetType().GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
        bool first = !EventButtons.Any();
        if(first)
            foreach(var _ in events)
            {
                var btn = new Button();
                EventButtons.Add(btn);
                this.Controls.Add(btn);
            }

        int gap = 20;
        int size = (int)(0.15*ClientSize.Height);
        int startX = (this.ClientSize.Width / 2) - (((events.Length*size)+(events.Length-1)*gap) / 2);
        int startY = (int)(0.10 * ClientSize.Height);
        for(int i=0; i<EventButtons.Count; i++)
        {
            Console.WriteLine(events[i].Name);
            var btn = EventButtons[i];
            var ev = events[i];
            btn.Font = new Font("Segoe UI", (int)(0.1 * size), FontStyle.Bold);
            btn.Text = ev.Name;
            btn.Height = size;
            btn.Width = size;
            btn.Location = new(startX, startY);
            startX += size + gap;
            if(first)
                btn.Click += (s,e) => {
                    logs = [];
                    ev?.Invoke(GIB, null);
                };
        }
    }

    protected override void OnResize(EventArgs e)
    {
        SetButtons();
        this.Invalidate();
    }

    public void AddLog(string log)
    {
        logs.Add(log);
        this.Invalidate();
    }
    protected override void OnPaint(PaintEventArgs e)
    {
        SetLogs(e.Graphics);
    }

    private void SetLogs(Graphics g)
    {
        int startX = ClientSize.Width / 2;
        int startY = (int)(0.35 * ClientSize.Height);
        StringFormat format = new StringFormat{Alignment = StringAlignment.Center};

        for (int i=0; i<logs.Count; i++)
        {
            var size = (int)(ClientSize.Height*0.01);
            g.DrawString($"{logs[i]}", new Font("Arial", size), Brushes.Black, new PointF(startX, startY), format);
            startY += 40;
        }
    }
}