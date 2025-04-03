using EpicureanVault.WindowsUI.Services;
using Microsoft.Extensions.Options;

namespace EpicureanVault.WindowsUI.Presenters;

internal class SplashPresenter(
    ILogger<SplashPresenter> logger,
    IOptions<ApplicationOptions> appOptions
) : ISplashPresenter
{
    private readonly ILogger _logger = logger;

    private readonly ApplicationOptions _appOptions = appOptions.Value;

    private ISplashView? _view;

    public void InitializePresenter(ISplashView view)
    {
        if (view == null)
            return;

        _view = view;
        _view.ViewLoaded += OnViewLoaded;
    }

    public void Report(string value)
    {
        _logger.LogInformation("{message}", value);

        _view?.SetStatus(value);
    }

    private void OnViewLoaded(object? sender, EventArgs e)
    {
        // Handle the ViewLoaded event
        // Perform any initialization or data loading here

        LoadData();
    }

    private void LoadData()
    {
        Report("Loading resources...");

        _view?.SetVersion(CoreAssembly.Version.ToString());

        _view?.SetProgress(10);

        _view?.AddTask(
            Task.Run(() => Task.Delay((int)(_appOptions.DefaultSplashScreenDelay * 1000)))
        );

        _view?.ExecuteLoadingTasks();
    }
}
