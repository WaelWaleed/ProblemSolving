namespace _268A
{
    public class Program
    {
        static void Main(string[] args)
        {
            int Teams = int.Parse(Console.ReadLine());

            List<int> Home = new List<int>(), Guest = new List<int>();
            int Result = 0;

            for(int i = 0; i < Teams; i++)
            {
                string[] Costumes = Console.ReadLine().Split();
                
                Home.Add(int.Parse(Costumes[0]));
                Guest.Add(int.Parse(Costumes[1]));

            }

            for(int i = 0; i < Teams; i++)
            {
                int HomeCostume = Home[i];
                //int GuestCostume = Guest[0];

                for(int j = 0; j < Teams; j++)
                {
                    if(i != j)
                    {
                        if(HomeCostume == Guest[j])
                        {
                            Result++;
                        }
                    }
                }

            }

            Console.WriteLine(Result);

        }
    }
}
