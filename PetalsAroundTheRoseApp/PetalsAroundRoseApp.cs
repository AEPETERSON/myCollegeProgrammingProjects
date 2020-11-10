using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetalsAroundTheRoseApp
{
// Name: Alex Peterson
//Date: September 1, 2018
//Project: Petals Around The Rose Game
    public partial class PetalsAroundRoseApp : Form
    {
        int correctAns = 0;
        public int totalRolls = 0;
        DiceApp[] picArray = new DiceApp[5];
        public PetalsAroundRoseApp()
        {
            InitializeComponent();
        }

        private void PetalsAroundRoseApp_Load(object sender, EventArgs e)
        {
            //for loop that excutes and sets the picture array specifications/properties to their default values when the application loads up.
            for (int i = 0; i < picArray.Length; i++)
            {
                picArray[i] = new DiceApp();
                picArray[i].Location = new System.Drawing.Point(i * 225, 51);
                picArray[i].Name = "pictureBox" + 1.ToString();
                picArray[i].Size = new System.Drawing.Size(123, 121);
                picArray[i].TabIndex = 0;
                picArray[i].TabStop = false;
                picArray[i].Image = (Image)Properties.Resources.ResourceManager.GetObject("Alea_" + (i + 1));
                picArray[i].Visible = false;
                this.Controls.Add(picArray[i]);
            }

        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            //for loop that executes when the roll button is clicked and sets the picture box values to false to only show the randomized dice values and allows the random dice rolls to execute.
            //int totalRolls = 0;
            for (int i = 0; i < picArray.Length; i++)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                picArray[i].Visible = true;
                picArray[i].Roll();
                picArray[i].Image = (Image)Properties.Resources.ResourceManager.GetObject("Alea_" + picArray[i].DieNum);
            }
            totalRolls = totalRolls + 1;
            txtTotalRolls.Text = Convert.ToString(totalRolls);
            
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            int ans = 0;
            for (int i = 0; i < picArray.Length; i++)
            {
                ans += picArray[i].DieScore;
                
            }

            DiceApp newDiceApp = new DiceApp();
            if (Convert.ToInt32(txtGuess.Text) == ans)
            {
                txtResult.Text = "*** YES ***";
                correctAns = correctAns + 1;
                txtCorrectAnswers.Text = Convert.ToString(correctAns);
            }
            //if (Convert.ToInt32(txtGuess.Text) != ans % 2)
            //{
                //txtResult.Text = "The answer is " + Convert.ToInt32(ans) + " Not " + Convert.ToInt32(txtGuess.Text) + " (The score is always even)";
            //}

            else
                txtResult.Text = "The answer is " + Convert.ToInt32(ans) + " Not " + Convert.ToInt32(txtGuess.Text);
        }
    }
}
