using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(init(age));
        }

        static bool init (int age)
        {
            if (age < 18)
                return false;
            else
                return true;
        }
    }
}
