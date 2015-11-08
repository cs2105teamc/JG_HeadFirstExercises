namespace Chapter6_Ex1
{
    partial class frmPartyPlanner
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
            this.tcParty = new System.Windows.Forms.TabControl();
            this.tabDinneryParty = new System.Windows.Forms.TabPage();
            this.tabBirthdayParty = new System.Windows.Forms.TabPage();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.lbCost = new System.Windows.Forms.Label();
            this.cbHealthy = new System.Windows.Forms.CheckBox();
            this.cbFancy = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudNumberOfPeople = new System.Windows.Forms.NumericUpDown();
            this.tbBirthdayCost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFancyBirthday = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudBirthday = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTooLong = new System.Windows.Forms.Label();
            this.tbCakeWriting = new System.Windows.Forms.TextBox();
            this.tcParty.SuspendLayout();
            this.tabDinneryParty.SuspendLayout();
            this.tabBirthdayParty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBirthday)).BeginInit();
            this.SuspendLayout();
            // 
            // tcParty
            // 
            this.tcParty.Controls.Add(this.tabDinneryParty);
            this.tcParty.Controls.Add(this.tabBirthdayParty);
            this.tcParty.Location = new System.Drawing.Point(12, 12);
            this.tcParty.Name = "tcParty";
            this.tcParty.SelectedIndex = 0;
            this.tcParty.Size = new System.Drawing.Size(228, 203);
            this.tcParty.TabIndex = 6;
            // 
            // tabDinneryParty
            // 
            this.tabDinneryParty.Controls.Add(this.tbCost);
            this.tabDinneryParty.Controls.Add(this.lbCost);
            this.tabDinneryParty.Controls.Add(this.cbHealthy);
            this.tabDinneryParty.Controls.Add(this.cbFancy);
            this.tabDinneryParty.Controls.Add(this.label1);
            this.tabDinneryParty.Controls.Add(this.nudNumberOfPeople);
            this.tabDinneryParty.Location = new System.Drawing.Point(4, 22);
            this.tabDinneryParty.Name = "tabDinneryParty";
            this.tabDinneryParty.Padding = new System.Windows.Forms.Padding(3);
            this.tabDinneryParty.Size = new System.Drawing.Size(220, 177);
            this.tabDinneryParty.TabIndex = 0;
            this.tabDinneryParty.Text = "Dinner Party";
            this.tabDinneryParty.UseVisualStyleBackColor = true;
            // 
            // tabBirthdayParty
            // 
            this.tabBirthdayParty.Controls.Add(this.tbCakeWriting);
            this.tabBirthdayParty.Controls.Add(this.lbTooLong);
            this.tabBirthdayParty.Controls.Add(this.label4);
            this.tabBirthdayParty.Controls.Add(this.tbBirthdayCost);
            this.tabBirthdayParty.Controls.Add(this.label2);
            this.tabBirthdayParty.Controls.Add(this.cbFancyBirthday);
            this.tabBirthdayParty.Controls.Add(this.label3);
            this.tabBirthdayParty.Controls.Add(this.nudBirthday);
            this.tabBirthdayParty.Location = new System.Drawing.Point(4, 22);
            this.tabBirthdayParty.Name = "tabBirthdayParty";
            this.tabBirthdayParty.Padding = new System.Windows.Forms.Padding(3);
            this.tabBirthdayParty.Size = new System.Drawing.Size(220, 177);
            this.tabBirthdayParty.TabIndex = 1;
            this.tabBirthdayParty.Text = "Birthday Party";
            this.tabBirthdayParty.UseVisualStyleBackColor = true;
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(68, 102);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(100, 20);
            this.tbCost.TabIndex = 11;
            // 
            // lbCost
            // 
            this.lbCost.AutoSize = true;
            this.lbCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCost.Location = new System.Drawing.Point(27, 105);
            this.lbCost.Name = "lbCost";
            this.lbCost.Size = new System.Drawing.Size(32, 13);
            this.lbCost.TabIndex = 10;
            this.lbCost.Text = "Cost";
            // 
            // cbHealthy
            // 
            this.cbHealthy.AutoSize = true;
            this.cbHealthy.Location = new System.Drawing.Point(27, 85);
            this.cbHealthy.Name = "cbHealthy";
            this.cbHealthy.Size = new System.Drawing.Size(96, 17);
            this.cbHealthy.TabIndex = 9;
            this.cbHealthy.Text = "Healthy Option";
            this.cbHealthy.UseVisualStyleBackColor = true;
            this.cbHealthy.CheckedChanged += new System.EventHandler(this.cbHealthy_CheckedChanged);
            // 
            // cbFancy
            // 
            this.cbFancy.AutoSize = true;
            this.cbFancy.Checked = true;
            this.cbFancy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFancy.Location = new System.Drawing.Point(27, 62);
            this.cbFancy.Name = "cbFancy";
            this.cbFancy.Size = new System.Drawing.Size(115, 17);
            this.cbFancy.TabIndex = 8;
            this.cbFancy.Text = "Fancy Decorations";
            this.cbFancy.UseVisualStyleBackColor = true;
            this.cbFancy.CheckedChanged += new System.EventHandler(this.cbFancy_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Number of people";
            // 
            // nudNumberOfPeople
            // 
            this.nudNumberOfPeople.Location = new System.Drawing.Point(27, 36);
            this.nudNumberOfPeople.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudNumberOfPeople.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfPeople.Name = "nudNumberOfPeople";
            this.nudNumberOfPeople.Size = new System.Drawing.Size(120, 20);
            this.nudNumberOfPeople.TabIndex = 6;
            this.nudNumberOfPeople.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudNumberOfPeople.ValueChanged += new System.EventHandler(this.nudNumberOfPeople_ValueChanged);
            // 
            // tbBirthdayCost
            // 
            this.tbBirthdayCost.Location = new System.Drawing.Point(70, 135);
            this.tbBirthdayCost.Name = "tbBirthdayCost";
            this.tbBirthdayCost.Size = new System.Drawing.Size(100, 20);
            this.tbBirthdayCost.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Cost";
            // 
            // cbFancyBirthday
            // 
            this.cbFancyBirthday.AutoSize = true;
            this.cbFancyBirthday.Checked = true;
            this.cbFancyBirthday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFancyBirthday.Location = new System.Drawing.Point(29, 61);
            this.cbFancyBirthday.Name = "cbFancyBirthday";
            this.cbFancyBirthday.Size = new System.Drawing.Size(115, 17);
            this.cbFancyBirthday.TabIndex = 14;
            this.cbFancyBirthday.Text = "Fancy Decorations";
            this.cbFancyBirthday.UseVisualStyleBackColor = true;
            this.cbFancyBirthday.CheckedChanged += new System.EventHandler(this.cbFancyBirthday_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Number of people";
            // 
            // nudBirthday
            // 
            this.nudBirthday.Location = new System.Drawing.Point(29, 35);
            this.nudBirthday.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudBirthday.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBirthday.Name = "nudBirthday";
            this.nudBirthday.Size = new System.Drawing.Size(120, 20);
            this.nudBirthday.TabIndex = 12;
            this.nudBirthday.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudBirthday.ValueChanged += new System.EventHandler(this.nudBirthday_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Cake Writing";
            // 
            // lbTooLong
            // 
            this.lbTooLong.AutoSize = true;
            this.lbTooLong.BackColor = System.Drawing.Color.Red;
            this.lbTooLong.Location = new System.Drawing.Point(114, 85);
            this.lbTooLong.Name = "lbTooLong";
            this.lbTooLong.Size = new System.Drawing.Size(63, 13);
            this.lbTooLong.TabIndex = 19;
            this.lbTooLong.Text = "TOO LONG";
            // 
            // tbCakeWriting
            // 
            this.tbCakeWriting.Location = new System.Drawing.Point(29, 101);
            this.tbCakeWriting.Name = "tbCakeWriting";
            this.tbCakeWriting.Size = new System.Drawing.Size(151, 20);
            this.tbCakeWriting.TabIndex = 20;
            this.tbCakeWriting.Text = "Happy Birthday";
            this.tbCakeWriting.TextChanged += new System.EventHandler(this.tbCakeWriting_TextChanged);
            // 
            // frmPartyPlanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 229);
            this.Controls.Add(this.tcParty);
            this.Name = "frmPartyPlanner";
            this.Text = "Party Planner";
            this.tcParty.ResumeLayout(false);
            this.tabDinneryParty.ResumeLayout(false);
            this.tabDinneryParty.PerformLayout();
            this.tabBirthdayParty.ResumeLayout(false);
            this.tabBirthdayParty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBirthday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcParty;
        private System.Windows.Forms.TabPage tabDinneryParty;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.Label lbCost;
        private System.Windows.Forms.CheckBox cbHealthy;
        private System.Windows.Forms.CheckBox cbFancy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudNumberOfPeople;
        private System.Windows.Forms.TabPage tabBirthdayParty;
        private System.Windows.Forms.TextBox tbCakeWriting;
        private System.Windows.Forms.Label lbTooLong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbBirthdayCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbFancyBirthday;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudBirthday;
    }
}

