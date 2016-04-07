using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubERP.ORM
{
    public class User
    {
        public static List<DAO.User> Search(DAO.User model)
        {
            List<DAO.User> result = new List<DAO.User>();

            DataSet dsResult = new DataSet();
            dsResult = DAL.User.User_Search(model.UserName, model.FirstName, model.LastName, model.eMail, model.PhoneNumber, model.SkypperRank.Id, model.State.Id);
            DataTable dtResult = new DataTable();
            dtResult = dsResult.Tables[0];

            foreach (DataRow dr in dtResult.Rows)
            {
                DAO.User item = new DAO.User();
                item = Detail(Convert.ToInt32(dr["id"]));
                result.Add(item);
            }

            return result;
        }

        public static int Save(DAO.User user)
        {
            int executeResult = 0;
            executeResult = DAL.User.User_Upsert(user.UserName, user.FirstName, user.LastName, user.eMail, user.PhoneNumber, user.SkypperRank.Id, user.IdentityId, user.State.Id, user.TimeStamp);
            return executeResult;
        }

        public static List<DAO.User> List()
        {
            List<DAO.User> result = new List<DAO.User>();
            DataSet dsResult = new DataSet();
            dsResult = DAL.User.User_List();
            DataTable dtResult = new DataTable();
            dtResult = dsResult.Tables[0];
            foreach (DataRow dr in dtResult.Rows)
            {
                DAO.User user = new DAO.User();
                user.Id = Convert.ToInt16(dr["id"]);
                user.UserName = dr["username"].ToString();
                user.FirstName = dr["firstName"].ToString();
                user.LastName = dr["lastName"].ToString();
                user.SkypperRank.Id = dr["skypperRankId"].ToString();
                user.IdentityId = dr["identityId"].ToString();
                user.State.Id = dr["stateId"].ToString();
                result.Add(user);
            }
            return result;
        }

        public static DAO.User Detail(int id)
        {
            DAO.User result = new DAO.User();
            string userName;
            string firstName;
            string lastName;
            string eMail;
            string phoneNumber;
            string skypperRankId;
            string identityId;
            string stateId;
            DateTime timeStamp;
            DAL.User.User_Detail(id, out userName, out firstName, out lastName, out eMail, out phoneNumber, out skypperRankId, out identityId,  out stateId, out timeStamp);
            result.Id = id;
            result.UserName = userName;
            result.FirstName = firstName;
            result.LastName = lastName;
            result.eMail = eMail;
            result.PhoneNumber = phoneNumber;
            result.SkypperRank.Id = skypperRankId;
            result.IdentityId = identityId;
            result.State.Id = stateId;
            result.TimeStamp = timeStamp;
            return result;
        }
    }
}
