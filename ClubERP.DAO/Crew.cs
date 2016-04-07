using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubERP.DAO
{
    public class Crew : Base
    {
        private int _id;
        private User _user;
        private Role _role;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public User User
        {
            get { return _user; }
            set { _user = value; }
        }
        public Role Role
        {
            get { return _role; }
            set { _role = value; }
        }


        public Crew()
        {
            User = new User();
            Role = new Role();
        }
    }
}
