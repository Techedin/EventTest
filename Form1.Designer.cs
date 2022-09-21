
namespace EventTest
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.DrawCards = new System.Windows.Forms.Button();
            this.Card1 = new System.Windows.Forms.PictureBox();
            this.Card2 = new System.Windows.Forms.PictureBox();
            this.Card3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(3, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Write to File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 140);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(89, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(134, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 41);
            this.button2.TabIndex = 2;
            this.button2.Text = "Check Integer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.IntegerCheckButton);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(19, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter In a Number\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(0, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter In a Number\r\n with more than 3 decimals";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(134, 200);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 41);
            this.button3.TabIndex = 5;
            this.button3.Text = "Round to 2 decimal places";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.RoundButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(22, 221);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(89, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(19, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Rolled Dice Number";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(134, 276);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 41);
            this.button4.TabIndex = 8;
            this.button4.Text = "Roll thy Dice!!";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.RollDiceButton);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(3, 297);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 20);
            this.textBox3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(418, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(428, 39);
            this.label4.TabIndex = 10;
            this.label4.Text = "The Player Guild Industries";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::EventTest.Properties.Resources._5_The_Player_Guild;
            this.pictureBox1.Image = global::EventTest.Properties.Resources._5_The_Player_Guild;
            this.pictureBox1.Location = new System.Drawing.Point(717, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(22, 28);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(252, 20);
            this.textBox4.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(-2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(298, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Write Something to the File";
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(191, 62);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(146, 31);
            this.button5.TabIndex = 14;
            this.button5.Text = "Read the File";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(280, 28);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 20);
            this.button6.TabIndex = 15;
            this.button6.Text = "Clear Current File";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // DrawCards
            // 
            this.DrawCards.Location = new System.Drawing.Point(464, 121);
            this.DrawCards.Name = "DrawCards";
            this.DrawCards.Size = new System.Drawing.Size(118, 37);
            this.DrawCards.TabIndex = 16;
            this.DrawCards.Text = "Click to Draw Some Cards";
            this.DrawCards.UseVisualStyleBackColor = true;
            this.DrawCards.Click += new System.EventHandler(this.DrawCards_Click);
            // 
            // Card1
            // 
            this.Card1.Location = new System.Drawing.Point(329, 221);
            this.Card1.Name = "Card1";
            this.Card1.Size = new System.Drawing.Size(127, 167);
            this.Card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card1.TabIndex = 17;
            this.Card1.TabStop = false;
            // 
            // Card2
            // 
            this.Card2.Location = new System.Drawing.Point(464, 221);
            this.Card2.Name = "Card2";
            this.Card2.Size = new System.Drawing.Size(127, 167);
            this.Card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card2.TabIndex = 18;
            this.Card2.TabStop = false;

            // 
            // Card3
            // 
            this.Card3.Location = new System.Drawing.Point(597, 221);
            this.Card3.Name = "Card3";
            this.Card3.Size = new System.Drawing.Size(127, 167);
            this.Card3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card3.TabIndex = 19;
            this.Card3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(858, 450);
            this.Controls.Add(this.Card3);
            this.Controls.Add(this.Card2);
            this.Controls.Add(this.Card1);
            this.Controls.Add(this.DrawCards);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button DrawCards;
        private System.Windows.Forms.PictureBox Card1;
        private System.Windows.Forms.PictureBox Card2;
        private System.Windows.Forms.PictureBox Card3;
    }
}

