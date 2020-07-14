using DAL;
using Model;
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
    public class EmployeeRepo
    {


        public Employee RetrieveEmployeeById(int id)
        {

            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@EmployeeId", id, SqlDbType.Int, ParameterDirection.Input, 0));
            DataAccess db = new DataAccess();

            DataTable dt = db.Execute("Employee_Get_Id", CommandType.StoredProcedure, parms);

            return PopulateEmployeeDetails(dt.Rows[0]);
        }
        #region Lists
        public List<Employee> GetAllEmployees()
        {
            DataAccess db = new DataAccess();
            DataTable dt = db.Execute("Employees_Get", CommandType.StoredProcedure);

            List<Employee> employees = new List<Employee>();

            foreach (DataRow row in dt.Rows)
            {
                employees.Add(PopulateEmployeeDetails(row));
            }

            return employees;

        }

        public List<Employee> RetrieveByNameAllInfo(string name)
        {
            List<ParmStruct> parms = new List<ParmStruct>();

            parms.Add(new ParmStruct("@Name", name, SqlDbType.VarChar, ParameterDirection.Input, 50));

            DataAccess db = new DataAccess();
            DataTable dt = db.Execute("Employee_Lookup_Name_AllInfo", CommandType.StoredProcedure, parms);

            List<Employee> employees = new List<Employee>();

            foreach (DataRow row in dt.Rows)
            {
                employees.Add(PopulateEmployeeDetails(row));
            }

            return employees;
        }
        public List<Employee> RetrieveByNameAllInfo(int id)
        {
            List<ParmStruct> parms = new List<ParmStruct>();

            parms.Add(new ParmStruct("@Id", id, SqlDbType.Int, ParameterDirection.Input));

            DataAccess db = new DataAccess();
            DataTable dt = db.Execute("Employee_Lookup_Id_AllInfo", CommandType.StoredProcedure, parms);

            List<Employee> employees = new List<Employee>();

            foreach (DataRow row in dt.Rows)
            {
                employees.Add(PopulateEmployeeDetails(row));
            }

            return employees;
        }

        public List<EmployeeLookup> RetrieveEmployeesByLastName(string name)
        {
            List<ParmStruct> parms = new List<ParmStruct>();

            parms.Add(new ParmStruct("@Name", name, SqlDbType.VarChar, ParameterDirection.Input, 50));

            DataAccess db = new DataAccess();
            DataTable dt = db.Execute("Employee_Lookup_Name", CommandType.StoredProcedure, parms);

            List<EmployeeLookup> employees = new List<EmployeeLookup>();

            foreach (DataRow row in dt.Rows)
            {
                employees.Add(
                    new EmployeeLookup()
                    {
                        Id = Convert.ToInt32(row["Id"]),
                        Name = row["Name"].ToString()
                    }


                );
            }

            return employees;
        }

        public List<Employee> RetrieveAllSupervisors()
        {
            DataAccess db = new DataAccess();
            DataTable dt = db.Execute("Employee_GetAllSupervisors", CommandType.StoredProcedure);

            List<Employee> employees = new List<Employee>();

            foreach (DataRow row in dt.Rows)
            {
                employees.Add(PopulateEmployeeDetails(row));
            }

            return employees;
        }


        public List<SupervisorLookup> RetrieveSupervisorsByDepartment(int departmentId)
        {
            List<ParmStruct> parms = new List<ParmStruct>();

            parms.Add(new ParmStruct("@DepartmentId", departmentId, SqlDbType.Int, ParameterDirection.Input));

            DataAccess db = new DataAccess();
            DataTable dt = db.Execute("Supervisor_GetByDepartment", CommandType.StoredProcedure, parms);

            List<SupervisorLookup> supervisors = new List<SupervisorLookup>();

            foreach (DataRow row in dt.Rows)
            {
                supervisors.Add(
                    new SupervisorLookup()
                    {
                        Id = Convert.ToInt32(row["Id"]),
                        Name = row["Name"].ToString()
                    }


                );
            }

            return supervisors;

        }

        public List<Employee> RetrieveEmployeesBySupervisor(int supervisorId)
        {
            List<ParmStruct> parms = new List<ParmStruct>();

            parms.Add(new ParmStruct("@SupervisorId", supervisorId, SqlDbType.Int, ParameterDirection.Input));
            DataAccess db = new DataAccess();
            DataTable dt = db.Execute("Employees_GetBySupervisorId", CommandType.StoredProcedure, parms);

            List<Employee> employees = new List<Employee>();

            foreach (DataRow row in dt.Rows)
            {
                employees.Add(PopulateEmployeeDetails(row));
            }

            return employees;

        }

        public List<Employee> RetrieveEmployeesByDepartment(int departmentId)
        {
            List<ParmStruct> parms = new List<ParmStruct>();

            parms.Add(new ParmStruct("@DepartmentId", departmentId, SqlDbType.Int, ParameterDirection.Input));
            DataAccess db = new DataAccess();
            string sql = "SELECT * FROM Employee WHERE Department = @DepartmentId";
            DataTable dt = db.Execute(sql, CommandType.Text, parms);

            List<Employee> employees = new List<Employee>();

            foreach (DataRow row in dt.Rows)
            {
                employees.Add(PopulateEmployeeDetails(row));
            }

            return employees;

        }
        #endregion
        #region Posts
        public bool AddEmployee(Employee e)
        {

            List<ParmStruct> parms = new List<ParmStruct>();

            parms.Add(new ParmStruct("@Id", e.Id, SqlDbType.Int, ParameterDirection.Input));
            parms.Add(new ParmStruct("@SupervisorId", e.Supervisor, SqlDbType.Int, ParameterDirection.Input));
            parms.Add(new ParmStruct("@DepartmentId", e.Department, SqlDbType.Int, ParameterDirection.Input));
            parms.Add(new ParmStruct("@LastName", e.LastName, SqlDbType.VarChar, ParameterDirection.Input, 50));
            parms.Add(new ParmStruct("@FirstName", e.FirstName, SqlDbType.VarChar, ParameterDirection.Input, 50));
            parms.Add(new ParmStruct("@MiddleInitial", e.MiddleInitial, SqlDbType.VarChar, ParameterDirection.Input, 1));
            parms.Add(new ParmStruct("@DOB", e.DOB, SqlDbType.DateTime, ParameterDirection.Input));
            parms.Add(new ParmStruct("@StreetAddress", e.StreetAddress, SqlDbType.NVarChar, ParameterDirection.Input, 255));
            parms.Add(new ParmStruct("@City", e.City, SqlDbType.VarChar, ParameterDirection.Input));
            parms.Add(new ParmStruct("@PostalZip", e.PostalZip, SqlDbType.NVarChar, ParameterDirection.Input, 6));
            parms.Add(new ParmStruct("@SIN", e.SIN, SqlDbType.Int, ParameterDirection.Input));
            parms.Add(new ParmStruct("@SeniorityDate", e.SeniorityDate, SqlDbType.DateTime, ParameterDirection.Input));
            parms.Add(new ParmStruct("@JobAssignment", e.JobAssignment, SqlDbType.Int, ParameterDirection.Input));
            parms.Add(new ParmStruct("@StartDate", e.StartDate, SqlDbType.DateTime, ParameterDirection.Input));
            parms.Add(new ParmStruct("@WorkPhoneNumber", e.WorkPhoneNumber, SqlDbType.NVarChar, ParameterDirection.Input, 16));
            parms.Add(new ParmStruct("@CellPhoneNumber", e.CellPhoneNumber, SqlDbType.NVarChar, ParameterDirection.Input, 16));
            parms.Add(new ParmStruct("@Email", e.Email, SqlDbType.NVarChar, ParameterDirection.Input, 50));
            parms.Add(new ParmStruct("@Status", (int)e.Status, SqlDbType.Int, ParameterDirection.Input));
            parms.Add(new ParmStruct("@ProvState", e.ProvState, SqlDbType.VarChar, ParameterDirection.Input, 2));
            parms.Add(new ParmStruct("@Country", e.Country, SqlDbType.VarChar, ParameterDirection.Input, 50));
            parms.Add(new ParmStruct("@IsSupervisor", e.IsSupervisor, SqlDbType.Bit, ParameterDirection.Input));
            //parms.Add(new ParmStruct("@EndDate", e.EndDate, SqlDbType.DateTime, ParameterDirection.Input));


            DataAccess db = new DataAccess();

            if (db.ExecuteNonQuery("Employee_Add", CommandType.StoredProcedure, parms) > 0)
            {
                return true;
            }
            return false;

        }

        public bool ModifyEmployee(Employee e)
        {

            List<ParmStruct> parms = new List<ParmStruct>();

            parms.Add(new ParmStruct("@TimeStamp", e.TimeStamp, SqlDbType.Timestamp, ParameterDirection.InputOutput));
            parms.Add(new ParmStruct("@EmployeeId", e.Id, SqlDbType.Int, ParameterDirection.Input));
            parms.Add(new ParmStruct("@SupervisorId", e.Supervisor, SqlDbType.Int, ParameterDirection.Input));
            parms.Add(new ParmStruct("@DepartmentId", e.Department, SqlDbType.Int, ParameterDirection.Input));
            parms.Add(new ParmStruct("@LastName", e.LastName, SqlDbType.VarChar, ParameterDirection.Input, 50));
            parms.Add(new ParmStruct("@FirstName", e.FirstName, SqlDbType.VarChar, ParameterDirection.Input, 50));
            parms.Add(new ParmStruct("@MiddleInitial", e.MiddleInitial, SqlDbType.VarChar, ParameterDirection.Input, 1));
            parms.Add(new ParmStruct("@DOB", e.DOB, SqlDbType.DateTime, ParameterDirection.Input));
            parms.Add(new ParmStruct("@StreetAddress", e.StreetAddress, SqlDbType.NVarChar, ParameterDirection.Input, 255));
            parms.Add(new ParmStruct("@City", e.City, SqlDbType.VarChar, ParameterDirection.Input));
            parms.Add(new ParmStruct("@PostalZip", e.PostalZip, SqlDbType.NVarChar, ParameterDirection.Input, 6));
            parms.Add(new ParmStruct("@SIN", e.SIN, SqlDbType.Int, ParameterDirection.Input));
            parms.Add(new ParmStruct("@SeniorityDate", e.SeniorityDate, SqlDbType.DateTime, ParameterDirection.Input));
            parms.Add(new ParmStruct("@JobAssignment", e.JobAssignment, SqlDbType.Int, ParameterDirection.Input));
            parms.Add(new ParmStruct("@StartDate", e.StartDate, SqlDbType.DateTime, ParameterDirection.Input));
            parms.Add(new ParmStruct("@WorkPhoneNumber", e.WorkPhoneNumber, SqlDbType.NVarChar, ParameterDirection.Input, 16));
            parms.Add(new ParmStruct("@CellPhoneNumber", e.CellPhoneNumber, SqlDbType.NVarChar, ParameterDirection.Input, 16));
            parms.Add(new ParmStruct("@Email", e.Email, SqlDbType.NVarChar, ParameterDirection.Input, 50));
            parms.Add(new ParmStruct("@Status", (int)e.Status, SqlDbType.Int, ParameterDirection.Input));
            parms.Add(new ParmStruct("@ProvState", e.ProvState, SqlDbType.VarChar, ParameterDirection.Input, 2));
            parms.Add(new ParmStruct("@Country", e.Country, SqlDbType.VarChar, ParameterDirection.Input, 50));
            parms.Add(new ParmStruct("@IsSupervisor", e.IsSupervisor, SqlDbType.Bit, ParameterDirection.Input));
            parms.Add(new ParmStruct("@EndDate", e.EndDate, SqlDbType.DateTime, ParameterDirection.Input));


            DataAccess db = new DataAccess();
            if (db.ExecuteNonQuery("Employee_Modify", CommandType.StoredProcedure, parms) > 0)
            {
                e.TimeStamp = (byte[])parms[0].Value;
                return true;
            }
            return false;
        }
        #endregion
        #region Uniques
        public int CheckCurrentEmployees(int id)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@EmployeeId", id, SqlDbType.Int));
            string sql = "SELECT COUNT(*) FROM Employee WHERE Id = @EmployeeId";
            DataAccess db = new DataAccess();

            return Convert.ToInt32(db.ExecuteScaler(sql, CommandType.Text, parms));
        }

        public int GetSubordinates(int id)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@Supervisor", id, SqlDbType.Int));
            string sql = "SELECT COUNT(*) FROM Employee WHERE Supervisor = @Supervisor";
            DataAccess db = new DataAccess();

            return Convert.ToInt32(db.ExecuteScaler(sql, CommandType.Text, parms));
        }

        public List<int> GetAllIdOfEmployees()
        {
            DataAccess db = new DataAccess();
            string sql = "SELECT Id FROM Employee";
            DataTable dt = db.Execute(sql, CommandType.Text);

            List<int> employeeIDs = new List<int>();

            foreach (DataRow row in dt.Rows)
            {
                employeeIDs.Add(Convert.ToInt32(row["Id"]));

            }

            return employeeIDs;
        }
        public string GetJobByEmployeeId(int id)
        {
            List<ParmStruct> parms = new List<ParmStruct>();
            parms.Add(new ParmStruct("@EmployeeId", id, SqlDbType.Int));
            string sql = "SELECT Job.Name FROM Employee INNER JOIN Job ON Employee.JobAssignment = Job.Id " +
                "WHERE Employee.Id = @EmployeeId";
            DataAccess db = new DataAccess();

            return db.ExecuteScaler(sql, CommandType.Text, parms).ToString();
        }
        #endregion

        #region Helpers
        private Employee PopulateEmployeeDetails(DataRow row)
        {
            Employee e = new Employee();

            e.Id = Convert.ToInt32(row["Id"]);
            e.FirstName = row["FirstName"].ToString();
            e.MiddleInitial = row["MiddleInitial"].ToString();
            e.LastName = row["LastName"].ToString();
            e.StreetAddress = row["StreetAddress"].ToString();
            e.City = row["City"].ToString();
            e.PostalZip = row["PostalZip"].ToString();
            e.WorkPhoneNumber = row["WorkPhoneNumber"].ToString();
            e.CellPhoneNumber = row["CellPhoneNumber"].ToString();
            e.Email = row["Email"].ToString();
            e.Country = row["Country"].ToString();
            e.ProvState = row["ProvState"].ToString();
            e.DOB = Convert.ToDateTime(row["DOB"]);
            e.SIN = Convert.ToInt32(row["SIN"]);

            e.Department = Convert.ToInt32(row["Department"]);
            e.Supervisor = Convert.ToInt32(row["Supervisor"]);
            e.JobAssignment = Convert.ToInt32(row["JobAssignment"]);
            e.IsSupervisor = Convert.ToBoolean(row["IsSupervisor"]);
            
            e.SeniorityDate = Convert.ToDateTime(row["SeniorityDate"]);
            e.StartDate = Convert.ToDateTime(row["StartDate"]);
            e.Status = (Model.Enums.EmployeeStatusType)row["Status"];

            object sqlEndDate = row["EndDate"];
            e.EndDate = (sqlEndDate == System.DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(sqlEndDate);

            e.TimeStamp = (byte[])row["TimeStamp"];



            return e;

        }

        #endregion
    }
}
