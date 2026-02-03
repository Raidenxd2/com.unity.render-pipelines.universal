using UnityEditor;

[InitializeOnLoad]
public static class BeanShootoutURP
{
    static BeanShootoutURP()
    {
        EditorApplication.playModeStateChanged += OnPlayModeStateChanged;
    }

    private static void OnPlayModeStateChanged(PlayModeStateChange obj)
    {
        if (obj == PlayModeStateChange.ExitingPlayMode)
        {
            EnableEarlyCmd = false;
        }
    }

    /// <summary>
    /// Determines if XR rendering should be done.
    /// </summary>
    public static bool EnableXRRenderingSupport;
#if KILLITMYSELF_URP
    /// <summary>
    /// Determines if EarlyCmd should be rendered. (EarlyCmd is the dark gray backgrond rendered behind everything to prevent nothing from being repainted)
    /// </summary>
    public static bool EnableEarlyCmd;
#endif
}