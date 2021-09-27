using System;

namespace TestTaxi
{
    public class Taxi
    {
        public bool IsInitialized;

        public Taxi()
        {
            IsInitialized = true;
        }
    }

    class TestTaxi
    {
        static void Main()
        {
            Taxi t = new Taxi();
            Console.WriteLine(t.IsInitialized);


            int i = new int(); // 자동 0으로 초기화
            Console.WriteLine(i);

            //int i;           //초기화안함
            //Console.WriteLine(i);
        }
    }

    /*class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }*/
}
