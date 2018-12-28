using System;

public static partial class DarksunBooleanExtensions
{
    public static void IfFalse(this bool value, Action action)
    {
        if (!value)
            action();
    }
}