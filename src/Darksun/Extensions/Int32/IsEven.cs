using System;

public static partial class DarksunInt32Extensions
{
    public static bool IsEven(this Int32 n)
    {
        n.ThrowIfNull(nameof(n));

        return n % 2 == 0;
    }
}