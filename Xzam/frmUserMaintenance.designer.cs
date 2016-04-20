namespace Xzam
{
    partial class frmUserMaintenance
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uSERDataSet = new Xzam.USERDataSet();
            this.uSER_TABLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSER_TABLETableAdapter = new Xzam.USERDataSetTableAdapters.USER_TABLETableAdapter();
            this.tableAdapterManager = new Xzam.USERDataSetTableAdapters.TableAdapterManager();
            this.btnAddNewStudent = new System.Windows.Forms.Button();
            this.userDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.uSERDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSER_TABLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // uSERDataSet
            // 
            this.uSERDataSet.DataSetName = "USERDataSet";
            this.uSERDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSER_TABLEBindingSource
            // 
            this.uSER_TABLEBindingSource.DataMember = "USER_TABLE";
            this.uSER_TABLEBindingSource.DataSource = this.uSERDataSet;
            // 
            // uSER_TABLETableAdapter
            // 
            this.uSER_TABLETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Xzam.USERDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USER_TABLETableAdapter = this.uSER_TABLETableAdapter;
            // 
            // btnAddNewStudent
            // 
            this.btnAddNewStudent.Location = new System.Drawing.Point(65, 339);
            this.btnAddNewStudent.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewStudent.Name = "btnAddNewStudent";
            this.btnAddNewStudent.Size = new System.Drawing.Size(230, 32);
            this.btnAddNewStudent.TabIndex = 3;
            this.btnAddNewStudent.Text = "Add New Student";
            this.btnAddNewStudent.UseVisualStyleBackColor = true;
            this.btnAddNewStudent.Click += new System.EventHandler(this.btnAddNewStudent_Click);
            // 
            // userDataSetBindingSource
            // 
            this.userDataSetBindingSource.DataMember = "USER_TABLE";
            // 
            // userDataGridView
            // 
            this.userDataGridView.AllowUserToDeleteRows = false;
            this.userDataGridView.AutoGenerateColumns = false;
            this.userDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.fullnameDataGridViewTextBoxColumn,
            this.Edit,
            this.Remove});
            this.userDataGridView.DataSource = this.uSER_TABLEBindingSource;
            this.userDataGridView.Location = new System.Drawing.Point(23, 13);
            this.userDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.ReadOnly = true;
            this.userDataGridView.Size = new System.Drawing.Size(659, 305);
            this.userDataGridView.TabIndex = 4;
            this.userDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickEdit);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "Fullname";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "Fullname";
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            this.fullnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Edit
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "Edit";
            this.Edit.DefaultCellStyle = dataGridViewCellStyle3;
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 40;
            // 
            // Remove
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = "Remove";
            this.Remove.DefaultCellStyle = dataGridViewCellStyle4;
            this.Remove.HeaderText = "";
            this.Remove.Name = "Remove";
            this.Remove.ReadOnly = true;
            this.Remove.Text = "Remove";
            this.Remove.UseColumnTextForButtonValue = true;
            // 
            // frmUserMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(714, 404);
            this.Controls.Add(this.btnAddNewStudent);
            this.Controls.Add(this.userDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmUserMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Maintenance";
            this.Load += new System.EventHandler(this.frmUserMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uSERDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSER_TABLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private USERDataSet uSERDataSet;
        private System.Windows.Forms.BindingSource uSER_TABLEBindingSource;
        private USERDataSetTableAdapters.USER_TABLETableAdapter uSER_TABLETableAdapter;
        private USERDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnAddNewStudent;
        private System.Windows.Forms.BindingSource userDataSetBindingSource;
        private System.Windows.Forms.DataGridView userDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Remove;
    }
}

