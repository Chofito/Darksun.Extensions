using System;

public static partial class DarksunObjectGenericExtensions
{
    public static void ThrowIfNull<TObject>(this TObject obj, string name, string msg = null)
    {
        if (obj != null)
            return;

        if (msg != null)
            throw new ArgumentNullException(nameof(name), name + "can not be null.");

        throw new ArgumentNullException(name, msg);
    }
}
