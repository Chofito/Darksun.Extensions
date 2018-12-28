using System;

public static partial class DarksunInt64Extensions
{
    public static bool IsEven(this Int64 n)
    {
        n.ThrowIfNull(nameof(n));

        return n % 2 == 0;
    }
}