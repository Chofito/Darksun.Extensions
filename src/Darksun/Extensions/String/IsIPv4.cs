using System.Text.RegularExpressions;

public static partial class DarksunStringExtensions
{
    public static bool IsIPv4(this string str)
    {
        str.ThrowIfNull(nameof(str));

        return Regex.IsMatch(str, 
            @"^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");
    }
}