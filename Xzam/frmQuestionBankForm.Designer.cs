﻿namespace Xzam
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
            this.groupDetails = new System.Windows.Forms.GroupBox();
            this.lvwQuestions = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chkShuffleQuestions = new System.Windows.Forms.CheckBox();
            this.chkBackTracking = new System.Windows.Forms.CheckBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupDetails.SuspendLayout();
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
            this.lvwQuestionBank.FullRowSelect = true;
            this.lvwQuestionBank.Location = new System.Drawing.Point(8, 21);
            this.lvwQuestionBank.Name = "lvwQuestionBank";
            this.lvwQuestionBank.Size = new System.Drawing.Size(522, 103);
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
            this.groupBox1.Size = new System.Drawing.Size(538, 132);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Questions";
            // 
            // groupDetails
            // 
            this.groupDetails.Controls.Add(this.lvwQuestions);
            this.groupDetails.Controls.Add(this.btnRemove);
            this.groupDetails.Controls.Add(this.btnAddQuestion);
            this.groupDetails.Controls.Add(this.label1);
            this.groupDetails.Controls.Add(this.chkShuffleQuestions);
            this.groupDetails.Controls.Add(this.chkBackTracking);
            this.groupDetails.Controls.Add(this.txtName);
            this.groupDetails.Controls.Add(this.lblName);
            this.groupDetails.Location = new System.Drawing.Point(12, 156);
            this.groupDetails.Name = "groupDetails";
            this.groupDetails.Size = new System.Drawing.Size(633, 316);
            this.groupDetails.TabIndex = 2;
            this.groupDetails.TabStop = false;
            this.groupDetails.Text = "Details";
            // 
            // lvwQuestions
            // 
            this.lvwQuestions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.lvwQuestions.FullRowSelect = true;
            this.lvwQuestions.Location = new System.Drawing.Point(59, 155);
            this.lvwQuestions.Name = "lvwQuestions";
            this.lvwQuestions.Size = new System.Drawing.Size(560, 140);
            this.lvwQuestions.TabIndex = 8;
            this.lvwQuestions.UseCompatibleStateImageBehavior = false;
            this.lvwQuestions.View = System.Windows.Forms.View.Details;
            this.lvwQuestions.SelectedIndexChanged += new System.EventHandler(this.lvwQuestions_SelectedIndexChanged);
            this.lvwQuestions.DoubleClick += new System.EventHandler(this.lvwQuestions_DoubleClick);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Correct Option";
            this.columnHeader5.Width = 85;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Question ";
            this.columnHeader6.Width = 164;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(577, 126);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(36, 23);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "-";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Location = new System.Drawing.Point(535, 126);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(36, 23);
            this.btnAddQuestion.TabIndex = 6;
            this.btnAddQuestion.Text = "+";
            this.btnAddQuestion.UseVisualStyleBackColor = true;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Questions:";
            // 
            // chkShuffleQuestions
            // 
            this.chkShuffleQuestions.AutoSize = true;
            this.chkShuffleQuestions.Location = new System.Drawing.Point(59, 106);
            this.chkShuffleQuestions.Name = "chkShuffleQuestions";
            this.chkShuffleQuestions.Size = new System.Drawing.Size(109, 17);
            this.chkShuffleQuestions.TabIndex = 5;
            this.chkShuffleQuestions.Text = "Shuffle Questions";
            this.chkShuffleQuestions.UseVisualStyleBackColor = true;
            // 
            // chkBackTracking
            // 
            this.chkBackTracking.AutoSize = true;
            this.chkBackTracking.Location = new System.Drawing.Point(59, 83);
            this.chkBackTracking.Name = "chkBackTracking";
            this.chkBackTracking.Size = new System.Drawing.Size(129, 17);
            this.chkBackTracking.TabIndex = 4;
            this.chkBackTracking.Text = "Backtracking Allowed";
            this.chkBackTracking.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(59, 57);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(176, 20);
            this.txtName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(56, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(111, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Question Bank Name:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(556, 56);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(556, 27);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Create New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(556, 85);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(556, 114);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmQuestionBankSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 489);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupDetails);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmQuestionBankSetup";
            this.Text = "QuestionBankForm";
            this.Load += new System.EventHandler(this.frmQuestionBankSetup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupDetails.ResumeLayout(false);
            this.groupDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwQuestionBank;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox groupDetails;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkShuffleQuestions;
        private System.Windows.Forms.CheckBox chkBackTracking;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ListView lvwQuestions;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
    }
}