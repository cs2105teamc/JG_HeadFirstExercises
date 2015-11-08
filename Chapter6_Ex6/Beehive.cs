using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter6_Ex6
{
    public partial class Beehive : Form
    {
        private Queen queen;
        public Beehive()
        {
            InitializeComponent();

            cbWorkerBeeJob.SelectedIndex = 0;
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" },175.00);
            workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring" }, 114.00);
            workers[2] = new Worker(new string[] { "Hive maintenance", "Honey manufacturing" }, 149.00);
            workers[3] = new Worker(new string[] { "Nectar collector", "Honey manufacturing", "Egg care", "Baby bee tutoring", "Hive maintenance", "Sting patrol" }, 155.00);

            queen = new Queen(workers, 275.00);
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(cbWorkerBeeJob.Text, (int)nudShifts.Value) == false)
                MessageBox.Show("No workers are available to do the job '" + cbWorkerBeeJob.Text + "'", "The queen bee says...");
            else
                MessageBox.Show("The job '" + cbWorkerBeeJob.Text + "' will be done in " + nudShifts.Value + " shifts", "The queen bee says...");
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            tbReport.Text = queen.WorkTheNextShift();
        }
    }
}
