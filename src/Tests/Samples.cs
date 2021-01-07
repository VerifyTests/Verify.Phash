using System.IO;
using System.Threading.Tasks;
using VerifyTests;
using VerifyNUnit;
using NUnit.Framework;

#region TestDefinition

[TestFixture]
public class Samples
{
    static Samples()
    {
        VerifyPhash.Initialize();
    }

    #endregion

    [Test]
    public async Task Simple()
    {
        var settings = new VerifySettings();
        settings.UseExtension("png");
        await Verifier.Verify(File.OpenRead("sample.png"), settings);
        await Verifier.Verify(File.OpenRead("sample2.png"), settings);
    }

    #region VerifyPng

    [Test]
    public Task VerifyPng()
    {
        return Verifier.VerifyFile("sample.png");
    }

    #endregion

    #region VerifyPngStream

    [Test]
    public Task VerifyPdfStream()
    {
        return Verifier.Verify(File.OpenRead("sample.png"))
            .UseExtension("png");
    }

    #endregion

    #region Settings

    [Test]
    public Task LocalSettings()
    {
        return Verifier.VerifyFile("sample.png")
            .PhashCompareSettings(
                threshold: .8f,
                sigma: 4f,
                gamma: 2f,
                angles: 170);
    }

    #endregion
}