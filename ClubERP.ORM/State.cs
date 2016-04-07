using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubERP.ORM
{
    public class State
    {
        public static int Save(DAO.State state)
        {
            int executeResult = 0;
            executeResult = DAL.Interface.State_Upsert(state.Id, state.Name, state.Description, state.Family, state.TimeStamp);
            return executeResult;
        }

        public static List<DAO.State> List()
        {
            List<DAO.State> result = new List<DAO.State>();
            DataSet dsResult = new DataSet();
            dsResult = DAL.Interface.State_List();
            DataTable dtResult = new DataTable();
            dtResult = dsResult.Tables[0];
            foreach (DataRow dr in dtResult.Rows)
            {
                DAO.State state = new DAO.State();
                state.Id = dr["id"].ToString();
                state.Name = dr["name"].ToString();
                state.Description = dr["description"].ToString();
                state.Family = dr["family"].ToString();
                state.TimeStamp = Convert.ToDateTime(dr["ts"]);
                result.Add(state);
            }
            return result;
        }

        public static DAO.State Detail(string id)
        {
            DAO.State result = new DAO.State();
            List<DAO.State> stateList = new List<DAO.State>();
            stateList = List();
            result = (from x in stateList
                      where x.Id == id
                      select x).FirstOrDefault();
            return result;
        }
    }
}
