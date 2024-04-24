/*************Not UNDERSTANDABLE***************/

using System;

namespace _579A
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            int count = 1, result = 0;
            for(int i = 0; result <= input; i++)
            {
                if(result != input)
                {
                    count++;
                    result ++;
                    result = result * 2;
                }
            }
            Console.Write($"{count}");
        }
    }
}
