using System.Diagnostics.CodeAnalysis;

namespace VerifyTests
{
    public static class PhashSettings
    {
        public static void PhashCompareSettings(
            this VerifySettings settings,
            float threshold = 0.999f,
            float sigma = 3.5f,
            float gamma = 1f,
            int angles = 180)
        {
            Guard.AgainstNull(settings, nameof(settings));
            settings.Context["Phash"] = new PhashCompareSettings(
                threshold,
                sigma,
                gamma,
                angles);
        }

        internal static bool GetPhashCompareSettings(
            this VerifySettings settings,
            [NotNullWhen(true)] out PhashCompareSettings? pagesSettings)
        {
            Guard.AgainstNull(settings, nameof(settings));
            if (settings.Context.TryGetValue("Phash", out var value))
            {
                pagesSettings = (PhashCompareSettings) value;
                return true;
            }

            pagesSettings = null;
            return false;
        }
    }
}