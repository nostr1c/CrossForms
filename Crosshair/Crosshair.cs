namespace Crosshair;

public partial class Crosshair : Form
{
    private CrosshairSettings _settings;
    private int _centerX;
    private int _centerY;

    public Crosshair(CrosshairSettings settings)
    {
        InitializeComponent();
        InitializeForm();
        _settings = settings;
        _centerX = Width / 2;
        _centerY = Height / 2;
    }

    private void InitializeForm()
    {
        this.FormBorderStyle = FormBorderStyle.None;
        this.TopMost = true;
        this.StartPosition = FormStartPosition.Manual;
        this.BackColor = Color.Magenta;
        this.TransparencyKey = Color.Magenta;
        this.Bounds = Screen.PrimaryScreen.Bounds;
        this.ShowInTaskbar = false;
        this.MouseDown += (s, e) => this.TopMost = true;
        this.Paint += CrosshairForm_Paint;
    }

    private void CrosshairForm_Paint(object sender, PaintEventArgs e)
    {
        var graphics = e.Graphics;

        using (Pen pen = new Pen(_settings.Color, _settings.Thickness))
        {
            switch (_settings.Style)
            {
                case CrosshairStyle.Traditional:
                    DrawTraditionalCrosshair(graphics, pen);
                    break;

                case CrosshairStyle.Dot:
                    DrawDotCrosshair(graphics, pen);
                    break;

                case CrosshairStyle.Circle:
                    DrawCirlceCrosshair(graphics, pen);
                    break;
            }
        }
    }

    private void DrawTraditionalCrosshair(Graphics graphics, Pen pen)
    {
        graphics.DrawLine(pen, _centerX - _settings.Size, _centerY, _centerX + _settings.Size, _centerY);
        graphics.DrawLine(pen, _centerX, _centerY - _settings.Size, _centerX, _centerY + _settings.Size);
    }

    private void DrawDotCrosshair(Graphics graphics, Pen pen)
    {
        graphics.FillEllipse(new SolidBrush(_settings.Color), _centerX - _settings.Size / 2, _centerY - _settings.Size / 2, _settings.Size, _settings.Size);
    }

    private void DrawCirlceCrosshair(Graphics graphics, Pen pen)
    {
        if (_settings.Dot)
            graphics.FillEllipse(new SolidBrush(_settings.Color), _centerX - 4 / 2, _centerY - 4 / 2, 4, 4);

        graphics.DrawEllipse(pen, _centerX - _settings.Size / 2, _centerY - _settings.Size / 2, _settings.Size, _settings.Size);
    }

    public void UpdateCrosshair(CrosshairSettings settings)
    {
        _settings = settings;
        this.Invalidate();
    }
}
