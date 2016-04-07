using System;
using System.ComponentModel.DataAnnotations;

namespace ClubERP.DAO
{
    public class SkypperRank : Base
    {
        private string _id;
        private string _name;
        private string _description;
        private int _position;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        [Display(Name = "Skypper Rank Name")]
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

        public int Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public SkypperRank()
        {
           
        }
    }
}
