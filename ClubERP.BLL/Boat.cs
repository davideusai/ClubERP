using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubERP.BLL
{
    public class Boat : DAO.Boat
    {
        public int Save(DAO.Boat boat)
        {
            int executeResult = 0;
            executeResult = ORM.Boat.Save(boat);
            return executeResult;
        }

        public List<DAO.Boat> List()
        {
            List<DAO.Boat> result = new List<DAO.Boat>();
            result = ORM.Boat.List();
            return result;
        }

        public DAO.Boat Load(string id)
        {
            DAO.Boat result = new DAO.Boat();
            result = ORM.Boat.Detail(id);
            return result;
        }
    }
}
