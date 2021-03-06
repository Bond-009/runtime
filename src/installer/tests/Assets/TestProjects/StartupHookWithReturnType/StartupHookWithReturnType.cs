// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

internal class StartupHook
{
    public static int Initialize()
    {
        // This hook should not be called because it doesn't have a
        // void return type. Instead, the startup hook provider code
        // should throw an exception.
        Console.WriteLine("Hello from startup hook returning int!");
        return 10;
    }
}
