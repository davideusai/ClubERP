using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubERP.ORM
{
    public class Crew
    {
        public static DAO.Crew Detail(int id)
        {
            DAO.Crew result = new DAO.Crew();
            int executeResult = 0;
            int sailId;
            int userId;
            string roleId;
            string stateId;
            DateTime ts;

            executeResult = DAL.Crew.P_Crew_Detail(id, out sailId, out userId, out roleId, out stateId, out ts);
            result.Id = id;
            result.User = User.Detail(userId);
            result.Role = Role.Detail(roleId);
            result.State.Id = stateId;
            result.TimeStamp = ts;
            return result;
        }
    }
}
