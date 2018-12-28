﻿using System;

public static partial class DarksunInt32Extensions
{
    public static bool IsOdd(this Int32 n)
    {
        n.ThrowIfNull(nameof(n));

        return n % 2 == 1;
    }
}