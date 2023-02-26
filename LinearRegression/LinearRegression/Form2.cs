using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LinearRegression
{
    public partial class Graph_Form1 : Form
    {
        // Initialize variables
        public string[] arr_Date2;
        public string[] arr_Open2;
        public string[] arr_High2;
        public string[] arr_Low2;
        public string[] arr_Close2;

        public Graph_Form1(string[] open, string[] high, string[] low, string[] close)
        {
            InitializeComponent();

            // Assign array datas from form1
            arr_Open2 = open;
            arr_High2 = high;
            arr_Low2 = low;
            arr_Close2 = close;

            fillChart();
        }

        //fillChart method  
        private void fillChart()
        {
            chart1.ChartAreas[0].AxisX.RoundAxisValues();
            chart1.ChartAreas[0].AxisX.Minimum = 80;
            chart1.ChartAreas[0].AxisY.Minimum = 80;

            //Add Values to chart
            for (int i = 0; i < 13; i++)
            {
                chart1.Series["Open"].Points.AddXY(double.Parse(arr_Open2[i]), double.Parse(arr_Close2[i]));
                chart1.Series["High"].Points.AddXY(double.Parse(arr_High2[i]), double.Parse(arr_Close2[i]));
                chart1.Series["Low"].Points.AddXY(double.Parse(arr_Low2[i]), double.Parse(arr_Close2[i]));
            }

            //chart title  
            chart1.Titles.Add("Tesla Stocks Graph");
        }
    }
}
