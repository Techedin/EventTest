

/*
Ben Williams 9-12-22 
Estimated Hours Taken: 2 Hours Basic 
GUI and Input Systems
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


namespace EventTest
{

    public partial class Form1 : Form
    {
        int number;
        int die;
        double numToRound;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Button source = (Button)sender;
            source.BackColor = Color.Aquamarine;
            MessageBox.Show("The button's text is:" + source.Text);

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("The mouse was clicked at(" + e.X + ", " + e.Y + ")");
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
            if (double.TryParse(textBox2.Text, out numToRound))
            {
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
            if (int.TryParse(textBox1.Text, out number))
            {
                MessageBox.Show("Valid Number");
            }
            else
            {
                MessageBox.Show("Not a Valid Number");
            }
        }
    }
}
