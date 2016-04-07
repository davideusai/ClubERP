using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubERP.DAL
{
    public class MSSQL_User
    {
        public static int P_User_Detail(int id,
                                        out string userName,
                                        out string firstName,
                                        out string lastName,
                                        out string eMail,
                                        out string phoneNumber,
                                        out string skypperRankId,
                                        out string identityId,
                                        out string stateId,
                                        out DateTime ts)
        {
            int executeResult = 0;
            string spName = "P_User_Detail";
            List<SqlParameter> paramIn = new List<SqlParameter>();
            SqlParameter idParam = new SqlParameter();
            idParam.ParameterName = "id";
            idParam.Value = id;
            paramIn.Add(idParam);

            List<SqlParameter> outParam = new List<SqlParameter>();

            SqlParameter userNameParam = new SqlParameter();
            userNameParam.ParameterName = "userName";
            userNameParam.Direction = ParameterDirection.Output;
            userNameParam.DbType = DbType.String;
            userNameParam.Size = 10;
            outParam.Add(userNameParam);

            SqlParameter firstNameParam = new SqlParameter();
            firstNameParam.ParameterName = "firstName";
            firstNameParam.Direction = ParameterDirection.Output;
            firstNameParam.DbType = DbType.String;
            firstNameParam.Size = 50;
            outParam.Add(firstNameParam);

            SqlParameter lastNameParam = new SqlParameter();
            lastNameParam.ParameterName = "lastName";
            lastNameParam.Direction = ParameterDirection.Output;
            lastNameParam.DbType = DbType.String;
            lastNameParam.Size = 50;
            outParam.Add(lastNameParam);

            SqlParameter eMailParam = new SqlParameter();
            eMailParam.ParameterName = "eMail";
            eMailParam.Direction = ParameterDirection.Output;
            eMailParam.DbType = DbType.String;
            eMailParam.Size = 50;
            outParam.Add(eMailParam);

            SqlParameter phoneNumberParam = new SqlParameter();
            phoneNumberParam.ParameterName = "phoneNumber";
            phoneNumberParam.Direction = ParameterDirection.Output;
            phoneNumberParam.DbType = DbType.String;
            phoneNumberParam.Size = 50;
            outParam.Add(phoneNumberParam);

            SqlParameter identityIdParam = new SqlParameter();
            identityIdParam.ParameterName = "identityId";
            identityIdParam.Direction = ParameterDirection.Output;
            identityIdParam.DbType = DbType.String;
            identityIdParam.Size = 128;
            outParam.Add(identityIdParam);

            SqlParameter skypperRankIdParam = new SqlParameter();
            skypperRankIdParam.ParameterName = "skypperRankId";
            skypperRankIdParam.Direction = ParameterDirection.Output;
            skypperRankIdParam.DbType = DbType.String;
            skypperRankIdParam.Size = 10;
            outParam.Add(skypperRankIdParam);

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
            userName = outParam[0].Value.ToString();
            firstName = outParam[1].Value.ToString();
            lastName = outParam[2].Value.ToString();
            eMail = outParam[3].Value.ToString();
            phoneNumber = outParam[4].Value.ToString();
            identityId = outParam[5].Value.ToString();
            skypperRankId = outParam[6].Value.ToString();
            stateId = outParam[7].Value.ToString();
            ts = Convert.ToDateTime(outParam[8].Value.ToString());
            return executeResult;
        }


        public static int P_User_Upsert(string userName,
                                        string firstName,
                                        string lastName,
                                        string adressMail,
                                        string phoneNumber,
                                        string skypperRankId,
                                        string identityId,
                                        string stateId,
                                        DateTime ts)
        {
            int executeResult = 0;
            string spName = "P_User_Upsert";
            List<SqlParameter> inParam = new List<SqlParameter>();

            SqlParameter userNameParam = new SqlParameter();
            userNameParam.ParameterName = "userName";
            userNameParam.Value = userName;
            inParam.Add(userNameParam);

            SqlParameter firstNameParam = new SqlParameter();
            firstNameParam.ParameterName = "firstName";
            firstNameParam.Value = firstName;
            inParam.Add(firstNameParam);

            SqlParameter lastNameParam = new SqlParameter();
            lastNameParam.ParameterName = "lastName";
            lastNameParam.Value = lastName;
            inParam.Add(lastNameParam);

            SqlParameter adressMailParam = new SqlParameter();
            adressMailParam.ParameterName = "eMail";
            adressMailParam.Value = adressMail;
            inParam.Add(adressMailParam);

            SqlParameter phoneNumberParam = new SqlParameter();
            phoneNumberParam.ParameterName = "phoneNumber";
            phoneNumberParam.Value = phoneNumber;
            inParam.Add(phoneNumberParam);

            SqlParameter skypperRankIdParam = new SqlParameter();
            skypperRankIdParam.ParameterName = "skypperRankId";
            skypperRankIdParam.Value = skypperRankId;
            inParam.Add(skypperRankIdParam);

            SqlParameter identityIdParam = new SqlParameter();
            identityIdParam.ParameterName = "identityId";
            identityIdParam.Value = identityId;
            inParam.Add(identityIdParam);

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

        public static DataSet P_User_List()
        {
            string spName = "P_User_List";
            DataBaseHelper dbHelper = new DataBaseHelper();
            DataSet result = new DataSet();
            result = dbHelper.ExecuteStoredProcedure(spName);
            return result;
        }

        public static DataSet P_User_Search(string userName,
                                            string firstName,
                                            string lastName,
                                            string adressMail,
                                            string phoneNumber,
                                            string skypperRankId,
                                            string stateId)
        {
            string spName = "P_User_Search";
            List<SqlParameter> inParam = new List<SqlParameter>();

            SqlParameter userNameParam = new SqlParameter();
            userNameParam.ParameterName = "userName";
            userNameParam.Value = userName;
            inParam.Add(userNameParam);

            SqlParameter firstNameParam = new SqlParameter();
            firstNameParam.ParameterName = "firstName";
            firstNameParam.Value = firstName;
            inParam.Add(firstNameParam);

            SqlParameter lastNameParam = new SqlParameter();
            lastNameParam.ParameterName = "lastName";
            lastNameParam.Value = lastName;
            inParam.Add(lastNameParam);

            SqlParameter adressMailParam = new SqlParameter();
            adressMailParam.ParameterName = "eMail";
            adressMailParam.Value = adressMail;
            inParam.Add(adressMailParam);

            SqlParameter phoneNumberParam = new SqlParameter();
            phoneNumberParam.ParameterName = "phoneNumber";
            phoneNumberParam.Value = phoneNumber;
            inParam.Add(phoneNumberParam);

            SqlParameter skypperRankIdParam = new SqlParameter();
            skypperRankIdParam.ParameterName = "skypperRankId";
            skypperRankIdParam.Value = skypperRankId;
            inParam.Add(skypperRankIdParam);

            SqlParameter paramStateId = new SqlParameter();
            paramStateId.ParameterName = "stateId";
            paramStateId.Value = stateId;
            inParam.Add(paramStateId);

            DataBaseHelper dbHelper = new DataBaseHelper();
            DataSet result = new DataSet();
            result = dbHelper.ExecuteStoredProcedure(spName, inParam);
            return result;
        }
    }
}
