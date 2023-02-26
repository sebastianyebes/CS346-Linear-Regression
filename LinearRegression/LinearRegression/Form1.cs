using Microsoft.VisualBasic.FileIO;
using System;
using System.Windows.Forms;

namespace LinearRegression
{
    public partial class Form1 : Form
    {
        // Initialize Variables
        string path;
        public string[] arr_Date = new string[70];
        public string[] arr_Open = new string[70];
        public string[] arr_High = new string[70];
        public string[] arr_Low = new string[70];
        public string[] arr_Close = new string[70];

        public Form1()
        {
            InitializeComponent();
            Graph_Button.Enabled = false;  
            button1.Enabled = false;

            // Initialize Grid View
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Date";
            dataGridView1.Columns[1].Name = "Open";
            dataGridView1.Columns[2].Name = "High";
            dataGridView1.Columns[3].Name = "Low";
            dataGridView1.Columns[4].Name = "Close";
            dataGridView1.RowHeadersVisible = false;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Fill_Data(string[] date, string[] open, string[] high, string[] low, string[] close)
        {
            for(int i = 0; i < date.Length; i++)
            {
                dataGridView1.Rows.Add(date[i], open[i], high[i], low[i], close[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Openprice.Text != "" && HighPrice.Text != "" && LowPrice.Text != "")
            {
                // Calculate through Multiple Regression
                double predicted_y = 16.53205682 + (double.Parse(Openprice.Text) * -0.889831308) + (double.Parse(HighPrice.Text) * 1.155089547) + (double.Parse(LowPrice.Text) * 0.601626723);
                double rounded = Math.Round(predicted_y, 2);
                PredictedClose.Text = rounded.ToString();
            }
            else
            {
                PredictedClose.Text = "Invalid";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Open File Code
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // To list only csv files, we need to add this filter
            openFileDialog.Filter = "|*.csv";
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                path = openFileDialog.FileName;
            }

            using (TextFieldParser csvParser = new TextFieldParser(path))
            {
                int i = 0;
                csvParser.CommentTokens = new string[] { "#" };
                csvParser.SetDelimiters(new string[] { "," });
                csvParser.HasFieldsEnclosedInQuotes = true;

                // Skip the row with the column names
                csvParser.ReadLine();

                while(!csvParser.EndOfData)
                {
                    // Read current line fields, pointer moves to the next line.
                    string[] fields = csvParser.ReadFields();
                    arr_Date[i] = fields[0];
                    arr_Open[i] = fields[1];
                    arr_High[i] = fields[2];
                    arr_Low[i] = fields[3];
                    arr_Close[i] = fields[4];
                    i++;
                }
            }

            Fill_Data(arr_Date, arr_Open, arr_High, arr_Low, arr_Close);
            Graph_Button.Enabled = true;
            button1.Enabled = true;
        }

        private void Graph_Button_Click(object sender, EventArgs e)
        {
            Graph_Form form = new Graph_Form(arr_Open, arr_High, arr_Low, arr_Close);
            form.ShowDialog();
        }
    }
}
