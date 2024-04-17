namespace _996A
{
    public class Program
    {
        static void Main(string[] args)
        {
            int Money = int.Parse(Console.ReadLine());

            int k = 0, Bills = 0;

            while(Money > 0)
            {
                switch(Money >= 100 ? "Over100"
                    : Money >= 20 ? "Over20"
                    : Money >= 10 ? "Over10"
                    : Money >= 5 ? "Over5"
                    : Money >= 1 ? "Over1" : "NA")
                {
                    case "Over100":
                        k = Money / 100;
                        Money -= k * 100;
                        Bills += k;
                        break;
                    case "Over20":
                        k = Money / 20;
                        Money -= k * 20;
                        Bills += k;
                        break;
                    case "Over10":
                        k = Money / 10;
                        Money -= k * 10;
                        Bills += k;
                        break;
                    case "Over5":
                        k = Money / 5;
                        Money -= k * 5;
                        Bills += k;
                        break;
                    case "Over1":
                        k = Money;
                        Money -= k;
                        Bills += k;
                        break;

                }

            }

            Console.WriteLine(Bills);

        }
    }
}
