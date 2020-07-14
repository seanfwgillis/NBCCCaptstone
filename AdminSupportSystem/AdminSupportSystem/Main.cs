using Model.Enums;
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
    public partial class Main : Form
    {
        public int tabCount { get; set; } = 0;

        private int empId = 0;
        private CredentialType cred;
        private string empEmail;

        private AddEmployee addEmployee;
        private EmployeeMaintenance employeeMaintenance;
        private ModifyEmployee modifyEmployee;

        private DepartmentMaintenance addDepartment;
        private ModifyDepartment modifyDepartment;


        private EmailReminder emailReminder;


        public Main(int employeeId, CredentialType credential, string email)
        {
            InitializeComponent();
            empId = employeeId;
            cred = credential;
            empEmail = email;
        }
        private void Main_Load(object sender, EventArgs e)
        {
            if (cred == CredentialType.HRSup || cred == CredentialType.HREmp)
            {

            }

            if (cred == CredentialType.RegSup || cred == CredentialType.RegEmp )
            {
                departmentToolStripMenuItem.Enabled = false;
                employeesToolStripMenuItem.Enabled = false;
                reviewsToolStripMenuItem.Enabled = false;



            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Close();
        }

        private void addDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (addDepartment == null || addDepartment.IsDisposed)
            {
                addDepartment = new DepartmentMaintenance();
            }
            
            if (tabControl.Contains(addDepartment))
            {
                tabControl.TabPages[addDepartment].Select();
            }
            else
            {
                addDepartment.Text = "Add Department";
                tabControl.TabPages.Add(addDepartment);
                tabCount++;
            }
        }

        private void editDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modifyDepartment == null || modifyDepartment.IsDisposed)
            {
                modifyDepartment = new ModifyDepartment();
            }

            if (tabControl.Contains(modifyDepartment))
            {
                tabControl.TabPages[modifyDepartment].Select();
            }
            else
            {
                modifyDepartment.Text = "Modify Department";
                tabControl.TabPages.Add(modifyDepartment);
                tabCount++;
            }
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (addEmployee == null || addEmployee.IsDisposed)
            {
                addEmployee = new AddEmployee();
            }

            if (tabControl.Contains(addEmployee))
            {
                tabControl.TabPages[addEmployee].Select();
            }
            else
            {
                addEmployee.Text = "Add Employee";
                tabControl.TabPages.Add(addEmployee);
                tabCount++;
            }
        }

        private void editEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modifyEmployee == null || modifyEmployee.IsDisposed)
            {
                modifyEmployee = new ModifyEmployee(empId);
            }

            if (tabControl.Contains(modifyEmployee))
            {
                tabControl.TabPages[modifyEmployee].Select();
            }
            else
            {
                modifyEmployee.Text = "Edit Employee Details";
                tabControl.TabPages.Add(modifyEmployee);
                tabCount++;
            }
        }

        private void searchEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (employeeMaintenance == null || employeeMaintenance.IsDisposed)
            {
                employeeMaintenance = new EmployeeMaintenance();
            }

            if (tabControl.Contains(employeeMaintenance))
            {
                tabControl.TabPages[employeeMaintenance].Select();
            }
            else
            {
                employeeMaintenance.Text = "Search For Employee";
                tabControl.TabPages.Add(employeeMaintenance);
                tabCount++;
            }
        }

      

        private void emailReminderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (emailReminder == null || emailReminder.IsDisposed)
            {
                emailReminder = new EmailReminder(empEmail);
            }

            if (tabControl.Contains(emailReminder))
            {
                tabControl.TabPages[emailReminder].Select();
            }
            else
            {
                emailReminder.Text = "Pending Reviews";
                tabControl.TabPages.Add(emailReminder);
                tabCount++;
            }
        }
    }
}
