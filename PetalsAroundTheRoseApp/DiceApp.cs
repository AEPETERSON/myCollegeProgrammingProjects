//DiceApp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetalsAroundTheRoseApp
{

    public class DiceApp : PictureBox
    {

        public DiceApp[] picArray = new DiceApp[5];
        private int dieNum;
        private int dieScore;
        private int answerAmount;
        private static Random randomGen = new Random();





        public int DieNum
        {
            get { return dieNum; }
            set { dieNum = value; }
        }

        public int DieScore
        {
            get { return dieScore; }
            set { dieScore = value; }
        }

        

        public override string ToString()
        {
            return "Die Number " + dieNum + "Die Score " + dieScore;
        }



        public void Roll()
        {   //code that randomly generates the dice number values on each roll from 1 to 6.
            dieNum = randomGen.Next(1, 7);
            //answerAmount = 0;


            dieScore = 0;
            if (dieNum == 3)
            {
                dieScore = 2;
            }
            if (dieNum == 5)
            {
                dieScore = 4;
            }
            // test amonnt gg
            //if(dieNum == 3)
            //{
            //    answerAmount = answerAmount + 2;
            //}
            //if(dieNum == 5)
            //{
            //    answerAmount = answerAmount + 4;
            //}

        }
        
       //public void Accept()
       //{
       //PetalsAroundRoseApp newPetals = new PetalsAroundRoseApp();
       //for (int i = 0; i < picArray.Length; i++)
       //{
       //if(picArray[i] == picArray[2])
       //{
       //answerAmount = answerAmount + 2;
       //}
       //if (picArray[i] == picArray[2])
       //{
       //answerAmount = answerAmount + 4;
       //}
       //else
       //answerAmount = answerAmount + 0;
       //}

        //answerAmount = 0;
        //AnswerAmount = answerAmount;
        // if statement structure needed to determine score needed

        //if (picArray[i] == picArray[2])
        //{
        //    //answerAmount = answerAmount + 2;

        //}

        //if (picArray[i] == picArray[4])
        //{
        //    //answerAmount = answerAmount + 4;

        //}
        //else
        //if (picArray[i] == picArray[0])
        //{
        //    answerAmount = answerAmount + 0;
        //    //answerAmount += 0;
        //}
        //else
        //    answerAmount = answerAmount + 0;

        //gg
        //if (dieNum == 3)
        //{
        //answerAmount = answerAmount + 2;
        //}
        //if (dieNum == 5)
        //{
        //answerAmount = answerAmount + 4;
        //}
        //endgg












        //}


    }


}
