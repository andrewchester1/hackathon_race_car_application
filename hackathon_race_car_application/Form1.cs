using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hackathon_race_car_application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Initialize Component and make 'over' label not visible
            InitializeComponent();
            over.Visible = false;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //call all methods needed
            moveline(gamespeed);
            enemy(gamespeed);
            collision();
            coins(gamespeed);
            coinscollection();
            livescollection();
            livz(gamespeed);
            shields(gamespeed);
            carShielded();

        }

        //instantiate variables to track coins, life and shield status
        int collectedcoin = 0;
        int currentlife = 3;
        bool shielded = false;

        Random r = new Random();
        int x;

        //method to move enemy car top to bottom of the screen
        void enemy(int speed)
        {
            if (enemy1.Top >= 500)
            {
                x = r.Next(0, 200);

                enemy1.Location = new Point(x, 0);
            }
            else { enemy1.Top += speed; }

            if (enemy2.Top >= 500)
            {
                x = r.Next(0, 400);

                enemy2.Location = new Point(x, 0);
            }
            else { enemy2.Top += speed; }

            if (enemy3.Top >= 500)
            {
                x = r.Next(200, 350);

                enemy3.Location = new Point(x, 0);
            }
            else { enemy3.Top += speed; }
        }

        //method to move coins top to bottom of the screen
        void coins(int speed)
        {
            if (coin1.Top >= 500)
            {
                x = r.Next(0, 200);

                coin1.Location = new Point(x, 0);
            }
            else { coin1.Top += speed; }

            if (coin2.Top >= 500)
            {
                x = r.Next(0, 200);

                coin2.Location = new Point(x, 0);
            }
            else { coin2.Top += speed; }

            if (coin3.Top >= 500)
            {
                x = r.Next(50, 300);

                coin3.Location = new Point(x, 0);
            }
            else { coin3.Top += speed; }

            if (coin4.Top >= 500)
            {
                x = r.Next(0, 400);

                coin4.Location = new Point(x, 0);
            }
            else { coin4.Top += speed; }
        }

        //method to move life icon top to bottom of the screen
        void livz(int speed)
        {
            if (life.Top >= 500)
            {
                x = r.Next(0, 200);
                life.Location = new Point(x, -100);
            }
            else { life.Top += speed; }

        }

        //setters and getters (to set and get shield status)
        public bool getShielded()
        {
            return shielded;
        }
        public void setShielded(bool s)
        {
            shielded = s;
        }

        //method to move shields icon from top to bottom of the screen
        void shields(int speed)
        {
            if (shield.Top >= 500)
            {
                x = r.Next(0, 400);
                shield.Location = new Point(x, -1000);
            }
            else { shield.Top += speed; }

        }

        //Collision method tracking collisions, lives, & shield status
        void collision()
        {
            if (car.Bounds.IntersectsWith(enemy1.Bounds))
            {
                if (getShielded() == true)
                {
                   setShielded(false);
                    x = r.Next(0, 200);
                    enemy1.Location = new Point(x, 0);
                    lives.Text = "Lives=" + currentlife.ToString();
                    gameover(currentlife);
                }
                else
                {
                    currentlife--;
                    x = r.Next(0, 200);
                    enemy1.Location = new Point(x, 0);
                    lives.Text = "Lives=" + currentlife.ToString();
                    gameover(currentlife);
                }

            }
            if (car.Bounds.IntersectsWith(enemy2.Bounds))
            {
                if (getShielded() == true)
                {
                    setShielded(false);
                    x = r.Next(0, 200);
                    enemy2.Location = new Point(x, 0);
                    lives.Text = "Lives=" + currentlife.ToString();
                    gameover(currentlife);
                }
                else
                {
                    currentlife--;
                    x = r.Next(0, 200);
                    enemy2.Location = new Point(x, 0);
                    lives.Text = "Lives=" + currentlife.ToString();
                    gameover(currentlife);
                }
            }
            if (car.Bounds.IntersectsWith(enemy3.Bounds))
            {
                if (getShielded() == true)
                {
                    setShielded(false);
                    x = r.Next(0, 200);
                    enemy3.Location = new Point(x, 0);
                    lives.Text = "Lives=" + currentlife.ToString();
                    gameover(currentlife);
                }
                else
                {
                    currentlife--;
                    x = r.Next(0, 200);
                    enemy3.Location = new Point(x, 0);
                    lives.Text = "Lives=" + currentlife.ToString();
                    gameover(currentlife);
                }
            }
        }
        
        //method to stop game when life gets to 0
        void gameover(int life)
        {
            if (life == 0)
            {
                timer1.Enabled = false;
                over.Visible = true;
            }
        }

        //method to move everything in window
        void moveline(int speed)
        {
            if(pictureBox1.Top >=500)
            { pictureBox1.Top = 0;  }
            else { pictureBox1.Top += speed; }

            if (pictureBox2.Top >= 500)
            { pictureBox2.Top = 0; }
            else { pictureBox2.Top += speed; }

            if (pictureBox3.Top >= 500)
            { pictureBox3.Top = 0; }
            else { pictureBox3.Top += speed; }

            if (pictureBox4.Top >= 500)
            { pictureBox4.Top = 0; }
            else { pictureBox4.Top += speed; }
        }

        //method sets shield status to true
        void carShielded()
        {
            if (car.Bounds.IntersectsWith(shield.Bounds))
            {
                setShielded(true);
                x = r.Next(0, 200);
                shield.Location = new Point(x, 0);
            }

        }

        //Increase live value by one if car hits life icon
        void livescollection()
        {
            if (car.Bounds.IntersectsWith(life.Bounds))
            {
                currentlife++;
                lives.Text = "Lives=" + currentlife.ToString();
                x = r.Next(200, 350);
                life.Location = new Point(x, 0);
            }
        }

        //method to collect coins if car hits them
        void coinscollection()
        {
            if (car.Bounds.IntersectsWith(coin1.Bounds))
            {
                collectedcoin++;
                coin_count.Text  =  "Coins=" + collectedcoin.ToString();
                x = r.Next(0, 400);
                coin1.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin2.Bounds))
            {
                collectedcoin++;
                coin_count.Text = "Coins=" + collectedcoin.ToString();
                x = r.Next(0, 400);
                coin2.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin3.Bounds))
            {
                collectedcoin++;
                coin_count.Text = "Coins=" + collectedcoin.ToString();
                x = r.Next(0, 400);
                coin3.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin4.Bounds))
            {
                collectedcoin++;
                coin_count.Text = "Coins=" + collectedcoin.ToString();
                x = r.Next(0, 400);
                coin4.Location = new Point(x, 0);
            }
        }

        //default game speed
        int gamespeed = 1;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        

        private void pause_Click(object sender, EventArgs e)
        {
            
        }

        //moves car left to right on screen also increases and decreases game speed
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (car.Left > 0)
                    car.Left += -8;
            }
            if (e.KeyCode == Keys.Right)
            {
                if (car.Right < 380)
                    car.Left += 8;
            }

            if (e.KeyCode == Keys.Up)
            {
                if (gamespeed < 21)
                { gamespeed++; }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (gamespeed > 0)
                { gamespeed--; }
            }
            if (e.KeyCode == Keys.Escape)
            {
                pause_func();
            }

        }
        //pause button. 
        private void pause_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        //pause function stps the game when called
        void pause_func()
        {
            timer1.Enabled = false;

            const string message = "Would you like to Resume?";
            const string caption = "Pause";
            var result = MessageBox.Show(message, caption,
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (result == DialogResult.No)
            {
                // Closes the Form.
                Application.Exit();
            }
            if (result == DialogResult.Yes)
            {
                timer1.Enabled = true;
            }
        }
        //pause button
        private void pause_Click_1(object sender, MouseEventArgs e)
            {
            timer1.Enabled = false;

            const string message = "Would you like to Resume?";
            const string caption = "Pause";
            var result = MessageBox.Show(message, caption,
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (result == DialogResult.No)
            {
            // Closes the Form.
            Application.Exit();
            }
            if (result == DialogResult.Yes)
            {
            timer1.Enabled = true;
            }
        }

        private void pause_Click_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
