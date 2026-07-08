using HarmonyLib;
using Keen.VRage.Core.Plugins;
using Keen.VRage.Library.Diagnostics;
using System.Reflection;

[assembly:AssemblyVersion("1.0.1")]
[assembly:AssemblyFileVersion("1.0.1")]
[assembly:AssemblyCopyright("© 2026 WesternSpace")]

namespace ClientPlugin;

public class Plugin : IPlugin
{
    public const string Name = "SE2-NoForcedCameraZoom";
    
    public Plugin()
    {
        Log.Default.WriteLine($"[{Name}] Loaded plugin.");
#if DEBUG
        Harmony.DEBUG = true;
#endif
        Harmony harmony = new(Name);
        harmony.PatchAll(Assembly.GetExecutingAssembly());
        Log.Default.WriteLine($"[{Name}] Applied patches");
    }
}