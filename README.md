![Build & Test Main](https://github.com/BracketShow/ColorSchemePreferenceDetector/workflows/Build%20&%20Test%20Main/badge.svg)

![Nuget](https://img.shields.io/nuget/v/bracketshow.colorschemepreferencedetector.svg)

# ColorSchemePreferenceDetector
Small library that wraps up a JS call to detect the color scheme preference.

This is inspired by the blog post from Scott Hanselman that can be found here, all credits go to him for the idea: https://www.hanselman.com/blog/how-to-detect-if-the-users-os-prefers-dark-mode-and-change-your-site-with-css-and-js


## Installation

You can install the package with the Nuget Package Manager by searching for *BracketShow.ColorSchemePreferenceDetector*.

You can also install it with Powershell by running the following command:

```powershell
Install-Package BracketShow.ColorSchemePreferenceDetector
```

Or by using the dotnet CLI with the following command:

```bash
dotnet add package BracketShow.ColorSchemePreferenceDetector
```

## Setup

The detector needs to be registered in your application's startup. For example, in your *Program.cs* file in a Blazor WebAssembly project:

```csharp
public static async Task Main(string[] args)
{
    var builder = WebAssemblyHostBuilder.CreateDefault(args);
    builder.RootComponents.Add<App>("#app");

    builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

    builder.Services.AddColorSchemePreferenceDetector();

    await builder.Build().RunAsync();
}
```

Then add a reference to the JavaScript file at the bottom of your *index.html* file as the last item of the *body* tag:

```html
<script src="_content/colorschemepreferencedetector/colorschemepreferencedetector.js"></script>
```


## Usage

To use the detector, simply inject the *IColorSchemePreferenceDetector* in your code and use the method *PrefersDarkMode* that will return `true` when the user prefers the Dark mode and `false` when the user prefers the Light mode or when a browser not supporting `matchMedia` is used.
