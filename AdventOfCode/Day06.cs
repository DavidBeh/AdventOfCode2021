using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using AoCHelper;

namespace AdventOfCode
{
    public class Day06 : BaseDay
    {
        public override ValueTask<string> Solve_1()
        {
            var input = File.ReadAllLines(this.InputFilePath)[0];
            var list = input.Split(',').Select<string, int>(s => int.Parse(s)).ToList();
            var dict = new Dictionary<int, ulong>();
            
            for (int i = 0; i <= 8; i++)
            {
                dict.Add(i, 0);
            }
            
            list.ForEach(i => dict[i]++);
            
            for (int d = 0; d < 256; d++)
            {
                ulong newFish = dict[0];
                for (int i = 0; i < 8; i++)
                {
                    dict[i] = dict[i + 1];
                }

                dict[6] += newFish;

                dict[8] = newFish;
            }

            for (var i = 0; i < dict.Count; i++)
            {
                Console.WriteLine($"{i}: {dict[i]}");
            }

            return new ValueTask<string>(dict.Values.Aggregate((arg1, arg2) => arg1 + arg2).ToString());
        }

        public override ValueTask<string> Solve_2()
        {
            throw new System.NotImplementedException();
        }
    }
}