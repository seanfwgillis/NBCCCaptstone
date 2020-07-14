using DAL;
using Model;
using Model.Entities;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Types;

namespace Repository
{
    public class PurchaseOrderRepo
    {

        public List<Purchase> GetPOById(int Id)
        {
            List<ParmStruct> parms = new List<ParmStruct>();

            parms.Add(new ParmStruct("@Id", Id, SqlDbType.Int, ParameterDirection.Input, 0));

            DataAccess db = new DataAccess();

            DataTable dt = db.Execute("PurchaseOrder_SearchById", CommandType.StoredProcedure, parms);

            List<Purchase> result = new List<Purchase>();
            foreach (DataRow r in dt.Rows)
            {
                result.Add(PopulatePORecord(r));
            }
            return result;
        }

        public Purchase GetForTotals(int id)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@Id", id, SqlDbType.Int, ParameterDirection.Input, 0));
            DataAccess db = new DataAccess();

            DataTable dt = db.Execute("PurchaseOrder_SearchById", CommandType.StoredProcedure, parms);

            return PopulatePORecord(dt.Rows[0]);
        }

        public List<Purchase> GetPOByDate(DateTime start, DateTime end)
        {
            List<ParmStruct> parms = new List<ParmStruct>();

            parms.Add(new ParmStruct("@StartDate", start, SqlDbType.DateTime, ParameterDirection.Input, 0));
            parms.Add(new ParmStruct("@EndDate", end, SqlDbType.DateTime, ParameterDirection.Input, 0));

            DataAccess db = new DataAccess();

            DataTable dt = db.Execute("PurchaseOrder_SearchByDate", CommandType.StoredProcedure, parms);

            List<Purchase> result = new List<Purchase>();
            foreach (DataRow r in dt.Rows)
            {
                result.Add(PopulatePORecord(r));
            }
            return result;
        }

        public ApprovalStatus GetPurchaseStatus(int Id)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@Id", Id, SqlDbType.Int));
            string sql = "SELECT ApprovalStatus FROM PurchaseOrder WHERE Id = @Id";
            DataAccess db = new DataAccess();

            return (ApprovalStatus)(db.ExecuteScaler(sql, CommandType.Text, parms));
        }

        public bool AddPO(Purchase p)
        {
            List<ParmStruct> parms = new List<ParmStruct>();

            parms.Add(new ParmStruct("@Id", p.Id, SqlDbType.Int, ParameterDirection.Input));
            parms.Add(new ParmStruct("@EmployeeId", p.EmployeeId, SqlDbType.Int, ParameterDirection.Input));
            parms.Add(new ParmStruct("@Supervisor", p.Supervisor, SqlDbType.Int, ParameterDirection.Input));
            //parms.Add(new ParmStruct("@CreationDate", p.CreationDate, SqlDbType.DateTime, ParameterDirection.Input));
            parms.Add(new ParmStruct("@ApprovalStatus", p.ApprovalStatus, SqlDbType.Int, ParameterDirection.Input));
    //        parms.Add(new ParmStruct("@Subtotal", p.Subtotal, SqlDbType.Money, ParameterDirection.Input));
     //       parms.Add(new ParmStruct("@Tax", p.Tax, SqlDbType.Money, ParameterDirection.Input));
     //       parms.Add(new ParmStruct("@GrandTotal", p.GrandTotal, SqlDbType.Money, ParameterDirection.Input));
            //   parms.Add(new ParmStruct("@TimeStamp", p.TimeStamp, SqlDbType.Timestamp, ParameterDirection.Input));

            DataAccess db = new DataAccess();

            if (db.ExecuteNonQuery("PurchaseOrder_Add", CommandType.StoredProcedure, parms) > 0)
            {
                return true;
            }
            return false;

        }

        public int GetPurchaseIDFromItem(int Id)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@Id", Id, SqlDbType.Int));
            string sql = "SELECT PurchaseOrder.Id FROM PurchaseOrder INNER JOIN Item ON PurchaseOrder.Id = Item.POId WHERE Item.Id = @Id";
            DataAccess db = new DataAccess();

            return Convert.ToInt32(db.ExecuteScaler(sql, CommandType.Text, parms));
        }

        public List<Purchase> UpdatePOSuper(int Id, String ModificationReason)
        {
            List<ParmStruct> parms = new List<ParmStruct>();

            parms.Add(new ParmStruct("@Id", Id, SqlDbType.Int, ParameterDirection.Input, 0));
            parms.Add(new ParmStruct("@ModificationReason", ModificationReason, SqlDbType.VarChar, ParameterDirection.Input, 0));

            DataAccess db = new DataAccess();

            DataTable dt = db.Execute("PurchaseOrder_UpdateIDSuper", CommandType.StoredProcedure, parms);

            List<Purchase> result = new List<Purchase>();
            foreach (DataRow r in dt.Rows)
            {
                result.Add(PopulatePORecord(r));
            }
            return result;
        }

        public Purchase CheckSupervisorID(int id)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@Id", id, SqlDbType.Int, ParameterDirection.Input, 0));
            DataAccess db = new DataAccess();

            DataTable dt = db.Execute("PurchaseOrder_CheckSupervisor", CommandType.StoredProcedure, parms);

            return PopulatePORecord(dt.Rows[0]);
        }

        public List<Purchase> UpdatePurchaseTotals(int Id, Purchase p)
        {
            List<ParmStruct> parms = new List<ParmStruct>();

            parms.Add(new ParmStruct("@Id", Id, SqlDbType.Int, ParameterDirection.Input, 0));
            parms.Add(new ParmStruct("@Subtotal", p.Subtotal, SqlDbType.Money, ParameterDirection.Input));

            DataAccess db = new DataAccess();

            DataTable dt = db.Execute("PurchaseOrder_UpdateTotals", CommandType.StoredProcedure, parms);

            List<Purchase> result = new List<Purchase>();
            foreach (DataRow r in dt.Rows)
            {
                result.Add(PopulatePORecord(r));
            }
            return result;
        }

        public Purchase DeletePO(int Id)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@Id", Id, SqlDbType.Int, ParameterDirection.Input, 0));
            DataAccess db = new DataAccess();

            DataTable dt = db.Execute("PurchaseOrder_Delete", CommandType.StoredProcedure, parms);

            return PopulatePORecord(dt.Rows[0]);
        }

        private Purchase PopulatePORecord(DataRow row)
        {
            Purchase p = new Purchase();

            p.Id = Convert.ToInt32(row["Id"]);

            p.PONumber = row["PONumber"].ToString();

            p.EmployeeId = Convert.ToInt32(row["EmployeeId"]);

            p.Supervisor = Convert.ToInt32(row["Supervisor"]);

            p.ApprovalStatus = (ApprovalStatus)Convert.ToInt32(row["ApprovalStatus"]);

            p.CreationDate = Convert.ToDateTime(row["CreationDate"]);

            p.Subtotal = Convert.ToDecimal(row["Subtotal"]);

            p.Tax = Convert.ToDecimal(row["Tax"]);

            p.GrandTotal = Convert.ToDecimal(row["GrandTotal"]);

            p.ModificationDate = Convert.ToDateTime(row["ModificationDate"]);

            p.ModificationReason = row["ModificationReason"].ToString();

            p.TimeStamp = (byte[])(row["TimeStamp"]);

            return p;
        }
    }
}

