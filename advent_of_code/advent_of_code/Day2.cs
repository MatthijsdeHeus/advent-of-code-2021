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
        static List<string> input = File.ReadAllLines(pathToInput).ToList();

        public static void Run()
        {
            int part1Answer = Part1();
            int part2Answer = Part2();

            Console.WriteLine("Day 2, Part 1 = " + part1Answer);
            Console.WriteLine("Day 2, Part 2 = " + part2Answer);
        }

        static int Part1()
        {
            var depth = 0;
            var horizontal = 0;

            for (int i = 0; i < input.Count; i++)
            {
                var lineSplitted = input[i].Split(' ', 2);
                
                var command = lineSplitted[0];

                var amount = Int32.Parse(lineSplitted[1]);

                switch (command)
                {
                    case "forward":
                        horizontal += amount;
                        break;

                    case "down":
                        depth += amount;
                        break;

                    case "up":
                        depth -= amount;
                        break;
                }
            }

            return (horizontal * depth);
        }

        static int Part2()
        {
            var depth = 0;
            var horizontal = 0;
            var aim = 0;

            for (int i = 0; i < input.Count; i++)
            {
                var lineSplitted = input[i].Split(' ', 2);

                var command = lineSplitted[0];

                var amount = Int32.Parse(lineSplitted[1]);

                switch (command)
                {
                    case "forward":
                        horizontal += amount;
                        depth += aim * amount;
                        break;

                    case "down":
                        aim += amount;
                        break;

                    case "up":
                        aim -= amount;
                        break;
                }
            }

            return (horizontal * depth);
        }
    }
}
