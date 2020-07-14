using Model;
using Model.Enums;
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
    public partial class EmployeeMaintenance : Form
    {
        public CredentialType credential { get; set; }
        private Employee _e = new Employee();
        public EmployeeMaintenance()
        {
            InitializeComponent();
        }

        private void EmployeeMaintenance_Load(object sender, EventArgs e)
        {
            Starter();
        }

        private void rdoName_CheckedChanged(object sender, EventArgs e)
        {
            ClearDetails();
            SetForRadioButtonSelection();
        }

        private void rdoEmployeeId_CheckedChanged(object sender, EventArgs e)
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
                EmployeeService service = new EmployeeService();
                if (txtSearchEmployee.Text != String.Empty 
                    && txtSearchEmployee.Text != "Enter Employee Name..."
                    && txtSearchEmployee.Text != "Enter Employee ID...")
                {


                    if (rdoName.Checked == true)
                    {
                        var employees = service.FindEmployees(txtSearchEmployee.Text);
                        lstEmployees.DataSource = employees;
                        lstEmployees.DisplayMember = "Name";
                        lstEmployees.ValueMember = "Id";
                        lstEmployees.SelectedIndex = -1;
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


        #region Helpers

        private void Starter()
        {
            rdoName.Checked = true;
        }
        private void ClearDetails()
        {
            lstEmployees.DataSource = null;
            lblAddressInfo.Text = String.Empty;
            lblContactInfo.Text = String.Empty;
            lblName.Text = String.Empty;

            if (rdoName.Checked)
            {
                txtSearchEmployee.Text = "Enter Employee Name...";
                txtSearchEmployee.ForeColor = Color.Silver;
            }
            else
            {
                txtSearchEmployee.Text = "Enter Employee ID...";
                txtSearchEmployee.ForeColor = Color.Silver;
            }
        }
        
        private void SetForRadioButtonSelection()
        {
            if (rdoName.Checked)
            {
                lstEmployees.Enabled = true;
                lstEmployees.Visible = true;
            }
            else
            {
                lstEmployees.Enabled = false;
                lstEmployees.Visible = false;
            }
        }

        private void GenerateEmployeeDetails()
        {
            string name = _e.LastName + ", " + _e.FirstName;
            lblName.Text = name;
            GenerateEmployeeAddress();
            GenerateEmployeeContact();
        }
        private void GenerateEmployeeAddress()
        {
            string provState = (_e.ProvState == String.Empty) ? "N/A" : _e.ProvState;
            string postalZip = (_e.PostalZip == String.Empty) ? "N/A" : _e.PostalZip;
            string address = String.Format(
                " {0} " +
                "\n {1}, {2}" +
                "\n {3}, {4}",
                _e.StreetAddress,
                _e.City,
                provState,
                _e.Country,
                postalZip);

            lblAddressInfo.Text = address;
        }

        private void GenerateEmployeeContact()
        {
            string contact = String.Format(
                " Work Phone: {0}" +
                "\n Cell Phone: {1}" +
                "\n Email: {2}",
                _e.WorkPhoneNumber,
                _e.CellPhoneNumber,
                _e.Email
                );
            lblContactInfo.Text = contact;
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
