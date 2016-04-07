using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubERP.BLL
{
    public class State : DAO.State
    {
        public int Save(DAO.State state)
        {
            int executeResult = 0;
            executeResult = ORM.State.Save(state);
            return executeResult;
        }

        public List<DAO.State> List()
        {
            List<DAO.State> result = new List<DAO.State>();
            result = ORM.State.List();
            return result;
        }

        public DAO.State Detail(string id)
        {
            DAO.State result = new DAO.State();
            result = ORM.State.Detail(id);
            return result;
        }
    }
}
