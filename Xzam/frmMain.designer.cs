namespace Xzam
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonUserManagement = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonExamManagement = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonQuestionBank = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTimeSchedule = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonChangePassword = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLogout = new System.Windows.Forms.ToolStripButton();
            this.lblCurrentUser = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerExamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questionBankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examArea = new System.Windows.Forms.GroupBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblExamTitle = new System.Windows.Forms.Label();
            this.lblScheduleDate = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.examArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.CanOverflow = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonUserManagement,
            this.toolStripButtonExamManagement,
            this.toolStripButtonQuestionBank,
            this.toolStripButtonTimeSchedule,
            this.toolStripButtonChangePassword,
            this.toolStripButtonLogout,
            this.lblCurrentUser,
            this.toolStripButton1});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1294, 84);
            this.toolStrip1.TabIndex = 4;
            // 
            // toolStripButtonUserManagement
            // 
            this.toolStripButtonUserManagement.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButtonUserManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButtonUserManagement.CheckOnClick = true;
            this.toolStripButtonUserManagement.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUserManagement.Image")));
            this.toolStripButtonUserManagement.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonUserManagement.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUserManagement.Name = "toolStripButtonUserManagement";
            this.toolStripButtonUserManagement.Size = new System.Drawing.Size(172, 81);
            this.toolStripButtonUserManagement.Text = "User Management";
            this.toolStripButtonUserManagement.Click += new System.EventHandler(this.toolStripButtonUserManagement_Click);
            // 
            // toolStripButtonExamManagement
            // 
            this.toolStripButtonExamManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButtonExamManagement.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonExamManagement.Image")));
            this.toolStripButtonExamManagement.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonExamManagement.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExamManagement.Name = "toolStripButtonExamManagement";
            this.toolStripButtonExamManagement.Size = new System.Drawing.Size(193, 81);
            this.toolStripButtonExamManagement.Text = "Exam Management";
            this.toolStripButtonExamManagement.Click += new System.EventHandler(this.toolStripButtonExamManagement_Click);
            // 
            // toolStripButtonQuestionBank
            // 
            this.toolStripButtonQuestionBank.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonQuestionBank.Image")));
            this.toolStripButtonQuestionBank.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonQuestionBank.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonQuestionBank.Name = "toolStripButtonQuestionBank";
            this.toolStripButtonQuestionBank.Size = new System.Drawing.Size(142, 81);
            this.toolStripButtonQuestionBank.Text = "Question Bank";
            this.toolStripButtonQuestionBank.Click += new System.EventHandler(this.toolStripButtonQuestionBank_Click);
            // 
            // toolStripButtonTimeSchedule
            // 
            this.toolStripButtonTimeSchedule.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonTimeSchedule.Image")));
            this.toolStripButtonTimeSchedule.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonTimeSchedule.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTimeSchedule.Name = "toolStripButtonTimeSchedule";
            this.toolStripButtonTimeSchedule.Size = new System.Drawing.Size(153, 81);
            this.toolStripButtonTimeSchedule.Text = "Time Schedule";
            this.toolStripButtonTimeSchedule.Click += new System.EventHandler(this.toolStripButtonTimeSchedule_Click);
            // 
            // toolStripButtonChangePassword
            // 
            this.toolStripButtonChangePassword.CheckOnClick = true;
            this.toolStripButtonChangePassword.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonChangePassword.Image")));
            this.toolStripButtonChangePassword.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonChangePassword.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonChangePassword.Name = "toolStripButtonChangePassword";
            this.toolStripButtonChangePassword.Size = new System.Drawing.Size(185, 81);
            this.toolStripButtonChangePassword.Text = "Change Password";
            this.toolStripButtonChangePassword.Click += new System.EventHandler(this.toolStripButtonChangePassword_Click);
            // 
            // toolStripButtonLogout
            // 
            this.toolStripButtonLogout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLogout.Image")));
            this.toolStripButtonLogout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonLogout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLogout.Name = "toolStripButtonLogout";
            this.toolStripButtonLogout.Size = new System.Drawing.Size(130, 81);
            this.toolStripButtonLogout.Text = "Log out";
            this.toolStripButtonLogout.Click += new System.EventHandler(this.toolStripButtonLogout_Click);
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Padding = new System.Windows.Forms.Padding(15);
            this.lblCurrentUser.Size = new System.Drawing.Size(116, 81);
            this.lblCurrentUser.Text = "toolStripLabel1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(87, 81);
            this.toolStripButton1.Text = "Logged In as : ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.exitApplicationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1294, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userManagementToolStripMenuItem,
            this.managerExamToolStripMenuItem,
            this.questionBankToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.viewScheduleToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.userManagementToolStripMenuItem.Text = "User Management";
            this.userManagementToolStripMenuItem.Click += new System.EventHandler(this.userManagementToolStripMenuItem_Click);
            // 
            // managerExamToolStripMenuItem
            // 
            this.managerExamToolStripMenuItem.Name = "managerExamToolStripMenuItem";
            this.managerExamToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.managerExamToolStripMenuItem.Text = "Manager Exam";
            this.managerExamToolStripMenuItem.Click += new System.EventHandler(this.managerExamToolStripMenuItem_Click);
            // 
            // questionBankToolStripMenuItem
            // 
            this.questionBankToolStripMenuItem.Name = "questionBankToolStripMenuItem";
            this.questionBankToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.questionBankToolStripMenuItem.Text = "Question Bank";
            this.questionBankToolStripMenuItem.Click += new System.EventHandler(this.questionBankToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // viewScheduleToolStripMenuItem
            // 
            this.viewScheduleToolStripMenuItem.Name = "viewScheduleToolStripMenuItem";
            this.viewScheduleToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.viewScheduleToolStripMenuItem.Text = "View Schedule";
            this.viewScheduleToolStripMenuItem.Click += new System.EventHandler(this.viewScheduleToolStripMenuItem_Click);
            // 
            // exitApplicationToolStripMenuItem
            // 
            this.exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            this.exitApplicationToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.exitApplicationToolStripMenuItem.Text = "Exit Application";
            // 
            // examArea
            // 
            this.examArea.Controls.Add(this.lblEndTime);
            this.examArea.Controls.Add(this.lblStartTime);
            this.examArea.Controls.Add(this.lblScheduleDate);
            this.examArea.Controls.Add(this.lblExamTitle);
            this.examArea.Controls.Add(this.label2);
            this.examArea.Controls.Add(this.label1);
            this.examArea.Controls.Add(this.lbl);
            this.examArea.Controls.Add(this.btnStart);
            this.examArea.Controls.Add(this.lbl1);
            this.examArea.Location = new System.Drawing.Point(0, 111);
            this.examArea.Name = "examArea";
            this.examArea.Size = new System.Drawing.Size(323, 181);
            this.examArea.TabIndex = 6;
            this.examArea.TabStop = false;
            this.examArea.Text = "Exam Available";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(7, 33);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(59, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Exam Title:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(219, 121);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(7, 62);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(81, 13);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "Schedule Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Start Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "EndTime:";
            // 
            // lblExamTitle
            // 
            this.lblExamTitle.AutoSize = true;
            this.lblExamTitle.Location = new System.Drawing.Point(109, 32);
            this.lblExamTitle.Name = "lblExamTitle";
            this.lblExamTitle.Size = new System.Drawing.Size(35, 13);
            this.lblExamTitle.TabIndex = 5;
            this.lblExamTitle.Text = "label3";
            // 
            // lblScheduleDate
            // 
            this.lblScheduleDate.AutoSize = true;
            this.lblScheduleDate.Location = new System.Drawing.Point(112, 61);
            this.lblScheduleDate.Name = "lblScheduleDate";
            this.lblScheduleDate.Size = new System.Drawing.Size(35, 13);
            this.lblScheduleDate.TabIndex = 6;
            this.lblScheduleDate.Text = "label4";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(112, 92);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(35, 13);
            this.lblStartTime.TabIndex = 7;
            this.lblStartTime.Text = "label5";
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(112, 120);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(35, 13);
            this.lblEndTime.TabIndex = 8;
            this.lblEndTime.Text = "label6";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1294, 454);
            this.Controls.Add(this.examArea);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Xzam Application";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.examArea.ResumeLayout(false);
            this.examArea.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonUserManagement;
        private System.Windows.Forms.ToolStripButton toolStripButtonExamManagement;
        private System.Windows.Forms.ToolStripButton toolStripButtonQuestionBank;
        private System.Windows.Forms.ToolStripButton toolStripButtonTimeSchedule;
        private System.Windows.Forms.ToolStripButton toolStripButtonChangePassword;
        private System.Windows.Forms.ToolStripButton toolStripButtonLogout;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managerExamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem questionBankToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel lblCurrentUser;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.GroupBox examArea;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblScheduleDate;
        private System.Windows.Forms.Label lblExamTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lbl1;
    }
}

