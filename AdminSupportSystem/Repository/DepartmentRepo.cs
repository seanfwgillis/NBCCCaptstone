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
    public class DepartmentRepo
    {
        #region Post
        public bool Insert (Department d)
        {
            List<ParmStruct> parms = new List<ParmStruct>();

            parms.Add(new ParmStruct("@Name", d.Name, SqlDbType.VarChar, ParameterDirection.Input));
            parms.Add(new ParmStruct("@Description", d.Description, SqlDbType.VarChar, ParameterDirection.Input, 255));
            parms.Add(new ParmStruct("@InvocationDate", d.InvocationDate, SqlDbType.DateTime, ParameterDirection.Input));

            DataAccess db = new DataAccess();

            if (db.ExecuteNonQuery("Department_Add", CommandType.StoredProcedure, parms) > 0)
            { 
                return true;
            }
            return false;

        }
        public bool Update(Department d)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@TimeStamp", d.TimeStamp, SqlDbType.Timestamp, ParameterDirection.InputOutput));
            parms.Add(new ParmStruct("@Id", d.Id, SqlDbType.Int, ParameterDirection.Input));
            parms.Add(new ParmStruct("@Name", d.Name, SqlDbType.VarChar, ParameterDirection.Input, 50));
            parms.Add(new ParmStruct("@Description", d.Description, SqlDbType.VarChar, ParameterDirection.Input, 255));
            parms.Add(new ParmStruct("@InvocationDate", d.InvocationDate, SqlDbType.DateTime, ParameterDirection.Input));

            DataAccess db = new DataAccess();
            if (db.ExecuteNonQuery("Department_Modify", CommandType.StoredProcedure, parms) > 0)
            {
                d.TimeStamp = (byte[])parms[0].Value;
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@DepartmentId", id, SqlDbType.Int, ParameterDirection.Input));
            DataAccess db = new DataAccess();

            if (db.ExecuteNonQuery("Department_Delete", CommandType.StoredProcedure, parms) > 0)
            {
                return true;
            }
            return false;
        }
        #endregion

        #region Get
        public Department GetDepartmentById(int id)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@DepartmentId", id, SqlDbType.Int, ParameterDirection.Input, 0));
            DataAccess db = new DataAccess();

            DataTable dt = db.Execute("Department_Get_Id", CommandType.StoredProcedure, parms);

            return FillDepartmentObject(dt.Rows[0]);
        }

        public Department GetDepartmentBySupId(int id)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@EmployeeId", id, SqlDbType.Int, ParameterDirection.Input, 0));
            DataAccess db = new DataAccess();

            DataTable dt = db.Execute("Department_Get_BySupId", CommandType.StoredProcedure, parms);

            return FillDepartmentObject(dt.Rows[0]);
        }


        #endregion

        #region Lists
        public List<DepartmentLookup> GetDepartments()
        {

            DataAccess db = new DataAccess();
            DataTable dt = db.Execute("Departments_Get", CommandType.StoredProcedure);

            List<DepartmentLookup> departments = new List<DepartmentLookup>();

            foreach (DataRow row in dt.Rows)
            {
                departments.Add(new DepartmentLookup()
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Name = row["Name"].ToString()

                });
            }

            return departments;
        }

        public List<Department> GetDepartmentsAllInfo()
        {
            DataAccess db = new DataAccess();
            DataTable dt = db.Execute("Departments_Get_AllInfo", CommandType.StoredProcedure);

            List<Department> departments = new List<Department>();

            foreach (DataRow row in dt.Rows)
            {
                departments.Add(new Department()
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Name = row["Name"].ToString(),
                    Description = row["Description"].ToString(),
                    InvocationDate = Convert.ToDateTime(row["Description"])

                });
                ;
            }

            return departments;
        }


        public List<JobLookup> GetJobsByDepartmentId(int departmentId)
        {
            List<ParmStruct> parms = new List<ParmStruct>();

            parms.Add(new ParmStruct("@DepartmentId", departmentId, SqlDbType.Int, ParameterDirection.Input));
            DataAccess db = new DataAccess();
            DataTable dt = db.Execute("Job_GetByDepartment", CommandType.StoredProcedure, parms);

            List<JobLookup> jobs = new List<JobLookup>();

            foreach (DataRow row in dt.Rows)
            {
                jobs.Add(new JobLookup()
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Name = row["Name"].ToString()

                });
            }

            return jobs;

        }

        public List<DepartmentLookupBySupId> GetDepartmentsBySupId(int supId)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@EmployeeId", supId, SqlDbType.Int, ParameterDirection.Input));
            DataAccess db = new DataAccess();

            DataTable dt = db.Execute("Department_Lookup_BySupId", CommandType.StoredProcedure, parms);
            List<DepartmentLookupBySupId> deps = new List<DepartmentLookupBySupId>();

            foreach(DataRow row in dt.Rows)
            {
                deps.Add(FillDepartmentLookupId(dt.Rows[0]));
            }

            return deps;

        }
        #endregion

        #region Helpers

        private Department FillDepartmentObject(DataRow row)
        {
            Department d = new Department();

            d.Id = Convert.ToInt32(row["Id"]);
            d.Name = row["Name"].ToString();
            d.Description = row["Description"].ToString();
            d.InvocationDate = Convert.ToDateTime(row["InvocationDate"]);
            d.TimeStamp = (byte[])row["TimeStamp"];

            return d;
        }

        private DepartmentLookupBySupId FillDepartmentLookupId(DataRow row)
        {
            DepartmentLookupBySupId d = new DepartmentLookupBySupId();

            d.Id = Convert.ToInt32(row["Id"]);
            d.Name = row["Name"].ToString();

            return d;
        }

        #endregion

    }
}
