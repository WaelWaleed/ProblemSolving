using System;

namespace _1374B
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCases = int.Parse(Console.ReadLine());
            bool flag = false;
            for (int i = 0; i < testCases; i++)
            {
                int count = 0;
                string number = Console.ReadLine();
                flag = false;
                //char[] numbers = new char[number.Length];
                //numbers = number.ToCharArray();
                int num = int.Parse(number);
                for (int j = 0; num != 1; j++)
                {
                    if (num % 3 == 0)
                    {
                        if (num % 6 == 0)
                        {
                            num /= 6;
                            count++;
                        }
                        else
                        {
                            num *= 2;
                            count++;
                        }
                    }
                    else
                    {
                        //if (num == 1) { Console.WriteLine($"{0}"); }
                        Console.WriteLine($"{-1}");
                        flag = true;
                        break;
                    }
                }
                if(flag == false)
                {
                    Console.WriteLine($"{count}");
                }
            }
        }
    }
}
