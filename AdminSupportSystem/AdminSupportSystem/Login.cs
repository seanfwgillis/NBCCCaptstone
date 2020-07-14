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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            LoadSplash();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            LoginService serv = new LoginService();
            EmployeeService es = new EmployeeService();
            try
            {
                if (txtEmployeeId.Text == String.Empty && txtPassword.Text == String.Empty)
                {
                    MessageBox.Show("Fields cannot be left blank", "Insufficient Login Data",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Text = String.Empty;
                    txtEmployeeId.Text = String.Empty;
                }
                else if (serv.IsValidLogin(Convert.ToInt32(txtEmployeeId.Text), txtPassword.Text))
                {
                    CredentialType credential = serv.GetLoginCredential(Convert.ToInt32(txtEmployeeId.Text));
                    int employeeId = Convert.ToInt32(txtEmployeeId.Text);
                    string email = es.GetEmployee(employeeId).Email;
                    Main m = new Main(employeeId, credential, email);
                    m.Show();
                    Hide();

                }
            }
            catch 
            {
                MessageBox.Show("Login Failed", "Invalid Login",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = String.Empty;
                txtEmployeeId.Text = String.Empty;


            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Splash

        private void LoadSplash()
        {
            Splash splash = new Splash();
            splash.ShowDialog();

            if (splash.DialogResult != DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }
        #endregion
    }
}
