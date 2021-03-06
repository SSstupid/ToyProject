using System;

namespace DynamicSample
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic rFile = new ReadOnlyFile(@"C:\Users\rlawo\source\repos\DynamicSample\TextFile1.txt");
            foreach (string line in rFile.Customer)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("----------------------------");
            foreach (string line in rFile.Customer(StringSearchOption.Contains, true))
            {
                Console.WriteLine(line);
            }
            Console.ReadLine();
        }
    }
}
