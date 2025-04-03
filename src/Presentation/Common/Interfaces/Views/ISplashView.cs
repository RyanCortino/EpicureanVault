namespace EpicureanVault.Presentation.Common.Interfaces.Views;

public interface ISplashView : IBaseView
{
    void AddTask(Task task);
    Task ExecuteLoadingTasks();
    void SetProgress(int step);
    void SetStatus(string label);
    void SetVersion(string text);
}
