using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubERP.DAL
{
    public class MSSQL_Sail
    {

        public static DataSet P_Sail_Search(DateTime departureDate,
                                            string boatId,
                                            string sailingModeId)
        {
            int executeResult = 0;
            string spName = "P_Sail_Search";
            List<SqlParameter> inParam = new List<SqlParameter>();

            SqlParameter departureDateParam = new SqlParameter();
            departureDateParam.ParameterName = "departureDate";
            departureDateParam.Value = departureDate;
            departureDateParam.IsNullable = true;
            inParam.Add(departureDateParam);

            SqlParameter boatIdParam = new SqlParameter();
            boatIdParam.ParameterName = "boatId";
            boatIdParam.Value = boatId;
            boatIdParam.IsNullable = true;
            inParam.Add(boatIdParam);

            SqlParameter sailingModeIdParam = new SqlParameter();
            sailingModeIdParam.ParameterName = "sailingModeId";
            sailingModeIdParam.Value = sailingModeId;
            sailingModeIdParam.IsNullable = true;
            inParam.Add(sailingModeIdParam);

            DataBaseHelper dbHelper = new DataBaseHelper();
            DataSet result = new DataSet();
            result = dbHelper.ExecuteStoredProcedure(spName, inParam);
            return result;
        }

        public static int P_Sail_Upsert(int id,
                                        DateTime departureDate,
                                        DateTime arrivalDate,
                                        string boatId,
                                        string departurePortId,
                                        string arrivalPortId,
                                        decimal price,
                                        string sailingModeId,
                                        string commentary,
                                        string stateId,
                                        DateTime? ts)

        {
            int executeResult = 0;
            string spName = "P_Sail_Upsert";
            List<SqlParameter> inParam = new List<SqlParameter>();

            SqlParameter idParam = new SqlParameter();
            idParam.ParameterName = "id";
            idParam.Value = id;
            inParam.Add(idParam);

            SqlParameter departureDateParam = new SqlParameter();
            departureDateParam.ParameterName = "departureDate";
            departureDateParam.Value = departureDate;
            inParam.Add(departureDateParam);

            SqlParameter arrivalDateParam = new SqlParameter();
            arrivalDateParam.ParameterName = "arrivalDate";
            arrivalDateParam.Value = arrivalDate;
            inParam.Add(arrivalDateParam);

            SqlParameter boatIdParam = new SqlParameter();
            boatIdParam.ParameterName = "boatId";
            boatIdParam.Value = boatId;
            inParam.Add(boatIdParam);

            SqlParameter departurePortIdParam = new SqlParameter();
            departurePortIdParam.ParameterName = "departurePortId";
            departurePortIdParam.Value = departurePortId;
            inParam.Add(departurePortIdParam);

            SqlParameter arrivalPortIdParam = new SqlParameter();
            arrivalPortIdParam.ParameterName = "arrivalPortId";
            arrivalPortIdParam.Value = arrivalPortId;
            inParam.Add(arrivalPortIdParam);

            SqlParameter priceParam = new SqlParameter();
            priceParam.ParameterName = "price";
            priceParam.Value = price;
            inParam.Add(priceParam);

            SqlParameter sailingModeIdParam = new SqlParameter();
            sailingModeIdParam.ParameterName = "sailingModeId";
            sailingModeIdParam.Value = sailingModeId;
            inParam.Add(sailingModeIdParam);

            SqlParameter commentaryParam = new SqlParameter();
            commentaryParam.ParameterName = "commentary";
            commentaryParam.Value = commentary;
            inParam.Add(commentaryParam);

            SqlParameter stateIdParam = new SqlParameter();
            stateIdParam.ParameterName = "stateId";
            stateIdParam.Value = stateId;
            inParam.Add(stateIdParam);

            SqlParameter paramTS = new SqlParameter();
            paramTS.ParameterName = "ts";
            paramTS.Value = ts;
            inParam.Add(paramTS);
            DataBaseHelper helper = new DataBaseHelper();
            executeResult = helper.ExecuteNonQueryStoredProcedure_1(spName, null, inParam);

            return executeResult;
        }


        public static DataSet P_Sail_List()
        {
            string spName = "P_Sail_List";
            DataBaseHelper dbHelper = new DataBaseHelper();
            DataSet result = new DataSet();
            result = dbHelper.ExecuteStoredProcedure(spName);
            return result;
        }


        public static int P_Sail_Detail(int id,
                                       out DateTime departureDate,
                                       out DateTime arrivalDate,
                                       out string boatId,
                                       out string departurePortId,
                                       out string arrivalPortId,
                                       out decimal price,
                                       out string sailingModeId,
                                       out string commentary,
                                       out string stateId,
                                       out DateTime ts)
        {
            int executeResult = 0;
            string spName = "P_Sail_Detail";
            List<SqlParameter> paramIn = new List<SqlParameter>();
            SqlParameter idParam = new SqlParameter();
            idParam.ParameterName = "id";
            idParam.Value = id;
            paramIn.Add(idParam);

            List<SqlParameter> outParam = new List<SqlParameter>();

            SqlParameter departureDateParam = new SqlParameter();
            departureDateParam.ParameterName = "departureDate";
            departureDateParam.Direction = ParameterDirection.Output;
            departureDateParam.DbType = DbType.DateTime;
            outParam.Add(departureDateParam);

            SqlParameter arrivalDateParam = new SqlParameter();
            arrivalDateParam.ParameterName = "arrivalDate";
            arrivalDateParam.Direction = ParameterDirection.Output;
            arrivalDateParam.DbType = DbType.DateTime;
            outParam.Add(arrivalDateParam);

            SqlParameter boatIdParam = new SqlParameter();
            boatIdParam.ParameterName = "boatId";
            boatIdParam.Direction = ParameterDirection.Output;
            boatIdParam.DbType = DbType.String;
            boatIdParam.Size = 10;
            outParam.Add(boatIdParam);

            SqlParameter departurePortIdParam = new SqlParameter();
            departurePortIdParam.ParameterName = "departurePortId";
            departurePortIdParam.Direction = ParameterDirection.Output;
            departurePortIdParam.DbType = DbType.String;
            departurePortIdParam.Size = 10;
            outParam.Add(departurePortIdParam);

            SqlParameter arrivalPortIdParam = new SqlParameter();
            arrivalPortIdParam.ParameterName = "arrivalPortId";
            arrivalPortIdParam.Direction = ParameterDirection.Output;
            arrivalPortIdParam.DbType = DbType.String;
            arrivalPortIdParam.Size = 10;
            outParam.Add(arrivalPortIdParam);

            SqlParameter priceParam = new SqlParameter();
            priceParam.ParameterName = "price";
            priceParam.Direction = ParameterDirection.Output;
            priceParam.DbType = DbType.Decimal;
            outParam.Add(priceParam);


            SqlParameter sailingModeIdParam = new SqlParameter();
            sailingModeIdParam.ParameterName = "sailingModeId";
            sailingModeIdParam.Direction = ParameterDirection.Output;
            sailingModeIdParam.DbType = DbType.String;
            sailingModeIdParam.Size = 10;
            outParam.Add(sailingModeIdParam);

            SqlParameter commentaryParam = new SqlParameter();
            commentaryParam.ParameterName = "commentary";
            commentaryParam.Direction = ParameterDirection.Output;
            commentaryParam.DbType = DbType.String;
            commentaryParam.Size = Int32.MaxValue;
            outParam.Add(commentaryParam);

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
            executeResult = dbHelper.ExecuteNonQueryStoredProcedure_1(spName, outParam, paramIn);

            departureDate = Convert.ToDateTime(outParam[0].Value);
            arrivalDate = Convert.ToDateTime(outParam[1].Value);
            boatId = outParam[2].Value.ToString();
            departurePortId = outParam[3].Value.ToString();
            arrivalPortId = outParam[4].Value.ToString();
            price = Convert.ToDecimal(outParam[5].Value);
            sailingModeId = outParam[6].Value.ToString();
            commentary = outParam[7].Value.ToString();
            stateId = outParam[8].Value.ToString();
            ts = Convert.ToDateTime(outParam[9].Value.ToString());
            return executeResult;
        }

    }
}
