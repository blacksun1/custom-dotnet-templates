using System.Threading.Tasks;
using System;

namespace consoleasync
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await Console.Out.WriteLineAsync("Hello World with C# 8.0!");
        }
    }
}
