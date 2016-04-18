namespace Xzam
{
    partial class ExamSetup
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
            this.text_ExamCode = new System.Windows.Forms.TextBox();
            this.text_ExamTitle = new System.Windows.Forms.TextBox();
            this.but_Setup = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exam Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Exam Title:";
            // 
            // text_ExamCode
            // 
            this.text_ExamCode.Location = new System.Drawing.Point(95, 25);
            this.text_ExamCode.Name = "text_ExamCode";
            this.text_ExamCode.Size = new System.Drawing.Size(100, 20);
            this.text_ExamCode.TabIndex = 2;
            // 
            // text_ExamTitle
            // 
            this.text_ExamTitle.Location = new System.Drawing.Point(95, 66);
            this.text_ExamTitle.Name = "text_ExamTitle";
            this.text_ExamTitle.Size = new System.Drawing.Size(100, 20);
            this.text_ExamTitle.TabIndex = 3;
            // 
            // but_Setup
            // 
            this.but_Setup.Location = new System.Drawing.Point(27, 168);
            this.but_Setup.Name = "but_Setup";
            this.but_Setup.Size = new System.Drawing.Size(75, 23);
            this.but_Setup.TabIndex = 4;
            this.but_Setup.Text = "Setup";
            this.but_Setup.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(146, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ExamSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.but_Setup);
            this.Controls.Add(this.text_ExamTitle);
            this.Controls.Add(this.text_ExamCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ExamSetup";
            this.Text = "Exam Setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_ExamCode;
        private System.Windows.Forms.TextBox text_ExamTitle;
        private System.Windows.Forms.Button but_Setup;
        private System.Windows.Forms.Button button2;
    }
}