namespace _1335A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int TestCases = int.Parse(Console.ReadLine());

            for(int i = 0; i < TestCases; i++)
            {
                int Candies = int.Parse(Console.ReadLine());

                int Result = (Candies - 1) / 2;
                Console.WriteLine(Result);

            }

        }
    }
}
