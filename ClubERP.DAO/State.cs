using System;
using System.ComponentModel.DataAnnotations;

namespace ClubERP.DAO
{
    public class State
    {
        private string _id;
        private string _name;
        private string _description;
        private string _family;
        private DateTime _ts;

        
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        [Display(Name = "State Name")]
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
        public string Family
        {
            get { return _family; }
            set { _family = value; }
        }
        public DateTime TimeStamp
        {
            get { return _ts; }
            set { _ts = value; }
        }

        public State()
        {

        }

    }
}
