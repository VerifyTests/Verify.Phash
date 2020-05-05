# <img src="/src/icon.png" height="30px"> Verify.Phash

[![Build status](https://ci.appveyor.com/api/projects/status/18lflc71pchw565r?svg=true)](https://ci.appveyor.com/project/VerifyTests/Verify-Phash)
[![NuGet Status](https://img.shields.io/nuget/v/Verify.Phash.svg)](https://www.nuget.org/packages/Verify.Phash/)

Extends [Verify](https://github.com/VerifyTests/Verify) to allow comparison of documents via [Phash](https://github.com/pgrho/phash).

Contains [comparers](https://github.com/VerifyTests/Verify/blob/master/docs/comparer.md) for png, jpg, bmp, and tiff.

Support is available via a [Tidelift Subscription](https://tidelift.com/subscription/pkg/nuget-verify.phash?utm_source=nuget-verify.phash&utm_medium=referral&utm_campaign=enterprise).

toc


## NuGet package

https://nuget.org/packages/Verify.Phash/


## Usage

Given a test with the following definition:

snippet: TestDefinition


### Comparers

Register all comparers

```
VerifyPhash.RegisterComparers();
```


## Security contact information

To report a security vulnerability, use the [Tidelift security contact](https://tidelift.com/security). Tidelift will coordinate the fix and disclosure.


## Icon

[Hash Brown](https://thenounproject.com/term/hash/1129857/) designed by [Icon Mark](https://thenounproject.com/iconmark) from [The Noun Project](https://thenounproject.com/).