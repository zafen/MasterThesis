using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterThesis
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();

        }

        private void tbnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                List<double> listPoly = new List<double> {
                Double.Parse(txtBoxValue1.Text),
                Double.Parse(txtBoxValue2.Text),
                Double.Parse(txtBoxValue3.Text),
                Double.Parse(txtBoxValue4.Text),
                Double.Parse(txtBoxValue5.Text)
                };

                double datapoints = Double.Parse(txtBoxDataPoints.Text);

                double futureValues = Double.Parse(txtBoxFutureValues.Text);

                Plot pl = new Plot(chart1, listPoly, datapoints, futureValues);
            }
            catch (FormatException)
            {
                MessageBox.Show("Wrong values for Polynom");
            }


        }
    }
}
