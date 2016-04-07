using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubERP.DAO
{
    public class SailSearch
    {
        public Sail Query { get; set; }
        public List<Sail> Sails { get; set; }

        public SailSearch()
        {
            Query = new Sail();
            Sails = new List<Sail>();
        }
    }
}
