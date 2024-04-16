namespace _281A
{
    public class Program
    {
        static void Main(string[] args)
        {
            char[] Word = Console.ReadLine().ToArray();
            int ASCIICharacter = Convert.ToInt32(Word[0]);
            if (ASCIICharacter >= 97 && ASCIICharacter <= 122)
            {
                ASCIICharacter -= 32;
                char NewCharacter = Convert.ToChar(ASCIICharacter);

                Word[0] = NewCharacter;

            }

            Console.WriteLine(new string(Word));



        }
    }
}
