using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter4_ex1
{
    public partial class Form1 : Form
    {
        int startingMileage = 0;
        int endingMileage = 0;
        double milesTravelled = 0;
        double reimburseRate = 0.39;
        double amountOwed = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            startingMileage = (int) nudStarting.Value;
            endingMileage = (int) nudEnding.Value;

            if (startingMileage >= endingMileage)
            {
                MessageBox.Show("The starting mileage must be less than the ending mileage", "Cannot calculate mileage");
            }
            else
            {
                milesTravelled = endingMileage - startingMileage;
                amountOwed = milesTravelled * reimburseRate;
                lblAmount.Text = "€" + amountOwed;
            }
        }
    }
}
