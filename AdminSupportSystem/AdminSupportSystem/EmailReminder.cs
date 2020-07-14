using Model;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminSupportSystem
{
    public partial class EmailReminder : Form
    {
        private EmployeeService es = new EmployeeService();
        private ReviewService rs = new ReviewService();
        private List<Employee> employees = new List<Employee>(); 
        private MailMessage mail = new MailMessage();
        private string empEmail;
        public EmailReminder(string email)
        {
            InitializeComponent();
            empEmail = email;
        }

        private void EmailReminder_Load(object sender, EventArgs e)
        {
            LoadSupervisors();
        }

        private void lstSupervisors_Click(object sender, EventArgs e)
        {
            try
            {
                Employee sup = es.GetEmployee(Convert.ToInt32(lstSupervisors.SelectedValue));
                lblSupervisor.Text = sup.LastName + ", " + sup.FirstName;
                lblEmail.Text = sup.Email;

                lstEmployees.DataSource = null;
                LoadEmployees();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear();
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SendEmail();
        }
        #region Helpers
        private void LoadSupervisors()
        {
            lstSupervisors.DisplayMember = "Name";
            lstSupervisors.ValueMember = "Id";
            lstSupervisors.DataSource = es.GetSupervisorsWithPendingReviews();
            lstSupervisors.SelectedIndex = -1;

        }

        private void LoadEmployees()
        {
            lstEmployees.DisplayMember = "Name";
            lstEmployees.ValueMember = "Id";
            lstEmployees.DataSource = es.GetEmployeesBySupWithPendingReviews(Convert.ToInt32(lstSupervisors.SelectedValue));
            lstEmployees.SelectedIndex = -1;
        }

        private void Clear()
        {
            lblSupervisor.Text = String.Empty;
            lblEmail.Text = String.Empty;

            lstSupervisors.DataSource = null;
            lstEmployees.DataSource = null;

            LoadSupervisors();
        }
        #endregion
        #region Email


        private void SendEmail()
        {
            try
            {
                List<Employee> sups = es.GetSupsPendingEmails();
                foreach(Employee s in sups)
                {
                    List<EmployeeLookup> subordinates = es.GetEmployeesBySupWithPendingReviews(s.Id);
                    string listOfSubs = "";

                    MailMessage msg = new MailMessage();
                    msg.From = new MailAddress(empEmail);
                    msg.To.Add(s.Email);
                    msg.Subject = "Employee list needing review";
                    foreach(EmployeeLookup e in subordinates)
                    {
                        listOfSubs += e.Name + " / ";
                    }

                    msg.Body = listOfSubs;
                    SmtpClient smt = new SmtpClient();
                    smt.Host = "smtp.gmail.com";
                    System.Net.NetworkCredential ntcd = new NetworkCredential();
                    ntcd.UserName = empEmail;
                    ntcd.Password = "Dev1234!";
                    smt.Credentials = ntcd;
                    smt.EnableSsl = true;
                    smt.Port = 587;
                    smt.Send(msg);
                }
                

                MessageBox.Show("Your Mail is sended");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear();
            }
        }
        #endregion

    }
}
