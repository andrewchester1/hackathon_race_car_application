using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hackathon_race_car_application
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void start_game_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure that you would like to close the form?";
            const string caption = "Form Closing";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (result == DialogResult.Yes)
            {
                // Closes the Form.
                Application.Exit();
            }
        }

        private void instructions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Use Arrorw keys to navigate the road, and avoid enemies", "Instructions");
        }
    }
}
