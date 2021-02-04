
namespace RacingGame
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.p3Bet = new System.Windows.Forms.Label();
            this.race = new System.Windows.Forms.Button();
            this.p2Bet = new System.Windows.Forms.Label();
            this.P1Bet = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.horseNumber = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.BettingAmount = new System.Windows.Forms.NumericUpDown();
            this.Bets = new System.Windows.Forms.Button();
            this.P3Button = new System.Windows.Forms.RadioButton();
            this.P2Button = new System.Windows.Forms.RadioButton();
            this.P1Button = new System.Windows.Forms.RadioButton();
            this.MaximumBet = new System.Windows.Forms.Label();
            this.racetrack = new System.Windows.Forms.PictureBox();
            this.racer1 = new System.Windows.Forms.PictureBox();
            this.racer2 = new System.Windows.Forms.PictureBox();
            this.racer3 = new System.Windows.Forms.PictureBox();
            this.racer4 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.horseNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BettingAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racer4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.p3Bet);
            this.groupBox1.Controls.Add(this.race);
            this.groupBox1.Controls.Add(this.p2Bet);
            this.groupBox1.Controls.Add(this.P1Bet);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.horseNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BettingAmount);
            this.groupBox1.Controls.Add(this.Bets);
            this.groupBox1.Controls.Add(this.P3Button);
            this.groupBox1.Controls.Add(this.P2Button);
            this.groupBox1.Controls.Add(this.P1Button);
            this.groupBox1.Controls.Add(this.MaximumBet);
            this.groupBox1.Location = new System.Drawing.Point(26, 296);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(925, 214);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Place Bet Here";
            // 
            // p3Bet
            // 
            this.p3Bet.BackColor = System.Drawing.SystemColors.Info;
            this.p3Bet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p3Bet.Location = new System.Drawing.Point(487, 89);
            this.p3Bet.Name = "p3Bet";
            this.p3Bet.Size = new System.Drawing.Size(290, 17);
            this.p3Bet.TabIndex = 13;
            this.p3Bet.Text = "P3 detalis";
            // 
            // race
            // 
            this.race.BackColor = System.Drawing.Color.Tan;
            this.race.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.race.FlatAppearance.BorderSize = 5;
            this.race.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.race.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.race.Location = new System.Drawing.Point(422, 119);
            this.race.Name = "race";
            this.race.Size = new System.Drawing.Size(234, 43);
            this.race.TabIndex = 9;
            this.race.Text = "START RACE";
            this.race.UseVisualStyleBackColor = false;
            this.race.Click += new System.EventHandler(this.race_Click);
            // 
            // p2Bet
            // 
            this.p2Bet.BackColor = System.Drawing.SystemColors.Info;
            this.p2Bet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p2Bet.Location = new System.Drawing.Point(487, 65);
            this.p2Bet.Name = "p2Bet";
            this.p2Bet.Size = new System.Drawing.Size(290, 17);
            this.p2Bet.TabIndex = 12;
            this.p2Bet.Text = "P2 details";
            // 
            // P1Bet
            // 
            this.P1Bet.BackColor = System.Drawing.SystemColors.Info;
            this.P1Bet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P1Bet.Location = new System.Drawing.Point(487, 41);
            this.P1Bet.Name = "P1Bet";
            this.P1Bet.Size = new System.Drawing.Size(290, 17);
            this.P1Bet.TabIndex = 11;
            this.P1Bet.Text = "P1 details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(484, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Bets";
            // 
            // horseNumber
            // 
            this.horseNumber.Location = new System.Drawing.Point(376, 86);
            this.horseNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.horseNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.horseNumber.Name = "horseNumber";
            this.horseNumber.Size = new System.Drawing.Size(64, 20);
            this.horseNumber.TabIndex = 8;
            this.horseNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Horse number";
            // 
            // BettingAmount
            // 
            this.BettingAmount.Location = new System.Drawing.Point(378, 38);
            this.BettingAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.BettingAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BettingAmount.Name = "BettingAmount";
            this.BettingAmount.Size = new System.Drawing.Size(63, 20);
            this.BettingAmount.TabIndex = 6;
            this.BettingAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Bets
            // 
            this.Bets.BackColor = System.Drawing.Color.Tan;
            this.Bets.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Bets.FlatAppearance.BorderSize = 5;
            this.Bets.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bets.Location = new System.Drawing.Point(214, 30);
            this.Bets.Name = "Bets";
            this.Bets.Size = new System.Drawing.Size(123, 36);
            this.Bets.TabIndex = 5;
            this.Bets.Text = "Place Bet";
            this.Bets.UseVisualStyleBackColor = false;
            this.Bets.Click += new System.EventHandler(this.Bets_Click);
            // 
            // P3Button
            // 
            this.P3Button.AutoSize = true;
            this.P3Button.Checked = true;
            this.P3Button.Location = new System.Drawing.Point(14, 97);
            this.P3Button.Name = "P3Button";
            this.P3Button.Size = new System.Drawing.Size(38, 17);
            this.P3Button.TabIndex = 3;
            this.P3Button.TabStop = true;
            this.P3Button.Text = "P3";
            this.P3Button.UseVisualStyleBackColor = true;
            // 
            // P2Button
            // 
            this.P2Button.AutoSize = true;
            this.P2Button.Location = new System.Drawing.Point(14, 73);
            this.P2Button.Name = "P2Button";
            this.P2Button.Size = new System.Drawing.Size(38, 17);
            this.P2Button.TabIndex = 2;
            this.P2Button.Text = "P2";
            this.P2Button.UseVisualStyleBackColor = true;
            // 
            // P1Button
            // 
            this.P1Button.AutoSize = true;
            this.P1Button.Location = new System.Drawing.Point(14, 49);
            this.P1Button.Name = "P1Button";
            this.P1Button.Size = new System.Drawing.Size(38, 17);
            this.P1Button.TabIndex = 1;
            this.P1Button.Text = "P1";
            this.P1Button.UseVisualStyleBackColor = true;
            this.P1Button.CheckedChanged += new System.EventHandler(this.P1Button_CheckedChanged);
            // 
            // MaximumBet
            // 
            this.MaximumBet.AutoSize = true;
            this.MaximumBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumBet.Location = new System.Drawing.Point(11, 24);
            this.MaximumBet.Name = "MaximumBet";
            this.MaximumBet.Size = new System.Drawing.Size(101, 17);
            this.MaximumBet.TabIndex = 0;
            this.MaximumBet.Text = "Maximum bet";
            // 
            // racetrack
            // 
            this.racetrack.BackColor = System.Drawing.Color.Transparent;
            this.racetrack.Image = ((System.Drawing.Image)(resources.GetObject("racetrack.Image")));
            this.racetrack.Location = new System.Drawing.Point(-6, -1);
            this.racetrack.Name = "racetrack";
            this.racetrack.Size = new System.Drawing.Size(957, 285);
            this.racetrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racetrack.TabIndex = 15;
            this.racetrack.TabStop = false;
            // 
            // racer1
            // 
            this.racer1.Image = ((System.Drawing.Image)(resources.GetObject("racer1.Image")));
            this.racer1.Location = new System.Drawing.Point(940, 23);
            this.racer1.Name = "racer1";
            this.racer1.Size = new System.Drawing.Size(95, 42);
            this.racer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racer1.TabIndex = 17;
            this.racer1.TabStop = false;
            // 
            // racer2
            // 
            this.racer2.Image = ((System.Drawing.Image)(resources.GetObject("racer2.Image")));
            this.racer2.Location = new System.Drawing.Point(940, 71);
            this.racer2.Name = "racer2";
            this.racer2.Size = new System.Drawing.Size(95, 42);
            this.racer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racer2.TabIndex = 18;
            this.racer2.TabStop = false;
            // 
            // racer3
            // 
            this.racer3.Image = ((System.Drawing.Image)(resources.GetObject("racer3.Image")));
            this.racer3.Location = new System.Drawing.Point(940, 133);
            this.racer3.Name = "racer3";
            this.racer3.Size = new System.Drawing.Size(95, 42);
            this.racer3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racer3.TabIndex = 19;
            this.racer3.TabStop = false;
            // 
            // racer4
            // 
            this.racer4.Image = ((System.Drawing.Image)(resources.GetObject("racer4.Image")));
            this.racer4.Location = new System.Drawing.Point(940, 194);
            this.racer4.Name = "racer4";
            this.racer4.Size = new System.Drawing.Size(95, 42);
            this.racer4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racer4.TabIndex = 20;
            this.racer4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 532);
            this.Controls.Add(this.racer4);
            this.Controls.Add(this.racer3);
            this.Controls.Add(this.racer2);
            this.Controls.Add(this.racer1);
            this.Controls.Add(this.racetrack);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.horseNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BettingAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racer4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label p3Bet;
        private System.Windows.Forms.Label p2Bet;
        private System.Windows.Forms.Label P1Bet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button race;
        private System.Windows.Forms.NumericUpDown horseNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown BettingAmount;
        private System.Windows.Forms.Button Bets;
        private System.Windows.Forms.RadioButton P3Button;
        private System.Windows.Forms.RadioButton P2Button;
        private System.Windows.Forms.RadioButton P1Button;
        private System.Windows.Forms.Label MaximumBet;
        private System.Windows.Forms.PictureBox racetrack;
        private System.Windows.Forms.PictureBox racer1;
        private System.Windows.Forms.PictureBox racer2;
        private System.Windows.Forms.PictureBox racer3;
        private System.Windows.Forms.PictureBox racer4;
    }
}

