using System;
namespace FindNumberOfWords
{
    internal class programm
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("This program finded how many words and numbers");

            string isContinue;
            do
            {
                Console.Write("Write string :\n");

                string userInput = Console.ReadLine();

                int lettersCount = 0;
                int numbersCount = 0;

                string letters = "";
                string numbers = "";

                foreach (char c in userInput)

                {
                    if (char.IsDigit(c))
                    {
                        numbers += c;
                        lettersCount++;

                        letters += c;
                        numbersCount++;
                    }
                    else if (char.IsLetter(c))
                    {
                        letters += c;
                        lettersCount++;
                    }
                }
                Console.WriteLine($"Number of letters: {lettersCount}\n");
                Console.WriteLine($"Number of numbers: {numbersCount}\n");

                Console.WriteLine("Do you want continue? ("+")");
                isContinue = Console.ReadLine();
            }
            while (isContinue == "+");
        }
    }
}
