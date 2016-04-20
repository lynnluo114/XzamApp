namespace Xzam
{
    partial class frmAddNewStudent
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelAddNewStudent = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddPassword = new System.Windows.Forms.TextBox();
            this.txtAddUsername = new System.Windows.Forms.TextBox();
            this.txtAddId = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Name";
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(191, 214);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(100, 20);
            this.txtAddName.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Location = new System.Drawing.Point(-2, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 41);
            this.panel1.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(68, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 37);
            this.label4.TabIndex = 12;
            this.label4.Text = "Add New Student";
            // 
            // btnCancelAddNewStudent
            // 
            this.btnCancelAddNewStudent.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelAddNewStudent.Location = new System.Drawing.Point(74, 272);
            this.btnCancelAddNewStudent.Name = "btnCancelAddNewStudent";
            this.btnCancelAddNewStudent.Size = new System.Drawing.Size(75, 23);
            this.btnCancelAddNewStudent.TabIndex = 23;
            this.btnCancelAddNewStudent.Text = "Cancel";
            this.btnCancelAddNewStudent.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Student Id";
            // 
            // txtAddPassword
            // 
            this.txtAddPassword.Location = new System.Drawing.Point(191, 174);
            this.txtAddPassword.Name = "txtAddPassword";
            this.txtAddPassword.Size = new System.Drawing.Size(100, 20);
            this.txtAddPassword.TabIndex = 17;
            // 
            // txtAddUsername
            // 
            this.txtAddUsername.Location = new System.Drawing.Point(191, 133);
            this.txtAddUsername.Name = "txtAddUsername";
            this.txtAddUsername.Size = new System.Drawing.Size(100, 20);
            this.txtAddUsername.TabIndex = 16;
            // 
            // txtAddId
            // 
            this.txtAddId.Location = new System.Drawing.Point(191, 88);
            this.txtAddId.Name = "txtAddId";
            this.txtAddId.Size = new System.Drawing.Size(100, 20);
            this.txtAddId.TabIndex = 15;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(247, 272);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Submit";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // frmAddNewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(398, 401);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAddName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancelAddNewStudent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddPassword);
            this.Controls.Add(this.txtAddUsername);
            this.Controls.Add(this.txtAddId);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmAddNewStudent";
            this.Text = "Add New Student";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelAddNewStudent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddPassword;
        private System.Windows.Forms.TextBox txtAddUsername;
        private System.Windows.Forms.TextBox txtAddId;
        private System.Windows.Forms.Button btnAdd;
    }
}

