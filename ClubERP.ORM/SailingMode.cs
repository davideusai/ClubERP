using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubERP.ORM
{
    public class SailingMode
    {
        public static int Save(DAO.SailingMode sailigMode)
        {
            int executeResult = 0;
            executeResult = DAL.SailingMode.SailigMode_Upsert(sailigMode.Id, sailigMode.Name, sailigMode.Description, sailigMode.State.Id, sailigMode.TimeStamp);
            return executeResult;
        }
        
        public static List<DAO.SailingMode> List()
        {
            List<DAO.SailingMode> result = new List<DAO.SailingMode>();

            DataSet dsResult = new DataSet();
            dsResult = DAL.SailingMode.SailingMode_List();
            DataTable dtResult = new DataTable();
            dtResult = dsResult.Tables[0];

            foreach (DataRow dr in dtResult.Rows)
            {
                DAO.SailingMode item = new DAO.SailingMode();
                item.Id = dr["id"].ToString();
                item.Name = dr["name"].ToString();
                item.Description = dr["description"].ToString();
                item.State = State.Detail(dr["stateId"].ToString());
                item.TimeStamp = Convert.ToDateTime(dr["ts"]);
                result.Add(item);
            }
            return result;
        }

        public static DAO.SailingMode Detail(string id)
        {
            DAO.SailingMode result = new DAO.SailingMode();
            List<DAO.SailingMode> sailingModeList = new List<DAO.SailingMode>();
            sailingModeList = List();
            result = (from x in sailingModeList
                      where x.Id == id
                      select x).FirstOrDefault();
            return result;
        }
    }
}
