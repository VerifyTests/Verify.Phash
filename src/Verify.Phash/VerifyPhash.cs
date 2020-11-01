using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using Shipwreck.Phash;
using Shipwreck.Phash.Bitmaps;

namespace VerifyTests
{
    public static class VerifyPhash
    {
        public static void Initialize()
        {
            RegisterComparer("png");
        }

        public static void RegisterComparer(
            string extension,
            float threshold = 0.999f,
            float sigma = 3.5f,
            float gamma = 1f,
            int angles = 180)
        {
            Guard.AgainstNullOrEmpty(extension, nameof(extension));
            VerifierSettings.RegisterComparer(
                extension,
                (received, verified, context) => Compare(context, received, verified, threshold, sigma, gamma, angles));
        }

        static Task<CompareResult> Compare(
            IReadOnlyDictionary<string, object> context,
            Stream received,
            Stream verified,
            float threshold,
            float sigma,
            float gamma,
            int angles)
        {
            if (context.GetPhashCompareSettings(out var innerSettings))
            {
                threshold = innerSettings.Threshold;
                sigma = innerSettings.Sigma;
                gamma = innerSettings.Gamma;
                angles = innerSettings.Angles;
            }

            var hash1 = HashImage(received, sigma, gamma, angles);
            var hash2 = HashImage(verified, sigma, gamma, angles);
            var score = ImagePhash.GetCrossCorrelation(hash1, hash2);
            var compare = score > threshold;
            if (compare)
            {
                return Task.FromResult(CompareResult.Equal);
            }

            return Task.FromResult(CompareResult.NotEqual($"diff > threshold. threshold: {threshold}, score: {score}"));
        }

        static Digest HashImage(Stream stream, float sigma, float gamma, int angles)
        {
            using var bitmap = (Bitmap) Image.FromStream(stream);
            var image = bitmap.ToLuminanceImage();
            return ImagePhash.ComputeDigest(image, sigma, gamma, angles);
        }
    }
}