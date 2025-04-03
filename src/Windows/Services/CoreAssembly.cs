using System.Reflection;

namespace EpicureanVault.WindowsUI.Services;

internal static class CoreAssembly
{
    public static readonly Assembly Reference = typeof(CoreAssembly).Assembly;
    public static readonly Version Version = Reference.GetName().Version!;
}
