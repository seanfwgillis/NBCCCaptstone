namespace AdminSupportSystem
{
    partial class ModifyEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyEmployee));
            this.lblTitle = new System.Windows.Forms.Label();
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.grbSearchType = new System.Windows.Forms.GroupBox();
            this.rdoEmployeeId = new System.Windows.Forms.RadioButton();
            this.rdoName = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstEmployees = new System.Windows.Forms.ListBox();
            this.txtSearchEmployee = new System.Windows.Forms.TextBox();
            this.lblSearchEmployee = new System.Windows.Forms.Label();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.grbEmployeeDetails = new System.Windows.Forms.GroupBox();
            this.grbProfessionalInfo = new System.Windows.Forms.GroupBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.btnResetDepartmentDetails = new System.Windows.Forms.Button();
            this.grbStatus = new System.Windows.Forms.GroupBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblAgeTitle = new System.Windows.Forms.Label();
            this.rdoRetired = new System.Windows.Forms.RadioButton();
            this.rdoTerminated = new System.Windows.Forms.RadioButton();
            this.rdoActive = new System.Windows.Forms.RadioButton();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblJobStart = new System.Windows.Forms.Label();
            this.chkIsSupervisor = new System.Windows.Forms.CheckBox();
            this.grbDepartmentDetails = new System.Windows.Forms.GroupBox();
            this.cboJob = new System.Windows.Forms.ComboBox();
            this.lblSupervisor = new System.Windows.Forms.Label();
            this.lblJob = new System.Windows.Forms.Label();
            this.cboSupervisor = new System.Windows.Forms.ComboBox();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.grbPersonalInfo = new System.Windows.Forms.GroupBox();
            this.cboCountries = new System.Windows.Forms.ComboBox();
            this.cboProvinces = new System.Windows.Forms.ComboBox();
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
            this.grbSearch.SuspendLayout();
            this.grbSearchType.SuspendLayout();
            this.grbEmployeeDetails.SuspendLayout();
            this.grbProfessionalInfo.SuspendLayout();
            this.grbStatus.SuspendLayout();
            this.grbDepartmentDetails.SuspendLayout();
            this.grbPersonalInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(223, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(419, 56);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Modify Employee";
            // 
            // grbSearch
            // 
            this.grbSearch.Controls.Add(this.grbSearchType);
            this.grbSearch.Controls.Add(this.btnSearch);
            this.grbSearch.Controls.Add(this.lstEmployees);
            this.grbSearch.Controls.Add(this.txtSearchEmployee);
            this.grbSearch.Controls.Add(this.lblSearchEmployee);
            this.grbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSearch.Location = new System.Drawing.Point(204, 87);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Size = new System.Drawing.Size(458, 212);
            this.grbSearch.TabIndex = 14;
            this.grbSearch.TabStop = false;
            this.grbSearch.Text = "Employee Search";
            // 
            // grbSearchType
            // 
            this.grbSearchType.Controls.Add(this.rdoEmployeeId);
            this.grbSearchType.Controls.Add(this.rdoName);
            this.grbSearchType.Location = new System.Drawing.Point(11, 29);
            this.grbSearchType.Name = "grbSearchType";
            this.grbSearchType.Size = new System.Drawing.Size(257, 78);
            this.grbSearchType.TabIndex = 13;
            this.grbSearchType.TabStop = false;
            this.grbSearchType.Text = "Search By";
            // 
            // rdoEmployeeId
            // 
            this.rdoEmployeeId.AutoSize = true;
            this.rdoEmployeeId.Location = new System.Drawing.Point(119, 34);
            this.rdoEmployeeId.Name = "rdoEmployeeId";
            this.rdoEmployeeId.Size = new System.Drawing.Size(119, 21);
            this.rdoEmployeeId.TabIndex = 1;
            this.rdoEmployeeId.TabStop = true;
            this.rdoEmployeeId.Text = "Employee ID";
            this.rdoEmployeeId.UseVisualStyleBackColor = true;
            this.rdoEmployeeId.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // rdoName
            // 
            this.rdoName.AutoSize = true;
            this.rdoName.Location = new System.Drawing.Point(26, 34);
            this.rdoName.Name = "rdoName";
            this.rdoName.Size = new System.Drawing.Size(70, 21);
            this.rdoName.TabIndex = 0;
            this.rdoName.TabStop = true;
            this.rdoName.Text = "Name";
            this.rdoName.UseVisualStyleBackColor = true;
            this.rdoName.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(11, 141);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(257, 52);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lstEmployees
            // 
            this.lstEmployees.FormattingEnabled = true;
            this.lstEmployees.ItemHeight = 16;
            this.lstEmployees.Location = new System.Drawing.Point(274, 29);
            this.lstEmployees.Name = "lstEmployees";
            this.lstEmployees.Size = new System.Drawing.Size(173, 164);
            this.lstEmployees.TabIndex = 7;
            this.lstEmployees.Click += new System.EventHandler(this.lstEmployees_Click);
            // 
            // txtSearchEmployee
            // 
            this.txtSearchEmployee.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSearchEmployee.Location = new System.Drawing.Point(81, 113);
            this.txtSearchEmployee.Name = "txtSearchEmployee";
            this.txtSearchEmployee.Size = new System.Drawing.Size(187, 22);
            this.txtSearchEmployee.TabIndex = 11;
            this.txtSearchEmployee.Enter += new System.EventHandler(this.txtSearchEmployee_Enter);
            this.txtSearchEmployee.Leave += new System.EventHandler(this.txtSearchEmployee_Leave);
            // 
            // lblSearchEmployee
            // 
            this.lblSearchEmployee.AutoSize = true;
            this.lblSearchEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchEmployee.Location = new System.Drawing.Point(12, 116);
            this.lblSearchEmployee.Name = "lblSearchEmployee";
            this.lblSearchEmployee.Size = new System.Drawing.Size(64, 17);
            this.lblSearchEmployee.TabIndex = 10;
            this.lblSearchEmployee.Text = "Search:";
            // 
            // btnClearFields
            // 
            this.btnClearFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFields.Location = new System.Drawing.Point(361, 714);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(139, 39);
            this.btnClearFields.TabIndex = 18;
            this.btnClearFields.Text = "Clear Fields";
            this.btnClearFields.UseVisualStyleBackColor = true;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.Location = new System.Drawing.Point(506, 714);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(139, 39);
            this.btnMainMenu.TabIndex = 16;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnModify
            // 
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.Location = new System.Drawing.Point(216, 714);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(139, 39);
            this.btnModify.TabIndex = 15;
            this.btnModify.Text = "Save";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // grbEmployeeDetails
            // 
            this.grbEmployeeDetails.Controls.Add(this.grbProfessionalInfo);
            this.grbEmployeeDetails.Controls.Add(this.grbPersonalInfo);
            this.grbEmployeeDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEmployeeDetails.Location = new System.Drawing.Point(36, 305);
            this.grbEmployeeDetails.Name = "grbEmployeeDetails";
            this.grbEmployeeDetails.Size = new System.Drawing.Size(776, 403);
            this.grbEmployeeDetails.TabIndex = 17;
            this.grbEmployeeDetails.TabStop = false;
            this.grbEmployeeDetails.Text = "Employee Details";
            // 
            // grbProfessionalInfo
            // 
            this.grbProfessionalInfo.Controls.Add(this.dtpEndDate);
            this.grbProfessionalInfo.Controls.Add(this.lblEndDate);
            this.grbProfessionalInfo.Controls.Add(this.btnResetDepartmentDetails);
            this.grbProfessionalInfo.Controls.Add(this.grbStatus);
            this.grbProfessionalInfo.Controls.Add(this.dtpStartDate);
            this.grbProfessionalInfo.Controls.Add(this.lblJobStart);
            this.grbProfessionalInfo.Controls.Add(this.chkIsSupervisor);
            this.grbProfessionalInfo.Controls.Add(this.grbDepartmentDetails);
            this.grbProfessionalInfo.Controls.Add(this.cboDepartment);
            this.grbProfessionalInfo.Controls.Add(this.lblDepartment);
            this.grbProfessionalInfo.Location = new System.Drawing.Point(6, 183);
            this.grbProfessionalInfo.Name = "grbProfessionalInfo";
            this.grbProfessionalInfo.Size = new System.Drawing.Size(751, 214);
            this.grbProfessionalInfo.TabIndex = 11;
            this.grbProfessionalInfo.TabStop = false;
            this.grbProfessionalInfo.Text = "Professional Information";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(111, 174);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 22);
            this.dtpEndDate.TabIndex = 25;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(18, 179);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(80, 17);
            this.lblEndDate.TabIndex = 24;
            this.lblEndDate.Text = "End Date:";
            // 
            // btnResetDepartmentDetails
            // 
            this.btnResetDepartmentDetails.Location = new System.Drawing.Point(508, 149);
            this.btnResetDepartmentDetails.Name = "btnResetDepartmentDetails";
            this.btnResetDepartmentDetails.Size = new System.Drawing.Size(227, 34);
            this.btnResetDepartmentDetails.TabIndex = 23;
            this.btnResetDepartmentDetails.Text = "Default Department Details";
            this.btnResetDepartmentDetails.UseVisualStyleBackColor = true;
            this.btnResetDepartmentDetails.Click += new System.EventHandler(this.btnResetDepartmentDetails_Click);
            // 
            // grbStatus
            // 
            this.grbStatus.Controls.Add(this.lblAge);
            this.grbStatus.Controls.Add(this.lblAgeTitle);
            this.grbStatus.Controls.Add(this.rdoRetired);
            this.grbStatus.Controls.Add(this.rdoTerminated);
            this.grbStatus.Controls.Add(this.rdoActive);
            this.grbStatus.Location = new System.Drawing.Point(26, 53);
            this.grbStatus.Name = "grbStatus";
            this.grbStatus.Size = new System.Drawing.Size(285, 111);
            this.grbStatus.TabIndex = 22;
            this.grbStatus.TabStop = false;
            this.grbStatus.Text = "Employment Status";
            // 
            // lblAge
            // 
            this.lblAge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(182, 44);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(86, 59);
            this.lblAge.TabIndex = 25;
            this.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAgeTitle
            // 
            this.lblAgeTitle.AutoSize = true;
            this.lblAgeTitle.Location = new System.Drawing.Point(206, 18);
            this.lblAgeTitle.Name = "lblAgeTitle";
            this.lblAgeTitle.Size = new System.Drawing.Size(36, 17);
            this.lblAgeTitle.TabIndex = 24;
            this.lblAgeTitle.Text = "Age";
            // 
            // rdoRetired
            // 
            this.rdoRetired.AutoSize = true;
            this.rdoRetired.Location = new System.Drawing.Point(18, 82);
            this.rdoRetired.Name = "rdoRetired";
            this.rdoRetired.Size = new System.Drawing.Size(82, 21);
            this.rdoRetired.TabIndex = 23;
            this.rdoRetired.TabStop = true;
            this.rdoRetired.Text = "Retired";
            this.rdoRetired.UseVisualStyleBackColor = true;
            this.rdoRetired.CheckedChanged += new System.EventHandler(this.rdoStatus_CheckedChanged);
            // 
            // rdoTerminated
            // 
            this.rdoTerminated.AutoSize = true;
            this.rdoTerminated.Location = new System.Drawing.Point(18, 55);
            this.rdoTerminated.Name = "rdoTerminated";
            this.rdoTerminated.Size = new System.Drawing.Size(111, 21);
            this.rdoTerminated.TabIndex = 23;
            this.rdoTerminated.TabStop = true;
            this.rdoTerminated.Text = "Terminated";
            this.rdoTerminated.UseVisualStyleBackColor = true;
            this.rdoTerminated.CheckedChanged += new System.EventHandler(this.rdoStatus_CheckedChanged);
            // 
            // rdoActive
            // 
            this.rdoActive.AutoSize = true;
            this.rdoActive.Location = new System.Drawing.Point(18, 28);
            this.rdoActive.Name = "rdoActive";
            this.rdoActive.Size = new System.Drawing.Size(73, 21);
            this.rdoActive.TabIndex = 0;
            this.rdoActive.TabStop = true;
            this.rdoActive.Text = "Active";
            this.rdoActive.UseVisualStyleBackColor = true;
            this.rdoActive.CheckedChanged += new System.EventHandler(this.rdoStatus_CheckedChanged);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(111, 25);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 22);
            this.dtpStartDate.TabIndex = 21;
            // 
            // lblJobStart
            // 
            this.lblJobStart.AutoSize = true;
            this.lblJobStart.Location = new System.Drawing.Point(18, 30);
            this.lblJobStart.Name = "lblJobStart";
            this.lblJobStart.Size = new System.Drawing.Size(87, 17);
            this.lblJobStart.TabIndex = 20;
            this.lblJobStart.Text = "Start Date:";
            // 
            // chkIsSupervisor
            // 
            this.chkIsSupervisor.AutoSize = true;
            this.chkIsSupervisor.Location = new System.Drawing.Point(377, 149);
            this.chkIsSupervisor.Name = "chkIsSupervisor";
            this.chkIsSupervisor.Size = new System.Drawing.Size(125, 21);
            this.chkIsSupervisor.TabIndex = 1;
            this.chkIsSupervisor.Text = "Is Supervisor";
            this.chkIsSupervisor.UseVisualStyleBackColor = true;
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
            this.grbPersonalInfo.Controls.Add(this.cboProvinces);
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
            this.grbPersonalInfo.Size = new System.Drawing.Size(751, 156);
            this.grbPersonalInfo.TabIndex = 10;
            this.grbPersonalInfo.TabStop = false;
            this.grbPersonalInfo.Text = "Personal Information";
            // 
            // cboCountries
            // 
            this.cboCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCountries.FormattingEnabled = true;
            this.cboCountries.Location = new System.Drawing.Point(318, 85);
            this.cboCountries.Name = "cboCountries";
            this.cboCountries.Size = new System.Drawing.Size(164, 24);
            this.cboCountries.TabIndex = 28;
            this.cboCountries.SelectedIndexChanged += new System.EventHandler(this.cboCountries_SelectedIndexChanged);
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
            this.lblCountry.Location = new System.Drawing.Point(243, 88);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(69, 17);
            this.lblCountry.TabIndex = 20;
            this.lblCountry.Text = "Country:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(514, 119);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(231, 22);
            this.txtEmail.TabIndex = 10;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(460, 122);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 17);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "Email:";
            // 
            // txtPhoneNumberCell
            // 
            this.txtPhoneNumberCell.Location = new System.Drawing.Point(318, 119);
            this.txtPhoneNumberCell.Name = "txtPhoneNumberCell";
            this.txtPhoneNumberCell.Size = new System.Drawing.Size(140, 22);
            this.txtPhoneNumberCell.TabIndex = 9;
            // 
            // lblPhoneNumberCell
            // 
            this.lblPhoneNumberCell.AutoSize = true;
            this.lblPhoneNumberCell.Location = new System.Drawing.Point(253, 122);
            this.lblPhoneNumberCell.Name = "lblPhoneNumberCell";
            this.lblPhoneNumberCell.Size = new System.Drawing.Size(59, 17);
            this.lblPhoneNumberCell.TabIndex = 15;
            this.lblPhoneNumberCell.Text = "Cell  #:";
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
            this.txtPhoneNumberWork.Location = new System.Drawing.Point(102, 119);
            this.txtPhoneNumberWork.Name = "txtPhoneNumberWork";
            this.txtPhoneNumberWork.Size = new System.Drawing.Size(143, 22);
            this.txtPhoneNumberWork.TabIndex = 8;
            // 
            // lblPhoneNumberWork
            // 
            this.lblPhoneNumberWork.AutoSize = true;
            this.lblPhoneNumberWork.Location = new System.Drawing.Point(26, 122);
            this.lblPhoneNumberWork.Name = "lblPhoneNumberWork";
            this.lblPhoneNumberWork.Size = new System.Drawing.Size(69, 17);
            this.lblPhoneNumberWork.TabIndex = 12;
            this.lblPhoneNumberWork.Text = "Work  #:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(317, 57);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(165, 22);
            this.txtCity.TabIndex = 4;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(271, 60);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(40, 17);
            this.lblCity.TabIndex = 10;
            this.lblCity.Text = "City:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(317, 26);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(262, 22);
            this.txtAddress.TabIndex = 3;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(239, 26);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(72, 17);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Address:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(102, 88);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(135, 22);
            this.txtLastName.TabIndex = 2;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(5, 91);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(90, 17);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(5, 27);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(91, 17);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name:";
            // 
            // txtMiddleInitial
            // 
            this.txtMiddleInitial.Location = new System.Drawing.Point(102, 55);
            this.txtMiddleInitial.Name = "txtMiddleInitial";
            this.txtMiddleInitial.Size = new System.Drawing.Size(135, 22);
            this.txtMiddleInitial.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(102, 24);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(135, 22);
            this.txtFirstName.TabIndex = 0;
            // 
            // lblMiddleInitial
            // 
            this.lblMiddleInitial.AutoSize = true;
            this.lblMiddleInitial.Location = new System.Drawing.Point(8, 58);
            this.lblMiddleInitial.Name = "lblMiddleInitial";
            this.lblMiddleInitial.Size = new System.Drawing.Size(87, 17);
            this.lblMiddleInitial.TabIndex = 4;
            this.lblMiddleInitial.Text = "Middle Init:";
            // 
            // ModifyEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(852, 923);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.grbEmployeeDetails);
            this.Controls.Add(this.grbSearch);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModifyEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modify Employee Details";
            this.Load += new System.EventHandler(this.ModifyEmployee_Load);
            this.grbSearch.ResumeLayout(false);
            this.grbSearch.PerformLayout();
            this.grbSearchType.ResumeLayout(false);
            this.grbSearchType.PerformLayout();
            this.grbEmployeeDetails.ResumeLayout(false);
            this.grbProfessionalInfo.ResumeLayout(false);
            this.grbProfessionalInfo.PerformLayout();
            this.grbStatus.ResumeLayout(false);
            this.grbStatus.PerformLayout();
            this.grbDepartmentDetails.ResumeLayout(false);
            this.grbDepartmentDetails.PerformLayout();
            this.grbPersonalInfo.ResumeLayout(false);
            this.grbPersonalInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grbSearch;
        private System.Windows.Forms.GroupBox grbSearchType;
        private System.Windows.Forms.RadioButton rdoEmployeeId;
        private System.Windows.Forms.RadioButton rdoName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lstEmployees;
        private System.Windows.Forms.TextBox txtSearchEmployee;
        private System.Windows.Forms.Label lblSearchEmployee;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.GroupBox grbEmployeeDetails;
        private System.Windows.Forms.GroupBox grbProfessionalInfo;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblJobStart;
        private System.Windows.Forms.CheckBox chkIsSupervisor;
        private System.Windows.Forms.GroupBox grbDepartmentDetails;
        private System.Windows.Forms.ComboBox cboJob;
        private System.Windows.Forms.Label lblSupervisor;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.ComboBox cboSupervisor;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.GroupBox grbPersonalInfo;
        private System.Windows.Forms.ComboBox cboCountries;
        private System.Windows.Forms.ComboBox cboProvinces;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblCountry;
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
        private System.Windows.Forms.GroupBox grbStatus;
        private System.Windows.Forms.RadioButton rdoRetired;
        private System.Windows.Forms.RadioButton rdoTerminated;
        private System.Windows.Forms.RadioButton rdoActive;
        private System.Windows.Forms.Button btnResetDepartmentDetails;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblAgeTitle;
    }
}