﻿using Microsoft.JSInterop;

namespace DemoBlazorInterop.Interop;

public class HelloHelper
{
    public HelloHelper(string name)
    {
        Name = name;
    }

    public string Name { get; }

    [JSInvokable]   
    public string SayHello()
    {
        return $"------------ Ciao, {Name}!";
    }
}
