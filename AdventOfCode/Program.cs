using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace AdventOfCode
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            var l = await new Day06().Solve_1();
            timer.Stop();
            Console.WriteLine($"Time: {timer.Elapsed.ToString()}\n{l}");
        }
    }
}