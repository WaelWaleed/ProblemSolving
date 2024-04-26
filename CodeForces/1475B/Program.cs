using System;

namespace _1475B
{
    public class Program
    {
        static void Main(string[] args)
        {
            int TestCases = int.Parse(Console.ReadLine());

            for (int i = 0; i < TestCases; i++)
            {
                int YearNumber = int.Parse(Console.ReadLine());

                if (YearNumber >= 2020)
                {
                    if (YearNumber % 2020 == 0)
                    {
                        Console.WriteLine("YES");
                    }
                    else
                    {
                        int x = YearNumber / 2020;
                        int y = YearNumber % 2020;
                        if (y <= x)
                        {
                            Console.WriteLine("YES");
                        }
                        else
                        {
                            Console.WriteLine("NO");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
