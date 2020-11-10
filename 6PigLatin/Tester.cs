using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _6PigLatin
{
    //Name: Alex Peterson
    //Date: October 2, 2017

    public class Tester
    {
        //all public and local strings are defined here
        string[] testWords = new string[] { "RPM", "help", "strong", "crystal", "yellow", "eating" };
        string testSentence = "RPM help strong crystal yellow eating";
        private string pigLatinWords;
        public string tempWords;

        //getter setter for PigLatinWords
        public string PigLatinWords
        {
            get { return pigLatinWords; }
            set { pigLatinWords = value; }
        }
        //Method that translate the test words into pig latin
        public string TranslatePigLatin()
        {
            //variables used for TranslatePigLatin method

            List<string> pigLatinWords = new List<string>();
            string firstLetter;
            string restOfTheWord;
            string vowels = "aeiouy";
            int currentLetter;
            //Foreach Loop that makes a split in the test word values and sets the variables in the TranslatePigLatin method to actual values in this case based on substring and an index
            foreach (string word in testSentence.Split(' '))
            {
                firstLetter = word.Substring(0, 1);
                restOfTheWord = word.Substring(1, word.Length - 1);
                currentLetter = vowels.IndexOf(firstLetter);
            //if else statements that determine whether each word in the array will have "ay" or "way" added to each of the test words
                if (currentLetter == -1)
                {
                    //pigLatinWords.Add(restOfTheWord + firstLetter + "ay");
                   tempWords = restOfTheWord + firstLetter + "ay";
                   WriteLine(tempWords);
                

                    //Console.WriteLine(pigLatinWords);
                }
                else
                {
                    //pigLatinWords.Add(word + "way");

                    tempWords = word + "way";
                    WriteLine(tempWords);

                    //pigLatinWords.ToString();
                    //Console.WriteLine(pigLatinWords.ToString());
                }
            }
            
            return string.Join(" ", pigLatinWords);

        }
        //    public override string ToString()
        //    {
        //        return " RPM help strong crystal yellow eating" + tempWords.ToString();
        //    }

    }

}
