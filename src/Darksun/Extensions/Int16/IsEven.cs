﻿using System;

public static partial class DarksunInt32Extensions
{
    public static bool IsEven(this Int16 n)
    {
        n.ThrowIfNull(nameof(n));

        return n % 2 == 0;
    }
}