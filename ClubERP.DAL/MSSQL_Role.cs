using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubERP.DAL
{
    public class MSSQL_Role
    {
        public static int P_Role_Upsert(string id,
                                 string name,
                                 string description,
                                 string stateId,
                                 DateTime ts)
        {
            int executeResult = 0;

            string spName = "P_Role_Upsert";
            List<SqlParameter> paramIn = new List<SqlParameter>();
            SqlParameter paramId = new SqlParameter();
            paramId.ParameterName = "id";
            paramId.Value = id;
            paramIn.Add(paramId);

            SqlParameter paramName = new SqlParameter();
            paramName.ParameterName = "name";
            paramName.Value = name;
            paramIn.Add(paramName);

            SqlParameter paramDescription = new SqlParameter();
            paramDescription.ParameterName = "description";
            paramDescription.Value = description;
            paramIn.Add(paramDescription);

            SqlParameter paramStateId = new SqlParameter();
            paramStateId.ParameterName = "stateId";
            paramStateId.Value = stateId;
            paramIn.Add(paramStateId);

            SqlParameter paramTS = new SqlParameter();
            paramTS.ParameterName = "ts";
            paramTS.Value = ts;
            paramIn.Add(paramTS);
            DataBaseHelper helper = new DataBaseHelper();
            executeResult = helper.ExecuteNonQueryStoredProcedure_1(spName, null, paramIn);
            return executeResult;
        }
        public static DataSet P_Role_List()
        {
            string spName = "P_Role_List";
            DataBaseHelper dbHelper = new DataBaseHelper();
            DataSet result = new DataSet();
            result = dbHelper.ExecuteStoredProcedure(spName);
            return result;
        }
    }
}
