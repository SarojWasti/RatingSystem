using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatingSystemHotel
{
    class Serialization
    {
        private string nameField;
        private string addressField;
        private string contactField;
        private string qualityFood;
        private string friendlyStaff;
        private string restClean;
        private string orderAccuracy;
        private string restAmbience;
        private string valueMoney;
        private string dateAndTime;
        //class constructor
        public Serialization(string nameTxt, string addressTxt, string contactTxt, string quality, string friendly, string clean, string accuracy, string ambience, string money, string dateAndTime)
        {
            this.nameField = nameTxt;
            this.addressField = addressTxt;
            this.contactField = contactTxt;
            this.qualityFood = quality;
            this.friendlyStaff = friendly;
            this.restClean = clean;
            this.orderAccuracy = accuracy;
            this.restAmbience = ambience;
            this.valueMoney = money;
            this.dateAndTime = dateAndTime;

        }

        public string NameField { get => nameField; set => nameField = value; }
        public string AddressField { get => addressField; set => addressField = value; }
        public string ContactField { get => contactField; set => contactField = value; }
        public string QualityFood { get => qualityFood; set => qualityFood = value; }
        public string FriendlyStaff { get => friendlyStaff; set => friendlyStaff = value; }
        public string RestClean { get => restClean; set => restClean = value; }
        public string OrderAccuracy { get => orderAccuracy; set => orderAccuracy = value; }
        public string RestAmbience { get => restAmbience; set => restAmbience = value; }
        public string ValueMoney { get => valueMoney; set => valueMoney = value; }
        public string DateAndTime { get => dateAndTime; set => dateAndTime = value; }

        //Properties to get value

    }
}
