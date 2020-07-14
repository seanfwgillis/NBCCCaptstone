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
    public partial class ModifyDepartment : Form
    {
        private DepartmentService d = new DepartmentService();
        private Department _d = new Department();
        private CredentialType cred;
        public ModifyDepartment()
        {

            InitializeComponent();
        }

        private void ModifyDepartment_Load(object sender, EventArgs e)
        {
            AddDepartments();
            ActiveControl = lblMainTitle;
            EditOptionsSetup();
            SetFieldAccessibility();
        }
        private void cboDepartments_SelectionChangeCommitted(object sender, EventArgs e)
        {
            EditOptionsSetup();
            _d = d.GetDepartmentById(Convert.ToInt32(cboDepartments.SelectedValue));
            FillDepartmentInfo();

        }
        private void rdo_CheckedChanged(object sender, EventArgs e)
        {
            SetFieldAccessibility();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                FillDepartmentObject();
                if (d.UpdateDepartment(_d))
                {
                    string message = "Department Modified Successfully.";
                    MessageBox.Show(message, "Status",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                else
                {
                    string msg = "";
                    foreach (Error error in d.Errors)
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
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboDepartments.SelectedIndex != -1)
                {
                    string message = "Are you sure you wish to delete this department?";
                    string title = "Delete";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons,MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (d.DeleteDepartment(_d.Id))
                        {
                            MessageBox.Show("Department Successfully Delete", "Delete Status", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        Clear();

                    }
                    else
                    {
                        Clear();
                    }
                }
                else
                {
                    MessageBox.Show("You must select a department to delete.", "Delete Status", MessageBoxButtons.OK
                        , MessageBoxIcon.Error);
                    Clear();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        #region Helpers

        private void AddDepartments()
        {
            DepartmentService service = new DepartmentService();
            cboDepartments.DisplayMember = "Name";
            cboDepartments.ValueMember = "Id";
            cboDepartments.DataSource = service.GetAllDepartments();
            cboDepartments.SelectedIndex = -1;
        }

        private void EditOptionsSetup()
        {
            foreach (Control c in grbEditOptions.Controls)
            {
                c.Enabled = true;
                if (cboDepartments.SelectedIndex == -1)
                {
                    c.Enabled = false;
                }
            }

        }
        private void SetFieldAccessibility()
        {
            dtpInvocationDate.Enabled = false;
            foreach (Control c in grbFields.Controls)
            {
                c.Enabled = false;
                if (rdoName.Checked)
                {
                    txtName.Enabled = true;
                }
                if (rdoDescription.Checked)
                {
                    txtDescription.Enabled = true;
                }
                if (rdoDate.Checked)
                {
                    dtpInvocationDate.Enabled = true;
                }
            }
        }
        private void FillDepartmentInfo()
        {

            txtName.Text = _d.Name;
            txtDescription.Text = _d.Description;
            dtpInvocationDate.Value = _d.InvocationDate;

        }

        private void FillDepartmentObject()
        {
            _d.Name = txtName.Text;
            _d.Description = txtDescription.Text;
            _d.InvocationDate = dtpInvocationDate.Value;
            d.Errors.Clear();
        }

        private void Clear()
        {
            txtName.Text = String.Empty;
            txtDescription.Text = String.Empty;
            dtpInvocationDate.Value = DateTime.Now;

            rdoDate.Checked = false;
            rdoDescription.Checked = false;
            rdoName.Checked = false;

            cboDepartments.DataSource = null;
            AddDepartments();


            cboDepartments.SelectedIndex = -1;
            EditOptionsSetup();
            SetFieldAccessibility();

            ActiveControl = lblMainTitle;

            _d = null;

        }






        #endregion


    }
}
