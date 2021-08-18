using System;

namespace FindMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Find Max Program");
            MaximumNumberCheck maximumNumberCheck = new MaximumNumberCheck();
            int outputInteger = maximumNumberCheck.MaximumIngerNumber(11, 22, 33);

            //Display Output
            Console.WriteLine("Maximum Number of Integer : " + outputInteger);
        }
    }
}
