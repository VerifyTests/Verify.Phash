# <img src="/src/icon.png" height="30px"> Verify.Phash

[![Build status](https://ci.appveyor.com/api/projects/status/18lflc71pchw565r?svg=true)](https://ci.appveyor.com/project/SimonCropp/Verify-Phash)
[![NuGet Status](https://img.shields.io/nuget/v/Verify.Phash.svg)](https://www.nuget.org/packages/Verify.Phash/)

Extends [Verify](https://github.com/VerifyTests/Verify) to allow comparison of documents via [Phash](https://github.com/pgrho/phash).

Contains [comparers](https://github.com/VerifyTests/Verify/blob/master/docs/comparer.md) for png, jpg, bmp, and tiff.

<a href='https://dotnetfoundation.org' alt='Part of the .NET Foundation'><img src='https://raw.githubusercontent.com/VerifyTests/Verify/master/docs/dotNetFoundation.svg' height='30px'></a><br>
Part of the <a href='https://dotnetfoundation.org' alt=''>.NET Foundation</a>


## NuGet package

https://nuget.org/packages/Verify.Phash/


## Usage

Given a test with the following definition:

<!-- snippet: TestDefinition -->
<a id='snippet-testdefinition'></a>
```cs
[TestFixture]
public class Samples
{
    static Samples()
    {
        VerifyPhash.Initialize();
    }
```
<sup><a href='/src/Tests/Samples.cs#L5-L15' title='Snippet source file'>snippet source</a> | <a href='#snippet-testdefinition' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->


### Comparers

Register all comparers

```
VerifyPhash.RegisterComparer();
```

### Compare Settings

Phash comparison settings can be modified as follows:

<!-- snippet: Settings -->
<a id='snippet-settings'></a>
```cs
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
```
<sup><a href='/src/Tests/Samples.cs#L46-L59' title='Snippet source file'>snippet source</a> | <a href='#snippet-settings' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->



## Icon

[Hash Brown](https://thenounproject.com/term/hash/1129857/) designed by [Icon Mark](https://thenounproject.com/iconmark) from [The Noun Project](https://thenounproject.com/).
