using System;
using System.Collections.Generic;

namespace FooBar.Generator
{
    public class NumberWordGenerator
    {
        private readonly Dictionary<int, string> rules = new();

        public void AddRule(int number, string output)
        {
            if (!rules.ContainsKey(number))
            {
                rules.Add(number, output);
            }
        }

        public void Generator(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                string result = string.Empty;
                foreach (var rule in rules)
                {
                    if (i % rule.Key == 0)
                    {
                        result += rule.Value;
                    }
                }
                Console.Write(string.IsNullOrEmpty(result) ? i.ToString() : result);
                if (i != n) Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
}