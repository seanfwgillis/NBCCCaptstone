namespace AdminSupportSystem
{
    partial class MainMenu
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.grbApplicationList = new System.Windows.Forms.GroupBox();
            this.btnModifyDepartment = new System.Windows.Forms.Button();
            this.btnEmployeeAdd = new System.Windows.Forms.Button();
            this.btnModifyPurchaseOrder = new System.Windows.Forms.Button();
            this.btnCreatePurchaseOrder = new System.Windows.Forms.Button();
            this.btnEmployeeSearch = new System.Windows.Forms.Button();
            this.btnDepartmentAdd = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnModifyEmployee = new System.Windows.Forms.Button();
            this.grbApplicationList.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(183, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(434, 32);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Administration Support System";
            // 
            // grbApplicationList
            // 
            this.grbApplicationList.Controls.Add(this.btnModifyEmployee);
            this.grbApplicationList.Controls.Add(this.btnModifyDepartment);
            this.grbApplicationList.Controls.Add(this.btnEmployeeAdd);
            this.grbApplicationList.Controls.Add(this.btnModifyPurchaseOrder);
            this.grbApplicationList.Controls.Add(this.btnCreatePurchaseOrder);
            this.grbApplicationList.Controls.Add(this.btnEmployeeSearch);
            this.grbApplicationList.Controls.Add(this.btnDepartmentAdd);
            this.grbApplicationList.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbApplicationList.Location = new System.Drawing.Point(135, 59);
            this.grbApplicationList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbApplicationList.Name = "grbApplicationList";
            this.grbApplicationList.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbApplicationList.Size = new System.Drawing.Size(548, 233);
            this.grbApplicationList.TabIndex = 4;
            this.grbApplicationList.TabStop = false;
            this.grbApplicationList.Text = "Application List";
            // 
            // btnModifyDepartment
            // 
            this.btnModifyDepartment.Location = new System.Drawing.Point(20, 133);
            this.btnModifyDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModifyDepartment.Name = "btnModifyDepartment";
            this.btnModifyDepartment.Size = new System.Drawing.Size(123, 86);
            this.btnModifyDepartment.TabIndex = 9;
            this.btnModifyDepartment.Text = "Modify Department";
            this.btnModifyDepartment.UseVisualStyleBackColor = true;
            this.btnModifyDepartment.Click += new System.EventHandler(this.btnModifyDepartment_Click);
            // 
            // btnEmployeeAdd
            // 
            this.btnEmployeeAdd.Location = new System.Drawing.Point(149, 34);
            this.btnEmployeeAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmployeeAdd.Name = "btnEmployeeAdd";
            this.btnEmployeeAdd.Size = new System.Drawing.Size(123, 86);
            this.btnEmployeeAdd.TabIndex = 8;
            this.btnEmployeeAdd.Text = "Add Employee";
            this.btnEmployeeAdd.UseVisualStyleBackColor = true;
            this.btnEmployeeAdd.Click += new System.EventHandler(this.btnEmployeeAdd_Click);
            // 
            // btnModifyPurchaseOrder
            // 
            this.btnModifyPurchaseOrder.Location = new System.Drawing.Point(404, 133);
            this.btnModifyPurchaseOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModifyPurchaseOrder.Name = "btnModifyPurchaseOrder";
            this.btnModifyPurchaseOrder.Size = new System.Drawing.Size(123, 86);
            this.btnModifyPurchaseOrder.TabIndex = 7;
            this.btnModifyPurchaseOrder.Text = "Modify Purchase Order";
            this.btnModifyPurchaseOrder.UseVisualStyleBackColor = true;
            this.btnModifyPurchaseOrder.Click += new System.EventHandler(this.btnModifyPurchaseOrder_Click);
            // 
            // btnCreatePurchaseOrder
            // 
            this.btnCreatePurchaseOrder.Location = new System.Drawing.Point(404, 34);
            this.btnCreatePurchaseOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreatePurchaseOrder.Name = "btnCreatePurchaseOrder";
            this.btnCreatePurchaseOrder.Size = new System.Drawing.Size(123, 86);
            this.btnCreatePurchaseOrder.TabIndex = 6;
            this.btnCreatePurchaseOrder.Text = "Create Purchase Order";
            this.btnCreatePurchaseOrder.UseVisualStyleBackColor = true;
            this.btnCreatePurchaseOrder.Click += new System.EventHandler(this.btnCreatePurchaseOrder_Click);
            // 
            // btnEmployeeSearch
            // 
            this.btnEmployeeSearch.Location = new System.Drawing.Point(149, 133);
            this.btnEmployeeSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmployeeSearch.Name = "btnEmployeeSearch";
            this.btnEmployeeSearch.Size = new System.Drawing.Size(123, 86);
            this.btnEmployeeSearch.TabIndex = 5;
            this.btnEmployeeSearch.Text = "Search Employee";
            this.btnEmployeeSearch.UseVisualStyleBackColor = true;
            this.btnEmployeeSearch.Click += new System.EventHandler(this.btnEmployeeSearch_Click);
            // 
            // btnDepartmentAdd
            // 
            this.btnDepartmentAdd.Location = new System.Drawing.Point(20, 34);
            this.btnDepartmentAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDepartmentAdd.Name = "btnDepartmentAdd";
            this.btnDepartmentAdd.Size = new System.Drawing.Size(123, 86);
            this.btnDepartmentAdd.TabIndex = 0;
            this.btnDepartmentAdd.Text = "Add Department";
            this.btnDepartmentAdd.UseVisualStyleBackColor = true;
            this.btnDepartmentAdd.Click += new System.EventHandler(this.btnDepartmentAdd_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(376, 341);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 35);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnModifyEmployee
            // 
            this.btnModifyEmployee.Location = new System.Drawing.Point(278, 34);
            this.btnModifyEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModifyEmployee.Name = "btnModifyEmployee";
            this.btnModifyEmployee.Size = new System.Drawing.Size(123, 86);
            this.btnModifyEmployee.TabIndex = 10;
            this.btnModifyEmployee.Text = "Modify Employee";
            this.btnModifyEmployee.UseVisualStyleBackColor = true;
            this.btnModifyEmployee.Click += new System.EventHandler(this.btnModifyEmployee_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.grbApplicationList);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.grbApplicationList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grbApplicationList;
        private System.Windows.Forms.Button btnDepartmentAdd;
        private System.Windows.Forms.Button btnEmployeeSearch;
        private System.Windows.Forms.Button btnModifyPurchaseOrder;
        private System.Windows.Forms.Button btnCreatePurchaseOrder;
        private System.Windows.Forms.Button btnEmployeeAdd;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnModifyDepartment;
        private System.Windows.Forms.Button btnModifyEmployee;
    }
}