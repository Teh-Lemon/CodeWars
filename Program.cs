using System;
using System.Collections.Generic;

namespace CodeWars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Bit Counting: {CountBits(0)}");
            Console.WriteLine($"Bit Counting: {CountBits(4)}");
            Console.WriteLine($"Bit Counting: {CountBits(7)}");
            Console.WriteLine($"Bit Counting: {CountBits(9)}");
            Console.WriteLine($"Bit Counting: {CountBits(10)}");
            Console.WriteLine($"Multiples of 3 or 5: {Solution(10)}");
            string[] likes0 = null;
            string[] likes1 = { };
            string[] likes2 = { "Peter" };
            string[] likes3 = { "Jacob", "Alex" };
            string[] likes4 = { "Max", "John", "Mark" };
            string[] likes5 = { "Alex", "Jacob", "Mark", "Max" };
            string[] likes6 = { "Lemon", "Alex", "Jacob", "Mark", "Max" };
            string[][] WhoLikesItTests = { likes0, likes1, likes2, likes3, likes4, likes5, likes6 };
            for (int WhoLikesItI = 0; WhoLikesItI < WhoLikesItTests.Length; WhoLikesItI++)
            {
                Console.WriteLine($"Who likes it?: {WhoLikesIt(WhoLikesItTests[WhoLikesItI])}");
            }
            Console.WriteLine($"Is valid walk?: {IsValidWalk(new string[] { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s" }).ToString()}");
            Console.WriteLine($"Is valid walk?: {IsValidWalk(new string[] { "w", "e", "w", "e", "w", "e", "w", "e", "w", "e", "w", "e" }).ToString()}");
            Console.WriteLine($"Is valid walk?: {IsValidWalk(new string[] { "w" }).ToString()}");
            Console.WriteLine($"Is valid walk?: {IsValidWalk(new string[] { "n", "n", "n", "s", "n", "s", "n", "s", "n", "s" }).ToString()}");

            Console.WriteLine($"String ends with?: {StringEndsWith("abc", "bc")}");
            Console.WriteLine($"String ends with?: {StringEndsWith("abc", "d")}");
            Console.WriteLine($"Is this a triangle?: {IsTriangle(5, 7, 10).ToString()}");

            #region Problems

            // Bit Counting
            int CountBits(int n)
            {
                int total = 0;
                do
                {
                    total += n % 2;
                    n >>= 1; // n /= 2
                } while (n != 0);    
                return total;
            }

            // Multiples of 3 or 5
            int Solution(int value)
            {
                int total = 0;
                for (int i = 0; i < value; i++)
                {
                    if (i % 3 == 0 || i % 5 == 0)
                    {
                        total += i;
                    }
                }
                return total;
            }

            // Is this a triangle?
            bool IsTriangle(int a, int b, int c)
            {
                if ((a + b > c) && (a + c > b) && (b + c > a))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            string WhoLikesIt(string[] name)
            {
                if (name == null || name.Length == 0)
                {
                    return "no one likes this";
                }
                else if (name.Length == 1)
                {
                    return $"{name[0]} likes this";
                }
                else if (name.Length == 2)
                {
                    return $"{name[0]} and {name[1]} like this";
                }
                else if (name.Length == 3)
                {
                    return $"{name[0]}, {name[1]} and {name[2]} like this";
                }
                else if (name.Length > 3)
                {
                    return $"{name[0]}, {name[1]} and {(name.Length - 2).ToString()} others like this";
                }

                return "no one likes this";
            }

            bool StringEndsWith(string str, string ending)
            {
                if (ending.Length > str.Length)
                {
                    return false;
                }

                str = str.Substring(str.Length - ending.Length);
                if (str == ending)
                { return true; }
                else
                { return false; }                
            }
            
            bool IsValidWalk(string[] walk)
            {
                // Longer than 10 minutes
                if (walk.Length != 10)
                {
                    return false;
                }

                // Do we return to the starting point
                int vertical = 0;
                int horizontal = 0;
                for (int i = 0; i < walk.Length; i++)
                {
                    switch(walk[i])
                    {
                        case "n":
                            vertical++;
                            break;
                        case "s":
                            vertical--;
                            break;
                        case "e":
                            horizontal++;
                            break;
                        case "w":
                            horizontal--;
                            break;
                    }
                }

                if (vertical == 0 && horizontal == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            #endregion

            // End of program
            Console.WriteLine("Any key to close");
            Console.ReadKey();            
        }
    }
}
