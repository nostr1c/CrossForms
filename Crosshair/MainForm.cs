namespace Crosshair;

public partial class MainForm : Form
{
    private Crosshair crosshair;
    private CrosshairSettings settings;

    public MainForm()
    {
        InitializeComponent();
        InitializeDefaultSettings();
        InitializeControls();
    }

    private void InitializeDefaultSettings()
    {
        settings = new CrosshairSettings
        {
            Style = CrosshairStyle.Traditional,
            Dot = false,
            Size = 15,
            Thickness = 2,
            Color = Color.Red
        };

        crosshair = new Crosshair(settings);
        crosshair.Show();
    }

    private void InitializeControls()
    {
        cbStyle.Items.AddRange(Enum.GetNames(typeof(CrosshairStyle)));
        cbStyle.SelectedIndex = 0;
        pbColor.BackColor = Color.Red;
    }

    private void cbStyle_SelectedIndexChanged(object sender, EventArgs e)
    {
        settings.Style = (CrosshairStyle)Enum.Parse(typeof(CrosshairStyle), cbStyle.SelectedItem.ToString());
        crosshair.UpdateCrosshair(settings);
    }

    private void tbSize_Scroll(object sender, EventArgs e)
    {
        settings.Size = tbSize.Value;
        crosshair.UpdateCrosshair(settings);
    }

    private void tbThickness_Scroll(object sender, EventArgs e)
    {
        settings.Thickness = tbThickness.Value;
        crosshair.UpdateCrosshair(settings);
    }

    private void btnColor_Click(object sender, EventArgs e)
    {
        var result = cdColor.ShowDialog();
        if (result == DialogResult.OK)
        {
            settings.Color = cdColor.Color;
            crosshair.UpdateCrosshair(settings);
            pbColor.BackColor = cdColor.Color;
        }
    }
}
