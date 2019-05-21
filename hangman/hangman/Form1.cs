using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hangman
{
    public partial class Form1 : Form
    {
        String word;
        int missed = 0;
        public Form1()
        {
            InitializeComponent();
            Randomize_word();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (missed < 12)
            {
                string letter = textBox1.Text;
                bool guessed = false;
                int where = 0;
                for (int i = 0; i < 6; i++)
                {
                    if (Convert.ToString(word[i]) == letter)
                    {
                        guessed = true;
                        where = i;
                    }
                    if (where == 1) { label2.Text = letter; }
                    if (where == 2) { label3.Text = letter; }
                    if (where == 3) { label4.Text = letter; }
                    if (where == 4) { label5.Text = letter; }
                    if (where == 5) { label6.Text = letter; }
                }
                if (guessed == false)
                {
                    missed++;
                    if (missed == 1) { pictureBox1.Image = hangman.Properties.Resources._1; }
                    if (missed == 2) { pictureBox1.Image = hangman.Properties.Resources._2; }
                    if (missed == 3) { pictureBox1.Image = hangman.Properties.Resources._3; }
                    if (missed == 4) { pictureBox1.Image = hangman.Properties.Resources._4; }
                    if (missed == 5) { pictureBox1.Image = hangman.Properties.Resources._5; }
                    if (missed == 6) { pictureBox1.Image = hangman.Properties.Resources._6; }
                    if (missed == 7) { pictureBox1.Image = hangman.Properties.Resources._7; }
                    if (missed == 8) { pictureBox1.Image = hangman.Properties.Resources._8; }
                    if (missed == 9) { pictureBox1.Image = hangman.Properties.Resources._9; }
                    if (missed == 10) { pictureBox1.Image = hangman.Properties.Resources._10; }
                    if (missed == 11) { pictureBox1.Image = hangman.Properties.Resources._11; }
                    if (missed == 12) {
                        pictureBox1.Image = hangman.Properties.Resources._12;
                        button2.Visible = true;
                    }
                }
                Win();
            }
            else
            {
                pictureBox1.Image = hangman.Properties.Resources.lose;
            }
        }

        private void Randomize_word()
        {
            string[] words = { "ability", "banking", "certain", "decline", "freedom", "instead", "massive", "perhaps" };
            int word_count = words.Length;
            Random gen = new Random();
            int word_index = gen.Next(0, word_count);
            word = words[word_index];
            label1.Text = Convert.ToString(word[0]);
            label7.Text = Convert.ToString(word[6]);
        }

        private void Win()
        {
            if (label2.Text != "_")
            {
                if (label3.Text != "_")
                {
                    if (label4.Text != "_")
                    {
                        if (label5.Text != "_")
                        {
                            if (label6.Text != "_")
                            {
                                pictureBox1.Image = hangman.Properties.Resources.win;
                                button2.Visible = true;
                            }
                        }
                    }
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Randomize_word();
            label2.Text = "_";
            label3.Text = "_";
            label4.Text = "_";
            label5.Text = "_";
            label6.Text = "_";
            missed = 0;
            button2.Visible = false;
            pictureBox1.Image = null;
        }
    }
}
