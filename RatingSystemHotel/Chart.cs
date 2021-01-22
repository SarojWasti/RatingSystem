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
    public partial class Chart : Form
    {
        List<Serialization> cusRatings = new List<Serialization>();
        MainPanelAdmin mp = new MainPanelAdmin();

        int[] ratings;
        public Chart()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Charts();
            
        }
        private void Charts()
        {
            TextValues();
            this.feedBackChart.Series["Feedbacks"].Points.AddXY("Excellent", ratings[0]);
            this.feedBackChart.Series["Feedbacks"].Points.AddXY("Good", ratings[1]);
            this.feedBackChart.Series["Feedbacks"].Points.AddXY("Average", ratings[2]);
            this.feedBackChart.Series["Feedbacks"].Points.AddXY("Dissatisfied", ratings[3]);
        }
        private void TextValues()
        {
            int[] ratingsCount = { 0, 0, 0, 0 };
            ratings = ratingsCount;
            foreach (Serialization list in cusRatings)
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
                /*string[] dataList = new string[6];
                dataList[0] = list.QualityFood;
                dataList[1] = list.FriendlyStaff;
                dataList[2] = list.RestClean;
                dataList[3] = list.OrderAccuracy;
                dataList[4] = list.RestAmbience;
                dataList[5] = list.ValueMoney;
                for(var i = 0; i<dataList.Length; i++)
                {
                    if(Equals(dataList[i], "4"))
                    {
                        ratings[0] = ratings[0] + 1;
                    }
                    else if (Equals(dataList[i], "3"))
                    {
                        ratings[1] = ratings[1] + 1;
                    }
                    else if (Equals(dataList[i], "2"))
                    {
                        ratings[2] = ratings[2] + 1;
                    }
                    else if (Equals(dataList[i], "1"))
                    {
                        ratings[3] = ratings[3] + 1;
                    }*/
            }
            MessageBox.Show(ratings[1].ToString());
        }
    }
}
