using System.Threading.Tasks;

namespace ColorSchemePreferenceDetector
{
    public interface IColorSchemePreferenceDetector
    {
        ValueTask<bool> PrefersDarkMode();
    }
}
