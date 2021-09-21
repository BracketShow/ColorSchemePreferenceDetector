export function prefersDarkMode() {
    if (window.matchMedia) {
        var match = window.matchMedia('(prefers-color-scheme: dark)')
        return match.matches;
    }
    return false;
}
