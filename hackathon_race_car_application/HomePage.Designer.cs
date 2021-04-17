
namespace hackathon_race_car_application
{
    partial class HomePage
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
            this.label1 = new System.Windows.Forms.Label();
            this.start_game = new System.Windows.Forms.Button();
            this.instructions = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Racing Game Application";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // start_game
            // 
            this.start_game.Location = new System.Drawing.Point(351, 82);
            this.start_game.Name = "start_game";
            this.start_game.Size = new System.Drawing.Size(112, 34);
            this.start_game.TabIndex = 1;
            this.start_game.Text = "Start Game";
            this.start_game.UseVisualStyleBackColor = true;
            this.start_game.Click += new System.EventHandler(this.start_game_Click);
            // 
            // instructions
            // 
            this.instructions.Location = new System.Drawing.Point(351, 135);
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(112, 34);
            this.instructions.TabIndex = 2;
            this.instructions.Text = "Instructions";
            this.instructions.UseVisualStyleBackColor = true;
            this.instructions.Click += new System.EventHandler(this.instructions_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(351, 189);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(112, 34);
            this.exit.TabIndex = 3;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 544);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.instructions);
            this.Controls.Add(this.start_game);
            this.Controls.Add(this.label1);
            this.Name = "HomePage";
            this.Text = "Instructions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button start_game;
        private System.Windows.Forms.Button instructions;
        private System.Windows.Forms.Button exit;
    }
}