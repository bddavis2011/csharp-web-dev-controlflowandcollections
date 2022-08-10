using System;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            static int sumEven(List<int> arr)
            {
                int total = 0;
                foreach (int integer in arr)
                {
                    if (integer % 2 == 0)
                    {
                        total += integer;
                    }
                }
                return total;
            }
        }
        static void printFiveLetterWords(List<string> wordlist)
        {
            foreach (string word in wordlist)
            {
                if (word.Length == 5)
                {
                    Console.WriteLine(word);
                }
            }
        }

        Console.WriteLine("Enter a word length: ");
   string numInput = Console.ReadLine();
        int numChars = int.Parse(numInput);

        // Call the method to print out list words of the chosen length:
        printXLetterWords(wordList, numChars);


        static void printXLetterWords(List<string> wordlist, int length)
        {
            foreach (string word in wordlist)
            {
                if (word.Length == length)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
