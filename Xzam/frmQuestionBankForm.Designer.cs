namespace Xzam
{
    partial class frmQuestionBankSetup
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
            this.lvwQuestionBank = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstQuestions = new System.Windows.Forms.ListBox();
            this.chkShuffleQuestions = new System.Windows.Forms.CheckBox();
            this.chkBackTracking = new System.Windows.Forms.CheckBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwQuestionBank
            // 
            this.lvwQuestionBank.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvwQuestionBank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwQuestionBank.Location = new System.Drawing.Point(8, 21);
            this.lvwQuestionBank.Name = "lvwQuestionBank";
            this.lvwQuestionBank.Size = new System.Drawing.Size(637, 103);
            this.lvwQuestionBank.TabIndex = 0;
            this.lvwQuestionBank.UseCompatibleStateImageBehavior = false;
            this.lvwQuestionBank.View = System.Windows.Forms.View.Details;
            this.lvwQuestionBank.SelectedIndexChanged += new System.EventHandler(this.lvwQuestionBank_SelectedIndexChanged);
            this.lvwQuestionBank.DoubleClick += new System.EventHandler(this.lvwQuestionBank_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 85;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 164;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Backtrack Allowed";
            this.columnHeader3.Width = 118;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Shuffle Questions";
            this.columnHeader4.Width = 126;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvwQuestionBank);
            this.groupBox1.Location = new System.Drawing.Point(12, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox1.Size = new System.Drawing.Size(653, 132);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Questions";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnAddQuestion);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lstQuestions);
            this.groupBox2.Controls.Add(this.chkShuffleQuestions);
            this.groupBox2.Controls.Add(this.chkBackTracking);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Location = new System.Drawing.Point(12, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(653, 347);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(609, 126);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(36, 23);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "-";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Location = new System.Drawing.Point(567, 126);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(36, 23);
            this.btnAddQuestion.TabIndex = 4;
            this.btnAddQuestion.Text = "+";
            this.btnAddQuestion.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Questions:";
            // 
            // lstQuestions
            // 
            this.lstQuestions.FormattingEnabled = true;
            this.lstQuestions.Location = new System.Drawing.Point(95, 155);
            this.lstQuestions.Name = "lstQuestions";
            this.lstQuestions.Size = new System.Drawing.Size(550, 134);
            this.lstQuestions.TabIndex = 0;
            // 
            // chkShuffleQuestions
            // 
            this.chkShuffleQuestions.AutoSize = true;
            this.chkShuffleQuestions.Location = new System.Drawing.Point(95, 104);
            this.chkShuffleQuestions.Name = "chkShuffleQuestions";
            this.chkShuffleQuestions.Size = new System.Drawing.Size(109, 17);
            this.chkShuffleQuestions.TabIndex = 3;
            this.chkShuffleQuestions.Text = "Shuffle Questions";
            this.chkShuffleQuestions.UseVisualStyleBackColor = true;
            // 
            // chkBackTracking
            // 
            this.chkBackTracking.AutoSize = true;
            this.chkBackTracking.Location = new System.Drawing.Point(95, 71);
            this.chkBackTracking.Name = "chkBackTracking";
            this.chkBackTracking.Size = new System.Drawing.Size(129, 17);
            this.chkBackTracking.TabIndex = 2;
            this.chkBackTracking.Text = "Backtracking Allowed";
            this.chkBackTracking.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(95, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(176, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(33, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(567, 307);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(582, 164);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "Create New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // frmQuestionBankSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 576);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmQuestionBankSetup";
            this.Text = "QuestionBankForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwQuestionBank;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkShuffleQuestions;
        private System.Windows.Forms.CheckBox chkBackTracking;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ListBox lstQuestions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnNew;
    }
}