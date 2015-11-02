namespace Chapter5_Ex1
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
            this.nudNumberOfPeople = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFancy = new System.Windows.Forms.CheckBox();
            this.cbHealthy = new System.Windows.Forms.CheckBox();
            this.lbCost = new System.Windows.Forms.Label();
            this.tbCost = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // nudNumberOfPeople
            // 
            this.nudNumberOfPeople.Location = new System.Drawing.Point(12, 29);
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
            this.nudNumberOfPeople.TabIndex = 0;
            this.nudNumberOfPeople.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudNumberOfPeople.ValueChanged += new System.EventHandler(this.nudNumberOfPeople_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of people";
            // 
            // cbFancy
            // 
            this.cbFancy.AutoSize = true;
            this.cbFancy.Checked = true;
            this.cbFancy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFancy.Location = new System.Drawing.Point(12, 55);
            this.cbFancy.Name = "cbFancy";
            this.cbFancy.Size = new System.Drawing.Size(115, 17);
            this.cbFancy.TabIndex = 2;
            this.cbFancy.Text = "Fancy Decorations";
            this.cbFancy.UseVisualStyleBackColor = true;
            this.cbFancy.CheckedChanged += new System.EventHandler(this.cbFancy_CheckedChanged);
            // 
            // cbHealthy
            // 
            this.cbHealthy.AutoSize = true;
            this.cbHealthy.Location = new System.Drawing.Point(12, 78);
            this.cbHealthy.Name = "cbHealthy";
            this.cbHealthy.Size = new System.Drawing.Size(96, 17);
            this.cbHealthy.TabIndex = 3;
            this.cbHealthy.Text = "Healthy Option";
            this.cbHealthy.UseVisualStyleBackColor = true;
            this.cbHealthy.CheckedChanged += new System.EventHandler(this.cbHealthy_CheckedChanged);
            // 
            // lbCost
            // 
            this.lbCost.AutoSize = true;
            this.lbCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCost.Location = new System.Drawing.Point(12, 98);
            this.lbCost.Name = "lbCost";
            this.lbCost.Size = new System.Drawing.Size(32, 13);
            this.lbCost.TabIndex = 4;
            this.lbCost.Text = "Cost";
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(53, 95);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(100, 20);
            this.tbCost.TabIndex = 5;
            // 
            // frmPartyPlanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 156);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.lbCost);
            this.Controls.Add(this.cbHealthy);
            this.Controls.Add(this.cbFancy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudNumberOfPeople);
            this.Name = "frmPartyPlanner";
            this.Text = "Party Planner";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudNumberOfPeople;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbFancy;
        private System.Windows.Forms.CheckBox cbHealthy;
        private System.Windows.Forms.Label lbCost;
        private System.Windows.Forms.TextBox tbCost;
    }
}

