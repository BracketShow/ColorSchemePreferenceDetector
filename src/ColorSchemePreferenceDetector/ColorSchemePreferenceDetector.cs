using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace ColorSchemePreferenceDetector
{
    public class ColorSchemePreferenceDetector : IColorSchemePreferenceDetector
    {
        private readonly IJSRuntime jSRuntime;

        public ColorSchemePreferenceDetector(IJSRuntime jSRuntime)
        {
            this.jSRuntime = jSRuntime;
        }

        public async ValueTask<bool> PrefersDarkMode()
        {
            var module = await jSRuntime.InvokeAsync<IJSObjectReference>("import", "./_content/colorschemepreferencedetector/colorSchemePreferenceDetector.js");
            return await module.InvokeAsync<bool>("prefersDarkMode");
        }
    }
}
