using System.IO;
using System.Threading.Tasks;
using Verify;
using VerifyXunit;
using Xunit;
using Xunit.Abstractions;

#region TestDefinition
public class Samples :
    VerifyBase
{
    public Samples(ITestOutputHelper output) :
        base(output)
    {
    }

    static Samples()
    {
        VerifyPhash.Initialize();
    }
    #endregion

    [Fact]
    public async Task Simple()
    {
        var settings = new VerifySettings();
        settings.UseExtension("png");
        await Verify(File.OpenRead("sample.png"), settings);
        await Verify(File.OpenRead("sample2.png"), settings);
    }

    #region VerifyPng

    [Fact]
    public Task VerifyPng()
    {
        return VerifyFile("sample.png");
    }

    #endregion

    #region VerifyPngStream

    [Fact]
    public Task VerifyPdfStream()
    {
        var settings = new VerifySettings();
        settings.UseExtension("png");
        return Verify(File.OpenRead("sample.png"), settings);
    }

    #endregion
}