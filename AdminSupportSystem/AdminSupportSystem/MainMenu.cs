using Model.Entities;
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
    public partial class MainMenu : Form
    {
        public CredentialType credential { get; set; }
        public int EmployeeId { get; set; }

        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            if (credential == CredentialType.HRSup)
            {

            }
            else if (credential == CredentialType.RegSup)
            {
                btnDepartmentAdd.Enabled = false;
                btnEmployeeAdd.Enabled = false;
                btnModifyDepartment.Enabled = false;
                btnModifyEmployee.Enabled = false;


            }
            else if (credential == CredentialType.HREmp)
            {

            }
            else
            {
                btnDepartmentAdd.Enabled = false;
                btnEmployeeAdd.Enabled = false;
                btnEmployeeSearch.Enabled = false;
                btnModifyDepartment.Enabled = false;
                btnModifyEmployee.Enabled = false;
            }

        }

        private void btnDepartmentAdd_Click(object sender, EventArgs e)
        {
            DepartmentMaintenance d = new DepartmentMaintenance();
            d.Show();
            Hide();

        }

        private void btnEmployeeSearch_Click(object sender, EventArgs e)
        {
            EmployeeMaintenance emp = new EmployeeMaintenance();
            emp.Show();
            Hide();
            
        }

        private void btnCreatePurchaseOrder_Click(object sender, EventArgs e)
        {
            POCreate pc = new POCreate(EmployeeId);

            pc.Show();
            Hide();
        }

        private void btnModifyPurchaseOrder_Click(object sender, EventArgs e)
        {
            POModify pm = new POModify(EmployeeId);
            pm.Show();
            Hide();
        }

        private void btnEmployeeAdd_Click(object sender, EventArgs e)
        {
            AddEmployee add = new AddEmployee();
            add.Show();
            Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Close();

        }

        private void btnModifyDepartment_Click(object sender, EventArgs e)
        {
            ModifyDepartment m = new ModifyDepartment();
            m.Show();
            Hide();
        }

        private void btnModifyEmployee_Click(object sender, EventArgs e)
        {
            ModifyEmployee m = new ModifyEmployee(EmployeeId);
            m.Show();
            Hide();
        }
    }
}
