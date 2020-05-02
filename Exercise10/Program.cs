using System;
using System.Collections.Generic;
using System.IO;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Format("There are {0} words that end with either t or e.", readFile()));
        }


        static int readFile()
        {
            StreamReader inputFile;
            int finalCount = 0;
            string line;

            inputFile = File.OpenText("testFile.txt");

            while (!inputFile.EndOfStream)
            {
                // Read each line
                line = inputFile.ReadLine();

                // Split each line into words
                string[] words = line.Split(" ");

                for (int x = 0; x < words.Length; x++)
                {
                    // Convert to lowercase for comparison
                    string currentWord = words[x].ToLower();

                    // Last character of word
                    int index = currentWord.Length - 1;

                    // Check if last character is a letter
                    // changes index value if last letter is not
                    // i.e. "wait!"
                    if (!char.IsLetter(currentWord[index]))
                    {
                        index--;
                    }

                    // Check if last letter is e or t, increase count accordingly
                    if (currentWord[index] == 'e' || currentWord[index] == 't')
                    {
                        finalCount++;
                    }

                }

            }

            return finalCount;

        }
    }
}
