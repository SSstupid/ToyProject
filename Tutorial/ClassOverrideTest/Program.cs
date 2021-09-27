using System;

namespace ClassOverrideTest
{
    class Program
    {
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            
            public override string ToString()
            {
                Console.WriteLine();
                return "Person: " + Name + " " + Age;
            }
        }


        static void Main(string[] args)
        {
            Person person = new Person { Name = "John", Age = 12 };
            Console.WriteLine(person);
            Console.Read();
            //Console.WriteLine(person);
        }
    }
}
