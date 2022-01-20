﻿#region TestDefinition

[TestFixture]
public class Samples
{
    static Samples()
    {
        VerifyPhash.Initialize();
    }

    #endregion

    [Test]
    public Task Simple()
    {
        var settings = new VerifySettings();
        settings.UseExtension("png");
        return Verify(File.OpenRead("sample.png"), settings);
    }

    #region VerifyPng

    [Test]
    public Task VerifyPng()
    {
        return VerifyFile("sample.png");
    }

    #endregion

    #region VerifyPngStream

    [Test]
    public Task VerifyPdfStream()
    {
        return Verify(File.OpenRead("sample.png"))
            .UseExtension("png");
    }

    #endregion

    #region Settings

    [Test]
    public Task LocalSettings()
    {
        return VerifyFile("sample.png")
            .PhashCompareSettings(
                threshold: .8f,
                sigma: 4f,
                gamma: 2f,
                angles: 170);
    }

    #endregion
}