using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Who likes it?
            /*
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
                Console.WriteLine(WhoLikesIt(WhoLikesItTests[WhoLikesItI]));
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
            */
            #endregion

            #region String ends with?
            Console.WriteLine($"String ends with?: {StringEndsWith("abc", "bc")}");
            Console.WriteLine($"String ends with?: {StringEndsWith("abc", "d")}");

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
            #endregion

            // End of program
            Console.WriteLine("Any key to close");
            Console.ReadKey();

            
        }
    }
}
