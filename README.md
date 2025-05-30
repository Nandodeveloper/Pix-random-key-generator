# 📌 PIX Key Generator - bytebank_PixRandomKeyGenerator

[![NuGet](https://img.shields.io/nuget/v/bytebank_GeradorChavePix.svg?style=flat-square)](https://www.nuget.org/packages/bytebank_PixRandomKeyGenerator/)

**A simple and efficient package for generating random PIX keys in GUID format, designed for .NET projects.**

## 🎯 Features

- *Generates unique random PIX keys*
- *Option to generate a single key or multiple keys at once*
- *Lightweight and easy to implement*
- *Compatible with .NET Standard 2.0+ projects*

## 📦 Installation

**Install via NuGet Package Manager:**

```bash
Install-Package bytebank_PixRandomKeyGenerator
```
**Or via .NET CLI:**
```bash
dotnet add package bytebank_PixRandomKeyGenerator
```
## 🚀 How to Use
```csharp
using bytebank_GeradorChavePix;

// Generate a single PIX key
string singleKey = GeradorPix.GetChavePix();
Console.WriteLine($"Single PIX key: {singleKey}");

// Generate multiple PIX keys
List<string> keys = GeradorPix.GetChavesPix(5);
foreach (var key in keys)
{
    Console.WriteLine($"PIX key: {key}");
}
```
## 📄 Available Methods
`GetChavePix()`
Generates a single PIX key in GUID format.

**Returns:** `string` - Generated PIX key

`GetChavesPix(int numeroChaves)`
Generates a list of PIX keys.

**Parameters:**

- `numeroChaves` - Number of keys to generate (must be greater than 0)

**Returns:** `List<string>` - List of PIX keys or `null` if parameter is invalid

---

**🌐 Developed by NandoDeveloper**  

[![GitHub](https://img.shields.io/badge/GitHub-100000?style=flat&logo=github&logoColor=white)](https://github.com/NandoDeveloper)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-0077B5?style=flat&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/fernandoodeveloper/)
