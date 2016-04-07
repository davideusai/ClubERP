using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubERP.ORM
{
    public class Boat
    {
        public static int Save(DAO.Boat boat)
        {
            int executeResult = 0;
            executeResult = DAL.Interface.Boat_Upsert(boat.Id, boat.Name, boat.Description, boat.DateBuild, boat.DateEntryClub, boat.Photo, boat.CrewMax, boat.MinSkypperRank.Id, boat.State.Id, boat.TimeStamp);
            return executeResult;
        }

        public static DAO.Boat Detail(string id)
        {
            DAO.Boat result = new DAO.Boat();
            string name;
            string description;
            DateTime dateConstruction;
            DateTime dateEntryClub;
            string photo;
            int crewMax;
            string minSkypperRankId;
            string stateId;
            DateTime ts;

            DAL.Interface.Boat_Detail(id, out name, out description, out dateConstruction, out dateEntryClub, out photo, out crewMax, out minSkypperRankId, out stateId, out ts);
            result.Id = id;
            result.Name = name;
            result.Description = description;
            result.DateBuild = dateConstruction;
            result.DateEntryClub = dateEntryClub;
            result.Photo = photo;
            result.CrewMax = crewMax;
            result.MinSkypperRank = SkypperRank.Detail(minSkypperRankId);
            result.State.Id = stateId;
            result.TimeStamp = ts;
            return result;
        }

        public static List<DAO.Boat> List()
        {
            List<DAO.Boat> result = new List<DAO.Boat>();
            DataSet dsResult = new DataSet();
            dsResult = DAL.Interface.Boat_List();
            DataTable dtResult = new DataTable();
            dtResult = dsResult.Tables[0];

            foreach (DataRow dr in dtResult.Rows)
            {
                DAO.Boat boat = new DAO.Boat();
                boat.Id = dr["id"].ToString();
                boat.Name = dr["name"].ToString();
                boat.Description = dr["description"].ToString();
                //boat.DateConstruction = Convert.ToDateTime(dr["dateConstruction"]);
                //boat.DateEntryClub = Convert.ToDateTime(dr["dateEntryClub"]);
                //boat.CrewNb = Convert.ToInt16(dr["crewNb"]);
                //boat.MinSkypperRank = new DAO.SkypperRank();
                boat.MinSkypperRank.Id = dr["minSkypperRankId"].ToString();
                boat.Photo = dr["photo"].ToString();
                //boat.State = new DAO.State();
                boat.State.Id = dr["stateId"].ToString();
                //boat.TimeStamp = Convert.ToDateTime(dr["ts"]);
                result.Add(boat);
            }
            return result;
        }
    }
}
