using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClubERP.DAO
{
    public class Base
    {
        private State _state;
        private DateTime _ts;

        public State State
        {
            get { return _state; }
            set { _state = value; }
        }
        public DateTime TimeStamp
        {
            get { return _ts; }
            set { _ts = value; }
        }

        public Base()
        {
            State = new State();
        }
    }
}
