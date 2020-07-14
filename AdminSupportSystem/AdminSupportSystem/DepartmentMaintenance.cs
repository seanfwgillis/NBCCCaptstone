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
    public partial class DepartmentMaintenance : Form
    {
        public CredentialType credential { get; set; }
        private Department department = new Department();
        public DepartmentMaintenance()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DepartmentService service = new DepartmentService();
                PopulateDepartmentObject();

                if (service.AddDepartment(department))
                {
                    MessageBox.Show("Department Added Successfully", "Status",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    txtName.Focus();
                    txtDescription.SelectAll();
                }
                else
                {
                    string msg = "";
                    foreach (Error error in service.Errors)
                    {
                        msg += error.Description + Environment.NewLine;
                    }
                    MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.Focus();
                    txtName.SelectAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                txtName.SelectAll();

            }
        }


        #region Helpers

        private void PopulateDepartmentObject()
        {
            department.Name = txtName.Text;
            department.Description = txtDescription.Text;
            DateTime now = DateTime.Now;
            dtpInvocationDate.Value = new DateTime(dtpInvocationDate.Value.Year, dtpInvocationDate.Value.Month, dtpInvocationDate.Value.Day, now.Hour, now.Minute, now.Second);
            department.InvocationDate = dtpInvocationDate.Value;
            department.InvocationDate = department.InvocationDate.AddMinutes(1);
        }

        private void ClearForm()
        {
            txtName.Text = String.Empty;
            txtDescription.Text = String.Empty;
            dtpInvocationDate.Value = DateTime.Now;
        }


        #endregion


    }
}
