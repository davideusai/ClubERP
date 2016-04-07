using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ClubERP.DAL
{
    class MSSQLStoredProcedureCall
    {
        public static int P_Port_Detail(string id,
                                        out string name,
                                        out string description,
                                        out string photo,
                                        out string url,
                                        out decimal latitude,
                                        out decimal longitude,
                                        out string city,
                                        out string stateId,
                                        out DateTime ts)
        {
            int executeResult = 0;
            string spName = "P_Port_Detail";
            List<SqlParameter> paramIn = new List<SqlParameter>();
            SqlParameter paramId = new SqlParameter();
            paramId.ParameterName = "id";
            paramId.Value = id;
            paramIn.Add(paramId);

            List<SqlParameter> paramOut = new List<SqlParameter>();
            SqlParameter paramName = new SqlParameter();
            paramName.ParameterName = "name";
            paramName.Direction = ParameterDirection.Output;
            paramName.DbType = DbType.String;
            paramName.Size = 50;
            paramOut.Add(paramName);

            SqlParameter paramDescription = new SqlParameter();
            paramDescription.ParameterName = "description";
            paramDescription.Direction = ParameterDirection.Output;
            paramDescription.DbType = DbType.String;
            paramDescription.Size = 3000;
            paramOut.Add(paramDescription);

            SqlParameter photoParam = new SqlParameter();
            photoParam.ParameterName = "photo";
            photoParam.Direction = ParameterDirection.Output;
            photoParam.DbType = DbType.String;
            photoParam.Size = 255;
            paramOut.Add(photoParam);

            SqlParameter urlParam = new SqlParameter();
            urlParam.ParameterName = "url";
            urlParam.Direction = ParameterDirection.Output;
            urlParam.DbType = DbType.String;
            urlParam.Size = 255;
            paramOut.Add(urlParam);

            SqlParameter latitudeParam = new SqlParameter();
            latitudeParam.ParameterName = "latitude";
            latitudeParam.Direction = ParameterDirection.Output;
            latitudeParam.DbType = DbType.Decimal;
            latitudeParam.Precision = 9;
            latitudeParam.Scale = 6;
            paramOut.Add(latitudeParam);

            SqlParameter longitudeParam = new SqlParameter();
            longitudeParam.ParameterName = "longitude";
            longitudeParam.Direction = ParameterDirection.Output;
            longitudeParam.DbType = DbType.Decimal;
            longitudeParam.Precision = 9;
            longitudeParam.Scale = 6;
            paramOut.Add(longitudeParam);

            SqlParameter cityParam = new SqlParameter();
            cityParam.ParameterName = "city";
            cityParam.Direction = ParameterDirection.Output;
            cityParam.DbType = DbType.String;
            cityParam.Size = 10;
            paramOut.Add(cityParam);

            SqlParameter paramStateId = new SqlParameter();
            paramStateId.ParameterName = "stateId";
            paramStateId.Direction = ParameterDirection.Output;
            paramStateId.DbType = DbType.String;
            paramStateId.Size = 10;
            paramOut.Add(paramStateId);

            SqlParameter paramTS = new SqlParameter();
            paramTS.ParameterName = "ts";
            paramTS.Direction = ParameterDirection.Output;
            paramTS.DbType = DbType.DateTime;
            paramOut.Add(paramTS);

            DataBaseHelper dbHelper = new DataBaseHelper();
            executeResult = dbHelper.ExecuteNonQueryStoredProcedure_1(spName, paramOut, paramIn);
            name = paramOut[0].Value.ToString();
            description = paramOut[1].Value.ToString();
            photo = paramOut[2].ToString();
            url = paramOut[3].Value.ToString();
            latitude = Convert.ToDecimal(paramOut[4].Value.ToString());
            longitude = Convert.ToDecimal(paramOut[5].Value.ToString());
            city = paramOut[6].Value.ToString();
            stateId = paramOut[7].Value.ToString();
            ts = Convert.ToDateTime(paramOut[8].Value.ToString());
            return executeResult;
        }

        public static DataSet P_Port_List()
        {
            string spName = "P_Port_List";
            DataBaseHelper dbHelper = new DataBaseHelper();
            DataSet result = new DataSet();
            result = dbHelper.ExecuteStoredProcedure(spName);
            return result;
        }

       
        public static int P_Port_Upsert(string id, 
                                        string name,
                                        string description,
                                        string photo,
                                        string url,
                                        decimal latitude,
                                        decimal longitude,
                                        string city,
                                        string stateId,
                                        DateTime ts) 
        
        {
            int executeResult = 0;
            string spName = "P_Port_Upsert";
            List<SqlParameter> inParam = new List<SqlParameter>();
            SqlParameter idParam = new SqlParameter();
            idParam.ParameterName = "id";
            idParam.Value = id;
            inParam.Add(idParam);

            SqlParameter nameParam = new SqlParameter();
            nameParam.ParameterName = "name";
            nameParam.Value = name;
            inParam.Add(nameParam);

            SqlParameter descriptionParam = new SqlParameter();
            descriptionParam.ParameterName = "description";
            descriptionParam.Value = description;
            inParam.Add(descriptionParam);

            SqlParameter photoPathParam = new SqlParameter();
            photoPathParam.ParameterName = "photo";
            photoPathParam.Value = photo;
            inParam.Add(photoPathParam);

            SqlParameter urlWebSiteParam = new SqlParameter();
            urlWebSiteParam.ParameterName = "url";
            urlWebSiteParam.Value = url;
            inParam.Add(urlWebSiteParam);

            SqlParameter latitudeParam = new SqlParameter();
            latitudeParam.ParameterName = "latitude";
            latitudeParam.Value = latitude;
            inParam.Add(latitudeParam);

            SqlParameter longitudeParam = new SqlParameter();
            longitudeParam.ParameterName = "longitude";
            longitudeParam.Value = longitude;
            inParam.Add(longitudeParam);

            SqlParameter cityParam = new SqlParameter();
            cityParam.ParameterName = "city";
            cityParam.Value = city;
            inParam.Add(cityParam);

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

        public static int P_Boat_Upsert(string id,
                                 string name,
                                 string description,
                                 DateTime dateBuild,
                                 DateTime dateEntryClub,
                                 string photo,
                                 int crewMax,
                                 string minSkypperRankId,
                                 string stateId,
                                 DateTime ts)
        {
            int executeResult = 0;
            string spName = "P_Boat_Upsert";
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
            SqlParameter paramDateConstruction = new SqlParameter();
            paramDateConstruction.ParameterName = "dateBuild";
            paramDateConstruction.Value = dateBuild;
            inParam.Add(paramDateConstruction);
            SqlParameter paramDateEntryClub = new SqlParameter();
            paramDateEntryClub.ParameterName = "dateEntryClub";
            paramDateEntryClub.Value = dateEntryClub;
            inParam.Add(paramDateEntryClub);
            SqlParameter paramPhoto = new SqlParameter();
            paramPhoto.ParameterName = "photo";
            paramPhoto.Value = photo;
            inParam.Add(paramPhoto);
            SqlParameter paramCrewMax = new SqlParameter();
            paramCrewMax.ParameterName = "crewMax";
            paramCrewMax.Value = crewMax;
            inParam.Add(paramCrewMax);
            SqlParameter paramMinSkypperRankId = new SqlParameter();
            paramMinSkypperRankId.ParameterName = "minSkypperRankId";
            paramMinSkypperRankId.Value = minSkypperRankId;
            inParam.Add(paramMinSkypperRankId);
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

        public static int P_State_Upsert(string id,
                                 string name,
                                 string description,
                                 string family,
                                 DateTime ts)
        {
            int executeResult = 0;
            string spName = "P_State_Upsert";
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
            SqlParameter paramFamily = new SqlParameter();
            paramFamily.ParameterName = "family";
            paramFamily.Value = family;
            paramIn.Add(paramFamily);
            SqlParameter paramTS = new SqlParameter();
            paramTS.ParameterName = "ts";
            paramTS.Value = ts;
            paramIn.Add(paramTS);
            DataBaseHelper dbHelper = new DataBaseHelper();
            executeResult = dbHelper.ExecuteNonQueryStoredProcedure_1(spName, null, paramIn);
            return executeResult;
        }

        public static DataSet P_Boat_List()
        {
            string spName = "P_Boat_List";
            DataBaseHelper dbHelper = new DataBaseHelper();
            DataSet result = new DataSet();
            result = dbHelper.ExecuteStoredProcedure(spName);
            return result;
        }

        public static DataSet P_State_List()
        {
            string spName = "P_State_List";
            DataBaseHelper dbHelper = new DataBaseHelper();
            DataSet result = new DataSet();
            result = dbHelper.ExecuteStoredProcedure(spName);
            return result;
        }
        public static int P_Boat_Detail(string id,
                                        out string name,
                                        out string description,
                                        out DateTime dateBuild,
                                        out DateTime dateEntryClub,
                                        out string photo,
                                        out int crewMax,
                                        out string minSkypperRankId,
                                        out string stateId,
                                        out DateTime ts)
        {
            int executeResult = 0;
            string spName = "P_Boat_Detail";
            List<SqlParameter> paramIn = new List<SqlParameter>();
            SqlParameter paramId = new SqlParameter();
            paramId.ParameterName = "id";
            paramId.Value = id;
            paramIn.Add(paramId);

            List<SqlParameter> paramOut = new List<SqlParameter>();
            SqlParameter paramName = new SqlParameter();
            paramName.ParameterName = "name";
            paramName.Direction = ParameterDirection.Output;
            paramName.DbType = DbType.String;
            paramName.Size = 50;
            paramOut.Add(paramName);

            SqlParameter paramDescription = new SqlParameter();
            paramDescription.ParameterName = "description";
            paramDescription.Direction = ParameterDirection.Output;
            paramDescription.DbType = DbType.String;
            paramDescription.Size = 3000;
            paramOut.Add(paramDescription);

            SqlParameter paramDateConstruction = new SqlParameter();
            paramDateConstruction.ParameterName = "dateBuild";
            paramDateConstruction.Direction = ParameterDirection.Output;
            paramDateConstruction.DbType = DbType.Date;
            paramOut.Add(paramDateConstruction);

            SqlParameter paramDateEntryClub = new SqlParameter();
            paramDateEntryClub.ParameterName = "dateEntryClub";
            paramDateEntryClub.Direction = ParameterDirection.Output;
            paramDateEntryClub.DbType = DbType.Date;
            paramOut.Add(paramDateEntryClub);

            SqlParameter paramPhoto = new SqlParameter();
            paramPhoto.ParameterName = "photo";
            paramPhoto.Direction = ParameterDirection.Output;
            paramPhoto.DbType = DbType.String;
            paramPhoto.Size = 255;
            paramOut.Add(paramPhoto);
            
            SqlParameter paramCrew = new SqlParameter();
            paramCrew.ParameterName = "crewMax";
            paramCrew.Direction = ParameterDirection.Output;
            paramCrew.DbType = DbType.Int16;
            paramOut.Add(paramCrew);

            SqlParameter paramMinSkypperRankId = new SqlParameter();
            paramMinSkypperRankId.ParameterName = "minSkypperRankId";
            paramMinSkypperRankId.Direction = ParameterDirection.Output;
            paramMinSkypperRankId.DbType = DbType.String;
            paramMinSkypperRankId.Size = 10;
            paramOut.Add(paramMinSkypperRankId);
            
            SqlParameter paramStateId = new SqlParameter();
            paramStateId.ParameterName = "stateId";
            paramStateId.Direction = ParameterDirection.Output;
            paramStateId.DbType = DbType.String;
            paramStateId.Size = 10;
            paramOut.Add(paramStateId);
            
            SqlParameter paramTS = new SqlParameter();
            paramTS.ParameterName = "ts";
            paramTS.Direction = ParameterDirection.Output;
            paramTS.DbType = DbType.DateTime;
            paramOut.Add(paramTS);

            DataBaseHelper dbHelper = new DataBaseHelper();
            executeResult = dbHelper.ExecuteNonQueryStoredProcedure_1(spName, paramOut, paramIn);
            name = paramOut[0].Value.ToString();
            description = paramOut[1].Value.ToString();
            dateBuild = Convert.ToDateTime(paramOut[2].Value);
            dateEntryClub = Convert.ToDateTime(paramOut[3].Value);
            photo = paramOut[4].ToString();
            crewMax = Convert.ToInt16(paramOut[5].Value.ToString());
            minSkypperRankId = paramOut[6].Value.ToString();
            stateId = paramOut[7].Value.ToString();
            ts = Convert.ToDateTime(paramOut[8].Value.ToString());
            return executeResult;
        }

        

        

        
    }
}
