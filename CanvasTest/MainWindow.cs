using System;
using Gtk;
using Cairo;

public partial class MainWindow : Gtk.Window
{
    private ImageSurface surface;

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();

        string filepath = "/home/marcin/cat.png";


        surface = new ImageSurface(filepath);

        Console.WriteLine("Surface.data {0}", surface.Data);
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

        int width = area.Allocation.Width;
        int height = area.Allocation.Height;
        int radius = (width < height ? width : height);


        double offsetX = -60;
        double offsetY = -60;
        double scale = 2.5;

        cr.SetSourceRGB(0.0, 0.0, 0.0);
        cr.Rectangle(0, 0, width, height);
        cr.Fill();

        cr.Translate(offsetX, offsetY);                     // move "pointer"
        cr.Scale(scale, scale);
        cr.SetSourceSurface(surface, 0, 0);                 // offset surface
        cr.Rectangle(0, 0, surface.Width, surface.Height);  // offset cutout
        cr.Fill();                                          // apply

        ((IDisposable)cr.GetTarget()).Dispose();
        ((IDisposable)cr).Dispose();
    }


}
