using System;
using System.Linq;
using Microsoft.Scripting.Hosting;
using IronPython.Hosting;


namespace DynamicIronPythonSample
{
    class Program
    {
        static void Main(string[] args) //실패
        {
            // Set the current directory to the IronPython libraries.
            System.IO.Directory.SetCurrentDirectory(
               Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) +
               @"\IronPython 2.7\Lib");// 실패

            // Create an instance of the random.py IronPython library.
            Console.WriteLine("Loading random.py");
            ScriptRuntime py = Python.CreateRuntime();
            dynamic random = py.UseFile("random.py");
            Console.WriteLine("random.py loaded.");

            // Initialize an enumerable set of integers.
            int[] items = Enumerable.Range(1, 7).ToArray();

            // Randomly shuffle the array of integers by using IronPython.
            for (int i = 0; i < 5; i++)
            {
                random.shuffle(items);
                foreach (int item in items)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("-------------------");
            }
            Console.ReadLine();
        }
    }
}
