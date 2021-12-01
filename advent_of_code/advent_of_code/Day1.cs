using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace advent_of_code
{
    static class Day1
    {
        static List<int> input = File.ReadAllLines(@"C:\Users\Matthijs\Documents\advent-of-code\advent-of-code-2021\advent_of_code\advent_of_code\Input\day1.txt").ToList().Select(int.Parse).ToList();

        public static void Run()
        {
            int answer = Part2();

            Console.WriteLine(answer);
        }

        static int Part1()
        {
            var counter = 0;

            for (int i = 0; i < input.Count - 1; i++)
            {

                if (input[i] < input[i + 1])
                {
                    counter += 1;
                }
            }

            return counter;
        }

        static int Part2()
        {
            var counter = 0;

            for (int i = 0; i < input.Count - 3; i++)
            {
                if (input[i] + input[i + 1] + input[i + 2] < input[i + 1] + input[i + 2] + input[i + 3])
                {
                    counter += 1;
                }
            }

            return counter;
        }
    }
}
