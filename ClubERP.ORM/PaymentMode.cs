using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubERP.ORM
{
    public class PaymentMode
    {
        public static int Save(DAO.PaymentMode paymentMode)
        {
            int executeResult = 0;
            executeResult = DAL.PaymentMode.PaymentMode_Upsert(paymentMode.Id, paymentMode.Name, paymentMode.Description, paymentMode.State.Id, paymentMode.TimeStamp);
            return executeResult;
        }
        
        public static List<DAO.PaymentMode> List()
        {
            List<DAO.PaymentMode> result = new List<DAO.PaymentMode>();

            DataSet dsResult = new DataSet();
            dsResult = DAL.PaymentMode.PaymentMode_List();
            DataTable dtResult = new DataTable();
            dtResult = dsResult.Tables[0];

            foreach (DataRow dr in dtResult.Rows)
            {
                DAO.PaymentMode item = new DAO.PaymentMode();
                item.Id = dr["id"].ToString();
                item.Name = dr["name"].ToString();
                item.Description = dr["description"].ToString();
                item.State = State.Detail(dr["stateId"].ToString());
                item.TimeStamp = Convert.ToDateTime(dr["ts"]);
                result.Add(item);
            }
            return result;
        }

        public static DAO.PaymentMode Detail(string id)
        {
            DAO.PaymentMode result = new DAO.PaymentMode();
            List<DAO.PaymentMode> paymentModeList = new List<DAO.PaymentMode>();
            paymentModeList = List();
            result = (from x in paymentModeList
                      where x.Id == id
                      select x).FirstOrDefault();
            return result;
        }
    }
}
