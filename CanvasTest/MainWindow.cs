using System;
using Gtk;


public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnDrawingarea1ExposeEvent(object o, ExposeEventArgs args)
    {
        Console.WriteLine("Exposed");

        DrawingArea area = (DrawingArea)o;
        Cairo.Context cr = Gdk.CairoHelper.Create(area.GdkWindow);

        cr.LineWidth = 9;
        cr.SetSourceRGB(0.7, 0.2, 0.0);

        int width = area.Allocation.Width;
        int height = area.Allocation.Height;
        int radius = (width < height ? width : height);

        cr.Translate(width / 2, height / 2);
        cr.Arc(0, 0, radius / 2 - 10, 0, 2 * Math.PI);
        cr.StrokePreserve();

        cr.SetSourceRGB(0.3, 0.4, 0.6);
        cr.Fill();

        ((IDisposable)cr.GetTarget()).Dispose();
        ((IDisposable)cr).Dispose();
    }
}
