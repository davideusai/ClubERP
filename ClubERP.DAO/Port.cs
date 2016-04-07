using System;
using System.ComponentModel.DataAnnotations;

namespace ClubERP.DAO
{
    public class Port : Base
    {
        private string _id;
        private string _name;
        private string _description;
        private string _photo;
        private string _url;
        private decimal _latitude;
        private decimal _longitude;
        private string _city;
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        [Display(Name = "Nom")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public string Photo
        {
            get { return _photo; }
            set { _photo = value; }
        }
        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }
        [DisplayFormat(DataFormatString = "{0:N6}", ApplyFormatInEditMode = true)]
        public decimal Latitude
        {
            get { return _latitude; }
            set { _latitude = value; }
        }
        [DisplayFormat(DataFormatString = "{0:N6}", ApplyFormatInEditMode = true)]
        public decimal Longitude
        {
            get { return _longitude; }
            set { _longitude = value; }
        }
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
    }
}
