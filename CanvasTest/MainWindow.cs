using System;
using Gtk;
using Cairo;

public partial class MainWindow : Gtk.Window
{
    private ImageSurface surface;
    private double offsetX = 0.0;
    double offsetY = 0.0;
    double scale = 1.0;

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();

        string filepath = "/home/marcin/cat.png";
        this.surface = new ImageSurface(filepath);
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

        cr.SetSourceRGB(0.0, 0.0, 0.0);
        cr.Rectangle(0, 0, width, height);
        cr.Fill();

        cr.Translate(this.offsetX, this.offsetY);           // move "pointer"
        cr.Scale(this.scale, this.scale);
        cr.SetSourceSurface(this.surface, 0, 0);            // offset surface
        cr.Rectangle(0, 0, this.surface.Width,              // offset cutout
                           this.surface.Height);            
        cr.Fill();                                          // apply

        ((IDisposable)cr.GetTarget()).Dispose();
        ((IDisposable)cr).Dispose();
    }

    private void updateLables()
    {
        this.labelOffsetX.Text = String.Format("OffsetX: {0}", this.offsetX);
        this.labelOffsetY.Text = String.Format("OffsetY: {0}", this.offsetY);
        this.labelScale.Text = String.Format("Scale: {0}", this.scale);
    }

    protected void OnHscaleOffsetXValueChanged(object sender, EventArgs e)
    {
        HScale hscale = (HScale)sender;
        this.offsetX = hscale.Value;
        this.updateLables();
        this.drawingarea1.QueueDraw();
    }

    protected void OnHscaleOffsetYValueChanged(object sender, EventArgs e)
    {
        HScale hscale = (HScale)sender;
        this.updateLables();
        this.offsetY = hscale.Value;
        this.drawingarea1.QueueDraw();
    }

    protected void OnHscaleScaleValueChanged(object sender, EventArgs e)
    {
        HScale hscale = (HScale)sender;
        this.updateLables();
        this.scale = hscale.Value / 10;
        this.drawingarea1.QueueDraw();
    }
}
