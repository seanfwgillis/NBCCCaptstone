namespace AdminSupportSystem
{
    partial class ModifyDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyDepartment));
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.grbFields = new System.Windows.Forms.GroupBox();
            this.dtpInvocationDate = new System.Windows.Forms.DateTimePicker();
            this.lblInvocationDate = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            this.grbDepartments = new System.Windows.Forms.GroupBox();
            this.cboDepartments = new System.Windows.Forms.ComboBox();
            this.grbEditOptions = new System.Windows.Forms.GroupBox();
            this.rdoDate = new System.Windows.Forms.RadioButton();
            this.rdoDescription = new System.Windows.Forms.RadioButton();
            this.rdoName = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grbFields.SuspendLayout();
            this.grbDepartments.SuspendLayout();
            this.grbEditOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitle.Location = new System.Drawing.Point(203, 85);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(460, 56);
            this.lblMainTitle.TabIndex = 1;
            this.lblMainTitle.Text = "Modify Department";
            // 
            // grbFields
            // 
            this.grbFields.Controls.Add(this.dtpInvocationDate);
            this.grbFields.Controls.Add(this.lblInvocationDate);
            this.grbFields.Controls.Add(this.txtDescription);
            this.grbFields.Controls.Add(this.lblDescription);
            this.grbFields.Controls.Add(this.txtName);
            this.grbFields.Controls.Add(this.lblName);
            this.grbFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFields.Location = new System.Drawing.Point(148, 434);
            this.grbFields.Name = "grbFields";
            this.grbFields.Size = new System.Drawing.Size(551, 204);
            this.grbFields.TabIndex = 2;
            this.grbFields.TabStop = false;
            this.grbFields.Text = "Department Details";
            // 
            // dtpInvocationDate
            // 
            this.dtpInvocationDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInvocationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInvocationDate.Location = new System.Drawing.Point(168, 170);
            this.dtpInvocationDate.Name = "dtpInvocationDate";
            this.dtpInvocationDate.Size = new System.Drawing.Size(200, 22);
            this.dtpInvocationDate.TabIndex = 5;
            // 
            // lblInvocationDate
            // 
            this.lblInvocationDate.AutoSize = true;
            this.lblInvocationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvocationDate.Location = new System.Drawing.Point(36, 175);
            this.lblInvocationDate.Name = "lblInvocationDate";
            this.lblInvocationDate.Size = new System.Drawing.Size(126, 17);
            this.lblInvocationDate.TabIndex = 4;
            this.lblInvocationDate.Text = "Invocation Date:";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(168, 62);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(365, 92);
            this.txtDescription.TabIndex = 3;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(67, 62);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(100, 17);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description: ";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(168, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(174, 22);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(19, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(143, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Department Name:";
            // 
            // btnModify
            // 
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.Location = new System.Drawing.Point(245, 644);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(131, 29);
            this.btnModify.TabIndex = 6;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // grbDepartments
            // 
            this.grbDepartments.Controls.Add(this.cboDepartments);
            this.grbDepartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDepartments.Location = new System.Drawing.Point(316, 237);
            this.grbDepartments.Name = "grbDepartments";
            this.grbDepartments.Size = new System.Drawing.Size(236, 65);
            this.grbDepartments.TabIndex = 3;
            this.grbDepartments.TabStop = false;
            this.grbDepartments.Text = "Departments";
            // 
            // cboDepartments
            // 
            this.cboDepartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartments.FormattingEnabled = true;
            this.cboDepartments.Location = new System.Drawing.Point(14, 26);
            this.cboDepartments.Name = "cboDepartments";
            this.cboDepartments.Size = new System.Drawing.Size(216, 24);
            this.cboDepartments.TabIndex = 0;
            this.cboDepartments.SelectionChangeCommitted += new System.EventHandler(this.cboDepartments_SelectionChangeCommitted);
            // 
            // grbEditOptions
            // 
            this.grbEditOptions.Controls.Add(this.rdoDate);
            this.grbEditOptions.Controls.Add(this.rdoDescription);
            this.grbEditOptions.Controls.Add(this.rdoName);
            this.grbEditOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEditOptions.Location = new System.Drawing.Point(316, 309);
            this.grbEditOptions.Name = "grbEditOptions";
            this.grbEditOptions.Size = new System.Drawing.Size(236, 119);
            this.grbEditOptions.TabIndex = 4;
            this.grbEditOptions.TabStop = false;
            this.grbEditOptions.Text = "Edit Options";
            // 
            // rdoDate
            // 
            this.rdoDate.AutoSize = true;
            this.rdoDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDate.Location = new System.Drawing.Point(64, 88);
            this.rdoDate.Name = "rdoDate";
            this.rdoDate.Size = new System.Drawing.Size(142, 21);
            this.rdoDate.TabIndex = 2;
            this.rdoDate.TabStop = true;
            this.rdoDate.Text = "Invocation Date";
            this.rdoDate.UseVisualStyleBackColor = true;
            this.rdoDate.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // rdoDescription
            // 
            this.rdoDescription.AutoSize = true;
            this.rdoDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDescription.Location = new System.Drawing.Point(64, 58);
            this.rdoDescription.Name = "rdoDescription";
            this.rdoDescription.Size = new System.Drawing.Size(111, 21);
            this.rdoDescription.TabIndex = 1;
            this.rdoDescription.TabStop = true;
            this.rdoDescription.Text = "Description";
            this.rdoDescription.UseVisualStyleBackColor = true;
            this.rdoDescription.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // rdoName
            // 
            this.rdoName.AutoSize = true;
            this.rdoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoName.Location = new System.Drawing.Point(64, 30);
            this.rdoName.Name = "rdoName";
            this.rdoName.Size = new System.Drawing.Size(70, 21);
            this.rdoName.TabIndex = 0;
            this.rdoName.TabStop = true;
            this.rdoName.Text = "Name";
            this.rdoName.UseVisualStyleBackColor = true;
            this.rdoName.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(380, 644);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(131, 29);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(516, 644);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(131, 29);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ModifyDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(852, 923);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grbEditOptions);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.grbDepartments);
            this.Controls.Add(this.grbFields);
            this.Controls.Add(this.lblMainTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModifyDepartment";
            this.Text = "Modify Department";
            this.Load += new System.EventHandler(this.ModifyDepartment_Load);
            this.grbFields.ResumeLayout(false);
            this.grbFields.PerformLayout();
            this.grbDepartments.ResumeLayout(false);
            this.grbEditOptions.ResumeLayout(false);
            this.grbEditOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.GroupBox grbFields;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.DateTimePicker dtpInvocationDate;
        private System.Windows.Forms.Label lblInvocationDate;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox grbDepartments;
        private System.Windows.Forms.ComboBox cboDepartments;
        private System.Windows.Forms.GroupBox grbEditOptions;
        private System.Windows.Forms.RadioButton rdoDate;
        private System.Windows.Forms.RadioButton rdoDescription;
        private System.Windows.Forms.RadioButton rdoName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
    }
}