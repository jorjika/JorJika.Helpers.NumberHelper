


# JorJika.Helpers.NumberHelper [![Build status](https://jorjika.visualstudio.com/JorJika/_apis/build/status/JorJika.Helpers.NumberHelper-CI)](https://jorjika.visualstudio.com/JorJika/_build/latest?definitionId=6) [![NuGet Badge](https://img.shields.io/nuget/v/JorJika.Helpers.NumberHelper.svg)](https://www.nuget.org/packages/JorJika.Helpers.NumberHelper)

Converting number to words grammatically to Georgian language

## Quick start

Installing package:
```powershell
Install-Package JorJika.Helpers.NumberHelper
```
Usage:
```csharp
 JorJika.Helpers.NumberHelper.NumberToWord(1202039);
```
Returns string, calling function above will result to: "მილიონ ორას ორი ათას ოცდაცხრამეტი"

Example of console application:
```csharp
using System;
using JorJika.Helpers;

namespace JorJika.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var numerToWord = NumberHelper.NumberToWord(1202039);
            Console.WriteLine(numerToWord);
        }
    }
}

```
