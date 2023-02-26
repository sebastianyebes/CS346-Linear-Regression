using System.Windows.Forms;

namespace LinearRegression
{
    public partial class Graph_Form2 : Form
    {
        // Initialize variables
        public string[] arr_Date2;
        public string[] arr_Open2;
        public string[] arr_High2;
        public string[] arr_Low2;
        public string[] arr_Close2;

        public Graph_Form2(string[] date,string[] open, string[] high, string[] low, string[] close)
        {
            InitializeComponent();

            arr_Date2 = date;
            arr_Open2 = open;
            arr_High2 = high;
            arr_Low2 = low;
            arr_Close2 = close;

            FillChart();
        }

        private void FillChart()
        {
            // Clear grid
            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
            chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;

            // Init
            chart1.Series["Monthly"].XValueMember = "Day";
            chart1.Series["Monthly"].YValueMembers = "High,Low,Open,Close";
            chart1.Series["Monthly"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
                               
            chart1.Series["Monthly"]["ShowOpenClose"] = "Both";
            chart1.DataManipulator.IsStartFromFirst = true;

            // Add Values to chart
            for (int i = 0; i < 13; i++)
            {
                chart1.Series["Monthly"].Points.AddXY(arr_Date2[i],
                    double.Parse(arr_High2[i]), double.Parse(arr_Low2[i]), double.Parse(arr_Open2[i]), double.Parse(arr_Close2[i]));
            }
        }
    }
}
