namespace _1409A
{
    public class Program
    {
        public static int LessThanB(int a, int b)
        {
            int k = 0;
            int Counter = 0;

            while(a < b)
            {
                int xxx = (b - a) / 10;

                if (xxx == 0)
                {
                    k = b - a;
                    a += k;
                    Counter++;
                }
                else
                {
                    k = xxx * 10;
                    a += k;
                    Counter += xxx;
                }
            }

            return Counter;

        }

        public static int GreaterThanB(int a, int b)
        {
            int k = 0;
            int Counter = 0;

            while (a > b)
            {
                int xxx = (a - b) / 10;

                if (xxx == 0)
                {
                    k = a - b;
                    a -= k;
                    Counter++;
                }
                else
                {
                    k = xxx * 10;
                    a -= k;
                    Counter += xxx;
                }
            }

            return Counter;

        }

        public static void Main(string[] args)
        {
            int TestCases = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < TestCases; i++)
            {
                string[] Input = Console.ReadLine().Split(" ");

                int a = Convert.ToInt32(Input[0]);
                int b = Convert.ToInt32(Input[1]);

                if (a == b) { Console.WriteLine(0); }
                else if (a < b)
                {
                    Console.WriteLine(LessThanB(a, b));
                }
                else
                {
                    Console.WriteLine(GreaterThanB(a, b));
                }
            }
        }
    }
}
