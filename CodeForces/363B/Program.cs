using System;

namespace _363B
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int length = int.Parse(input[0]), hole = int.Parse(input[1]), min = 1000000000, sum = 0 ;
            int index = 0;
            input = new string[length];
            input = Console.ReadLine().Split();

            for(int i = 0; i <= input.Length - hole; i++)
            {
                sum = 0;
                for(int j = i; j < i + hole; j++)
                {
                    sum += int.Parse(input[j]);
                }
                if(min != Math.Min(min, sum))
                {
                    min = Math.Min(min, sum);
                    index = i + 1;
                }
            }
            Console.WriteLine($"{index}");

        }
    }
}
