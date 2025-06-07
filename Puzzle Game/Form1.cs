using Puzzle_Game.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ShuffleImages();
        }

        Random randNumber = new Random();

        byte Minutes = 0;
        byte Seconds = 0;

        private int RandomNumber(int From, int To)
        {
            return randNumber.Next(From, To);
        }

        private void FillArrayWithOrdredNumber(byte[,] Matrix, byte Rows, byte Cols)
        {
            byte Counter = 1;
            for (byte i = 0; i < Rows; i++)
            {
                for (byte j = 0; j < Cols; j++)
                {
                    Matrix[i, j] = Counter;
                    Counter++;
                }
            }
        }

        private void SwapTwoNumbers(ref byte num1, ref byte num2)
        {
            byte temp = num1;
            num1 = num2;
            num2 = temp;
        }

        private void ShuffleArray(byte[,] Matrix, byte Rows, byte Cols)
        {
            for (int i = 0; i < Rows * Cols; i++)
            {
                SwapTwoNumbers(ref Matrix[RandomNumber(0, Rows), RandomNumber(0, Cols)],
                    ref Matrix[RandomNumber(0, Rows), RandomNumber(0, Cols)]);
            }
        }

        private void ShuffleImages()
        {
            byte[,] Matrix = new byte[3,3];
            FillArrayWithOrdredNumber(Matrix, 3, 3);
            ShuffleArray(Matrix, 3, 3);

            byte Counter = 1;

            for (byte i = 0; i < 3; i++)
            {
                for (byte j = 0; j < 3; j++)
                {
                    string btnImageClip = "btnImageClip" + Counter;

                    Button button = panelPicture.Controls[btnImageClip] as Button;
                    button.ImageIndex = Matrix[i, j];
                    Counter++;
                }
            }
        }

        private Button FindNullPicture()
        {
            byte Counter = 1;
            for (int i = 1; i <= 9; i++)
            {
                string btnImageClip = "btnImageClip" + Counter;

                Button button = panelPicture.Controls[btnImageClip] as Button;

                if (button.ImageIndex == 9)
                    return button;
                
                Counter++;
            }
            return null;
        }

        private void SwapTwoPicture(Button CurrentPicture, Button NullPicture)
        {
            byte Index = Convert.ToByte(CurrentPicture.ImageIndex);
            CurrentPicture.ImageIndex = 9;
            NullPicture.ImageIndex = Index;
        }

        private void StartTimer()
        {
            if (rbEasy.Checked)
                Minutes = 1;

            else if (rbMedium.Checked)
                Minutes = 2;

            else
                Minutes = 15;
            
            Clock.Enabled = true;
        }

        private void MediumLevel(Button CurrentPicture, Button NullPicture)
        {
        
            if(Convert.ToByte(NullPicture.Tag) == 5)
            {
                SwapTwoPicture(CurrentPicture, NullPicture);
            }

            if (Convert.ToByte(NullPicture.Tag) == 1 || Convert.ToByte(NullPicture.Tag) == 3)
            {
                if (Convert.ToByte(CurrentPicture.Tag) == 2 || Convert.ToByte(CurrentPicture.Tag) == 5)
                {
                    SwapTwoPicture(CurrentPicture, NullPicture);
                }
            }

            if (Convert.ToByte(NullPicture.Tag) == 7 || Convert.ToByte(NullPicture.Tag) == 9)
            {
                if (Convert.ToByte(CurrentPicture.Tag) == 8 || Convert.ToByte(CurrentPicture.Tag) == 5)
                {
                    SwapTwoPicture(CurrentPicture, NullPicture);
                }
            }

            if (Convert.ToByte(NullPicture.Tag) == 1 || Convert.ToByte(NullPicture.Tag) == 7)
            {
                if (Convert.ToByte(CurrentPicture.Tag) == 4)
                {
                    SwapTwoPicture(CurrentPicture, NullPicture);
                }
            }

            if (Convert.ToByte(NullPicture.Tag) == 3 || Convert.ToByte(NullPicture.Tag) == 9)
            {
                if (Convert.ToByte(CurrentPicture.Tag) == 6)
                {
                    SwapTwoPicture(CurrentPicture, NullPicture);
                }
            }

            if (Convert.ToByte(NullPicture.Tag) == 4 || Convert.ToByte(NullPicture.Tag) == 6)
            {
                if (Convert.ToByte(CurrentPicture.Tag) == 2 || Convert.ToByte(CurrentPicture.Tag) == 5 || Convert.ToByte(CurrentPicture.Tag) == 8)
                {
                    SwapTwoPicture(CurrentPicture, NullPicture);
                }
            }

            if (Convert.ToByte(NullPicture.Tag) == 2 || Convert.ToByte(NullPicture.Tag) == 8)
            {
                if (Convert.ToByte(CurrentPicture.Tag) == 4 || Convert.ToByte(CurrentPicture.Tag) == 5 || Convert.ToByte(CurrentPicture.Tag) == 6)
                {
                    SwapTwoPicture(CurrentPicture, NullPicture);
                }
            }

            if (Convert.ToByte(NullPicture.Tag) == 4)
            {
                if (Convert.ToByte(CurrentPicture.Tag) == 1 || Convert.ToByte(CurrentPicture.Tag) == 7)
                {
                    SwapTwoPicture(CurrentPicture, NullPicture);
                }
            }

            if (Convert.ToByte(NullPicture.Tag) == 6)
            {
                if (Convert.ToByte(CurrentPicture.Tag) == 3 || Convert.ToByte(CurrentPicture.Tag) == 9)
                {
                    SwapTwoPicture(CurrentPicture, NullPicture);
                }
            }

            if (Convert.ToByte(NullPicture.Tag) == 2)
            {
                if (Convert.ToByte(CurrentPicture.Tag) == 1 || Convert.ToByte(CurrentPicture.Tag) == 3)
                {
                    SwapTwoPicture(CurrentPicture, NullPicture);
                }
            }

            if (Convert.ToByte(NullPicture.Tag) == 8)
            {
                if (Convert.ToByte(CurrentPicture.Tag) == 7 || Convert.ToByte(CurrentPicture.Tag) == 9)
                {
                    SwapTwoPicture(CurrentPicture, NullPicture);
                }
            }
        }

        private void HardLevel(Button CurrentPicture, Button NullPicture)
        {
    
            if (Convert.ToByte(NullPicture.Tag) == 5)
            {
                if(Convert.ToByte(CurrentPicture.Tag) != 1 && Convert.ToByte(CurrentPicture.Tag) != 3
                    && Convert.ToByte(CurrentPicture.Tag) != 7 && Convert.ToByte(CurrentPicture.Tag) != 9)
                {
                    SwapTwoPicture(CurrentPicture, NullPicture);
                }
            }

            if (Convert.ToByte(NullPicture.Tag) == 1 || Convert.ToByte(NullPicture.Tag) == 3)
            {
                if (Convert.ToByte(CurrentPicture.Tag) == 2)
                {
                    SwapTwoPicture(CurrentPicture, NullPicture);
                }
            }

            if (Convert.ToByte(NullPicture.Tag) == 7 || Convert.ToByte(NullPicture.Tag) == 9)
            {
                if (Convert.ToByte(CurrentPicture.Tag) == 8)
                {
                    SwapTwoPicture(CurrentPicture, NullPicture);
                }
            }

            if (Convert.ToByte(NullPicture.Tag) == 1 || Convert.ToByte(NullPicture.Tag) == 7)
            {
                if (Convert.ToByte(CurrentPicture.Tag) == 4)
                {
                    SwapTwoPicture(CurrentPicture, NullPicture);
                }
            }

            if (Convert.ToByte(NullPicture.Tag) == 3 || Convert.ToByte(NullPicture.Tag) == 9)
            {
                if (Convert.ToByte(CurrentPicture.Tag) == 6)
                {
                    SwapTwoPicture(CurrentPicture, NullPicture);
                }
            }

            if (Convert.ToByte(NullPicture.Tag) == 4 || Convert.ToByte(NullPicture.Tag) == 6 ||
                Convert.ToByte(NullPicture.Tag) == 2 || Convert.ToByte(NullPicture.Tag) == 8)
            {
                if (Convert.ToByte(CurrentPicture.Tag) == 5)
                {
                    SwapTwoPicture(CurrentPicture, NullPicture);
                }
            }

            if (Convert.ToByte(NullPicture.Tag) == 4)
            {
                if (Convert.ToByte(CurrentPicture.Tag) == 1 || Convert.ToByte(CurrentPicture.Tag) == 7)
                {
                    SwapTwoPicture(CurrentPicture, NullPicture);
                }
            }

            if (Convert.ToByte(NullPicture.Tag) == 6)
            {
                if (Convert.ToByte(CurrentPicture.Tag) == 3 || Convert.ToByte(CurrentPicture.Tag) == 9)
                {
                    SwapTwoPicture(CurrentPicture, NullPicture);
                }
            }

            if (Convert.ToByte(NullPicture.Tag) == 2)
            {
                if (Convert.ToByte(CurrentPicture.Tag) == 1 || Convert.ToByte(CurrentPicture.Tag) == 3)
                {
                    SwapTwoPicture(CurrentPicture, NullPicture);
                }
            }

            if (Convert.ToByte(NullPicture.Tag) == 8)
            {
                if (Convert.ToByte(CurrentPicture.Tag) == 7 || Convert.ToByte(CurrentPicture.Tag) == 9)
                {
                    SwapTwoPicture(CurrentPicture, NullPicture);
                }
            }
        }

        private void EasyLevel(Button CurrentPicture, Button NullPicture)
        {
            SwapTwoPicture(CurrentPicture, NullPicture);
        }

        private void ShowAWinningMessage()
        {
            MessageBox.Show("Congratulations you won!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowLossMessage()
        {
            MessageBox.Show("Time is up.", "Game Over", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if(MessageBox.Show("Do you want to play?", "Play Again", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                Reset();
            }
        }

        private void AfterTheOrihinalImageIsCompleted()
        {
            btnImageClip1.ImageIndex = 0;

            Clock.Enabled = false;
            Check.Enabled = false;

            lblClock.Text = "Congratulations you won";

            ShowAWinningMessage();
        }

        private void CheckOriginalImage()
        {
            short Counter = 2;
            for (int i = 1; i < 9; i++)
            {
                string btnImageClip = "btnImageClip" + Counter;
                Button button = panelPicture.Controls[btnImageClip] as Button;
                if (button.ImageIndex != (Counter - 1))
                    return;

                Counter++;
            }
            AfterTheOrihinalImageIsCompleted();
        }

        private void UpdateUserInterfaceAfterClickStart()
        {
            btnStart.Visible = false;
            btnShuffle.Visible = false;
            btnReset.Visible = true;

            rbEasy.Enabled = false;
            rbMedium.Enabled = false;
            rbHard.Enabled = false;

        }

        private void Start()
        {
            UpdateUserInterfaceAfterClickStart();
            StartTimer();
            lblClock.Visible = true;
        }

        private void ResetButtons()
        {
            btnShuffle.Visible = true;
            btnStart.Visible = true;
            btnReset.Visible = false;

            rbEasy.Enabled = true;
            rbMedium.Enabled = true;
            rbHard.Enabled = true;
        }

        private void ResetLabel()
        {
            lblClock.Text = "";
        }

        private void ResetClock()
        {
            Minutes = 0;
            Seconds = 0;
        }

        private void ResetTimer()
        {
            Clock.Enabled = false;
            Check.Enabled = true;
        }

        private void Reset()
        {
            ResetButtons();
            ResetClock();
            ShuffleImages();
            ResetTimer();
            ResetLabel();
        }

        private void UpdateAfterClickButton(Button CurrentButton, Button NullButton)
        {
            if (rbEasy.Checked)
                EasyLevel(CurrentButton, NullButton);

            else if (rbMedium.Checked)
                MediumLevel(CurrentButton, NullButton);

            else
                HardLevel(CurrentButton, NullButton);
        }

        private void CheckTimeOver(byte Minutes, byte Seconds)
        {
            if (Minutes == 0 && Seconds == 0)
            {
                Clock.Enabled = false;
                ShowLossMessage();
            }
        }





        private void btnShuffle_Click(object sender, EventArgs e)
        {
            ShuffleImages();
        }

        private void btnImageClip1_Click(object sender, EventArgs e)
        {
            UpdateAfterClickButton(btnImageClip1, FindNullPicture());
        }

        private void btnImageClip2_Click(object sender, EventArgs e)
        {
            UpdateAfterClickButton(btnImageClip2, FindNullPicture());
        }

        private void btnImageClip3_Click(object sender, EventArgs e)
        {
            UpdateAfterClickButton(btnImageClip3, FindNullPicture());
        }

        private void btnImageClip4_Click(object sender, EventArgs e)
        {
            UpdateAfterClickButton(btnImageClip4, FindNullPicture());
        }

        private void btnImageClip5_Click(object sender, EventArgs e)
        {
            UpdateAfterClickButton(btnImageClip5, FindNullPicture());
        }

        private void btnImageClip6_Click(object sender, EventArgs e)
        {
            UpdateAfterClickButton(btnImageClip6, FindNullPicture());
        }

        private void btnImageClip7_Click(object sender, EventArgs e)
        {
            UpdateAfterClickButton(btnImageClip7, FindNullPicture());
        }

        private void btnImageClip8_Click(object sender, EventArgs e)
        {
            UpdateAfterClickButton(btnImageClip8, FindNullPicture());
        }

        private void btnImageClip9_Click(object sender, EventArgs e)
        {
            UpdateAfterClickButton(btnImageClip9, FindNullPicture());
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        
        private void rbEasy_CheckedChanged(object sender, EventArgs e)
        {
            btnStart.Visible = true;
        }



        private void Clock_Tick(object sender, EventArgs e)
        {
            if (Seconds == 0 && Minutes >= 0)
            {
                Seconds = 60;
                --Minutes;
            }
            else
            {
                --Seconds;
                CheckTimeOver(Minutes,Seconds);
            }

            if(Clock.Enabled == true)
                lblClock.Text = "Remaining Time :  00 : " + Minutes.ToString() + " : " + Seconds.ToString(); 

        }

        private void Check_Tick(object sender, EventArgs e)
        {
            CheckOriginalImage();
        }

       
    }
}
