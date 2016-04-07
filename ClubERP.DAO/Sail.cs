using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace ClubERP.DAO
{
    public class Sail : Base
    {
        private int _id;
        private DateTime _departureDate;
        private DateTime _arrivalDate;
        private Boat _boat;
        private Port _departurePort;
        private Port _arrivalPort;
        private decimal _price;
        private string _commentary;
        private SailingMode _sailingMode;
        private List<Crew> _crew;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DepartureDate
        {
            get { return _departureDate; }
            set { _departureDate = value; }
        }
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ArrivalDate
        {
            get { return _arrivalDate; }
            set { _arrivalDate = value; }
        }
        public Boat Boat
        {
            get { return _boat; }
            set { _boat = value; }
        }
        public Port DeparturePort
        {
            get { return _departurePort; }
            set { _departurePort = value; }
        }
        public Port ArrivalPort
        {
            get { return _arrivalPort; }
            set { _arrivalPort = value; }
        }
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public string Commentary
        {
            get { return _commentary; }
            set { _commentary = value; }
        }
        public SailingMode SailingMode
        {
            get { return _sailingMode; }
            set { _sailingMode = value; }
        }
        public List<Crew> Crew
        {
            get { return _crew; }
            set { _crew = value; }
        }

        public Sail()
        {
            Boat = new Boat();
            SailingMode = new SailingMode();
            DeparturePort = new Port();
            ArrivalPort = new Port();
            Crew = new List<Crew>();
        }
            
            

    }
}
