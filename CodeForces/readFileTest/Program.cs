using System;
using System.IO;

namespace readFileTest
{
    class Program
    {
        static void Main(string[] args)
        {
            String line = "";
            try {
                StreamReader sr = new StreamReader("C:/Users/Waelw/OneDrive/Desktop/ReadTest.txt");
                line = sr.ReadLine();
                while(line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();
                line = "- ♥ And indeed I am ♥";
                //StreamWriter sw = new StreamWriter("C:/Users/Waelw/OneDrive/Desktop/ReadTest.txt", true);
                //sw.WriteLine(line);
                using (StreamWriter sw = File.AppendText("C:/Users/Waelw/OneDrive/Desktop/ReadTest.txt"))
                {
                    sw.WriteLine(DateTime.Now.ToString() + ":" + "App initialized");
                }
                Console.Write($"Done!");
            } catch { Console.Write($"Not Done!"); }
        }
    }
}
