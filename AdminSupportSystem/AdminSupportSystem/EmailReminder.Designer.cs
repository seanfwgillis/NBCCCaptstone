namespace AdminSupportSystem
{
    partial class EmailReminder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailReminder));
            this.lblTitle = new System.Windows.Forms.Label();
            this.grbSupervisors = new System.Windows.Forms.GroupBox();
            this.lstSupervisors = new System.Windows.Forms.ListBox();
            this.grbEmployees = new System.Windows.Forms.GroupBox();
            this.lstEmployees = new System.Windows.Forms.ListBox();
            this.grbMain = new System.Windows.Forms.GroupBox();
            this.lblSupervisorTitle = new System.Windows.Forms.Label();
            this.grbSupervisorDetails = new System.Windows.Forms.GroupBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblEmailTitle = new System.Windows.Forms.Label();
            this.lblSupervisor = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.grbSupervisors.SuspendLayout();
            this.grbEmployees.SuspendLayout();
            this.grbMain.SuspendLayout();
            this.grbSupervisorDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(216, 88);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(420, 56);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Pending Reviews";
            // 
            // grbSupervisors
            // 
            this.grbSupervisors.Controls.Add(this.lstSupervisors);
            this.grbSupervisors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSupervisors.Location = new System.Drawing.Point(11, 36);
            this.grbSupervisors.Name = "grbSupervisors";
            this.grbSupervisors.Size = new System.Drawing.Size(322, 186);
            this.grbSupervisors.TabIndex = 2;
            this.grbSupervisors.TabStop = false;
            this.grbSupervisors.Text = "Supervisors Requiring Action";
            // 
            // lstSupervisors
            // 
            this.lstSupervisors.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSupervisors.FormattingEnabled = true;
            this.lstSupervisors.ItemHeight = 16;
            this.lstSupervisors.Location = new System.Drawing.Point(16, 27);
            this.lstSupervisors.Name = "lstSupervisors";
            this.lstSupervisors.Size = new System.Drawing.Size(288, 148);
            this.lstSupervisors.TabIndex = 0;
            this.lstSupervisors.Click += new System.EventHandler(this.lstSupervisors_Click);
            // 
            // grbEmployees
            // 
            this.grbEmployees.Controls.Add(this.lstEmployees);
            this.grbEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEmployees.Location = new System.Drawing.Point(352, 36);
            this.grbEmployees.Name = "grbEmployees";
            this.grbEmployees.Size = new System.Drawing.Size(322, 186);
            this.grbEmployees.TabIndex = 3;
            this.grbEmployees.TabStop = false;
            this.grbEmployees.Text = "Employees Needing Review";
            // 
            // lstEmployees
            // 
            this.lstEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEmployees.FormattingEnabled = true;
            this.lstEmployees.ItemHeight = 16;
            this.lstEmployees.Location = new System.Drawing.Point(16, 27);
            this.lstEmployees.Name = "lstEmployees";
            this.lstEmployees.Size = new System.Drawing.Size(288, 148);
            this.lstEmployees.TabIndex = 0;
            // 
            // grbMain
            // 
            this.grbMain.Controls.Add(this.grbSupervisors);
            this.grbMain.Controls.Add(this.grbEmployees);
            this.grbMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbMain.Location = new System.Drawing.Point(72, 300);
            this.grbMain.Name = "grbMain";
            this.grbMain.Size = new System.Drawing.Size(682, 255);
            this.grbMain.TabIndex = 4;
            this.grbMain.TabStop = false;
            this.grbMain.Text = "Review Administration";
            // 
            // lblSupervisorTitle
            // 
            this.lblSupervisorTitle.AutoSize = true;
            this.lblSupervisorTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupervisorTitle.Location = new System.Drawing.Point(7, 52);
            this.lblSupervisorTitle.Name = "lblSupervisorTitle";
            this.lblSupervisorTitle.Size = new System.Drawing.Size(105, 20);
            this.lblSupervisorTitle.TabIndex = 5;
            this.lblSupervisorTitle.Text = "Supervisor:";
            // 
            // grbSupervisorDetails
            // 
            this.grbSupervisorDetails.Controls.Add(this.lblEmail);
            this.grbSupervisorDetails.Controls.Add(this.lblEmailTitle);
            this.grbSupervisorDetails.Controls.Add(this.lblSupervisor);
            this.grbSupervisorDetails.Controls.Add(this.lblSupervisorTitle);
            this.grbSupervisorDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSupervisorDetails.Location = new System.Drawing.Point(72, 187);
            this.grbSupervisorDetails.Name = "grbSupervisorDetails";
            this.grbSupervisorDetails.Size = new System.Drawing.Size(682, 107);
            this.grbSupervisorDetails.TabIndex = 6;
            this.grbSupervisorDetails.TabStop = false;
            this.grbSupervisorDetails.Text = "Supervisor Details";
            // 
            // lblEmail
            // 
            this.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(389, 33);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(267, 58);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmailTitle
            // 
            this.lblEmailTitle.AutoSize = true;
            this.lblEmailTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailTitle.Location = new System.Drawing.Point(321, 52);
            this.lblEmailTitle.Name = "lblEmailTitle";
            this.lblEmailTitle.Size = new System.Drawing.Size(62, 20);
            this.lblEmailTitle.TabIndex = 7;
            this.lblEmailTitle.Text = "Email:";
            // 
            // lblSupervisor
            // 
            this.lblSupervisor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSupervisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupervisor.Location = new System.Drawing.Point(128, 33);
            this.lblSupervisor.Name = "lblSupervisor";
            this.lblSupervisor.Size = new System.Drawing.Size(187, 58);
            this.lblSupervisor.TabIndex = 6;
            this.lblSupervisor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(343, 561);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(150, 40);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Send Reminders";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // EmailReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(852, 923);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.grbSupervisorDetails);
            this.Controls.Add(this.grbMain);
            this.Controls.Add(this.lblTitle);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmailReminder";
            this.Text = "Email Reminder";
            this.Load += new System.EventHandler(this.EmailReminder_Load);
            this.grbSupervisors.ResumeLayout(false);
            this.grbEmployees.ResumeLayout(false);
            this.grbMain.ResumeLayout(false);
            this.grbSupervisorDetails.ResumeLayout(false);
            this.grbSupervisorDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grbSupervisors;
        private System.Windows.Forms.ListBox lstSupervisors;
        private System.Windows.Forms.GroupBox grbEmployees;
        private System.Windows.Forms.ListBox lstEmployees;
        private System.Windows.Forms.GroupBox grbMain;
        private System.Windows.Forms.Label lblSupervisorTitle;
        private System.Windows.Forms.GroupBox grbSupervisorDetails;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblEmailTitle;
        private System.Windows.Forms.Label lblSupervisor;
        private System.Windows.Forms.Button btnSend;
    }
}