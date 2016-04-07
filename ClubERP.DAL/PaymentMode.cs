using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubERP.DAL
{
    public class PaymentMode
    {
        public static int PaymentMode_Upsert(string id,
                            string name,
                            string description,
                            string stateId,
                            DateTime ts)
        {
            int executeResult = 0;
            if (true)
            {
                executeResult = MSSQL_PaymentMode.P_PaymentMode_Upsert(id, name, description, stateId, ts);
            }
            return executeResult;
        }

        public static DataSet PaymentMode_List()
        {
            DataSet result = new DataSet();
            if (true)
            {
                result = MSSQL_PaymentMode.P_PaymentMode_List();
            }
            return result;
        }
    }
}
