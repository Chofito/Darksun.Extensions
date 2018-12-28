using System;

public static partial class DarksunBooleanExtensions
{
    public static void IfTrue(this bool value, Action action)
    {
        if (value)
            action();
    }
}