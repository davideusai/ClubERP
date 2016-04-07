using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubERP.ORM
{
    public class Sail
    {

        public static List<DAO.Sail> Search(DAO.Sail model)
        {
            List<DAO.Sail> result = new List<DAO.Sail>();

            DataSet dsResult = new DataSet();
            dsResult = DAL.Sail.Sail_Search(model.DepartureDate, model.Boat.Id, model.SailingMode.Id);
            DataTable dtResult = new DataTable();
            dtResult = dsResult.Tables[0];

            foreach (DataRow dr in dtResult.Rows)
            {
                DAO.Sail item = new DAO.Sail();
                item = Sail.Detail(Convert.ToInt32(dr["id"]));
                item.SailingMode = SailingMode.Detail(item.SailingMode.Id);
                item.DeparturePort = Port.Detail(item.DeparturePort.Id);
                item.ArrivalPort = Port.Detail(item.ArrivalPort.Id);
                item.Boat = Boat.Detail(item.Boat.Id);
                result.Add(item);
            }

            return result;
        }

        public static int Save(DAO.Sail sail)
        {
            int executeResult = 0;
            executeResult = DAL.Sail.Sail_Upsert(sail.Id, sail.DepartureDate, sail.ArrivalDate, sail.Boat.Id, sail.DeparturePort.Id, sail.ArrivalPort.Id, sail.Price, sail.SailingMode.Id, sail.Commentary, sail.State.Id, sail.TimeStamp);
            return executeResult;
        }

        public static List<DAO.Sail> List()
        {
            List<DAO.Sail> result = new List<DAO.Sail>();

            DataSet dsResult = new DataSet();
            dsResult = DAL.Sail.Sail_List();
            DataTable dtResult = new DataTable();
            dtResult = dsResult.Tables[0];

            foreach (DataRow dr in dtResult.Rows)
            {
                DAO.Sail item = new DAO.Sail();
                item.Id = Convert.ToInt32(dr["id"]);
                item.SailingMode.Id = dr["SailingModeId"].ToString();
                item.DepartureDate = Convert.ToDateTime(dr["departureDate"].ToString());
                item.ArrivalDate = Convert.ToDateTime(dr["arrivalDate"].ToString());
                item.DeparturePort.Id = dr["departurePortId"].ToString();
                item.ArrivalPort.Id = dr["arrivalPortId"].ToString();
                item.Boat.Id = dr["boatId"].ToString();
                item.Commentary = dr["commentary"].ToString();
                item.Price = Convert.ToDecimal(dr["price"].ToString());
                item.State = State.Detail(dr["stateId"].ToString());
                item.TimeStamp = Convert.ToDateTime(dr["ts"].ToString());

                result.Add(item);
            }
            return result;
        }

        public static DAO.Sail Detail(int id)
        {
            DAO.Sail result = new DAO.Sail();

            DateTime departureDate;
            DateTime arrivalDate;
            string boatId;
            string departurePortId;
            string arrivalPortId;
            decimal price;
            string sailingModeId;
            string commentary;
            string stateId;
            DateTime timeStamp;
            DAL.Sail.Sail_Detail(id, out departureDate, out arrivalDate, out boatId, out departurePortId, out arrivalPortId, out price, out sailingModeId, out commentary, out stateId, out timeStamp);
            result.Id = id;
            result.DepartureDate = departureDate;
            result.ArrivalDate = arrivalDate;
            result.Boat.Id = boatId;
            result.DeparturePort.Id = departurePortId;
            result.ArrivalPort.Id = arrivalPortId;
            result.Price = price;
            result.SailingMode.Id = sailingModeId;
            result.Commentary = commentary;
            result.State.Id = stateId;
            result.TimeStamp = timeStamp;
            return result;
        }

        public static int AddCrew(int sailId, DAO.Crew crew)
        {
            int executeResult = 0;
            executeResult = DAL.Crew.P_Crew_Upsert(sailId, crew.User.Id, crew.Role.Id, crew.State.Id, crew.TimeStamp);
            return executeResult;
        }

        public static List<DAO.Crew> CrewList(int sailId)
        {
            List<DAO.Crew> result = new List<DAO.Crew>();
            DataSet dsResult = new DataSet();
            dsResult = DAL.Crew.P_Crew_List(sailId);
            DataTable dtResult = new DataTable();
            dtResult = dsResult.Tables[0];

            foreach (DataRow dr in dtResult.Rows)
            {
                DAO.Crew item = new DAO.Crew();
                item.Id = Convert.ToInt32(dr["id"]);
                item.User  = User.Detail(Convert.ToInt16(dr["userId"].ToString()));
                item.Role = Role.Detail(dr["roleId"].ToString());
                item.State = State.Detail(dr["stateId"].ToString());
                item.TimeStamp = Convert.ToDateTime(dr["ts"].ToString());
                result.Add(item);
            }

            return result;
        }

        

    }
}
