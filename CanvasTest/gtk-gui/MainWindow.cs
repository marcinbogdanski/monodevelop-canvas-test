
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed1;

	private global::Gtk.DrawingArea drawingarea1;

	private global::Gtk.HScale hscaleOffsetX;

	private global::Gtk.Label labelOffsetX;

	private global::Gtk.Label labelOffsetY;

	private global::Gtk.HScale hscaleOffsetY;

	private global::Gtk.HScale hscaleScale;

	private global::Gtk.Label labelScale;

	private global::Gtk.Label labelPointX;

	private global::Gtk.Label labelPointY;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.drawingarea1 = new global::Gtk.DrawingArea();
		this.drawingarea1.WidthRequest = 500;
		this.drawingarea1.HeightRequest = 500;
		this.drawingarea1.Events = ((global::Gdk.EventMask)(2097936));
		this.drawingarea1.Name = "drawingarea1";
		this.fixed1.Add(this.drawingarea1);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.drawingarea1]));
		w1.X = 25;
		w1.Y = 26;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.hscaleOffsetX = new global::Gtk.HScale(null);
		this.hscaleOffsetX.WidthRequest = 200;
		this.hscaleOffsetX.CanFocus = true;
		this.hscaleOffsetX.Name = "hscaleOffsetX";
		this.hscaleOffsetX.Adjustment.Upper = 100D;
		this.hscaleOffsetX.Adjustment.PageIncrement = 10D;
		this.hscaleOffsetX.Adjustment.StepIncrement = 1D;
		this.hscaleOffsetX.DrawValue = true;
		this.hscaleOffsetX.Digits = 0;
		this.hscaleOffsetX.ValuePos = ((global::Gtk.PositionType)(2));
		this.fixed1.Add(this.hscaleOffsetX);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.hscaleOffsetX]));
		w2.X = 578;
		w2.Y = 128;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.labelOffsetX = new global::Gtk.Label();
		this.labelOffsetX.Name = "labelOffsetX";
		this.labelOffsetX.LabelProp = global::Mono.Unix.Catalog.GetString("OffsetX");
		this.fixed1.Add(this.labelOffsetX);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.labelOffsetX]));
		w3.X = 580;
		w3.Y = 103;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.labelOffsetY = new global::Gtk.Label();
		this.labelOffsetY.Name = "labelOffsetY";
		this.labelOffsetY.LabelProp = global::Mono.Unix.Catalog.GetString("OffsetY");
		this.fixed1.Add(this.labelOffsetY);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.labelOffsetY]));
		w4.X = 580;
		w4.Y = 187;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.hscaleOffsetY = new global::Gtk.HScale(null);
		this.hscaleOffsetY.WidthRequest = 200;
		this.hscaleOffsetY.CanFocus = true;
		this.hscaleOffsetY.Name = "hscaleOffsetY";
		this.hscaleOffsetY.Adjustment.Upper = 100D;
		this.hscaleOffsetY.Adjustment.PageIncrement = 10D;
		this.hscaleOffsetY.Adjustment.StepIncrement = 1D;
		this.hscaleOffsetY.DrawValue = true;
		this.hscaleOffsetY.Digits = 0;
		this.hscaleOffsetY.ValuePos = ((global::Gtk.PositionType)(2));
		this.fixed1.Add(this.hscaleOffsetY);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.hscaleOffsetY]));
		w5.X = 580;
		w5.Y = 210;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.hscaleScale = new global::Gtk.HScale(null);
		this.hscaleScale.WidthRequest = 200;
		this.hscaleScale.CanFocus = true;
		this.hscaleScale.Name = "hscaleScale";
		this.hscaleScale.Adjustment.Upper = 100D;
		this.hscaleScale.Adjustment.PageIncrement = 10D;
		this.hscaleScale.Adjustment.StepIncrement = 1D;
		this.hscaleScale.Adjustment.Value = 10D;
		this.hscaleScale.DrawValue = true;
		this.hscaleScale.Digits = 0;
		this.hscaleScale.ValuePos = ((global::Gtk.PositionType)(2));
		this.fixed1.Add(this.hscaleScale);
		global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.hscaleScale]));
		w6.X = 576;
		w6.Y = 288;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.labelScale = new global::Gtk.Label();
		this.labelScale.Name = "labelScale";
		this.labelScale.LabelProp = global::Mono.Unix.Catalog.GetString("Scale");
		this.fixed1.Add(this.labelScale);
		global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.labelScale]));
		w7.X = 579;
		w7.Y = 268;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.labelPointX = new global::Gtk.Label();
		this.labelPointX.Name = "labelPointX";
		this.labelPointX.LabelProp = global::Mono.Unix.Catalog.GetString("PointX");
		this.fixed1.Add(this.labelPointX);
		global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.labelPointX]));
		w8.X = 581;
		w8.Y = 33;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.labelPointY = new global::Gtk.Label();
		this.labelPointY.Name = "labelPointY";
		this.labelPointY.LabelProp = global::Mono.Unix.Catalog.GetString("PointY");
		this.fixed1.Add(this.labelPointY);
		global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.labelPointY]));
		w9.X = 580;
		w9.Y = 60;
		this.Add(this.fixed1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 838;
		this.DefaultHeight = 579;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.drawingarea1.ExposeEvent += new global::Gtk.ExposeEventHandler(this.OnDrawingarea1ExposeEvent);
		this.drawingarea1.ButtonPressEvent += new global::Gtk.ButtonPressEventHandler(this.OnDrawingarea1ButtonPressEvent);
		this.drawingarea1.ButtonReleaseEvent += new global::Gtk.ButtonReleaseEventHandler(this.OnDrawingarea1ButtonReleaseEvent);
		this.drawingarea1.ScrollEvent += new global::Gtk.ScrollEventHandler(this.OnDrawingarea1ScrollEvent);
		this.drawingarea1.MotionNotifyEvent += new global::Gtk.MotionNotifyEventHandler(this.OnDrawingarea1MotionNotifyEvent);
		this.hscaleOffsetX.ValueChanged += new global::System.EventHandler(this.OnHscaleOffsetXValueChanged);
		this.hscaleOffsetY.ValueChanged += new global::System.EventHandler(this.OnHscaleOffsetYValueChanged);
		this.hscaleScale.ValueChanged += new global::System.EventHandler(this.OnHscaleScaleValueChanged);
	}
}
