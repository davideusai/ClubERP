using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubERP.BLL
{
    public class SailingMode
    {
        public int Save(DAO.SailingMode sailingMode)
        {
            int executeResult = 0;
            executeResult = ORM.SailingMode.Save(sailingMode);
            return executeResult;
        }

        public List<DAO.SailingMode> List()
        {
            List<DAO.SailingMode> result = new List<DAO.SailingMode>();
            result = ORM.SailingMode.List();
            return result;
        }

        public DAO.SailingMode Detail(string id)
        {
            DAO.SailingMode result = new DAO.SailingMode();
            result = ORM.SailingMode.Detail(id);
            return result;
        }
    }
}
