using System;
using Gtk;
using Cairo;

public partial class MainWindow : Gtk.Window
{
    private ImageSurface surface;
    private double offsetX = 0.0;
    double offsetY = 0.0;
    double scale = 1.0;

    double pointX = 128;
    double pointY = 128;

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

        cr.SetSourceRGB(1.0, 0.0, 0.0);
        cr.Arc(this.pointX, this.pointY, 2, 0, 2 * Math.PI);
        cr.Fill();

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

    protected void OnDrawingarea1ButtonPressEvent(object o, ButtonPressEventArgs args)
    {
        Console.WriteLine("Button Press");

        if(args.Event.Button == 1)
        {
            this.pointX = (args.Event.X - this.offsetX) / this.scale;
            this.pointY = (args.Event.Y - this.offsetY) / this.scale;
        }

        if (args.Event.Button == 3)
        {
            this.isDragging = true;
            this.lastDragX = args.Event.X;
            this.lastDragY = args.Event.Y;
        }
        this.drawingarea1.QueueDraw();
    }

    protected void OnDrawingarea1ButtonReleaseEvent(object o, ButtonReleaseEventArgs args)
    {
        Console.WriteLine("Button Release");
        if (args.Event.Button == 3)
        {
            this.isDragging = false;
        }
    }

    protected void OnDrawingarea1ScrollEvent(object o, ScrollEventArgs args)
    {
        Console.WriteLine("Scroll");

        if (args.Event.Direction == Gdk.ScrollDirection.Down)
        {
            this.scale *= 0.9;
        }
        else if (args.Event.Direction == Gdk.ScrollDirection.Up)
        {
            this.scale /= 0.9;
        }
        this.updateLables();
        this.drawingarea1.QueueDraw();
    }

    private bool isDragging = false;
    private double lastDragX;
    private double lastDragY;
    protected void OnDrawingarea1MotionNotifyEvent(object o, MotionNotifyEventArgs args)
    {
        Console.WriteLine(args.ToString());

        if (this.isDragging)
        {
            this.offsetX += args.Event.X - this.lastDragX;
            this.offsetY += args.Event.Y - this.lastDragY;

            this.lastDragX = args.Event.X;
            this.lastDragY = args.Event.Y;

            this.updateLables();
            this.drawingarea1.QueueDraw();
        }

    }
}
