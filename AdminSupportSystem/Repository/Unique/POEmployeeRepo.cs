using DAL;
using Model.Entities.Unique;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace Repository.Unique
{
    public class POEmployeeRepo
    {
        public List<POEmployee> GetPODById(int Id)
        {
            List<ParmStruct> parms = new List<ParmStruct>();

            parms.Add(new ParmStruct("@Id", Id, SqlDbType.Int, ParameterDirection.Input, 0));

            DataAccess db = new DataAccess();

            DataTable dt = db.Execute("PurchaseOrderDetails_SearchById", CommandType.StoredProcedure, parms);

            List<POEmployee> result = new List<POEmployee>();
            foreach (DataRow r in dt.Rows)
            {
                result.Add(PopulatePOERecord(r));
            }
            return result;
        }

        public List<POEmployee> GetPODByDate(DateTime start, DateTime end)
        {
            List<ParmStruct> parms = new List<ParmStruct>();

            parms.Add(new ParmStruct("@StartDate", start, SqlDbType.DateTime, ParameterDirection.Input, 0));
            parms.Add(new ParmStruct("@EndDate", end, SqlDbType.DateTime, ParameterDirection.Input, 0));

            DataAccess db = new DataAccess();

            DataTable dt = db.Execute("PurchaseOrderDetails_SearchByDate", CommandType.StoredProcedure, parms);

            List<POEmployee> result = new List<POEmployee>();
            foreach (DataRow r in dt.Rows)
            {
                result.Add(PopulatePOERecord(r));
            }
            return result;
        }
        private POEmployee PopulatePOERecord(DataRow row)
        {
            POEmployee p = new POEmployee();

            p.CreationDate = Convert.ToDateTime(row["CreationDate"]);

            p.PONumber = row["PONumber"].ToString();

            p.ApprovalStatus = (ApprovalStatus)Convert.ToInt32(row["ApprovalStatus"]);

            p.Subtotal = Convert.ToDecimal(row["Subtotal"]);

            p.Tax = Convert.ToDecimal(row["Tax"]);

            p.GrandTotal = Convert.ToDecimal(row["GrandTotal"]);

            p.FirstName = row["FirstName"].ToString();

            p.LastName = row["LastName"].ToString();

            p.Department = Convert.ToInt32(row["Department"]);

            p.Supervisor = Convert.ToInt32(row["Supervisor"]);

            return p;
        }
       
    }
}
