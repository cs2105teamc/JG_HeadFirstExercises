namespace Lab1
{
    partial class frmDayAtRaces
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDayAtRaces));
            this.raceTimer = new System.Windows.Forms.Timer(this.components);
            this.pbRaceTrack = new System.Windows.Forms.PictureBox();
            this.pbDog0 = new System.Windows.Forms.PictureBox();
            this.pbDog1 = new System.Windows.Forms.PictureBox();
            this.pbDog2 = new System.Windows.Forms.PictureBox();
            this.pbDog3 = new System.Windows.Forms.PictureBox();
            this.btnRace = new System.Windows.Forms.Button();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.cbxDog = new System.Windows.Forms.ComboBox();
            this.bdxBettingParlour = new System.Windows.Forms.GroupBox();
            this.lblMinimumBet = new System.Windows.Forms.Label();
            this.rbAl = new System.Windows.Forms.RadioButton();
            this.rbBob = new System.Windows.Forms.RadioButton();
            this.rbJoe = new System.Windows.Forms.RadioButton();
            this.lbName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbBets = new System.Windows.Forms.Label();
            this.lbJoe = new System.Windows.Forms.Label();
            this.lbBob = new System.Windows.Forms.Label();
            this.lbAl = new System.Windows.Forms.Label();
            this.btnBets = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbRaceTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.bdxBettingParlour.SuspendLayout();
            this.SuspendLayout();
            // 
            // raceTimer
            // 
            this.raceTimer.Interval = 10;
            this.raceTimer.Tick += new System.EventHandler(this.raceTimer_Tick);
            // 
            // pbRaceTrack
            // 
            this.pbRaceTrack.Image = ((System.Drawing.Image)(resources.GetObject("pbRaceTrack.Image")));
            this.pbRaceTrack.Location = new System.Drawing.Point(0, 0);
            this.pbRaceTrack.Name = "pbRaceTrack";
            this.pbRaceTrack.Size = new System.Drawing.Size(977, 286);
            this.pbRaceTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRaceTrack.TabIndex = 0;
            this.pbRaceTrack.TabStop = false;
            // 
            // pbDog0
            // 
            this.pbDog0.Image = ((System.Drawing.Image)(resources.GetObject("pbDog0.Image")));
            this.pbDog0.Location = new System.Drawing.Point(24, 0);
            this.pbDog0.Name = "pbDog0";
            this.pbDog0.Size = new System.Drawing.Size(125, 50);
            this.pbDog0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDog0.TabIndex = 1;
            this.pbDog0.TabStop = false;
            // 
            // pbDog1
            // 
            this.pbDog1.Image = ((System.Drawing.Image)(resources.GetObject("pbDog1.Image")));
            this.pbDog1.Location = new System.Drawing.Point(24, 74);
            this.pbDog1.Name = "pbDog1";
            this.pbDog1.Size = new System.Drawing.Size(125, 50);
            this.pbDog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDog1.TabIndex = 2;
            this.pbDog1.TabStop = false;
            // 
            // pbDog2
            // 
            this.pbDog2.Image = ((System.Drawing.Image)(resources.GetObject("pbDog2.Image")));
            this.pbDog2.Location = new System.Drawing.Point(24, 152);
            this.pbDog2.Name = "pbDog2";
            this.pbDog2.Size = new System.Drawing.Size(125, 50);
            this.pbDog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDog2.TabIndex = 3;
            this.pbDog2.TabStop = false;
            // 
            // pbDog3
            // 
            this.pbDog3.Image = ((System.Drawing.Image)(resources.GetObject("pbDog3.Image")));
            this.pbDog3.Location = new System.Drawing.Point(24, 225);
            this.pbDog3.Name = "pbDog3";
            this.pbDog3.Size = new System.Drawing.Size(125, 50);
            this.pbDog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDog3.TabIndex = 4;
            this.pbDog3.TabStop = false;
            // 
            // btnRace
            // 
            this.btnRace.Location = new System.Drawing.Point(817, 321);
            this.btnRace.Name = "btnRace";
            this.btnRace.Size = new System.Drawing.Size(151, 103);
            this.btnRace.TabIndex = 5;
            this.btnRace.Text = "Race!";
            this.btnRace.UseVisualStyleBackColor = true;
            this.btnRace.Click += new System.EventHandler(this.btnRace_Click);
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(149, 419);
            this.nudAmount.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudAmount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(65, 20);
            this.nudAmount.TabIndex = 6;
            this.nudAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // cbxDog
            // 
            this.cbxDog.FormattingEnabled = true;
            this.cbxDog.Location = new System.Drawing.Point(328, 418);
            this.cbxDog.Name = "cbxDog";
            this.cbxDog.Size = new System.Drawing.Size(91, 21);
            this.cbxDog.TabIndex = 7;
            // 
            // bdxBettingParlour
            // 
            this.bdxBettingParlour.Controls.Add(this.lblMinimumBet);
            this.bdxBettingParlour.Controls.Add(this.rbAl);
            this.bdxBettingParlour.Controls.Add(this.rbBob);
            this.bdxBettingParlour.Controls.Add(this.rbJoe);
            this.bdxBettingParlour.Location = new System.Drawing.Point(12, 292);
            this.bdxBettingParlour.Name = "bdxBettingParlour";
            this.bdxBettingParlour.Size = new System.Drawing.Size(212, 115);
            this.bdxBettingParlour.TabIndex = 8;
            this.bdxBettingParlour.TabStop = false;
            this.bdxBettingParlour.Text = "Betting Parlour";
            // 
            // lblMinimumBet
            // 
            this.lblMinimumBet.AutoSize = true;
            this.lblMinimumBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimumBet.Location = new System.Drawing.Point(12, 20);
            this.lblMinimumBet.Name = "lblMinimumBet";
            this.lblMinimumBet.Size = new System.Drawing.Size(100, 13);
            this.lblMinimumBet.TabIndex = 3;
            this.lblMinimumBet.Text = "Minimum Bet: €5";
            // 
            // rbAl
            // 
            this.rbAl.AutoSize = true;
            this.rbAl.Location = new System.Drawing.Point(12, 82);
            this.rbAl.Name = "rbAl";
            this.rbAl.Size = new System.Drawing.Size(34, 17);
            this.rbAl.TabIndex = 2;
            this.rbAl.TabStop = true;
            this.rbAl.Text = "Al";
            this.rbAl.UseVisualStyleBackColor = true;
            this.rbAl.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rbBob
            // 
            this.rbBob.AutoSize = true;
            this.rbBob.Location = new System.Drawing.Point(12, 59);
            this.rbBob.Name = "rbBob";
            this.rbBob.Size = new System.Drawing.Size(44, 17);
            this.rbBob.TabIndex = 1;
            this.rbBob.TabStop = true;
            this.rbBob.Text = "Bob";
            this.rbBob.UseVisualStyleBackColor = true;
            this.rbBob.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rbJoe
            // 
            this.rbJoe.AutoSize = true;
            this.rbJoe.Location = new System.Drawing.Point(12, 36);
            this.rbJoe.Name = "rbJoe";
            this.rbJoe.Size = new System.Drawing.Size(42, 17);
            this.rbJoe.TabIndex = 0;
            this.rbJoe.TabStop = true;
            this.rbJoe.Text = "Joe";
            this.rbJoe.UseVisualStyleBackColor = true;
            this.rbJoe.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(30, 421);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(16, 13);
            this.lbName.TabIndex = 9;
            this.lbName.Text = "---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "euro on dog number";
            // 
            // lbBets
            // 
            this.lbBets.AutoSize = true;
            this.lbBets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBets.Location = new System.Drawing.Point(315, 312);
            this.lbBets.Name = "lbBets";
            this.lbBets.Size = new System.Drawing.Size(32, 13);
            this.lbBets.TabIndex = 12;
            this.lbBets.Text = "Bets";
            // 
            // lbJoe
            // 
            this.lbJoe.AutoSize = true;
            this.lbJoe.Location = new System.Drawing.Point(318, 330);
            this.lbJoe.Name = "lbJoe";
            this.lbJoe.Size = new System.Drawing.Size(108, 13);
            this.lbJoe.TabIndex = 13;
            this.lbJoe.Text = "Joe hasn\'t placed bet";
            // 
            // lbBob
            // 
            this.lbBob.AutoSize = true;
            this.lbBob.Location = new System.Drawing.Point(318, 355);
            this.lbBob.Name = "lbBob";
            this.lbBob.Size = new System.Drawing.Size(110, 13);
            this.lbBob.TabIndex = 14;
            this.lbBob.Text = "Bob hasn\'t placed bet";
            // 
            // lbAl
            // 
            this.lbAl.AutoSize = true;
            this.lbAl.Location = new System.Drawing.Point(318, 380);
            this.lbAl.Name = "lbAl";
            this.lbAl.Size = new System.Drawing.Size(100, 13);
            this.lbAl.TabIndex = 15;
            this.lbAl.Text = "Al hasn\'t placed bet";
            // 
            // btnBets
            // 
            this.btnBets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBets.Location = new System.Drawing.Point(91, 419);
            this.btnBets.Name = "btnBets";
            this.btnBets.Size = new System.Drawing.Size(43, 23);
            this.btnBets.TabIndex = 16;
            this.btnBets.Text = "Bets";
            this.btnBets.UseVisualStyleBackColor = true;
            this.btnBets.Click += new System.EventHandler(this.btnBets_Click);
            // 
            // frmDayAtRaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 463);
            this.Controls.Add(this.btnBets);
            this.Controls.Add(this.lbAl);
            this.Controls.Add(this.lbBob);
            this.Controls.Add(this.lbJoe);
            this.Controls.Add(this.lbBets);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.bdxBettingParlour);
            this.Controls.Add(this.cbxDog);
            this.Controls.Add(this.nudAmount);
            this.Controls.Add(this.btnRace);
            this.Controls.Add(this.pbDog3);
            this.Controls.Add(this.pbDog2);
            this.Controls.Add(this.pbDog1);
            this.Controls.Add(this.pbDog0);
            this.Controls.Add(this.pbRaceTrack);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDayAtRaces";
            this.Text = "A Day at the Races";
            ((System.ComponentModel.ISupportInitialize)(this.pbRaceTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.bdxBettingParlour.ResumeLayout(false);
            this.bdxBettingParlour.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer raceTimer;
        private System.Windows.Forms.PictureBox pbRaceTrack;
        private System.Windows.Forms.PictureBox pbDog0;
        private System.Windows.Forms.PictureBox pbDog1;
        private System.Windows.Forms.PictureBox pbDog2;
        private System.Windows.Forms.PictureBox pbDog3;
        private System.Windows.Forms.Button btnRace;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.ComboBox cbxDog;
        private System.Windows.Forms.GroupBox bdxBettingParlour;
        private System.Windows.Forms.RadioButton rbAl;
        private System.Windows.Forms.RadioButton rbBob;
        private System.Windows.Forms.RadioButton rbJoe;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbBets;
        private System.Windows.Forms.Label lbJoe;
        private System.Windows.Forms.Label lbBob;
        private System.Windows.Forms.Label lbAl;
        private System.Windows.Forms.Label lblMinimumBet;
        private System.Windows.Forms.Button btnBets;
    }
}

