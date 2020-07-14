using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace Repository
{
    public class ReviewRepo
    {
        #region Post
        public bool CreateReview(Review r)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@EmployeeId", r.EmployeeId, SqlDbType.Int));
            parms.Add(new ParmStruct("@SupervisorId", r.SupervisorId, SqlDbType.Int));
            parms.Add(new ParmStruct("@Date", r.Date, SqlDbType.DateTime));
            parms.Add(new ParmStruct("@Rating", r.Rating, SqlDbType.Int));
            parms.Add(new ParmStruct("@Comments", r.Comments, SqlDbType.VarChar, ParameterDirection.Input, 255));

            DataAccess db = new DataAccess();

            if (db.ExecuteNonQuery("Review_Add", CommandType.StoredProcedure, parms) > 0)
            {
                return true;
            }
            return false;

        }
        #endregion
        #region Get/Lists

        public Review GetReview(int id)
        {
            List<ParmStruct> parms = new List<ParmStruct>();

            parms.Add(new ParmStruct("@Id", id, SqlDbType.Int, ParameterDirection.Input));

            DataAccess db = new DataAccess();
            DataTable dt = db.Execute("Review_GetById", CommandType.StoredProcedure, parms);

            return PopulateReviewDetails(dt.Rows[0]);
        }
        public List<Review> GetReviewsByEmployeeId(int employeeId)
        {
            List<ParmStruct> parms = new List<ParmStruct>();

            parms.Add(new ParmStruct("@EmployeeId", employeeId, SqlDbType.Int, ParameterDirection.Input));

            DataAccess db = new DataAccess();
            DataTable dt = db.Execute("Reviews_GetByEmployeeId", CommandType.StoredProcedure, parms);

            List<Review> reviews = new List<Review>();

            foreach (DataRow row in dt.Rows)
            {
                reviews.Add(PopulateReviewDetails(row));
            }

            return reviews;
        }

        public List<Review> GetReviewsBySupervisor(int supervisorId)
        {
            List<ParmStruct> parms = new List<ParmStruct>();

            parms.Add(new ParmStruct("@SupervisorId", supervisorId, SqlDbType.Int, ParameterDirection.Input));

            DataAccess db = new DataAccess();
            DataTable dt = db.Execute("Reviews_GetBySupervisor", CommandType.StoredProcedure, parms);

            List<Review> reviews = new List<Review>();

            foreach (DataRow row in dt.Rows)
            {
                reviews.Add(PopulateReviewDetails(row));
            }

            return reviews;
        }
        #endregion
        #region Unique
        public DateTime? GetLastReviewDate(int id)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@EmployeeId", id, SqlDbType.Int));
            string sql = "SELECT MAX(Date) FROM Review WHERE EmployeeId = @EmployeeId";
            DataAccess db = new DataAccess();
            var holder = db.ExecuteScaler(sql, CommandType.Text, parms);



            return holder != DBNull.Value ? (DateTime?)holder : new DateTime?();

        }

        #endregion
        #region Helpers
        private Review PopulateReviewDetails(DataRow row)
        {
            Review r = new Review();
            r.Id = Convert.ToInt32(row["Id"]);
            r.EmployeeId = Convert.ToInt32(row["EmployeeId"]);
            r.SupervisorId = Convert.ToInt32(row["SupervisorId"]);
            r.Date = Convert.ToDateTime(row["Date"]);
            r.Rating = (Model.Enums.ReviewRatingType)row["Rating"];
            r.Comments = row["Comments"].ToString();

            return r;
        }
        #endregion
    }
}
