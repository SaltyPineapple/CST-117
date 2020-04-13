using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void fileButton_Click(object sender, EventArgs e)
        {
            // Clear list box
            if(itemsListBox.Items.Count != 0)
            {
                itemsListBox.Items.Clear();
            }

            // Create stream reader and writer objects
            StreamReader inputFile;
            StreamWriter outputFile;


            // Initialize all string variables
            string sentence;
            string firstWord;
            string lastWord;
            string longestWord = " ";
            string mostVowel = " ";
            int mostVowelCount = 0;

            // Use list for easy sorting
            List<string> alphabetize = new List<string>();

            // Create list of vowels
            List<char> vowels = new List<char>()
            {
                'a',
                'e',
                'i',
                'o',
                'u'
            };

            // Open input file
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                inputFile = File.OpenText(openFile.FileName);

                List<string> words = new List<string>();

                // Read every line of file
                
                while (!inputFile.EndOfStream)
                {


                    sentence = inputFile.ReadLine();
                    string[] phrase = sentence.Split(' ');

                    // Convert every word to lowercase
                    // Add words in the line to the list
                    for (int x=0; x< phrase.Length; x++)
                    {
                        
                        words.Add(phrase[x].ToLower());
                    }

                }

                foreach(var word in words)
                {

                
                    // Get longest word
                    if (word.Length > longestWord.Length)
                    {
                        longestWord = word;
                    }


                    // Find most vowels
                    int counter = 0;
                    for (int k = 0; k < word.Length; k++)
                    {
                        if (vowels.Contains(word[k]))
                        {
                            counter++;
                        }
                    }


                    if (counter > mostVowelCount)
                    {
                        mostVowel = word;
                        mostVowelCount = counter;
                    }

                    // Add each word to list for sorting
                    alphabetize.Add(word);

                }

                // Sort the list alphabetically
                alphabetize = alphabetize.OrderBy(q => q).ToList();

                // Grab first and last word in list
                firstWord = alphabetize[0];
                lastWord = alphabetize[alphabetize.Count - 1];

                // Add all items of list to listBox
                for (int x = 0; x < alphabetize.Count; x++)
                {
                    itemsListBox.Items.Add(alphabetize[x]);
                }

                // Display words
                longestWordLabel.Text = longestWord;
                firstWordLabel.Text = firstWord;
                lastWordLabel.Text = lastWord;
                mostVowelsLabel.Text = mostVowel;



                // Write all words to output file
                outputFile = File.CreateText("Output.txt");

                for (int x = 0; x < alphabetize.Count; x++)
                {
                    outputFile.WriteLine(alphabetize[x]);
                }

                outputFile.WriteLine(" ");
                outputFile.WriteLine(" ");

                outputFile.WriteLine(string.Format("Longest word: {0}", longestWord));
                outputFile.WriteLine(string.Format("First word: {0}", firstWord));
                outputFile.WriteLine(string.Format("Last word: {0}", lastWord));
                outputFile.WriteLine(string.Format("Word with most vowels: {0}", mostVowel));

                // Close output File
                outputFile.Close();
            }
            else
            {
                MessageBox.Show("Please Select a File to continue");
            }
            

        }

        
    }
}
