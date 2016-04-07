using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubERP.DAL
{
    public class Sail
    {

        public static DataSet Sail_Search(DateTime departureDate, string boatId, string sailingModeId)
        {
            DataSet result = new DataSet();
            if (true)
            {
                result = MSSQL_Sail.P_Sail_Search(departureDate, boatId, sailingModeId);
            }
            return result;
        }
        public static int Sail_Upsert(int id,
                                      DateTime departureDate,
                                      DateTime arrivalDate,
                                      string boatId,
                                      string departurePortId,
                                      string arrivalPortId,
                                      decimal price,
                                      string sailingModeId,
                                      string commentary,
                                      string stateId,
                                      DateTime? ts)

        {
            int executeResult = 0;
            if (true)
            {
                executeResult = MSSQL_Sail.P_Sail_Upsert(id, departureDate, arrivalDate, boatId, departurePortId, arrivalPortId, price, sailingModeId, commentary, stateId, ts);
            }
            return executeResult;
        }

        public static DataSet Sail_List()
        {
            DataSet result = new DataSet();
            if (true)
            {
                result = MSSQL_Sail.P_Sail_List();
            }
            return result;
        }

        public static void Sail_Detail(int id,
                                       out DateTime departureDate,
                                       out DateTime arrivalDate,
                                       out string boatId,
                                       out string departurePortId,
                                       out string arrivalPortId,
                                       out decimal price,
                                       out string sailingModeId,
                                       out string commentary,
                                       out string stateId,
                                       out DateTime ts)
        {
            int executeResult = 0;
            if (true)
            {
                executeResult = MSSQL_Sail.P_Sail_Detail(id, out departureDate, out arrivalDate, out boatId, out departurePortId, out arrivalPortId, out price, out sailingModeId, out commentary, out stateId, out ts);
            }
        }

    }
}
