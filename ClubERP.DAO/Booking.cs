using System;

namespace ClubERP.DAO
{
    public class Booking : Base
    {
        private int _id;
        private Sail _sail;
        private User _person;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public Sail Sail
        {
            get { return _sail; }
            set { _sail = value; }
        }
        public User Person
        {
            get { return _person; }
            set { _person = value; }
        }
    }
}
