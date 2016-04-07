using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubERP.ORM
{
    public class Role
    {
        public static int Save(DAO.Role role)
        {
            int executeResult = 0;
            executeResult = DAL.Role.Role_Upsert(role.Id, role.Name, role.Description, role.State.Id, role.TimeStamp);
            return executeResult;
        }

        public static List<DAO.Role> List()
        {
            List<DAO.Role> result = new List<DAO.Role>();
            DataSet dsResult = new DataSet();
            dsResult = DAL.Role.Role_List();
            DataTable dtResult = new DataTable();
            dtResult = dsResult.Tables[0];
            foreach (DataRow dr in dtResult.Rows)
            {
                DAO.Role role = new DAO.Role();
                role.Id = dr["id"].ToString();
                role.Name = dr["name"].ToString();
                role.Description = dr["description"].ToString();
                role.State = State.Detail(dr["stateId"].ToString());
                role.TimeStamp = Convert.ToDateTime(dr["ts"]);
                result.Add(role);
            }
            return result;
        }

        public static DAO.Role Detail(string id)
        {
            DAO.Role result = new DAO.Role();
            List<DAO.Role> roleList = new List<DAO.Role>();
            roleList = List();
            result = (from item in roleList
                      where item.Id == id
                      select item).FirstOrDefault();
            return result;
        }
    }
}
