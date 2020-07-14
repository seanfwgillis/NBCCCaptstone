using DAL;
using Model;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace Repository
{
    public class LoginRepo
    {
        public CredentialType GetLoginCredential(int employeeId)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@EmployeeId", employeeId, SqlDbType.Int));
            string sql = "SELECT Credential FROM Login WHERE EmployeeId = @EmployeeId";
            DataAccess db = new DataAccess();

            return (CredentialType)(db.ExecuteScaler(sql, CommandType.Text, parms));

        }

        public bool Insert(Login l)
        {
            List<ParmStruct> parms = new List<ParmStruct>();

            parms.Add(new ParmStruct("@Id", l.Id, SqlDbType.Int, ParameterDirection.Input));
            parms.Add(new ParmStruct("@Password", l.Password, SqlDbType.NVarChar, ParameterDirection.Input, 255));
            parms.Add(new ParmStruct("@Credential",(int)l.Credential, SqlDbType.Int, ParameterDirection.Input));
            DataAccess db = new DataAccess();

            if (db.ExecuteNonQuery("Login_Create", CommandType.StoredProcedure, parms) > 0)
            {
                return true;
            }
            return false;
        }

        #region Validation

        public int ValidateLogin(int employeeId, string password)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@EmployeeId", employeeId, SqlDbType.Int));
            parms.Add(new ParmStruct("@Password", password, SqlDbType.NVarChar, ParameterDirection.Input, 255));
            string sql = "SELECT COUNT(*) FROM Login WHERE EmployeeId = @EmployeeId AND Password = @Password";
            DataAccess db = new DataAccess();

            return Convert.ToInt32(db.ExecuteScaler(sql, CommandType.Text, parms));
        }
        #endregion
    }
}
