/***************DONEEEEEEEEE*****************/



using System;

namespace Hemispherical_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = -1, Density = -1; double max = 0;
            while(radius !=0 || Density != 0)
            {
                Console.WriteLine("Enter the Raduis: ");
                radius = double.Parse(Console.ReadLine());
                //Console.WriteLine();
                Console.WriteLine("Enter the Density: ");
                Density = double.Parse(Console.ReadLine());

                double Volume = (2.0/3.0)*(3.14* Math.Pow(radius,3));
                double mass = Volume * Density;
                max = Math.Max(max, mass);

                Console.WriteLine($"mass: {mass}");
            }
            Console.WriteLine($"Haviest lequid mass = {max}");

        }
    }
}
