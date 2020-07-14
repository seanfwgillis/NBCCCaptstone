namespace AdminSupportSystem
{
    partial class EmployeeMaintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeMaintenance));
            this.lblTitle = new System.Windows.Forms.Label();
            this.grbEmployeeDetails = new System.Windows.Forms.GroupBox();
            this.grbContactInfo = new System.Windows.Forms.GroupBox();
            this.lblContactInfo = new System.Windows.Forms.Label();
            this.grbAddressInfo = new System.Windows.Forms.GroupBox();
            this.lblAddressInfo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNameTitle = new System.Windows.Forms.Label();
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.grbSearchType = new System.Windows.Forms.GroupBox();
            this.rdoEmployeeId = new System.Windows.Forms.RadioButton();
            this.rdoName = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstEmployees = new System.Windows.Forms.ListBox();
            this.txtSearchEmployee = new System.Windows.Forms.TextBox();
            this.lblSearchEmployee = new System.Windows.Forms.Label();
            this.grbEmployeeDetails.SuspendLayout();
            this.grbContactInfo.SuspendLayout();
            this.grbAddressInfo.SuspendLayout();
            this.grbSearch.SuspendLayout();
            this.grbSearchType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(218, 76);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(425, 56);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Search Employee";
            // 
            // grbEmployeeDetails
            // 
            this.grbEmployeeDetails.Controls.Add(this.grbContactInfo);
            this.grbEmployeeDetails.Controls.Add(this.grbAddressInfo);
            this.grbEmployeeDetails.Controls.Add(this.lblName);
            this.grbEmployeeDetails.Controls.Add(this.lblNameTitle);
            this.grbEmployeeDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEmployeeDetails.Location = new System.Drawing.Point(118, 464);
            this.grbEmployeeDetails.Name = "grbEmployeeDetails";
            this.grbEmployeeDetails.Size = new System.Drawing.Size(631, 253);
            this.grbEmployeeDetails.TabIndex = 6;
            this.grbEmployeeDetails.TabStop = false;
            this.grbEmployeeDetails.Text = "Employee Details";
            // 
            // grbContactInfo
            // 
            this.grbContactInfo.Controls.Add(this.lblContactInfo);
            this.grbContactInfo.Location = new System.Drawing.Point(308, 81);
            this.grbContactInfo.Name = "grbContactInfo";
            this.grbContactInfo.Size = new System.Drawing.Size(296, 166);
            this.grbContactInfo.TabIndex = 3;
            this.grbContactInfo.TabStop = false;
            this.grbContactInfo.Text = "Contact Information";
            // 
            // lblContactInfo
            // 
            this.lblContactInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblContactInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactInfo.Location = new System.Drawing.Point(15, 28);
            this.lblContactInfo.Name = "lblContactInfo";
            this.lblContactInfo.Size = new System.Drawing.Size(275, 126);
            this.lblContactInfo.TabIndex = 15;
            this.lblContactInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbAddressInfo
            // 
            this.grbAddressInfo.Controls.Add(this.lblAddressInfo);
            this.grbAddressInfo.Location = new System.Drawing.Point(6, 81);
            this.grbAddressInfo.Name = "grbAddressInfo";
            this.grbAddressInfo.Size = new System.Drawing.Size(296, 166);
            this.grbAddressInfo.TabIndex = 2;
            this.grbAddressInfo.TabStop = false;
            this.grbAddressInfo.Text = "Address Information";
            // 
            // lblAddressInfo
            // 
            this.lblAddressInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAddressInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressInfo.Location = new System.Drawing.Point(15, 28);
            this.lblAddressInfo.Name = "lblAddressInfo";
            this.lblAddressInfo.Size = new System.Drawing.Size(275, 126);
            this.lblAddressInfo.TabIndex = 15;
            this.lblAddressInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(212, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(186, 27);
            this.lblName.TabIndex = 1;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNameTitle
            // 
            this.lblNameTitle.AutoSize = true;
            this.lblNameTitle.Location = new System.Drawing.Point(240, 17);
            this.lblNameTitle.Name = "lblNameTitle";
            this.lblNameTitle.Size = new System.Drawing.Size(124, 17);
            this.lblNameTitle.TabIndex = 0;
            this.lblNameTitle.Text = "Employee Name";
            // 
            // grbSearch
            // 
            this.grbSearch.Controls.Add(this.grbSearchType);
            this.grbSearch.Controls.Add(this.btnSearch);
            this.grbSearch.Controls.Add(this.lstEmployees);
            this.grbSearch.Controls.Add(this.txtSearchEmployee);
            this.grbSearch.Controls.Add(this.lblSearchEmployee);
            this.grbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSearch.Location = new System.Drawing.Point(213, 246);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Size = new System.Drawing.Size(458, 212);
            this.grbSearch.TabIndex = 13;
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
            this.rdoEmployeeId.CheckedChanged += new System.EventHandler(this.rdoEmployeeId_CheckedChanged);
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
            this.rdoName.CheckedChanged += new System.EventHandler(this.rdoName_CheckedChanged);
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
            // EmployeeMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(852, 923);
            this.Controls.Add(this.grbSearch);
            this.Controls.Add(this.grbEmployeeDetails);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search For Employee";
            this.Load += new System.EventHandler(this.EmployeeMaintenance_Load);
            this.grbEmployeeDetails.ResumeLayout(false);
            this.grbEmployeeDetails.PerformLayout();
            this.grbContactInfo.ResumeLayout(false);
            this.grbAddressInfo.ResumeLayout(false);
            this.grbSearch.ResumeLayout(false);
            this.grbSearch.PerformLayout();
            this.grbSearchType.ResumeLayout(false);
            this.grbSearchType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grbEmployeeDetails;
        private System.Windows.Forms.GroupBox grbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lstEmployees;
        private System.Windows.Forms.TextBox txtSearchEmployee;
        private System.Windows.Forms.Label lblSearchEmployee;
        private System.Windows.Forms.GroupBox grbSearchType;
        private System.Windows.Forms.RadioButton rdoEmployeeId;
        private System.Windows.Forms.RadioButton rdoName;
        private System.Windows.Forms.Label lblAddressInfo;
        private System.Windows.Forms.GroupBox grbContactInfo;
        private System.Windows.Forms.Label lblContactInfo;
        private System.Windows.Forms.GroupBox grbAddressInfo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNameTitle;
    }
}