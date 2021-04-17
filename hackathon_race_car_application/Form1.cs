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
            InitializeComponent();
            over.Visible = false;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(gamespeed);
            enemy(gamespeed);
            //gameover();
            collision();
            coins(gamespeed);
            coinscollection();
            livescollection();
            life1(gamespeed);
        }

        int collectedcoin = 0;
        int currentlife = 3;

        Random r = new Random();
        int x;
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

        void life1(int speed)
        {
            if (life.Top >= 500)
            {
                x = r.Next(0, 200);
                life.Location = new Point(x, -100);
            }
            else { life.Top += speed; }

        }

        void collision()
        {
            if (car.Bounds.IntersectsWith(enemy1.Bounds))
            {
                currentlife--;
                x = r.Next(0, 200);
                enemy1.Location = new Point(x, 0);
                lives.Text = "Lives=" + currentlife.ToString();
                gameover(currentlife);
            }
            if (car.Bounds.IntersectsWith(enemy2.Bounds))
            {
                currentlife--;
                x = r.Next(0, 400);
                enemy2.Location = new Point(x, 0);
                lives.Text = "Lives=" + currentlife.ToString();
                gameover(currentlife);
            }
            if (car.Bounds.IntersectsWith(enemy3.Bounds))
            {
                currentlife--;
                x = r.Next(200, 350);
                enemy3.Location = new Point(x, 0);
                lives.Text = "Lives=" + currentlife.ToString();
                gameover(currentlife);
            }
        }
        
        void gameover(int life)
        {
            if (life == 0)
            {
                timer1.Enabled = false;
                over.Visible = true;
            }
        }

        /*
                void gameover()
                {
                    if (car.Bounds.IntersectsWith(enemy1.Bounds))
                    {
                        timer1.Enabled = false;
                        over.Visible = true;
                    }
                    if (car.Bounds.IntersectsWith(enemy2.Bounds))
                    {
                        timer1.Enabled = false;
                        over.Visible = true;
                    }
                    if (car.Bounds.IntersectsWith(enemy3.Bounds))
                    {
                        timer1.Enabled = false;
                        over.Visible = true;
                    }
                }
        */
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

        int gamespeed = 1;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if(car.Left>0)
                car.Left += -8;
            }
            if (e.KeyCode == Keys.Right)
            {
                if(car.Right<380)
                car.Left += 8;
            }

            if (e.KeyCode==Keys.Up)
            {
                if (gamespeed<21)
                { gamespeed++; }
            }
            if (e.KeyCode==Keys.Down)
            {
                if (gamespeed>0)
                { gamespeed--; }
            }
        }

        private void pause_Click(object sender, EventArgs e)
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
                //Form1.Close();
                Application.Exit();
                new HomePage().Show();
            }
            if (result == DialogResult.Yes)
            {
                timer1.Enabled = true;
            }
        }
    }
}
