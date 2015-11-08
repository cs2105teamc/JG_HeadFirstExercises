namespace Chapter6_Ex6
{
    partial class Beehive
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbWorkerBeeJob = new System.Windows.Forms.ComboBox();
            this.nudShifts = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnWork = new System.Windows.Forms.Button();
            this.gbWorker = new System.Windows.Forms.GroupBox();
            this.tbReport = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudShifts)).BeginInit();
            this.gbWorker.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Job";
            // 
            // cbWorkerBeeJob
            // 
            this.cbWorkerBeeJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWorkerBeeJob.FormattingEnabled = true;
            this.cbWorkerBeeJob.Items.AddRange(new object[] {
            "Baby bee tutoring",
            "Egg care",
            "Hive maintenance",
            "Honey manufacturing",
            "Nectar collector",
            "Sting patrol"});
            this.cbWorkerBeeJob.Location = new System.Drawing.Point(9, 42);
            this.cbWorkerBeeJob.Name = "cbWorkerBeeJob";
            this.cbWorkerBeeJob.Size = new System.Drawing.Size(243, 21);
            this.cbWorkerBeeJob.TabIndex = 2;
            // 
            // nudShifts
            // 
            this.nudShifts.Location = new System.Drawing.Point(271, 43);
            this.nudShifts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudShifts.Name = "nudShifts";
            this.nudShifts.Size = new System.Drawing.Size(90, 20);
            this.nudShifts.TabIndex = 3;
            this.nudShifts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Shifts";
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(9, 69);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(356, 23);
            this.btnAssign.TabIndex = 5;
            this.btnAssign.Text = "Assign this job to a bee";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // btnWork
            // 
            this.btnWork.Location = new System.Drawing.Point(403, 14);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(184, 105);
            this.btnWork.TabIndex = 6;
            this.btnWork.Text = "Work the next shift";
            this.btnWork.UseVisualStyleBackColor = true;
            this.btnWork.Click += new System.EventHandler(this.btnWork_Click);
            // 
            // gbWorker
            // 
            this.gbWorker.Controls.Add(this.label2);
            this.gbWorker.Controls.Add(this.cbWorkerBeeJob);
            this.gbWorker.Controls.Add(this.btnAssign);
            this.gbWorker.Controls.Add(this.label3);
            this.gbWorker.Controls.Add(this.nudShifts);
            this.gbWorker.Location = new System.Drawing.Point(12, 14);
            this.gbWorker.Name = "gbWorker";
            this.gbWorker.Size = new System.Drawing.Size(376, 105);
            this.gbWorker.TabIndex = 7;
            this.gbWorker.TabStop = false;
            this.gbWorker.Text = "Worker Bee Assignments";
            // 
            // tbReport
            // 
            this.tbReport.Location = new System.Drawing.Point(12, 125);
            this.tbReport.Multiline = true;
            this.tbReport.Name = "tbReport";
            this.tbReport.Size = new System.Drawing.Size(575, 272);
            this.tbReport.TabIndex = 8;
            // 
            // Beehive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 409);
            this.Controls.Add(this.tbReport);
            this.Controls.Add(this.gbWorker);
            this.Controls.Add(this.btnWork);
            this.Name = "Beehive";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudShifts)).EndInit();
            this.gbWorker.ResumeLayout(false);
            this.gbWorker.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbWorkerBeeJob;
        private System.Windows.Forms.NumericUpDown nudShifts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.GroupBox gbWorker;
        private System.Windows.Forms.TextBox tbReport;
    }
}

