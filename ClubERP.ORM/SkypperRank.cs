using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubERP.ORM
{
    public class SkypperRank
    {
        public static int Save(DAO.SkypperRank skypperRank)
        {
            int executeResult = 0;
            executeResult = DAL.SkypperRank.SkypperRank_Upsert(skypperRank.Id, skypperRank.Name, skypperRank.Description, skypperRank.Position, skypperRank.State.Id, skypperRank.TimeStamp);
            return executeResult;
        }

        public static List<DAO.SkypperRank> List()
        {
            List<DAO.SkypperRank> result = new List<DAO.SkypperRank>();
            DataSet dsResult = new DataSet();
            dsResult = DAL.SkypperRank.SkypperRank_List();
            DataTable dtResult = new DataTable();
            dtResult = dsResult.Tables[0];
            foreach (DataRow dr in dtResult.Rows)
            {
                DAO.SkypperRank rank = new DAO.SkypperRank();
                rank.Id = dr["id"].ToString();
                rank.Name = dr["name"].ToString();
                rank.Description = dr["description"].ToString();
                rank.Position = Convert.ToInt16(dr["position"].ToString());
                rank.State = State.Detail(dr["stateId"].ToString());
                rank.TimeStamp = Convert.ToDateTime(dr["ts"]);
                result.Add(rank);
            }
            return result;
        }

        public static DAO.SkypperRank Detail(string id)
        {
            DAO.SkypperRank result = new DAO.SkypperRank();
            List<DAO.SkypperRank> rankList = new List<DAO.SkypperRank>();
            rankList = List();
            result = (from item in rankList
                      where item.Id == id
                      select item).FirstOrDefault();
            return result;
        }
    }
}
