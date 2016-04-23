namespace Xzam
{
    partial class frmAdminChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminChangePassword));
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUserCancelChangePass = new System.Windows.Forms.Button();
            this.btnUserChangePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(201, 111);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(132, 20);
            this.txtPassword.TabIndex = 13;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtNewPassword_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(201, 72);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(132, 20);
            this.txtUsername.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "PASSWORD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "USERNAME";
            // 
            // btnUserCancelChangePass
            // 
            this.btnUserCancelChangePass.BackColor = System.Drawing.Color.SeaShell;
            this.btnUserCancelChangePass.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnUserCancelChangePass.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserCancelChangePass.ForeColor = System.Drawing.Color.Black;
            this.btnUserCancelChangePass.Location = new System.Drawing.Point(61, 180);
            this.btnUserCancelChangePass.Name = "btnUserCancelChangePass";
            this.btnUserCancelChangePass.Size = new System.Drawing.Size(75, 28);
            this.btnUserCancelChangePass.TabIndex = 15;
            this.btnUserCancelChangePass.Text = "Cancel";
            this.btnUserCancelChangePass.UseVisualStyleBackColor = false;
            // 
            // btnUserChangePassword
            // 
            this.btnUserChangePassword.BackColor = System.Drawing.Color.OrangeRed;
            this.btnUserChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserChangePassword.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnUserChangePassword.Location = new System.Drawing.Point(201, 175);
            this.btnUserChangePassword.Name = "btnUserChangePassword";
            this.btnUserChangePassword.Size = new System.Drawing.Size(147, 33);
            this.btnUserChangePassword.TabIndex = 14;
            this.btnUserChangePassword.Text = "Change Password";
            this.btnUserChangePassword.UseVisualStyleBackColor = false;
            this.btnUserChangePassword.Click += new System.EventHandler(this.btnUserChangePassword_Click);
            // 
            // frmAdminChangePassword
            // 
            this.AcceptButton = this.btnUserChangePassword;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnUserCancelChangePass;
            this.ClientSize = new System.Drawing.Size(401, 242);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUserCancelChangePass);
            this.Controls.Add(this.btnUserChangePassword);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdminChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUserCancelChangePass;
        private System.Windows.Forms.Button btnUserChangePassword;
    }
}

