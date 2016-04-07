using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubERP.BLL
{
    public class SkypperRank
    {
        public int Save(DAO.SkypperRank skypperRank)
        {
            int executeResult = 0;
            executeResult = ORM.SkypperRank.Save(skypperRank);
            return executeResult;
        }

        public List<DAO.SkypperRank> List()
        {
            List<DAO.SkypperRank> result = new List<DAO.SkypperRank>();
            result = ORM.SkypperRank.List();
            return result;
        }

        public DAO.SkypperRank Detail(string id)
        {
            DAO.SkypperRank result = new DAO.SkypperRank();
            var temp = ORM.SkypperRank.List();
            result = (from x in temp
                     where x.Id == id
                     select x).FirstOrDefault();
            return result;
        }
    }
}
