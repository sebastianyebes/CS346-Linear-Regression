using System;
using System.Windows.Forms;

namespace LinearRegression
{
    public partial class Form1 : Form
    {
        // Open File Code
        /*string path;
        OpenFileDialog openFileDialog = new OpenFileDialog();

        // To list only csv files, we need to add this filter
        openFileDialog.Filter = "|*.csv";
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                path = openFileDialog.FileName;
                textBox1.Text = path;
            }*/

        //x1 is for open price
        //x2 is for high price
        //x3 is for low price
        double[] x1 = { 289.8933, 360.3833, 286.9233, 251.72, 227, 301.2767, 272.58, 254.5, 234.05, 197.08, 118.47, 173.89, 199.985 };
        double[] x2 = { 371.59, 384.29, 318.5, 264.21, 298.32, 314.6667, 313.8, 257.5, 237.4, 198.92, 180.68, 217.65, 208.44 };
        double[] x3 = { 252.0133, 273.9, 206.8567, 208.6933, 216.1667, 271.81, 262.47, 198.59, 166.19, 108.24, 101.81, 169.93, 197.5 };

        double[] y = { 259.2, 290.2533, 252.7533, 224.4733, 297.15, 275.61, 265.25, 227.54, 194.7, 123.18, 173.22, 208.31, 208.31 };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Calculate through Multiple Regression
            double predicted_y = 16.53205682 + (Double.Parse(Openprice.Text) * -0.889831308) + (Double.Parse(HighPrice.Text) * 1.155089547) + (Double.Parse(LowPrice.Text) * 0.601626723);
            double rounded = Math.Round(predicted_y, 2);
            PredictedClose.Text = rounded.ToString();
        }
    }
}
