using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Threading.Tasks;
using AoCHelper;

namespace AdventOfCode
{
    public class Day01 : BaseDay
    {
        public override ValueTask<string> Solve_1()
        {
            var inp = File.ReadAllLines(InputFilePath);

            var ints = Array.ConvertAll(inp, input => int.Parse(input));

            int old = ints.First();
            int count = 0;
            for (var i = 1; i < ints.Length; i++)
            {
                if (ints[i] > old) count++;
                old = ints[i];
            }

            return new ValueTask<string>(count.ToString());

        }
        
        

        public override ValueTask<string> Solve_2()
        {
            var inp = File.ReadAllLines(InputFilePath);
            
            var ints = Array.ConvertAll(inp, input => int.Parse(input));
            int counter = 0;
            for (var i = 1; i < ints.Length - 2; i++)
            {
                if (ints.Skip(i).Take(3).Sum() > ints.Skip(i - 1).Take(3).Sum())
                {
                    counter++;
                }
            }

            return new ValueTask<string>(counter.ToString());
        }

        private class Three
        {
            public int a, b, c;

            public Three(int a, int b, int c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }

            public int Sum() => a + b + c;
        }
        

    }
    
}