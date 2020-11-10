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

    class Program
    {
        
        // Main Method that executes the Tester and PigLatin Class
        static void Main(string[] args)
        {
            string testSentence = "RPM help strong crystal yellow eating";




            PigLatin newPigLatin = new PigLatin();
            Tester newTester = new Tester();
            Console.WriteLine(testSentence);
            newTester.TranslatePigLatin();
            newPigLatin.TranslateToPigLatinUserDefined();
            
            






            //Console.WriteLine("Enter a sentence to be converted into Pig Latin: \n");
            //string sentence = Console.ReadLine();
            //newTester.TranslatePigLatin();
            //Console.WriteLine(newTester.PigLatinWords);


            ReadKey();

        }
    







    }

}


