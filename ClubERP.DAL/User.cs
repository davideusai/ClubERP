using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubERP.DAL
{
    public class User
    {

        public static DataSet User_Search(string userName,
                                          string firstName,
                                          string lastName,
                                          string eMail,
                                          string phoneNumber,
                                          string skypperRankId,
                                          string stateId)
        {
            DataSet result = new DataSet();
            if (true)
            {
                result = MSSQL_User.P_User_Search(userName, firstName, lastName, eMail, phoneNumber, skypperRankId, stateId);
            }
            return result;
        }

        public static void User_Detail(int id,
                                       out string userName,
                                       out string firstName,
                                       out string lastName,
                                       out string eMail,
                                       out string phoneNumber,
                                       out string skypperRankId,
                                       out string identityId,
                                       out string stateId,
                                       out DateTime ts)
        {
            int executeResult = 0;
            if (true)
            {
                executeResult = MSSQL_User.P_User_Detail(id, out userName, out firstName, out lastName, out eMail, out phoneNumber, out skypperRankId, out identityId, out stateId, out ts);
            }
        }

        public static int User_Upsert(string userName,
                                      string firstName,
                                      string lastName,
                                      string eMail,
                                      string phoneNumber,
                                      string skypperRankId,
                                      string identityId,
                                      string stateId,
                                      DateTime ts)
        {
            int executeResult = 0;
            if (true)
            {
                executeResult = MSSQL_User.P_User_Upsert(userName, firstName, lastName, eMail, phoneNumber, skypperRankId, identityId, stateId, ts);
            }
            return executeResult;
        }

        public static DataSet User_List()
        {
            DataSet result = new DataSet();
            if (true)
            {
                result = MSSQL_User.P_User_List();
            }
            return result;
        }
    }
}
