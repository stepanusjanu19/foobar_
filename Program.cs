using System;
using System.Collections.Generic;
using FooBar.Generator;

class Program
{
    static void Main()
    {
        var numberWordGenerator = new NumberWordGenerator();
        numberWordGenerator.AddRule(3, "foo");
        numberWordGenerator.AddRule(4, "baz");
        numberWordGenerator.AddRule(5, "bar");
        numberWordGenerator.AddRule(7, "jazz");
        numberWordGenerator.AddRule(9, "huzz");
        numberWordGenerator.Generator(50);
    }
}

