namespace PetalsAroundTheRoseApp
{
    partial class PetalsAroundRoseApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRoll = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.lblGuess = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtCorrectAnswers = new System.Windows.Forms.TextBox();
            this.lblCorrectAnswer = new System.Windows.Forms.Label();
            this.lblTotalRolls = new System.Windows.Forms.Label();
            this.txtTotalRolls = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRoll
            // 
            this.btnRoll.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoll.Location = new System.Drawing.Point(107, 307);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(117, 48);
            this.btnRoll.TabIndex = 0;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = false;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PetalsAroundTheRoseApp.Properties.Resources.Alea_1;
            this.pictureBox1.Location = new System.Drawing.Point(51, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 114);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PetalsAroundTheRoseApp.Properties.Resources.Alea_3;
            this.pictureBox2.Location = new System.Drawing.Point(301, 77);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(118, 114);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PetalsAroundTheRoseApp.Properties.Resources.Alea_2;
            this.pictureBox3.Location = new System.Drawing.Point(175, 77);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(120, 114);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PetalsAroundTheRoseApp.Properties.Resources.Alea_5;
            this.pictureBox4.Location = new System.Drawing.Point(551, 77);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(116, 114);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::PetalsAroundTheRoseApp.Properties.Resources.Alea_4;
            this.pictureBox5.Location = new System.Drawing.Point(425, 77);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(120, 114);
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(129, 269);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(40, 20);
            this.txtGuess.TabIndex = 6;
            // 
            // lblGuess
            // 
            this.lblGuess.AutoSize = true;
            this.lblGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuess.Location = new System.Drawing.Point(12, 267);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(102, 20);
            this.lblGuess.TabIndex = 7;
            this.lblGuess.Text = "Your Guess: ";
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(254, 307);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(114, 48);
            this.btnAccept.TabIndex = 8;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(77, 409);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(620, 20);
            this.txtResult.TabIndex = 9;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(12, 407);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(59, 20);
            this.lblResult.TabIndex = 10;
            this.lblResult.Text = "Result:";
            // 
            // txtCorrectAnswers
            // 
            this.txtCorrectAnswers.Location = new System.Drawing.Point(607, 269);
            this.txtCorrectAnswers.Name = "txtCorrectAnswers";
            this.txtCorrectAnswers.Size = new System.Drawing.Size(68, 20);
            this.txtCorrectAnswers.TabIndex = 11;
            // 
            // lblCorrectAnswer
            // 
            this.lblCorrectAnswer.AutoSize = true;
            this.lblCorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectAnswer.Location = new System.Drawing.Point(471, 267);
            this.lblCorrectAnswer.Name = "lblCorrectAnswer";
            this.lblCorrectAnswer.Size = new System.Drawing.Size(130, 20);
            this.lblCorrectAnswer.TabIndex = 12;
            this.lblCorrectAnswer.Text = "Correct Answers:";
            // 
            // lblTotalRolls
            // 
            this.lblTotalRolls.AutoSize = true;
            this.lblTotalRolls.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRolls.Location = new System.Drawing.Point(514, 298);
            this.lblTotalRolls.Name = "lblTotalRolls";
            this.lblTotalRolls.Size = new System.Drawing.Size(87, 20);
            this.lblTotalRolls.TabIndex = 13;
            this.lblTotalRolls.Text = "Total Rolls:";
            // 
            // txtTotalRolls
            // 
            this.txtTotalRolls.Location = new System.Drawing.Point(607, 300);
            this.txtTotalRolls.Name = "txtTotalRolls";
            this.txtTotalRolls.Size = new System.Drawing.Size(70, 20);
            this.txtTotalRolls.TabIndex = 14;
            // 
            // PetalsAroundRoseApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTotalRolls);
            this.Controls.Add(this.lblTotalRolls);
            this.Controls.Add(this.lblCorrectAnswer);
            this.Controls.Add(this.txtCorrectAnswers);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lblGuess);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRoll);
            this.Name = "PetalsAroundRoseApp";
            this.Text = "Petals Around The Rose Game";
            this.Load += new System.EventHandler(this.PetalsAroundRoseApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Label lblGuess;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtCorrectAnswers;
        private System.Windows.Forms.Label lblCorrectAnswer;
        private System.Windows.Forms.Label lblTotalRolls;
        private System.Windows.Forms.TextBox txtTotalRolls;
    }
}

