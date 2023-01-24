using System;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                char charr = char.Parse(Console.ReadLine());

                sum = sum + charr;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
