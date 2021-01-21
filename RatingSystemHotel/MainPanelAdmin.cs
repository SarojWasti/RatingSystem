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
        public MainPanelAdmin()
        {
            InitializeComponent();
            ImportData();
            
        }
        private void ImportData()
        {
            List<string[]> feedBackData = System.IO.File.ReadAllLines("Records.csv").Select(x => x.Split(',')).ToList();
            feedbackGrid.ColumnCount = feedBackData[0].Length;
            {
                for (var column = 0; column < feedBackData[0].Length; column++)
                {
                    feedbackGrid.Columns[column].Name = feedBackData[0][column];
                }
            }
            for (int i = 1; i < feedBackData.Count; i++)
            {
                serialize.Add(new Serialization(feedBackData[i][0], feedBackData[i][1], feedBackData[i][2], feedBackData[i][3], feedBackData[i][4], feedBackData[i][5], feedBackData[i][6], feedBackData[i][7], feedBackData[i][8], feedBackData[i][9]));
            }
            AddToGrid();
        }

        private void AddToGrid()
        {
            foreach(Serialization list in serialize)
            {
                string[] dataList = new string[10];
                dataList[0] = list.NameField;
                dataList[1] = list.AddressField;
                dataList[2] = list.ContactField;
                dataList[3] = list.QualityFood;
                dataList[4] = list.FriendlyStaff;
                dataList[5] = list.RestClean;
                dataList[6] = list.OrderAccuracy;
                dataList[7] = list.RestAmbience;
                for (int i = 0; i < dataList.Length; i++)
                {
                    if (Equals(dataList[i], "4"))
                    {
                        dataList[i] = "Excellent";
                    }
                    if (Equals(dataList[i], "3"))
                    {
                        dataList[i] = "Good";
                    }
                    if (Equals(dataList[i], "2"))
                    {
                        dataList[i] = "Average";
                    }
                    if (Equals(dataList[i], "1"))
                    {
                        dataList[i] = "Dissatisfied";
                    }
                }
                dataList[8] = list.ValueMoney;
                dataList[9] = list.DateAndTime;
                feedbackGrid.Rows.Add(dataList);
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
                    feedbackGrid.Rows.Add(feedBackData[i]);
                    using (System.IO.StreamWriter writeFile = new System.IO.StreamWriter("Records.csv", true))
                    {
                        writeFile.Write(feedBackData[i][0] + "," + feedBackData[i][1] + "," + feedBackData[i][2] + "," + feedBackData[i][3] + "," + feedBackData[i][4] + "," + feedBackData[i][5] + "," + feedBackData[i][6] + "," + feedBackData[i][7] + "," + feedBackData[i][8] + "," + feedBackData[i][9]);
                        writeFile.Write("\n");
                        writeFile.Close();
                    }
                }

            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            this.serialize = sortData.quickSorter(this.serialize, 0, this.serialize.Count - 1);
            feedbackGrid.Rows.Clear();
            AddToGrid();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Close();
        }
    }
}
