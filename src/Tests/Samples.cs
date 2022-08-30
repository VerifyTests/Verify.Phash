[TestFixture]
public class Samples
{
    [Test]
    public Task Simple() =>
        Verify(File.OpenRead("sample.png"))
            .UseExtension("png");

    #region VerifyPng

    [Test]
    public Task VerifyPng() =>
        VerifyFile("sample.png");

    #endregion

    #region VerifyPngStream

    [Test]
    public Task VerifyPdfStream() =>
        Verify(File.OpenRead("sample.png"))
            .UseExtension("png");

    #endregion

    #region Settings

    [Test]
    public Task LocalSettings() =>
        VerifyFile("sample.png")
            .PhashCompareSettings(
                threshold: .8f,
                sigma: 4f,
                gamma: 2f,
                angles: 170);

    #endregion
}