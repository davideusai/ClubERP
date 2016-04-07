using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubERP.ORM
{
    public class Port
    {
        public static int Save(DAO.Port port)
        {
            int executeResult = 0;
            executeResult = DAL.Interface.Port_Upsert(port.Id, port.Name, port.Description, port.Photo, port.Url, port.Latitude, port.Longitude, port.City, port.State.Id, port.TimeStamp);
            return executeResult;
        }

        public static List<DAO.Port> List()
        {
            List<DAO.Port> result = new List<DAO.Port>();

            DataSet dsResult = new DataSet();
            dsResult = DAL.Interface.Port_List();
            DataTable dtResult = new DataTable();
            dtResult = dsResult.Tables[0];

            foreach (DataRow dr in dtResult.Rows)
            {
                DAO.Port item = new DAO.Port();
                item.Id = dr["id"].ToString();
                item.Name = dr["name"].ToString();
                item.State = State.Detail(dr["stateId"].ToString());


                result.Add(item);
            }
            return result;
        }

        public static DAO.Port Detail(string id)
        {
            DAO.Port result = new DAO.Port();
            string name;
            string description;
            string photo;
            string url;
            decimal latitude;
            decimal longitude;
            string city;
            string stateId;
            DateTime timeStamp;
            DAL.Interface.Port_Detail(id, out name, out description, out photo, out url, out latitude, out longitude, out city, out stateId, out timeStamp);
            result.Id = id;
            result.Name = name;
            result.Description = description;
            result.Photo = photo;
            result.Url = url;
            result.Latitude = latitude;
            result.Longitude = longitude;
            result.City = city;
            result.State.Id = stateId;
            result.TimeStamp = timeStamp;
            return result;
        }
    }
}
