using Model;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminSupportSystem
{
    public partial class ModifyEmployee : Form
    {
        private Employee _e = new Employee();
        private int employeeId = 0;

        public ModifyEmployee(int empId)
        {

            InitializeComponent();
            employeeId = empId;

        }

        private void ModifyEmployee_Load(object sender, EventArgs e)
        {
            Starter();
        }

        private void rdo_CheckedChanged(object sender, EventArgs e)
        {
            ClearDetails();
            SetForRadioButtonSelection();
        }

        private void txtSearchEmployee_Enter(object sender, EventArgs e)
        {
            if (txtSearchEmployee.Text == "Enter Employee Name..." || txtSearchEmployee.Text == "Enter Employee ID...")
            {
                txtSearchEmployee.Text = "";
                txtSearchEmployee.ForeColor = Color.Black;
            }
        }

        private void txtSearchEmployee_Leave(object sender, EventArgs e)
        {
            if (txtSearchEmployee.Text == "")
            {
                if (rdoName.Checked)
                {
                    txtSearchEmployee.Text = "Enter Employee Name...";

                }
                else
                {
                    txtSearchEmployee.Text = "Enter Employee ID...";
                }
                txtSearchEmployee.ForeColor = Color.Silver;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtSearchEmployee.Text != String.Empty
                    && txtSearchEmployee.Text != "Enter Employee Name..."
                    && txtSearchEmployee.Text != "Enter Employee ID...")
                {

                    if (rdoName.Checked == true)
                    {
                        FillEmployeeList();
                        if (lstEmployees.Items.Count == 0)
                        {
                            MessageBox.Show("No employees match provided search criteria.", "Search Status",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtSearchEmployee.Focus();
                            txtSearchEmployee.SelectAll();

                        }
                    }
                    else
                    {
                        if (ValidIdSearchField())
                        {
                            EmployeeService service = new EmployeeService();
                            _e = service.GetEmployee(Convert.ToInt32(txtSearchEmployee.Text));
                            GenerateEmployeeDetails();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Employee ID format", "Search Status",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtSearchEmployee.Focus();
                            txtSearchEmployee.SelectAll();

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Search field cannot be left blank", "Search Status",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearDetails();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearchEmployee.Focus();
                txtSearchEmployee.SelectAll();

            }
        }

        private void lstEmployees_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeService service = new EmployeeService();
                _e = service.GetEmployee(Convert.ToInt32(lstEmployees.SelectedValue));
                GenerateEmployeeDetails();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearchEmployee.Focus();
                txtSearchEmployee.SelectAll();

            }
        }

        private void cboCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboProvinces.Enabled = false;
            txtPostalCode.Enabled = false;
            cboProvinces.Items.Clear();

            if (cboCountries.SelectedIndex != -1)
            {

                if (cboCountries.SelectedItem.ToString().ToLower().Trim() == "canada" ||
                    cboCountries.SelectedItem.ToString().ToLower().Trim() == "united states")
                {
                    cboProvinces.Enabled = true;
                    txtPostalCode.Enabled = true;
                    AddProvOrStates(cboCountries.SelectedItem.ToString().ToLower().Trim());
                }
            }
        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboDepartment.SelectedIndex != -1)
                {
                    cboSupervisor.Enabled = true;
                    cboJob.Enabled = true;
                    AddSupervisors();
                    AddJobs();
                }
                else
                {
                    cboSupervisor.DataSource = null;
                    cboJob.DataSource = null;
                    cboSupervisor.Enabled = false;
                    cboJob.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboDepartment.SelectedIndex = -1;
                cboDepartment.Focus();
                cboDepartment.SelectAll();

            }
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            ClearDetails();
        }

        private void btnResetDepartmentDetails_Click(object sender, EventArgs e)
        {
            SetDepartmentSupJobDefault();
        }
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            var formToShow = Application.OpenForms.Cast<Form>()
                .FirstOrDefault(c => c is MainMenu);
            if (formToShow != null)
            {
                formToShow.Show();
                Close();
            }
        }

        private void rdoStatus_CheckedChanged(object sender, EventArgs e)
        {
            SetUpEndDateOption();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            EmployeeService s = new EmployeeService();
            try
            {
                Employee unmodifiedEmployee = s.GetEmployee(_e.Id);
                FillEmployeeObject();
                if (s.ModifyEmployee(_e, unmodifiedEmployee, employeeId))
                {
                    string message = "Employee Modification Successfull.";
                    MessageBox.Show(message, "Status",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearDetails();
                }
                else
                {
                    string msg = "";
                    foreach (Error error in s.Errors)
                    {
                        msg += error.Description + Environment.NewLine;
                    }
                    MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Modify Status", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }
        #region Submit Helpers
        private void FillEmployeeObject()
        {
            _e.FirstName = txtFirstName.Text;
            _e.MiddleInitial = txtMiddleInitial.Text;
            _e.LastName = txtLastName.Text;
            _e.StreetAddress = txtAddress.Text;
            _e.City = txtCity.Text;
            _e.Country = cboCountries.GetItemText(cboCountries.SelectedItem);
            _e.PostalZip = txtPostalCode.Text;
            _e.ProvState = cboProvinces.GetItemText(cboProvinces.SelectedItem);
            _e.WorkPhoneNumber = txtPhoneNumberWork.Text;
            _e.CellPhoneNumber = txtPhoneNumberCell.Text;
            _e.Email = txtEmail.Text;

            _e.StartDate = dtpStartDate.Value;
            CheckStatus();
            _e.Department = Convert.ToInt32(cboDepartment.SelectedValue);
            _e.Supervisor = Convert.ToInt32(cboSupervisor.SelectedValue);
            _e.JobAssignment = Convert.ToInt32(cboJob.SelectedValue);
            _e.IsSupervisor = chkIsSupervisor.Checked ? true : false;

            ApplyEndDate();


        }
        private void CheckStatus()
        {
            if (rdoActive.Checked)
            {
                _e.Status = Model.Enums.EmployeeStatusType.Active;
            }
            if (rdoTerminated.Checked)
            {
                _e.Status = Model.Enums.EmployeeStatusType.Terminated;
            }
            if (rdoRetired.Checked)
            {
                _e.Status = Model.Enums.EmployeeStatusType.Retired;
            }
        }
        private void ApplyEndDate()
        {
            if(rdoTerminated.Checked || rdoRetired.Checked)
            {
                _e.EndDate = dtpEndDate.Value;
            }
            else
            {
                _e.EndDate = null;
            }
        }

        #endregion
        #region Helpers
        private void Starter()
        {
            rdoName.Checked = true;
            rdoActive.Checked = true;
            txtSearchEmployee.Text = "Enter Employee Name...";
            txtSearchEmployee.ForeColor = Color.Silver;

            AddDepartments();
            AddCountries();
            ClearDetails();
        }

        private void SetForRadioButtonSelection()
        {
            if (rdoName.Checked)
            {
                lstEmployees.Enabled = true;
                lstEmployees.Visible = true;
                txtSearchEmployee.Text = "Enter Employee Name...";
                txtSearchEmployee.ForeColor = Color.Silver;
            }
            else
            {
                lstEmployees.Enabled = false;
                lstEmployees.Visible = false;
                txtSearchEmployee.Text = "Enter Employee ID...";
                txtSearchEmployee.ForeColor = Color.Silver;
            }
        }

        private void GenerateEmployeeDetails()
        {
            txtFirstName.Text = _e.FirstName;
            txtMiddleInitial.Text = _e.MiddleInitial;
            txtLastName.Text = _e.LastName;
            txtAddress.Text = _e.StreetAddress;
            txtCity.Text = _e.City;
            if (_e.Country.ToLower() == "canada" || _e.Country.ToLower() == "united states")
            {
                cboCountries.SelectedIndex = cboCountries.FindString(_e.Country);
                txtPostalCode.Text = _e.PostalZip;
                cboProvinces.SelectedIndex = cboProvinces.FindString(_e.ProvState);
            }
            txtPhoneNumberWork.Text = _e.WorkPhoneNumber;
            txtPhoneNumberCell.Text = _e.CellPhoneNumber;
            txtEmail.Text = _e.Email;
            dtpStartDate.Value = _e.StartDate;
            VerifyEmployeeStatus();
            VerifyIfSupervisor();
            SetDepartmentSupJobDefault();
            VerifyIfActive();

            lblAge.Text = CalculateAge(_e.DOB).ToString();


        }
        private void ClearDetails()
        {

            lstEmployees.DataSource = null;

            foreach (Control c in grbPersonalInfo.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
            }

            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            chkIsSupervisor.Checked = false;

            cboDepartment.SelectedIndex = -1;
            cboCountries.SelectedIndex = -1;

            cboJob.Enabled = false;
            cboSupervisor.Enabled = false;
            cboProvinces.Enabled = false;
            txtPostalCode.Enabled = false;
            cboProvinces.Items.Clear();

            SetForRadioButtonSelection();
            rdoActive.Checked = true;

            lblAge.Text = String.Empty;
            
            lblTitle.Focus();

        }

        private void VerifyEmployeeStatus()
        {
            if (_e.Status == Model.Enums.EmployeeStatusType.Active)
            {
                rdoActive.Checked = true;
            }
            if (_e.Status == Model.Enums.EmployeeStatusType.Terminated)
            {
                rdoTerminated.Checked = true;
            }
            if (_e.Status == Model.Enums.EmployeeStatusType.Retired)
            {
                rdoRetired.Checked = true;
            }
        }
        private void VerifyIfSupervisor()
        {
            if (_e.IsSupervisor)
            {
                chkIsSupervisor.Checked = true;
            }
            else
            {
                chkIsSupervisor.Checked = false;
            }
        }

        private bool VerifyIfActive()
        {
            if(_e.EndDate == null)
            {
                return true;
            }
            DateTime? holder = _e.EndDate;
            dtpEndDate.Value = (DateTime)holder;
            return false;
        }

        private void SetDepartmentSupJobDefault()
        {
            cboDepartment.SelectedValue = _e.Department;
            cboSupervisor.SelectedValue = _e.Supervisor;
            cboJob.SelectedValue = _e.JobAssignment;
        }


        private void SetUpEndDateOption()
        {
            if (rdoActive.Checked)
            {
                dtpEndDate.Enabled = false;
            }
            if (rdoTerminated.Checked || rdoRetired.Checked)
            {
                dtpEndDate.Enabled = true;
            }

        }

        private int CalculateAge(DateTime dateOfBirth)
        {
            int age = 0;
            age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age = age - 1;

            return age;
        }
        #endregion
        #region FillListsAndCombos
        private void AddCountries()
        {
            cboCountries.Items.Add("Canada");
            cboCountries.Items.Add("United States");

        }
        private void AddProvOrStates(string country)
        {
            EmployeeService service = new EmployeeService();
            string[] provOrStates = { };

            if (country.ToLower().Trim() == "canada")
            {
                provOrStates = service.GetAllProvincesAndTerritories();
            }
            else
            {
                provOrStates = service.GetAllStates();
            }

            var sorted = from p in provOrStates orderby p select p;

            foreach (string p in sorted)
            {
                cboProvinces.Items.Add(p);
            }
            cboProvinces.SelectedIndex = -1;
        }

        private void AddDepartments()
        {
            DepartmentService service = new DepartmentService();
            cboDepartment.DisplayMember = "Name";
            cboDepartment.ValueMember = "Id";
            cboDepartment.DataSource = service.GetAllDepartments();
            cboDepartment.SelectedIndex = -1;

        }

        private void AddSupervisors()
        {
            EmployeeService service = new EmployeeService();

            cboSupervisor.DisplayMember = "Name";
            cboSupervisor.ValueMember = "Id";
            if (!_e.IsSupervisor)
            {
                cboSupervisor.DataSource = service.GetSupervisorsByDepartment(Convert.ToInt32(cboDepartment.SelectedValue));
            }
            else
            {
                cboSupervisor.DataSource = service.GetSupervisorsByDepartment(1);
            }
            cboSupervisor.SelectedIndex = -1;
        }


        private void AddJobs()
        {
            DepartmentService service = new DepartmentService();

            cboJob.DisplayMember = "Name";
            cboJob.ValueMember = "Id";
            cboJob.DataSource = service.GetAllJobsByDepartmentId(Convert.ToInt32(cboDepartment.SelectedValue));
            cboJob.SelectedIndex = -1;
        }

        private void FillEmployeeList()
        {
            EmployeeService service = new EmployeeService();
            var employees = service.FindEmployees(txtSearchEmployee.Text);
            lstEmployees.DataSource = employees;
            lstEmployees.DisplayMember = "Name";
            lstEmployees.ValueMember = "Id";
            lstEmployees.SelectedIndex = -1;
        }


        #endregion
        #region Validation

        private bool ValidIdSearchField()
        {
            int number;
            if (!Int32.TryParse(txtSearchEmployee.Text, out number))
            {
                return false;
            }
            if (txtSearchEmployee.Text.Length != 8)
            {
                return false;
            }
            return true;
        }













        #endregion


    }
}
