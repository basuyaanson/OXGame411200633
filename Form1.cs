using System;
using System.Windows.Forms;

namespace OXGame
{
    public partial class Form1 : Form
    {
        string playermaker = "X";
        string[] name = new string[9];
        int win=0;
        int time = 0;
        DialogResult result;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Button button = (Button)sender;
            if(button.Text == "")
            {
                name[time] = button.Name;
                time++;
                button.Text = playermaker;
                checkWinner();
                playermaker = playermaker == "X" ? "O" : "X";
                label2.Text = playermaker;
            }
            
        }
        private void checkWinner()
        {
           foreach(string s in name)
            {

                if (s == "button1")
                {
                    if (button1.Text == button2.Text && button2.Text == button3.Text)
                    {
                        win = 1;
                    }
                    else if (button1.Text == button4.Text && button4.Text == button7.Text)
                    {
                        win = 1;
                    }
                    else if (button1.Text == button5.Text && button5.Text == button9.Text)
                    {
                        win = 1;
                    }
                }
                if (s == "button2")
                {
                    if (button2.Text == button5.Text && button5.Text == button8.Text)
                    {
                        win = 1;
                    }
                }
                if (s == "button3")
                {
                    if (button3.Text == button5.Text && button5.Text == button7.Text)
                    {
                        win = 1;
                    }
                    else if (button3.Text == button6.Text && button6.Text == button9.Text)
                    {
                        win = 1;
                    }
                }
                if (s == "button4")
                {
                    if (button4.Text == button5.Text && button5.Text == button6.Text)
                    {
                        win = 1;
                    }
                }
                if (s == "button7")
                {
                    if (button7.Text == button8.Text && button8.Text == button9.Text)
                    {
                        win = 1;
                    }
                   
                }
                if(name[8] != null)
                {
                    win = 2;
                }
            }
            if(win == 1 || win ==2)
            {
                switch(win)
                {
                    case 1:
                        result = MessageBox.Show($"遊戲結束!  恭喜   {playermaker}    獲勝!   是否繼續遊戲", "遊戲結果", MessageBoxButtons.YesNo);
                        break;
                    case 2:
                        result = MessageBox.Show($"遊戲結束!  是否繼續遊戲", "遊戲結果", MessageBoxButtons.YesNo);
                        break;
                }        
                if (result == DialogResult.Yes)
                {
                    again();
                }
                else if(result == DialogResult.No)
                {
                    Close();
                }
            }
        }
        private void again()
        {
                playermaker = "X";
                name = new string[9];
                win = 0;
                time = 0;
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}