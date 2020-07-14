namespace AdminSupportSystem
{
    partial class AddEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployee));
            this.lblTitle = new System.Windows.Forms.Label();
            this.grbEmployeeDetails = new System.Windows.Forms.GroupBox();
            this.grbProfessionalInfo = new System.Windows.Forms.GroupBox();
            this.chkBullets = new System.Windows.Forms.CheckBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblJobStart = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.chkIsSupervisor = new System.Windows.Forms.CheckBox();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.lblHireDate = new System.Windows.Forms.Label();
            this.grbDepartmentDetails = new System.Windows.Forms.GroupBox();
            this.cboJob = new System.Windows.Forms.ComboBox();
            this.lblSupervisor = new System.Windows.Forms.Label();
            this.lblJob = new System.Windows.Forms.Label();
            this.cboSupervisor = new System.Windows.Forms.ComboBox();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.grbPersonalInfo = new System.Windows.Forms.GroupBox();
            this.cboCountries = new System.Windows.Forms.ComboBox();
            this.txtSIN = new System.Windows.Forms.TextBox();
            this.lblSIN = new System.Windows.Forms.Label();
            this.cboProvinces = new System.Windows.Forms.ComboBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhoneNumberCell = new System.Windows.Forms.TextBox();
            this.lblPhoneNumberCell = new System.Windows.Forms.Label();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.txtPhoneNumberWork = new System.Windows.Forms.TextBox();
            this.lblPhoneNumberWork = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtMiddleInitial = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblMiddleInitial = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.grbEmployeeDetails.SuspendLayout();
            this.grbProfessionalInfo.SuspendLayout();
            this.grbDepartmentDetails.SuspendLayout();
            this.grbPersonalInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(252, 81);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(355, 56);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Add Employee";
            // 
            // grbEmployeeDetails
            // 
            this.grbEmployeeDetails.Controls.Add(this.grbProfessionalInfo);
            this.grbEmployeeDetails.Controls.Add(this.grbPersonalInfo);
            this.grbEmployeeDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEmployeeDetails.Location = new System.Drawing.Point(41, 210);
            this.grbEmployeeDetails.Name = "grbEmployeeDetails";
            this.grbEmployeeDetails.Size = new System.Drawing.Size(776, 430);
            this.grbEmployeeDetails.TabIndex = 7;
            this.grbEmployeeDetails.TabStop = false;
            this.grbEmployeeDetails.Text = "Employee Details";
            // 
            // grbProfessionalInfo
            // 
            this.grbProfessionalInfo.Controls.Add(this.chkBullets);
            this.grbProfessionalInfo.Controls.Add(this.dtpStartDate);
            this.grbProfessionalInfo.Controls.Add(this.lblJobStart);
            this.grbProfessionalInfo.Controls.Add(this.txtPassword);
            this.grbProfessionalInfo.Controls.Add(this.lblPassword);
            this.grbProfessionalInfo.Controls.Add(this.chkIsSupervisor);
            this.grbProfessionalInfo.Controls.Add(this.dtpHireDate);
            this.grbProfessionalInfo.Controls.Add(this.lblHireDate);
            this.grbProfessionalInfo.Controls.Add(this.grbDepartmentDetails);
            this.grbProfessionalInfo.Controls.Add(this.cboDepartment);
            this.grbProfessionalInfo.Controls.Add(this.lblDepartment);
            this.grbProfessionalInfo.Location = new System.Drawing.Point(6, 240);
            this.grbProfessionalInfo.Name = "grbProfessionalInfo";
            this.grbProfessionalInfo.Size = new System.Drawing.Size(751, 184);
            this.grbProfessionalInfo.TabIndex = 11;
            this.grbProfessionalInfo.TabStop = false;
            this.grbProfessionalInfo.Text = "Professional Information";
            // 
            // chkBullets
            // 
            this.chkBullets.AutoSize = true;
            this.chkBullets.Location = new System.Drawing.Point(108, 126);
            this.chkBullets.Name = "chkBullets";
            this.chkBullets.Size = new System.Drawing.Size(137, 21);
            this.chkBullets.TabIndex = 22;
            this.chkBullets.Text = "Hide Password";
            this.chkBullets.UseVisualStyleBackColor = true;
            this.chkBullets.CheckedChanged += new System.EventHandler(this.chkBullets_CheckedChanged);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(108, 66);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 22);
            this.dtpStartDate.TabIndex = 21;
            // 
            // lblJobStart
            // 
            this.lblJobStart.AutoSize = true;
            this.lblJobStart.Location = new System.Drawing.Point(15, 71);
            this.lblJobStart.Name = "lblJobStart";
            this.lblJobStart.Size = new System.Drawing.Size(87, 17);
            this.lblJobStart.TabIndex = 20;
            this.lblJobStart.Text = "Start Date:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(108, 98);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 22);
            this.txtPassword.TabIndex = 19;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(20, 101);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 17);
            this.lblPassword.TabIndex = 18;
            this.lblPassword.Text = "Password:";
            // 
            // chkIsSupervisor
            // 
            this.chkIsSupervisor.AutoSize = true;
            this.chkIsSupervisor.Location = new System.Drawing.Point(462, 146);
            this.chkIsSupervisor.Name = "chkIsSupervisor";
            this.chkIsSupervisor.Size = new System.Drawing.Size(125, 21);
            this.chkIsSupervisor.TabIndex = 1;
            this.chkIsSupervisor.Text = "Is Supervisor";
            this.chkIsSupervisor.UseVisualStyleBackColor = true;
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.Location = new System.Drawing.Point(108, 34);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(200, 22);
            this.dtpHireDate.TabIndex = 0;
            // 
            // lblHireDate
            // 
            this.lblHireDate.AutoSize = true;
            this.lblHireDate.Location = new System.Drawing.Point(20, 39);
            this.lblHireDate.Name = "lblHireDate";
            this.lblHireDate.Size = new System.Drawing.Size(82, 17);
            this.lblHireDate.TabIndex = 8;
            this.lblHireDate.Text = "Hire Date:";
            // 
            // grbDepartmentDetails
            // 
            this.grbDepartmentDetails.Controls.Add(this.cboJob);
            this.grbDepartmentDetails.Controls.Add(this.lblSupervisor);
            this.grbDepartmentDetails.Controls.Add(this.lblJob);
            this.grbDepartmentDetails.Controls.Add(this.cboSupervisor);
            this.grbDepartmentDetails.Location = new System.Drawing.Point(337, 52);
            this.grbDepartmentDetails.Name = "grbDepartmentDetails";
            this.grbDepartmentDetails.Size = new System.Drawing.Size(398, 88);
            this.grbDepartmentDetails.TabIndex = 7;
            this.grbDepartmentDetails.TabStop = false;
            this.grbDepartmentDetails.Text = "Department Details";
            // 
            // cboJob
            // 
            this.cboJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboJob.FormattingEnabled = true;
            this.cboJob.Location = new System.Drawing.Point(135, 57);
            this.cboJob.Name = "cboJob";
            this.cboJob.Size = new System.Drawing.Size(241, 24);
            this.cboJob.TabIndex = 1;
            // 
            // lblSupervisor
            // 
            this.lblSupervisor.AutoSize = true;
            this.lblSupervisor.Location = new System.Drawing.Point(37, 27);
            this.lblSupervisor.Name = "lblSupervisor";
            this.lblSupervisor.Size = new System.Drawing.Size(91, 17);
            this.lblSupervisor.TabIndex = 7;
            this.lblSupervisor.Text = "Supervisor:";
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Location = new System.Drawing.Point(52, 60);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(76, 17);
            this.lblJob.TabIndex = 9;
            this.lblJob.Text = "Job Title:";
            // 
            // cboSupervisor
            // 
            this.cboSupervisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSupervisor.FormattingEnabled = true;
            this.cboSupervisor.Location = new System.Drawing.Point(134, 24);
            this.cboSupervisor.Name = "cboSupervisor";
            this.cboSupervisor.Size = new System.Drawing.Size(242, 24);
            this.cboSupervisor.TabIndex = 0;
            // 
            // cboDepartment
            // 
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(472, 22);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(241, 24);
            this.cboDepartment.TabIndex = 2;
            this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.cboDepartment_SelectedIndexChanged);
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(368, 25);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(97, 17);
            this.lblDepartment.TabIndex = 5;
            this.lblDepartment.Text = "Department:";
            // 
            // grbPersonalInfo
            // 
            this.grbPersonalInfo.Controls.Add(this.cboCountries);
            this.grbPersonalInfo.Controls.Add(this.txtSIN);
            this.grbPersonalInfo.Controls.Add(this.lblSIN);
            this.grbPersonalInfo.Controls.Add(this.cboProvinces);
            this.grbPersonalInfo.Controls.Add(this.dtpDOB);
            this.grbPersonalInfo.Controls.Add(this.lblDOB);
            this.grbPersonalInfo.Controls.Add(this.lblProvince);
            this.grbPersonalInfo.Controls.Add(this.lblCountry);
            this.grbPersonalInfo.Controls.Add(this.txtEmail);
            this.grbPersonalInfo.Controls.Add(this.lblEmail);
            this.grbPersonalInfo.Controls.Add(this.txtPhoneNumberCell);
            this.grbPersonalInfo.Controls.Add(this.lblPhoneNumberCell);
            this.grbPersonalInfo.Controls.Add(this.txtPostalCode);
            this.grbPersonalInfo.Controls.Add(this.lblPostalCode);
            this.grbPersonalInfo.Controls.Add(this.txtPhoneNumberWork);
            this.grbPersonalInfo.Controls.Add(this.lblPhoneNumberWork);
            this.grbPersonalInfo.Controls.Add(this.txtCity);
            this.grbPersonalInfo.Controls.Add(this.lblCity);
            this.grbPersonalInfo.Controls.Add(this.txtAddress);
            this.grbPersonalInfo.Controls.Add(this.lblAddress);
            this.grbPersonalInfo.Controls.Add(this.txtLastName);
            this.grbPersonalInfo.Controls.Add(this.lblLastName);
            this.grbPersonalInfo.Controls.Add(this.lblFirstName);
            this.grbPersonalInfo.Controls.Add(this.txtMiddleInitial);
            this.grbPersonalInfo.Controls.Add(this.txtFirstName);
            this.grbPersonalInfo.Controls.Add(this.lblMiddleInitial);
            this.grbPersonalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPersonalInfo.Location = new System.Drawing.Point(6, 21);
            this.grbPersonalInfo.Name = "grbPersonalInfo";
            this.grbPersonalInfo.Size = new System.Drawing.Size(751, 213);
            this.grbPersonalInfo.TabIndex = 10;
            this.grbPersonalInfo.TabStop = false;
            this.grbPersonalInfo.Text = "Personal Information";
            // 
            // cboCountries
            // 
            this.cboCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCountries.FormattingEnabled = true;
            this.cboCountries.Location = new System.Drawing.Point(341, 85);
            this.cboCountries.Name = "cboCountries";
            this.cboCountries.Size = new System.Drawing.Size(164, 24);
            this.cboCountries.TabIndex = 28;
            this.cboCountries.SelectedIndexChanged += new System.EventHandler(this.cboCountries_SelectedIndexChanged);
            // 
            // txtSIN
            // 
            this.txtSIN.Location = new System.Drawing.Point(435, 152);
            this.txtSIN.Name = "txtSIN";
            this.txtSIN.Size = new System.Drawing.Size(200, 22);
            this.txtSIN.TabIndex = 12;
            // 
            // lblSIN
            // 
            this.lblSIN.AutoSize = true;
            this.lblSIN.Location = new System.Drawing.Point(389, 155);
            this.lblSIN.Name = "lblSIN";
            this.lblSIN.Size = new System.Drawing.Size(38, 17);
            this.lblSIN.TabIndex = 27;
            this.lblSIN.Text = "SIN:";
            // 
            // cboProvinces
            // 
            this.cboProvinces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvinces.FormattingEnabled = true;
            this.cboProvinces.Location = new System.Drawing.Point(606, 86);
            this.cboProvinces.Name = "cboProvinces";
            this.cboProvinces.Size = new System.Drawing.Size(139, 24);
            this.cboProvinces.TabIndex = 7;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(435, 124);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 22);
            this.dtpDOB.TabIndex = 11;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(373, 127);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(56, 17);
            this.lblDOB.TabIndex = 24;
            this.lblDOB.Text = "D.O.B:";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(511, 88);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(89, 17);
            this.lblProvince.TabIndex = 22;
            this.lblProvince.Text = "Prov/State:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(266, 88);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(69, 17);
            this.lblCountry.TabIndex = 20;
            this.lblCountry.Text = "Country:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(161, 180);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(196, 22);
            this.txtEmail.TabIndex = 10;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(103, 183);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 17);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "Email:";
            // 
            // txtPhoneNumberCell
            // 
            this.txtPhoneNumberCell.Location = new System.Drawing.Point(161, 152);
            this.txtPhoneNumberCell.Name = "txtPhoneNumberCell";
            this.txtPhoneNumberCell.Size = new System.Drawing.Size(140, 22);
            this.txtPhoneNumberCell.TabIndex = 9;
            // 
            // lblPhoneNumberCell
            // 
            this.lblPhoneNumberCell.AutoSize = true;
            this.lblPhoneNumberCell.Location = new System.Drawing.Point(50, 155);
            this.lblPhoneNumberCell.Name = "lblPhoneNumberCell";
            this.lblPhoneNumberCell.Size = new System.Drawing.Size(105, 17);
            this.lblPhoneNumberCell.TabIndex = 15;
            this.lblPhoneNumberCell.Text = "Cell Phone #:";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(605, 57);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(140, 22);
            this.txtPostalCode.TabIndex = 6;
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(513, 60);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(86, 17);
            this.lblPostalCode.TabIndex = 14;
            this.lblPostalCode.Text = "Postal/Zip:";
            // 
            // txtPhoneNumberWork
            // 
            this.txtPhoneNumberWork.Location = new System.Drawing.Point(161, 126);
            this.txtPhoneNumberWork.Name = "txtPhoneNumberWork";
            this.txtPhoneNumberWork.Size = new System.Drawing.Size(140, 22);
            this.txtPhoneNumberWork.TabIndex = 8;
            // 
            // lblPhoneNumberWork
            // 
            this.lblPhoneNumberWork.AutoSize = true;
            this.lblPhoneNumberWork.Location = new System.Drawing.Point(40, 129);
            this.lblPhoneNumberWork.Name = "lblPhoneNumberWork";
            this.lblPhoneNumberWork.Size = new System.Drawing.Size(115, 17);
            this.lblPhoneNumberWork.TabIndex = 12;
            this.lblPhoneNumberWork.Text = "Work Phone #:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(340, 57);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(165, 22);
            this.txtCity.TabIndex = 4;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(294, 60);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(40, 17);
            this.lblCity.TabIndex = 10;
            this.lblCity.Text = "City:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(340, 26);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(262, 22);
            this.txtAddress.TabIndex = 3;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(262, 26);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(72, 17);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Address:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(117, 90);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(135, 22);
            this.txtLastName.TabIndex = 2;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(20, 93);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(90, 17);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(20, 29);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(91, 17);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name:";
            // 
            // txtMiddleInitial
            // 
            this.txtMiddleInitial.Location = new System.Drawing.Point(117, 57);
            this.txtMiddleInitial.Name = "txtMiddleInitial";
            this.txtMiddleInitial.Size = new System.Drawing.Size(135, 22);
            this.txtMiddleInitial.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(117, 26);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(135, 22);
            this.txtFirstName.TabIndex = 0;
            // 
            // lblMiddleInitial
            // 
            this.lblMiddleInitial.AutoSize = true;
            this.lblMiddleInitial.Location = new System.Drawing.Point(23, 60);
            this.lblMiddleInitial.Name = "lblMiddleInitial";
            this.lblMiddleInitial.Size = new System.Drawing.Size(87, 17);
            this.lblMiddleInitial.TabIndex = 4;
            this.lblMiddleInitial.Text = "Middle Init:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(294, 646);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(139, 39);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Employee";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClearFields
            // 
            this.btnClearFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFields.Location = new System.Drawing.Point(439, 646);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(139, 39);
            this.btnClearFields.TabIndex = 8;
            this.btnClearFields.Text = "Clear Fields";
            this.btnClearFields.UseVisualStyleBackColor = true;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(852, 923);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grbEmployeeDetails);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add an Employee";
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            this.grbEmployeeDetails.ResumeLayout(false);
            this.grbProfessionalInfo.ResumeLayout(false);
            this.grbProfessionalInfo.PerformLayout();
            this.grbDepartmentDetails.ResumeLayout(false);
            this.grbDepartmentDetails.PerformLayout();
            this.grbPersonalInfo.ResumeLayout(false);
            this.grbPersonalInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grbEmployeeDetails;
        private System.Windows.Forms.GroupBox grbProfessionalInfo;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.GroupBox grbPersonalInfo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPhoneNumberCell;
        private System.Windows.Forms.Label lblPhoneNumberCell;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.TextBox txtPhoneNumberWork;
        private System.Windows.Forms.Label lblPhoneNumberWork;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtMiddleInitial;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblMiddleInitial;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.Label lblHireDate;
        private System.Windows.Forms.GroupBox grbDepartmentDetails;
        private System.Windows.Forms.ComboBox cboJob;
        private System.Windows.Forms.Label lblSupervisor;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.ComboBox cboSupervisor;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.ComboBox cboProvinces;
        private System.Windows.Forms.CheckBox chkIsSupervisor;
        private System.Windows.Forms.TextBox txtSIN;
        private System.Windows.Forms.Label lblSIN;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.ComboBox cboCountries;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblJobStart;
        private System.Windows.Forms.CheckBox chkBullets;
    }
}