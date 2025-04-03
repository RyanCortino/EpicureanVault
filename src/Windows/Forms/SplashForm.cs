namespace EpicureanVault.WindowsUI.Forms;

public partial class SplashForm : Form, ISplashView, IProgress<string>
{
    public SplashForm()
    {
        InitializeComponent();
    }

    public void Report(string value)
    {
        throw new NotImplementedException();
    }
}
