using System;
using System.ComponentModel.DataAnnotations;

namespace ClubERP.DAO
{
    public class Boat : Base
    {
        private string _id;
        private string _name;
        private string _description;
        private DateTime _dateBuild;
        private DateTime _dateEntryClub;
        private string _photo;
        private int _crewMax;
        private SkypperRank _minSkypperRank;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        [Display(Name = "Bateau")]
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
        public DateTime DateBuild
        {
            get { return _dateBuild; }
            set { _dateBuild = value; }
        }
        public DateTime DateEntryClub
        {
            get { return _dateEntryClub; }
            set { _dateEntryClub = value; }
        }
        public string Photo
        {
            get { return _photo; }
            set { _photo = value; }
        }
        public int CrewMax
        {
            get { return _crewMax; }
            set { _crewMax = value; }
        }
        public SkypperRank MinSkypperRank
        {
            get { return _minSkypperRank; }
            set { _minSkypperRank = value; }
        }

        public Boat()
        {
            MinSkypperRank = new SkypperRank();
        }
    }
}
