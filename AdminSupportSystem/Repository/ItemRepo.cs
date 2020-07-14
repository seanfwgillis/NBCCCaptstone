using DAL;
using Model.Entities;
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
    public class ItemRepo
    {
        public bool AddItem(Item i)
        {
            List<ParmStruct> parms = new List<ParmStruct>();

            parms.Add(new ParmStruct("@Id", i.Id, SqlDbType.Int, ParameterDirection.Input));
            parms.Add(new ParmStruct("@Name", i.Name, SqlDbType.NVarChar, ParameterDirection.Input));
            parms.Add(new ParmStruct("@Description", i.Description, SqlDbType.NVarChar, ParameterDirection.Input, 255));
            parms.Add(new ParmStruct("@UnitPrice", i.UnitPrice, SqlDbType.Decimal, ParameterDirection.Input));
            parms.Add(new ParmStruct("@Location", i.Location, SqlDbType.NVarChar, ParameterDirection.Input));
            parms.Add(new ParmStruct("@Justification", i.Justification, SqlDbType.NVarChar, ParameterDirection.Input, 255));
            parms.Add(new ParmStruct("@Quantity", i.Quantity, SqlDbType.Int, ParameterDirection.Input));
            parms.Add(new ParmStruct("@ItemStatus", i.ItemStatus, SqlDbType.Int, ParameterDirection.Input));

            DataAccess db = new DataAccess();

            if (db.ExecuteNonQuery("Item_Add", CommandType.StoredProcedure, parms) > 0)
            {
                return true;
            }
            return false;

        }

        public ItemStatusType GetItemStatus(int Id)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@Id", Id, SqlDbType.Int));
            string sql = "SELECT ItemStatus FROM Item WHERE Id = @Id";
            DataAccess db = new DataAccess();

            return (ItemStatusType)(db.ExecuteScaler(sql, CommandType.Text, parms));
        }

        public List<Item> GetItemsByDate(DateTime start, DateTime end)
        {
            List<ParmStruct> parms = new List<ParmStruct>();

            parms.Add(new ParmStruct("@StartDate", start, SqlDbType.DateTime, ParameterDirection.Input, 0));
            parms.Add(new ParmStruct("@EndDate", end, SqlDbType.DateTime, ParameterDirection.Input, 0));

            DataAccess db = new DataAccess();

            DataTable dt = db.Execute("Item_SearchByDate", CommandType.StoredProcedure, parms);

            List<Item> result = new List<Item>();
            foreach (DataRow r in dt.Rows)
            {
                result.Add(PopulateItemRecord(r));
            }
            return result;
        }

        public Item GetItemById(int id)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@Id", id, SqlDbType.Int, ParameterDirection.Input, 0));
            DataAccess db = new DataAccess();

            DataTable dt = db.Execute("Item_SearchById", CommandType.StoredProcedure, parms);

            return PopulateItemRecord(dt.Rows[0]);
        }

        public bool UpdateItemSuper(Item i)
        {
            List<ParmStruct> parms = new List<ParmStruct>();

            parms.Add(new ParmStruct("@Id", i.Id, SqlDbType.Int, ParameterDirection.Input));
            parms.Add(new ParmStruct("@UnitPrice", i.UnitPrice, SqlDbType.Decimal, ParameterDirection.Input));
            parms.Add(new ParmStruct("@Location", i.Location, SqlDbType.NVarChar, ParameterDirection.Input));
            parms.Add(new ParmStruct("@Quantity", i.Quantity, SqlDbType.Int, ParameterDirection.Input));

            DataAccess db = new DataAccess();

            if (db.ExecuteNonQuery("Item_UpdateSuper", CommandType.StoredProcedure, parms) > 0)
            {
                return true;
            }
            return false;
        }

        public List<Item> GetItems()
        {
            DataAccess db = new DataAccess();

            DataTable dt = db.Execute("Item_GetItems", CommandType.StoredProcedure);

            List<Item> result = new List<Item>();
            foreach (DataRow r in dt.Rows)
            {
                result.Add(PopulateItemRecord(r));
            }
            return result;
        }

        public List<Item> UpdateItemPO(int Id)
        {
            List<ParmStruct> parms = new List<ParmStruct>();

            parms.Add(new ParmStruct("@Id", Id, SqlDbType.Int, ParameterDirection.Input, 0));

            DataAccess db = new DataAccess();

            DataTable dt = db.Execute("Item_UpdatePOID", CommandType.StoredProcedure, parms);

            List<Item> result = new List<Item>();
            foreach (DataRow r in dt.Rows)
            {
                result.Add(PopulateItemRecord(r));
            }
            return result;
        }

        public List<Item> GetItemsById(int POId)
        {
            List<ParmStruct> parms = new List<ParmStruct>();

            parms.Add(new ParmStruct("@POId", POId, SqlDbType.Int, ParameterDirection.Input, 0));

            DataAccess db = new DataAccess();

            DataTable dt = db.Execute("Item_SearchByPOId", CommandType.StoredProcedure, parms);

            List<Item> result = new List<Item>();
            foreach (DataRow r in dt.Rows)
            {
                result.Add(PopulateItemRecord(r));
            }
            return result;
        }
        private Item PopulateItemRecord(DataRow row)
        {
            Item i = new Item();

            i.Id = Convert.ToInt32(row["Id"]);

            i.Name = Convert.ToString(row["Name"]);

            i.Description = Convert.ToString(row["Description"]);

            i.UnitPrice = Convert.ToDecimal(row["UnitPrice"]);

            i.Location = Convert.ToString(row["Location"]);

            i.Justification = Convert.ToString(row["Justification"]);

            i.Quantity = Convert.ToInt32(row["Quantity"]);

            i.ItemTotal = Convert.ToDecimal(row["ItemTotal"]);

            i.ItemStatus = (ItemStatusType)Convert.ToInt32(row["ItemStatus"]);

            return i;
        }

        public bool UpdateItem(Item i)
        {
            List<ParmStruct> parms = new List<ParmStruct>();

            parms.Add(new ParmStruct("@Id", i.Id, SqlDbType.Int, ParameterDirection.Input));
            parms.Add(new ParmStruct("@Name", i.Name, SqlDbType.NVarChar, ParameterDirection.Input));
            parms.Add(new ParmStruct("@Description", i.Description, SqlDbType.NVarChar, ParameterDirection.Input, 255));
            parms.Add(new ParmStruct("@UnitPrice", i.UnitPrice, SqlDbType.Decimal, ParameterDirection.Input));
            parms.Add(new ParmStruct("@Location", i.Location, SqlDbType.NVarChar, ParameterDirection.Input));
            parms.Add(new ParmStruct("@Justification", i.Justification, SqlDbType.NVarChar, ParameterDirection.Input, 255));
            parms.Add(new ParmStruct("@Quantity", i.Quantity, SqlDbType.Int, ParameterDirection.Input));

            DataAccess db = new DataAccess();

            if (db.ExecuteNonQuery("Item_UpdateAll", CommandType.StoredProcedure, parms) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
