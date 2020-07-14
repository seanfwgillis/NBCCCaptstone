using Model;
using Model.Enums;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminSupportSystem
{
    public partial class AddEmployee : Form
    {
        private Employee _e = new Employee();

        public AddEmployee()
        {
            InitializeComponent();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            
            AddDepartments();
            AddCountries();
            ClearFields();

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //if (txtPassword.Text != String.Empty)
                //{
                    EmployeeService service = new EmployeeService();
                    FillEmployeeObject();

                    if (service.AddEmployee(_e, txtPassword.Text))
                    {
                        string message = "Employee Added Successfully." +
                            "\nTemporary password: " + txtPassword.Text;
                        MessageBox.Show(message, "Status",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                        txtFirstName.Focus();
                        txtFirstName.SelectAll();
                    }
                    else
                    {
                        string msg = "";
                        foreach (Error error in service.Errors)
                        {
                            msg += error.Description + Environment.NewLine;
                        }
                        MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtFirstName.Focus();
                        txtFirstName.SelectAll();
                    }
                //}
                //else
                //{
                //    MessageBox.Show("Password is required", "Missing Info",
                //        MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    txtPassword.Focus();
                //    txtPassword.SelectAll();
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                txtFirstName.SelectAll();

            }

        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void chkBullets_CheckedChanged(object sender, EventArgs e)
        {
            PasswordToggle();
        }


        #region Helpers
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
            cboSupervisor.DataSource = service.GetSupervisorsByDepartment(Convert.ToInt32(cboDepartment.SelectedValue));
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

        private void FillEmployeeObject()
        {
            if (cboProvinces.Enabled == true)
            {
                _e.ProvState = cboProvinces.SelectedItem.ToString();
                _e.PostalZip = txtPostalCode.Text;
            }
            _e.Supervisor = Convert.ToInt32(cboSupervisor.SelectedValue);
            _e.Department = Convert.ToInt32(cboDepartment.SelectedValue);
            _e.LastName = txtLastName.Text;
            _e.FirstName = txtFirstName.Text;
            _e.MiddleInitial = txtMiddleInitial.Text;
            _e.DOB = Convert.ToDateTime(dtpDOB.Value);
            _e.StreetAddress = txtAddress.Text;
            _e.City = txtCity.Text;

            int sin = Int32.TryParse(txtSIN.Text, out sin) ? sin : 0;
            _e.SIN = sin;

            _e.SeniorityDate = Convert.ToDateTime(dtpHireDate.Value);
            _e.StartDate = Convert.ToDateTime(dtpStartDate.Value);
            _e.JobAssignment = Convert.ToInt32(cboJob.SelectedValue);
            _e.WorkPhoneNumber = txtPhoneNumberWork.Text;
            _e.CellPhoneNumber = txtPhoneNumberCell.Text;
            _e.Email = txtEmail.Text;
            if (cboCountries.SelectedIndex != -1)
            {
                _e.Country = cboCountries.SelectedItem.ToString();
            }

            _e.IsSupervisor = chkIsSupervisor.Checked ? true : false;

        }

        private void ClearFields()
        {
            txtFirstName.Text = String.Empty;
            txtMiddleInitial.Text = String.Empty;
            txtLastName.Text = String.Empty;
            txtAddress.Text = String.Empty;
            txtCity.Text = String.Empty;
            txtPostalCode.Text = String.Empty;
            txtPhoneNumberWork.Text = String.Empty;
            txtPhoneNumberCell.Text = String.Empty;
            txtEmail.Text = String.Empty;
            dtpDOB.Value = DateTime.Now;
            txtSIN.Text = String.Empty;
            dtpHireDate.Value = DateTime.Now;
            dtpStartDate.Value = DateTime.Now;
            txtPassword.Text = String.Empty;
            chkIsSupervisor.Checked = false;

            cboDepartment.SelectedIndex = -1;
            cboCountries.SelectedIndex = -1;

            cboJob.Enabled = false;
            cboSupervisor.Enabled = false;
            cboProvinces.Enabled = false;
            txtPostalCode.Enabled = false;

            cboProvinces.Items.Clear();
            txtFirstName.Focus();
            txtFirstName.SelectAll();

        }

        private void PasswordToggle()
        {
            if (chkBullets.Checked)
            {
                chkBullets.Text = "Show Password";
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                chkBullets.Text = "Hide Password";
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        #endregion


    }
}
