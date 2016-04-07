using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubERP.DAL
{
    public class MSSQL_Crew
    {
        public static int P_Crew_Upsert(int sailId,
                                        int userId,
                                        string roleId,
                                        string stateId,
                                        DateTime ts)
        {
            int executeResult = 0;
            string spName = "P_Crew_Upsert";
            List<SqlParameter> inParam = new List<SqlParameter>();
            SqlParameter sailIdParam = new SqlParameter();
            sailIdParam.ParameterName = "sailId";
            sailIdParam.Value = sailId;
            inParam.Add(sailIdParam);
            SqlParameter userIdParam = new SqlParameter();
            userIdParam.ParameterName = "userId";
            userIdParam.Value = userId;
            inParam.Add(userIdParam);
            SqlParameter roleIdParam = new SqlParameter();
            roleIdParam.ParameterName = "roleId";
            roleIdParam.Value = roleId;
            inParam.Add(roleIdParam);
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

        public static DataSet P_Crew_List(int sailId)
        {
            string spName = "P_Crew_List";
            List<SqlParameter> inParam = new List<SqlParameter>();
            SqlParameter sailIdParam = new SqlParameter();
            sailIdParam.ParameterName = "sailId";
            sailIdParam.Value = sailId;
            inParam.Add(sailIdParam);

            DataBaseHelper dbHelper = new DataBaseHelper();
            DataSet result = new DataSet();
            result = dbHelper.ExecuteStoredProcedure(spName, inParam);
            return result;
        }

        public static int P_Crew_Detail(int id,
                                        out int sailId,
                                        out int userId,
                                        out string roleId,
                                        out string stateId,
                                        out DateTime ts)
        {
            int executeResult = 0;
            string spName = "P_Crew_Detail";
            List<SqlParameter> inParam = new List<SqlParameter>();
            SqlParameter idParam = new SqlParameter();
            idParam.ParameterName = "id";
            idParam.Value = id;
            inParam.Add(idParam);

            List<SqlParameter> outParam = new List<SqlParameter>();

            SqlParameter sailIdParam = new SqlParameter();
            sailIdParam.ParameterName = "sailId";
            sailIdParam.Direction = ParameterDirection.Output;
            sailIdParam.DbType = DbType.Int32;
            sailIdParam.Size = Int32.MaxValue;
            outParam.Add(sailIdParam);

            SqlParameter userIdParam = new SqlParameter();
            userIdParam.ParameterName = "userId";
            userIdParam.Direction = ParameterDirection.Output;
            userIdParam.DbType = DbType.String;
            userIdParam.Size = 128;
            outParam.Add(userIdParam);

            SqlParameter roleIdParam = new SqlParameter();
            roleIdParam.ParameterName = "roleId";
            roleIdParam.Direction = ParameterDirection.Output;
            roleIdParam.DbType = DbType.String;
            roleIdParam.Size = 10;
            outParam.Add(roleIdParam);

            SqlParameter paramStateId = new SqlParameter();
            paramStateId.ParameterName = "stateId";
            paramStateId.Direction = ParameterDirection.Output;
            paramStateId.DbType = DbType.String;
            paramStateId.Size = 10;
            outParam.Add(paramStateId);

            SqlParameter paramTS = new SqlParameter();
            paramTS.ParameterName = "ts";
            paramTS.Direction = ParameterDirection.Output;
            paramTS.DbType = DbType.DateTime;
            outParam.Add(paramTS);

            DataBaseHelper dbHelper = new DataBaseHelper();
            executeResult = dbHelper.ExecuteNonQueryStoredProcedure_1(spName, outParam, inParam);
            sailId = Convert.ToInt16(outParam[0].Value);
            userId = Convert.ToInt16(outParam[1].Value);
            roleId = outParam[2].Value.ToString();
            stateId = outParam[3].Value.ToString();
            ts = Convert.ToDateTime(outParam[4].Value.ToString());

            return executeResult;
        }
    }
}
