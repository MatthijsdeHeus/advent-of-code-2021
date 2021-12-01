using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace advent_of_code
{
    static class Day2
    {
        static string pathToInput = "..\\..\\..\\Input\\day2.txt";
        static List<int> input = File.ReadAllLines(pathToInput).ToList().Select(int.Parse).ToList();

        public static void Run()
        {
            int part1Answer = Part1();
            int part2Answer = Part2();

            Console.WriteLine("Day 2, Part 1 = " + part1Answer);
            Console.WriteLine("Day 2, Part 2 = " + part2Answer);
        }

        static int Part1()
        {
            return 0;
        }

        static int Part2()
        {
            return 0;
        }
    }
}
