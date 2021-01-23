using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RatingSystemHotel
{
    public partial class MainPanelAdmin : Form
    {
        List<Serialization> serialize = new List<Serialization>();
        DataSort sortData = new DataSort();
        int[] ratings;
        public MainPanelAdmin()
        {
            InitializeComponent();
            ImportData();
        }
        private void ImportData()
        {
            //list is created to store data by readling line by line then converting each row to list
            List<string[]> feedBackData = System.IO.File.ReadAllLines("Records.csv").Select(x => x.Split(',')).ToList();
            //data grid view column is set to the lenght of the first index to create column
            feedbackGrid.ColumnCount = feedBackData[0].Length;
            {
                for (var column = 0; column < feedBackData[0].Length; column++)
                {
                    feedbackGrid.Columns[column].Name = feedBackData[0][column];
                }
            }
            //serializing the list data from index 1 to all existing rows
            for (int i = 1; i < feedBackData.Count; i++)
            {
                serialize.Add(new Serialization(feedBackData[i][0], feedBackData[i][1], feedBackData[i][2], feedBackData[i][3], feedBackData[i][4], feedBackData[i][5], feedBackData[i][6], feedBackData[i][7], feedBackData[i][8], feedBackData[i][9]));
            }
            AddToGrid();
        }

        private void AddToGrid()
        {
            //iterating the object of the serialization class
            foreach (Serialization list in serialize)
            {
                //creating and adding data to array to populate data grid view
                string[] dataList = new string[10];
                dataList[0] = list.NameField;
                dataList[1] = list.AddressField;
                dataList[2] = list.ContactField;
                dataList[3] = list.QualityFood;
                dataList[4] = list.FriendlyStaff;
                dataList[5] = list.RestClean;
                dataList[6] = list.OrderAccuracy;
                dataList[7] = list.RestAmbience;
                dataList[8] = list.ValueMoney;
                RateToText(dataList);
                dataList[9] = list.DateAndTime;
                feedbackGrid.Rows.Add(dataList);
            }
        }
        private void RateToText(string[] dataList)
        {
            for (int i = 0; i < dataList.Length; i++)
            {
                if (Equals(dataList[i], "4"))
                {
                    dataList[i] = "Excellent";
                }
                else if (Equals(dataList[i], "3"))
                {
                    dataList[i] = "Good";
                }
                else if (Equals(dataList[i], "2"))
                {
                    dataList[i] = "Average";
                }
                else if (Equals(dataList[i], "1"))
                {
                    dataList[i] = "Dissatisfied";
                }
            }
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            //for adding feedBackData to the data grid view after importing a file
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "CSVFiles|*.csv";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string file = System.IO.Path.Combine(Application.StartupPath, openFileDialog1.FileName);
                List<string[]> feedBackData = System.IO.File.ReadAllLines(file).Select(x => x.Split(',')).ToList();
                for (var i = 1; i < feedBackData.Count; i++)
                {
                    serialize.Add(new Serialization(feedBackData[i][0], feedBackData[i][1], feedBackData[i][2], feedBackData[i][3], feedBackData[i][4], feedBackData[i][5], feedBackData[i][6], feedBackData[i][7], feedBackData[i][8], feedBackData[i][9]));
                    using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter("Records.csv", true))
                    {
                        writeFile.Write(feedBackData[i][0] + "," + feedBackData[i][1] + "," + feedBackData[i][2] + "," + feedBackData[i][3] + "," + feedBackData[i][4] + "," + feedBackData[i][5] + "," + feedBackData[i][6] + "," + feedBackData[i][7] + "," + feedBackData[i][8] + "," + feedBackData[i][9]);
                        writeFile.Write("\n");
                        writeFile.Close();
                    }

                }
            }
            feedbackGrid.Rows.Clear();
            AddToGrid();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            this.serialize = sortData.quickSorter(this.serialize, 0, this.serialize.Count - 1);
            feedbackGrid.Rows.Clear();
            AddToGrid();
        }
        private void Charts()
        {
            TextValues();
            this.foodQualityChart.Series["Food Quality"].Points.AddXY("Excellent", ratings[0]);
            this.foodQualityChart.Series["Food Quality"].Points.AddXY("Good", ratings[1]);
            this.foodQualityChart.Series["Food Quality"].Points.AddXY("Average", ratings[2]);
            this.foodQualityChart.Series["Food Quality"].Points.AddXY("Dissatisfied", ratings[3]);
        }
        private void TextValues()
        {
            int[] ratingsCount = { 0, 0, 0, 0 };
            ratings = ratingsCount;
            foreach (Serialization list in serialize)
            {
                if (Equals(list.QualityFood, "4"))
                {
                    ratings[0] = ratings[0] + 1;
                }
                else if (Equals(list.QualityFood, "3"))
                {
                    ratings[1] = ratings[1] + 1;
                }
                else if (Equals(list.QualityFood, "2"))
                {
                    ratings[2] = ratings[2] + 1;
                }
                else if (Equals(list.QualityFood, "1"))
                {
                    ratings[3] = ratings[3] + 1;
                }
            }
        }
        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            foodQualityChart.Series["Food Quality"].Points.Clear();
            Charts();
            MessageBox.Show("Chart has been plotted", "Chart Panel");
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }
    }
}
