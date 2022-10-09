

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

Ben Williams 10-6-22 / 10-8-22
Estimated Hours Taken: 4-6 Hours
Rehauling Look and Purpose while putting inheritance
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


        public bool isPlayer;

        string textFile = "file.txt";

        Image[] images = new Image[14];
        PictureBox[] cardDisplay = new PictureBox[3];

        List<string> groceries = new List<string>();

        List<string> playerNames = new List<string>();

        int gambleAmount;
        public class Player
        {
            protected string firstName;
            protected string lastName;
            protected string playerName;

            public Player(string fName, string lName, string pName)
            {
                this.firstName = fName;
                this.lastName = lName;
                this.playerName = pName;

            }
            public void AddPlayer(Player player)
            {
                MessageBox.Show("Real player name: " + firstName + " " + lastName);
                MessageBox.Show("Player tag:" + playerName);


            }
            public string getfName()
            {
                return firstName;
            }
            public string getlName()
            {
                return lastName;
            }
            public string getpName()
            {
                return playerName;
            }

        }

        public class Gambler : Player
        {
            private int potAmount;
            private DateTime date;
            private bool is21 = false;
            public Gambler(string fName, string lName, string pName, int money, DateTime birthdate) : base(fName, lName, pName)
            {
                potAmount = money;
                date = birthdate;

            }

            public void AddPlayer(Gambler gambler)
            {
                CheckAge();
                if (is21 == true)
                {
                    MessageBox.Show("Real player name: " + firstName + " " + lastName);
                    MessageBox.Show("Player tag:" + playerName);
                    MessageBox.Show("Gamble Amount: " + potAmount);
                }
                else
                {
                    MessageBox.Show("Must Be Over 21 to Gamble");
                }


            }

            public void CheckAge()
            {
                if (date.Year <= 2000)
                {
                    is21 = true;
                }
                else
                {
                    is21 = false;
                }

            }

            public int getMoneyAmount()
            {
                return potAmount;
            }

            public DateTime getBirthdate()
            {
                CheckAge();
                return date;
            }

            public bool getIs21()
            {
                return is21;
            }



        }


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

            isPlayer = false;
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




        private void button6_Click(object sender, EventArgs e)
        {
            //Delete refernced file
            File.Delete(textFile);
        }

        private void DrawCards_Click(object sender, EventArgs e)
        {

            if (isPlayer == true)
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
            else
            {
                PlayerCheckPopup();
            }

        }

        public void PlayerCheckPopup()
        {
            //Initialize new Form and components for popUP
            Form popUp = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button checkButton = new Button();
            Button cancelButton = new Button();

            Font LargeFont = new Font("Arial", 10);

            label.Text = "Please Enter Player Name to play cards";

            // Set the text of button1 to "OK".
            checkButton.Text = "Check For Player Name";
            // Set the text of button2 to "Cancel".
            cancelButton.Text = "Cancel";
            //Set location of all components
            label.SetBounds(36, 36, 372, 20);
            label.Font = LargeFont;
            textBox.SetBounds(36, 86, 700, 20);
            checkButton.SetBounds(228, 160, 160, 60);
            cancelButton.SetBounds(400, 160, 160, 60);
            checkButton.BackgroundImage = Image.FromFile("C:/Users/Techedin/source/repos/CSC202 Projects/EventTest/Resources/gold.JPG");
            cancelButton.BackgroundImage = Image.FromFile("C:/Users/Techedin/source/repos/CSC202 Projects/EventTest/Resources/gold.JPG");
            // Make button1's dialog result OK.
            checkButton.DialogResult = DialogResult.OK;
            // Make button2's dialog result Cancel.
            cancelButton.DialogResult = DialogResult.Cancel;


            // Set the setting for the form popUp 
            popUp.Text = "Player Check";
            popUp.ClientSize = new Size(796, 307);
            popUp.FormBorderStyle = FormBorderStyle.FixedDialog;
            popUp.StartPosition = FormStartPosition.CenterScreen;
            popUp.MinimizeBox = false;
            popUp.MaximizeBox = false;
            popUp.BackColor = Color.Maroon;
            //Additional formating
            // Define the border style of the form to a dialog box.
            popUp.FormBorderStyle = FormBorderStyle.FixedDialog;
            // Set the accept button of the form to button1.
            popUp.AcceptButton = checkButton;
            // Set the cancel button of the form to button2.
            popUp.CancelButton = cancelButton;
            // Set the start position of the form to the center of the screen.
            popUp.StartPosition = FormStartPosition.CenterScreen;



            //Add label, textbox and buttons to form
            popUp.Controls.Add(label);
            popUp.Controls.Add(textBox);
            popUp.Controls.Add(checkButton);
            popUp.Controls.Add(cancelButton);

            //Show popUp
            popUp.ShowDialog();



            // Determine if the check button was clicked on the dialog box.
            if (popUp.DialogResult == DialogResult.OK)
            {
                if (playerNames.Contains(textBox.Text) == true)
                {
                    MessageBox.Show("Player ID Confirmed");
                    isPlayer = true;
                }
                else
                {
                    MessageBox.Show("A Player ID needs to be created to play card");
                }
                // Optional: Call the Dispose method when you are finished with the dialog box.
                popUp.Dispose();
            }
            else
            {
                // Display a message box indicating that the Cancel button was clicked.
                MessageBox.Show("Player ID check was canceled");
                // Optional: Call the Dispose method when you are finished with the dialog box.
                popUp.Dispose();
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

        private void Card3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Check if textboxes have values
            if (String.IsNullOrEmpty(textBox1.Text) != true && String.IsNullOrEmpty(textBox2.Text) != true && String.IsNullOrEmpty(textBox3.Text) != true)
            {
                //Create player refernce 
                Player player = new Player(textBox1.Text, textBox2.Text, textBox3.Text);
                //Call Add Player
                player.AddPlayer(player);
                //Add player name to list for checking purposes
                playerNames.Add(player.getpName());
            }
            else
            {
                MessageBox.Show("All fields must not be empty");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Check if textboxes have values
            if (String.IsNullOrEmpty(textBox1.Text) != true && String.IsNullOrEmpty(textBox2.Text) != true && String.IsNullOrEmpty(textBox3.Text) != true)
            {
                //Check for int in textbox 5
                if (int.TryParse(textBox5.Text, out gambleAmount))
                {
                    //Create gambler reference
                    Gambler gambler = new Gambler(textBox1.Text, textBox2.Text, textBox3.Text, gambleAmount, monthCalendar1.SelectionStart);
                    //Call add player
                    gambler.AddPlayer(gambler);
                    //Check for 21 or over
                    if (gambler.getIs21() == true)
                    {

                        playerNames.Add(gambler.getpName());
                    }
                    else
                    {
                        MessageBox.Show("Player must be over 21 to gamble");
                    }

                }
                else
                {
                    MessageBox.Show("Gamble amount must be an number only");
                }


            }
            else
            {
                MessageBox.Show("All fields must not be empty");
            }
        }



        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Exit Application
            Application.Exit();
        }

        private void Card1_Click(object sender, EventArgs e)
        {

        }

        private void Card2_Click(object sender, EventArgs e)
        {

        }
    }
}
