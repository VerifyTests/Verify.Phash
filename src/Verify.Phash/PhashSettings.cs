using System.Diagnostics.CodeAnalysis;

namespace VerifyTests;

public static class PhashSettings
{
    public static void PhashCompareSettings(
        this VerifySettings settings,
        float threshold = 0.999f,
        float sigma = 3.5f,
        float gamma = 1f,
        int angles = 180) =>
        PhashCompareSettings(threshold, sigma, gamma, angles, settings.Context);

    public static SettingsTask PhashCompareSettings(
        this SettingsTask settings,
        float threshold = 0.999f,
        float sigma = 3.5f,
        float gamma = 1f,
        int angles = 180)
    {
        PhashCompareSettings(threshold, sigma, gamma, angles, settings.CurrentSettings.Context);
        return settings;
    }

    static void PhashCompareSettings(
        float threshold,
        float sigma,
        float gamma,
        int angles,
        Dictionary<string, object> context) =>
        context["Phash"] = new PhashCompareSettings(
            threshold,
            sigma,
            gamma,
            angles);

    internal static bool GetPhashCompareSettings(
        this IReadOnlyDictionary<string, object> context,
        [NotNullWhen(true)] out PhashCompareSettings? pagesSettings)
    {
        if (context.TryGetValue("Phash", out var value))
        {
            pagesSettings = (PhashCompareSettings) value;
            return true;
        }

        pagesSettings = null;
        return false;
    }
}