public static class BeanShootoutURP
{
    /// <summary>
    /// Determines if XR rendering should be done.
    /// </summary>
    public static bool EnableXRRenderingSupport;
#if KILLITMYSELF_URP
    /// <summary>
    /// Determines if EarlyCmd should be rendered. (EarlyCmd is the dark gray backgrond rendered behind everything to prevent nothing from being repainted)
    /// </summary>
    public static bool EnableEarlyCmd = true;
#endif
}