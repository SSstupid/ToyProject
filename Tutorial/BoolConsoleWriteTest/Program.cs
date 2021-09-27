using System;

namespace BoolConsoleWriteTest
{
    class Program
    {
        public static bool TestCon(int x)
        {
            return x > 10;
        }


    static void Main(string[] args)
        {
            var x = new int[] { 1, 11, 6, 9, 16, 3, 18 };

            foreach(var w in x)
            { 
               Console.WriteLine("true or not : {0}", TestCon(w) ? "ture" : "False");
            }
        }
    }
}
