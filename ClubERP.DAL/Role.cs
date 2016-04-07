using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubERP.DAL
{
    public class Role
    {
        public static int Role_Upsert(string id,
                                            string name,
                                            string description,
                                            string stateId,
                                            DateTime ts)
        {
            int executeResult = 0;
            if (true)
            {
                executeResult = MSSQL_Role.P_Role_Upsert(id, name, description, stateId, ts);
            }
            return executeResult;
        }
        public static DataSet Role_List()
        {
            DataSet result = new DataSet();
            if (true)
            {
                result = MSSQL_Role.P_Role_List();
            }
            return result;
        }
    }
}
