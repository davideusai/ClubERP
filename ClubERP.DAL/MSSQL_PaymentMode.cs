using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubERP.DAL
{
    class MSSQL_PaymentMode
    {
        public static int P_PaymentMode_Upsert(string id,
                                 string name,
                                 string description,
                                 string stateId,
                                 DateTime ts)
        {
            int executeResult = 0;
            string spName = "P_PaymentMode_Upsert";
            List<SqlParameter> inParam = new List<SqlParameter>();
            SqlParameter paramId = new SqlParameter();
            paramId.ParameterName = "id";
            paramId.Value = id;
            inParam.Add(paramId);
            SqlParameter paramName = new SqlParameter();
            paramName.ParameterName = "name";
            paramName.Value = name;
            inParam.Add(paramName);
            SqlParameter paramDescription = new SqlParameter();
            paramDescription.ParameterName = "description";
            paramDescription.Value = description;
            inParam.Add(paramDescription);
            SqlParameter paramStateId = new SqlParameter();
            paramStateId.ParameterName = "stateId";
            paramStateId.Value = stateId;
            inParam.Add(paramStateId);
            SqlParameter paramTS = new SqlParameter();
            paramTS.ParameterName = "ts";
            paramTS.Value = ts;
            inParam.Add(paramTS);
            DataBaseHelper helper = new DataBaseHelper();
            executeResult = helper.ExecuteNonQueryStoredProcedure_1(spName, null, inParam);

            return executeResult;
        }

        public static DataSet P_PaymentMode_List()
        {
            string spName = "P_PaymentMode_List";
            DataBaseHelper dbHelper = new DataBaseHelper();
            DataSet result = new DataSet();
            result = dbHelper.ExecuteStoredProcedure(spName);
            return result;
        }
    }
}
