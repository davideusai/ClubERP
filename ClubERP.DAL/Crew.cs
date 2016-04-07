using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubERP.DAL
{
    public class Crew
    {
        public static int P_Crew_Upsert(int sailId,
                                        int userId,
                                        string roleId,
                                        string stateId,
                                        DateTime ts)
        {
            int executeResult = 0;
            if (true)
            {
                executeResult = MSSQL_Crew.P_Crew_Upsert(sailId, userId, roleId, stateId, ts);
            }
            return executeResult;
        }

        public static DataSet P_Crew_List(int saildId)
        {
            DataSet result = new DataSet();
            if (true)
            {
                result = MSSQL_Crew.P_Crew_List(saildId);
            }
            return result;
        }

        public static int P_Crew_Detail(int id,
                                        out int sailId,
                                        out int userId,
                                        out string roleId,
                                        out string stateId,
                                        out DateTime ts)
        {
            int executeResult = 0;
            if (true)
            {
                executeResult = MSSQL_Crew.P_Crew_Detail(id, out sailId, out userId, out roleId, out stateId, out ts);
            }
            return executeResult;
        }
    }
}
