# <img src="/src/icon.png" height="30px"> Verify.Phash

[![Discussions](https://img.shields.io/badge/Verify-Discussions-yellow?svg=true&label=)](https://github.com/orgs/VerifyTests/discussions)
[![Build status](https://img.shields.io/appveyor/build/SimonCropp/Verify-Phash)](https://ci.appveyor.com/project/SimonCropp/Verify-Phash)
[![NuGet Status](https://img.shields.io/nuget/v/Verify.Phash.svg)](https://www.nuget.org/packages/Verify.Phash/)

Extends [Verify](https://github.com/VerifyTests/Verify) to allow comparison of documents via [Phash](https://github.com/pgrho/phash).<!-- singleLineInclude: intro. path: /docs/intro.include.md -->

**See [Milestones](../../milestones?state=closed) for release notes.**

Contains [comparers](https://github.com/VerifyTests/Verify/blob/master/docs/comparer.md) for png, jpg, bmp, and tiff.


## Sponsors


### Entity Framework Extensions<!-- include: zzz. path: /docs/zzz.include.md -->

[Entity Framework Extensions](https://entityframework-extensions.net/?utm_source=simoncropp&utm_medium=Verify.Phash) is a major sponsor and is proud to contribute to the development this project.

[![Entity Framework Extensions](https://raw.githubusercontent.com/VerifyTests/Verify.Phash/refs/heads/main/docs/zzz.png)](https://entityframework-extensions.net/?utm_source=simoncropp&utm_medium=Verify.Phash)<!-- endInclude -->


## NuGet

 * https://nuget.org/packages/Verify.Phash


## Usage

Enable:

<!-- snippet: enable -->
<a id='snippet-enable'></a>
```cs
[ModuleInitializer]
public static void Init() =>
    VerifyPhash.Initialize();
```
<sup><a href='/src/Tests/ModuleInit.cs#L5-L11' title='Snippet source file'>snippet source</a> | <a href='#snippet-enable' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->


### Comparers

Register all comparers

```
VerifyPhash.RegisterComparer();
```

### Compare Settings

Phash comparison settings can be modified as follows:

<!-- snippet: Settings -->
<a id='snippet-Settings'></a>
```cs
[Test]
public Task LocalSettings() =>
    VerifyFile("sample.png")
        .PhashCompareSettings(
            threshold: .8f,
            sigma: 4f,
            gamma: 2f,
            angles: 170);
```
<sup><a href='/src/Tests/Samples.cs#L27-L38' title='Snippet source file'>snippet source</a> | <a href='#snippet-Settings' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->


## Icon

[Hash Brown](https://thenounproject.com/term/hash/1129857/) designed by [Icon Mark](https://thenounproject.com/iconmark) from [The Noun Project](https://thenounproject.com/).
