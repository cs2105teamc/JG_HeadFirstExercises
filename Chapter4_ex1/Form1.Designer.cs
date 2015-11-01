namespace Chapter4_ex1
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
            this.lblStartMileage = new System.Windows.Forms.Label();
            this.lblEndMileage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.nudStarting = new System.Windows.Forms.NumericUpDown();
            this.nudEnding = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudStarting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnding)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStartMileage
            // 
            this.lblStartMileage.AutoSize = true;
            this.lblStartMileage.Location = new System.Drawing.Point(25, 29);
            this.lblStartMileage.Name = "lblStartMileage";
            this.lblStartMileage.Size = new System.Drawing.Size(83, 13);
            this.lblStartMileage.TabIndex = 0;
            this.lblStartMileage.Text = "Starting Mileage";
            // 
            // lblEndMileage
            // 
            this.lblEndMileage.AutoSize = true;
            this.lblEndMileage.Location = new System.Drawing.Point(25, 56);
            this.lblEndMileage.Name = "lblEndMileage";
            this.lblEndMileage.Size = new System.Drawing.Size(80, 13);
            this.lblEndMileage.TabIndex = 1;
            this.lblEndMileage.Text = "Ending Mileage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount Owed";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(111, 97);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(54, 20);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "€0.00";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(104, 155);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // nudStarting
            // 
            this.nudStarting.Location = new System.Drawing.Point(114, 27);
            this.nudStarting.Name = "nudStarting";
            this.nudStarting.Size = new System.Drawing.Size(120, 20);
            this.nudStarting.TabIndex = 5;
            this.nudStarting.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudEnding
            // 
            this.nudEnding.Location = new System.Drawing.Point(114, 53);
            this.nudEnding.Name = "nudEnding";
            this.nudEnding.Size = new System.Drawing.Size(120, 20);
            this.nudEnding.TabIndex = 6;
            this.nudEnding.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 201);
            this.Controls.Add(this.nudEnding);
            this.Controls.Add(this.nudStarting);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblEndMileage);
            this.Controls.Add(this.lblStartMileage);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudStarting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStartMileage;
        private System.Windows.Forms.Label lblEndMileage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.NumericUpDown nudStarting;
        private System.Windows.Forms.NumericUpDown nudEnding;
    }
}

