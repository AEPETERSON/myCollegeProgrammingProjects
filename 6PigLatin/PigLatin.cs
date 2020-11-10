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

    class PigLatin
    {
        
        public string realWords;
        


        public void TranslateToPigLatinUserDefined()
        {
            string sentence;
            //Two programmed prompts that let the user know they can type as many words as they like and type in the integer value of how many words they would like to type and see translated to Pig Latin 
            Console.WriteLine("Type in as many words as you would like in the space below to convert the following word or sentence into pig latin: \n");
            Console.WriteLine("How many words would you like to be translated?");
            //number of words is defined by the user with a ReadLine statement.
            int numWords = Convert.ToInt32(ReadLine());
            string[] wordArray = new string[numWords];
            //A prompt to the user to let them know this is where they type in the words they would like to see translated and informs the user to not seperate the words with commas but only one space per word and when they made all the number words they asked for they will type enter to see the translation.
            Console.WriteLine("Please enter the words you want to be translated into Pig Latin: (no commas only one space per word and then press enter.) /n");
            //A user-defined ReadLine statement that allows the users to type in their user-defined words.
            sentence = Console.ReadLine();
            string firstLetterReal;
            string restOfTheWordReal;
            string vowelsReal = "aeiouyAEIOUY";
            int currentLetterReal;
            //Foreach Loop that makes a split in the user-defined word values and sets the variables in the TranslatePigLatinUserDefined method to actual values in this case based on a substring and an index
            foreach (string realWord in sentence.Split(' ')) 
            {
                firstLetterReal = realWord.Substring(0, 1);
                restOfTheWordReal = realWord.Substring(1, realWord.Length - 1);
                currentLetterReal = vowelsReal.IndexOf(firstLetterReal);
                //if else statements that determine whether each user-defined word in the array will have "ay" or "way" added to each of the test words
                if (currentLetterReal == -1)
                {
                    //pigLatinWords.Add(restOfTheWord + firstLetter + "ay");
                    realWords = restOfTheWordReal + firstLetterReal + "ay";
                    WriteLine(realWords);


                    //Console.WriteLine(pigLatinWords);
                }
                else
                {
                    //pigLatinWords.Add(word + "way");

                    realWords = realWord + "way";
                    WriteLine(realWords);
                }
                

            }
        }
    }




}
