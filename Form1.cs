

/*
Ben Williams 9-12-22 
Estimated Hours Taken: 2 Hours Basic 
GUI and Input Systems

Ben Williams 9-21-22
Estimated Hours Taken: 2 Hours 
Files,Card Draw Loop

Ben Williams 9-22-22
Estimated Hours Taken: 2 Hours 
Comments and more loops

Ben Williams 10-2-22
Estimated Hours Taken: 2-4 Hours
Adding more string manipulation, lists, design
*/



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace EventTest
{

    public partial class Form1 : Form
    {

        string textFile = "file.txt";

        Image[] images = new Image[14];
        PictureBox[] cardDisplay = new PictureBox[3];

        int number;
        int die;
        double numToRound;

        List<string> groceries = new List<string>();

        public Form1()
        {
            InitializeComponent();
            //Card Images
            images[0] = Image.FromFile("C:/Users/Techedin/source/repos/CSC202 Projects/EventTest/1.JPG");
            images[1] = Image.FromFile("C:/Users/Techedin/source/repos/CSC202 Projects/EventTest/2.PnG");
            images[2] = Image.FromFile("C:/Users/Techedin/source/repos/CSC202 Projects/EventTest/3.PnG");
            images[3] = Image.FromFile("C:/Users/Techedin/source/repos/CSC202 Projects/EventTest/4.PnG");
            images[4] = Image.FromFile("C:/Users/Techedin/source/repos/CSC202 Projects/EventTest/5.PnG");
            images[5] = Image.FromFile("C:/Users/Techedin/source/repos/CSC202 Projects/EventTest/6.PnG");
            images[6] = Image.FromFile("C:/Users/Techedin/source/repos/CSC202 Projects/EventTest/7.PnG");
            images[7] = Image.FromFile("C:/Users/Techedin/source/repos/CSC202 Projects/EventTest/8.PnG");
            images[8] = Image.FromFile("C:/Users/Techedin/source/repos/CSC202 Projects/EventTest/9.PnG");
            images[9] = Image.FromFile("C:/Users/Techedin/source/repos/CSC202 Projects/EventTest/10.PnG");
            images[10] = Image.FromFile("C:/Users/Techedin/source/repos/CSC202 Projects/EventTest/11.JPG");
            images[11] = Image.FromFile("C:/Users/Techedin/source/repos/CSC202 Projects/EventTest/12.PnG");
            images[12] = Image.FromFile("C:/Users/Techedin/source/repos/CSC202 Projects/EventTest/13.PnG");
            images[13] = Image.FromFile("C:/Users/Techedin/source/repos/CSC202 Projects/EventTest/14.PnG");
            //References to my picture boxes
            cardDisplay[0] = Card1;
            cardDisplay[1] = Card2;
            cardDisplay[2] = Card3;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Set text in text box to a referencable string
            string str = textBox4.Text;
            //check string for all lower case, uppercase, and numbers 0-9 for validation
            if (Regex.IsMatch(str, "^[a-zA-Z0-9]*$"))
            {

                MessageBox.Show("valid string a-z, 0-9");
                //Use streamwrite to write string into selected textFile
                using (StreamWriter fileWriter = File.AppendText(textFile))
                {
                    fileWriter.WriteLine(textBox4.Text.ToString());

                }
            }
            else
            {
                MessageBox.Show("NOT VALID char or #");
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            //Check if the file exists
            if (File.Exists(textFile))
            {
                //Grab all lines in file and assign it to a string array
                string[] linesInFile = File.ReadAllLines(textFile);
                //use a stream reader to read the line in file
                using (StreamReader file = new StreamReader(textFile))
                    //forech loop (Runs loop for every string in the textFile)
                    foreach (string line in linesInFile)
                    {
                        MessageBox.Show(line);

                    }
            }
            else
            {
                MessageBox.Show("File doesn't exist yet");
            }

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void RoundButton_Click(object sender, EventArgs e)
        {
            //Check Text Box for a double
            if (double.TryParse(textBox2.Text, out numToRound))
            {
                //Round to two decimal points
                numToRound = Math.Round((Double)numToRound, 2);
                textBox2.Text = numToRound.ToString();
            }
            else
            {
                MessageBox.Show("Not A Valid Number");
            }
        }

        private void RollDiceButton(object sender, EventArgs e)
        {
            //Random number between 1 and 20 and some math
            Random random = new Random();
            die = random.Next(1, 20);
            MessageBox.Show("Random Die = " + die);
            textBox3.Text = die.ToString();
            die--;
            MessageBox.Show("Random Die - 1 = " + die);
            die = die + 2;
            MessageBox.Show("Random Die + 1 = " + die);
        }

        private void IntegerCheckButton(object sender, EventArgs e)
        {
            //Check to see is there is a number in text box
            if (int.TryParse(textBox1.Text, out number))
            {
                MessageBox.Show("Valid Number");
            }
            else
            {
                MessageBox.Show("Not a Valid Number");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Delete refernced file
            File.Delete(textFile);
        }

        private void DrawCards_Click(object sender, EventArgs e)
        {
            //Make a random
            Random random = new Random();
            //Call function
            DrawCards(3);
            //Draw cards function
            void DrawCards(int i)
            {
                //A For Loop
                for (int k = 0; k < i; k++)
                {
                    //Change card displays to the drawn card image
                    cardDisplay[k].Image = images[random.Next(0, 13)];
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Simple while loop
            int i = 1;
            while (i <= 5)
            {
                MessageBox.Show(i.ToString()); ;
                i++;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //simple do while loop
            int i = 1;
            do
            {
                MessageBox.Show(i.ToString()); ;
                i++;
            }
            while (i < 5);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Rainbowbutton_Click(object sender, EventArgs e)
        {
            Random rndColor = new Random();
            // Save selection
            var oldStart = RainbowTextbox.SelectionStart;
            var oldLength = RainbowTextbox.SelectionLength;


            // Select the text to change
            for (int i = 0; i < RainbowTextbox.TextLength; i++)
            {
                //Got the color randomizer from the web but made it apply to each char in a string via counting up to the length of the string.
                Color randomColor = Color.FromArgb(rndColor.Next(256), rndColor.Next(256), rndColor.Next(256));
                RainbowTextbox.Select(i, 1);
                // Change color
                RainbowTextbox.SelectionColor = randomColor;
            }

            // Restore selection
            RainbowTextbox.Select(oldStart, oldLength);
        }

        //All the sound were pulled from royalty free sites 
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {

                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Techedin\source\repos\CSC202 Projects\EventTest\cat.wav");
                player.Stop();
                player.Play();
            }
            catch
            {
                MessageBox.Show("WAV file doesn't exist. Please add one to the file");
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //try and catch so code doesn't crash if media isn't found
            try
            {
                //Initalize Player
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Techedin\source\repos\CSC202 Projects\EventTest\music.wav");
                //Stop any previous sound
                player.Stop();
                //Play sound
                player.Play();
            }
            catch
            {
                MessageBox.Show("WAV file doesn't exist. Please add one to the file");
            }


        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Techedin\source\repos\CSC202 Projects\EventTest\cow.wav");
                player.Stop();
                player.Play();
            }
            catch
            {
                MessageBox.Show("WAV file doesn't exist. Please add one to the file");
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            //Add to list
            groceries.Add(GroceryTextbox.Text);
            //Read list
            for (int i = 0; i < groceries.Count; i++)
            {
                MessageBox.Show(groceries[i]);
            }


        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < groceries.Count; i++)
            {
                //Checks the text box to remove 
                if (groceries[i].Equals(removeItem.Text))
                {
                    groceries.RemoveAt(i);
                }
                try
                {
                    MessageBox.Show(groceries[i]);
                }
                catch
                {

                }


            }


        }
    }
}
