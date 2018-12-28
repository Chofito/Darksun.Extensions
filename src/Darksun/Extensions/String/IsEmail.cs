using System.Text.RegularExpressions;

public static partial class DarksunStringExtensions
{
    public static bool IsEmail(this string str)
    {
        str.ThrowIfNull(nameof(str));
        
        return Regex.IsMatch(str,
            @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*@((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$");
    }
    // @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z0-9]{1,30})(\]?)$"
    // Other regex pattern, idk if this is better :P need testing
}