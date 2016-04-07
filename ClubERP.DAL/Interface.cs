using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubERP.DAL
{
    public class Interface
    {
        
        public static int Port_Upsert(string id,
                                      string name,
                                      string description,
                                      string photo,
                                      string url,
                                      decimal latitude,
                                      decimal longitude,
                                      string city,
                                      string stateId,
                                      DateTime ts)
        {
            int executeResult = 0;
            if (true)
            {
                executeResult = MSSQLStoredProcedureCall.P_Port_Upsert(id, name, description, photo, url, latitude, longitude, city, stateId, ts);
            }
            return executeResult;
        }

        


   

        public static int State_Upsert(string id,
                                 string name,
                                 string description,
                                 string family,
                                 DateTime ts)
        {
            int executeResult = 0;
            if (true)
            {
                executeResult = MSSQLStoredProcedureCall.P_State_Upsert(id, name, description, family, ts);
            }
            return executeResult;
        }

        public static int Boat_Upsert(string id,
                                 string name,
                                 string description,
                                 DateTime dateBuild,
                                 DateTime dateEntryClub,
                                 string photo,
                                 int crewMax,
                                 string minSkypperRankId,
                                 string stateId,
                                 DateTime ts)
        {
            int executeResult = 0;
            if (true)
            {
                executeResult = MSSQLStoredProcedureCall.P_Boat_Upsert(id, name, description, dateBuild, dateEntryClub, photo, crewMax, minSkypperRankId, stateId, ts);
            }
            return executeResult;
        }

        public static DataSet Port_List()
        {
            DataSet result = new DataSet();
            if (true)
            {
                result = MSSQLStoredProcedureCall.P_Port_List();
            }
            return result;
        }

       
        public static DataSet State_List()
        {
            DataSet result = new DataSet();
            if (true)
            {
                result = MSSQLStoredProcedureCall.P_State_List();
            }
            return result;
        }
       

        public static DataSet Boat_List()
        {
            DataSet result = new DataSet();
            if (true)
            {
                result = MSSQLStoredProcedureCall.P_Boat_List();
            }
                return result;
        }

       


        public static void Port_Detail(string id,
                                        out string name,
                                        out string description,
                                        out string photo,
                                        out string url,
                                        out decimal latitude,
                                        out decimal longitude,
                                        out string city,
                                        out string stateId,
                                        out DateTime ts)
        {
            int executeResult = 0;
            name = "";
            if (true)
            {
                executeResult = MSSQLStoredProcedureCall.P_Port_Detail(id, out name, out description, out photo, out url, out latitude, out longitude, out city, out stateId, out ts);
            }
        }


        public static void Boat_Detail(string id,
                                       out string name,
                                       out string description,
                                       out DateTime dateBuild,
                                       out DateTime dateEntryClub,
                                       out string photo,
                                       out int crewMax,
                                       out string minSkypperRankId,
                                       out string stateId,
                                       out DateTime ts)
        {
            int executeResult = 0;
            name = "";
           if (true)
            {
                executeResult = MSSQLStoredProcedureCall.P_Boat_Detail(id, out name, out description, out dateBuild, out dateEntryClub, out photo, out crewMax, out minSkypperRankId, out stateId, out ts);
            }
        }

       
    }
}