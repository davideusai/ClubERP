using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubERP.DAL
{
    public class SkypperRank
    {
        public static int SkypperRank_Upsert(string id,
                                            string name,
                                            string description,
                                            int order,
                                            string stateId,
                                            DateTime ts)
        {
            int executeResult = 0;
            if (true)
            {
                executeResult = MSSQL_SkypperRank.P_SkypperRank_Upsert(id, name, description, order, stateId, ts);
            }
            return executeResult;
        }
        public static DataSet SkypperRank_List()
        {
            DataSet result = new DataSet();
            if (true)
            {
                result = MSSQL_SkypperRank.P_SkypperRank_List();
            }
            return result;
        }
    }
}
