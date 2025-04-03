using Microsoft.Extensions.Options;

namespace EpicureanVault.WindowsUI.Forms;

public partial class SplashForm : Form, ISplashView
{
    private readonly ILogger _logger;
    private readonly ISplashPresenter _presenter;
    private readonly ApplicationOptions _appOptions;

    public event EventHandler? ViewLoaded;

    private readonly ICollection<Task> _loadingTasks = [];

    public SplashForm(
        ISplashPresenter splashPresenter,
        ILogger<SplashForm> logger,
        IOptions<ApplicationOptions> appOptions
    )
    {
        _logger = logger;
        _logger.LogInformation("Initializing Splash Form Components.");

        _presenter = splashPresenter;
        _presenter.InitializePresenter(this);

        _appOptions = appOptions.Value;

        InitializeComponent();

        this.Load += SplashForm_Load;
    }

    private void SplashForm_Load(object? sender, EventArgs e)
    {
        _logger.LogInformation("Loading Splash Form.");

        ViewLoaded?.Invoke(this, EventArgs.Empty);
    }

    public void SetVersion(string text)
    {
        //this.VersionLabel.Text = _presenter.GetCurrentVersion();
    }

    public void SetProgress(int step)
    {
        //this.ProgressBar.ProgressBar.Step = step;
    }

    public void SetStatus(string label)
    {
        //this.StatusLabel.Text = value;
    }

    public void AddTask(Task task)
    {
        _loadingTasks.Add(task);
    }

    public async Task ExecuteLoadingTasks()
    {
        await Task.Run(() => Task.WaitAll(_loadingTasks));

        Close();
    }
}
