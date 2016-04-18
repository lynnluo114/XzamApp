using System;

namespace Xzam
{
    partial class frmSchedulerCreation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.examCodeList = new System.Windows.Forms.ComboBox();
            this.examTitleList = new System.Windows.Forms.ComboBox();
            this.list_Students = new System.Windows.Forms.ListBox();
            this.qbankList = new System.Windows.Forms.ComboBox();
            this.scheduledDate = new System.Windows.Forms.DateTimePicker();
            this.startTime = new System.Windows.Forms.DateTimePicker();
            this.endTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exam Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Exam Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Student(s):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Question Bank:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Scheduled Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Start Time:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "End Time:";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(22, 361);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.but_Create_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(165, 361);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // examCodeList
            // 
            this.examCodeList.FormattingEnabled = true;
            this.examCodeList.Location = new System.Drawing.Point(120, 13);
            this.examCodeList.Name = "examCodeList";
            this.examCodeList.Size = new System.Drawing.Size(121, 21);
            this.examCodeList.TabIndex = 9;
            this.examCodeList.SelectedIndexChanged += new System.EventHandler(this.examCodeList_SelectedIndexChanged);
            // 
            // examTitleList
            // 
            this.examTitleList.FormattingEnabled = true;
            this.examTitleList.Location = new System.Drawing.Point(120, 46);
            this.examTitleList.Name = "examTitleList";
            this.examTitleList.Size = new System.Drawing.Size(121, 21);
            this.examTitleList.TabIndex = 10;
            this.examTitleList.SelectedIndexChanged += new System.EventHandler(this.examTitleList_SelectedIndexChanged);
            // 
            // list_Students
            // 
            this.list_Students.FormattingEnabled = true;
            this.list_Students.Location = new System.Drawing.Point(120, 91);
            this.list_Students.Name = "list_Students";
            this.list_Students.Size = new System.Drawing.Size(200, 95);
            this.list_Students.TabIndex = 11;
            // 
            // qbankList
            // 
            this.qbankList.FormattingEnabled = true;
            this.qbankList.Location = new System.Drawing.Point(120, 213);
            this.qbankList.Name = "qbankList";
            this.qbankList.Size = new System.Drawing.Size(200, 21);
            this.qbankList.TabIndex = 12;
            // 
            // scheduledDate
            // 
            this.scheduledDate.Location = new System.Drawing.Point(120, 267);
            this.scheduledDate.Name = "scheduledDate";
            this.scheduledDate.Size = new System.Drawing.Size(200, 20);
            this.scheduledDate.TabIndex = 13;
            // 
            // startTime
            // 
            this.startTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startTime.Location = new System.Drawing.Point(120, 292);
            this.startTime.Name = "startTime";
            this.startTime.ShowUpDown = true;
            this.startTime.Size = new System.Drawing.Size(200, 20);
            this.startTime.TabIndex = 14;
            // 
            // endTime
            // 
            this.endTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.endTime.Location = new System.Drawing.Point(120, 319);
            this.endTime.Name = "endTime";
            this.endTime.ShowUpDown = true;
            this.endTime.Size = new System.Drawing.Size(200, 20);
            this.endTime.TabIndex = 15;
            // 
            // frmSchedulerCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 414);
            this.Controls.Add(this.endTime);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.scheduledDate);
            this.Controls.Add(this.qbankList);
            this.Controls.Add(this.list_Students);
            this.Controls.Add(this.examTitleList);
            this.Controls.Add(this.examCodeList);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSchedulerCreation";
            this.Text = "Exam Scheduler Creation";
            this.Load += new System.EventHandler(this.frmSchedulerCreation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox examCodeList;
        private System.Windows.Forms.ComboBox examTitleList;
        private System.Windows.Forms.ListBox list_Students;
        private System.Windows.Forms.ComboBox qbankList;
        private System.Windows.Forms.DateTimePicker scheduledDate;
        private System.Windows.Forms.DateTimePicker startTime;
        private System.Windows.Forms.DateTimePicker endTime;
    }
}

