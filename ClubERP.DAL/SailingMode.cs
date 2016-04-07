using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubERP.DAL
{
    public class SailingMode
    {
        public static int SailigMode_Upsert(string id,
                            string name,
                            string description,
                            string stateId,
                            DateTime ts)
        {
            int executeResult = 0;
            if (true)
            {
                executeResult = MSSQL_SailingMode.P_SailingMode_Upsert(id, name, description, stateId, ts);
            }
            return executeResult;
        }

        public static DataSet SailingMode_List()
        {
            DataSet result = new DataSet();
            if (true)
            {
                result = MSSQL_SailingMode.P_SailingMode_List();
            }
            return result;
        }
    }
}
