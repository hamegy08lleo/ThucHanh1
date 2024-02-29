using System.Windows.Forms;

namespace ThucHanh1
{
    partial class UCInfomartion
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gvData = new System.Windows.Forms.DataGridView();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtGovernmentID = new System.Windows.Forms.TextBox();
            this.lblGovernmentID = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.dtBirthdate = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblIDValue = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            this.SuspendLayout();
            // 
            // gvData
            // 
            this.gvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvData.Location = new System.Drawing.Point(525, 62);
            this.gvData.MultiSelect = false;
            this.gvData.Name = "gvData";
            this.gvData.RowHeadersWidth = 62;
            this.gvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvData.Size = new System.Drawing.Size(1200, 511);
            this.gvData.TabIndex = 6;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(218, 123);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(200, 26);
            this.txtFullName.TabIndex = 5;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(60, 123);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(78, 20);
            this.lblFullName.TabIndex = 4;
            this.lblFullName.Text = "Full name";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(218, 196);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 26);
            this.txtAddress.TabIndex = 8;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(60, 196);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(68, 20);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "Address";
            // 
            // txtGovernmentID
            // 
            this.txtGovernmentID.Location = new System.Drawing.Point(218, 262);
            this.txtGovernmentID.Name = "txtGovernmentID";
            this.txtGovernmentID.Size = new System.Drawing.Size(200, 26);
            this.txtGovernmentID.TabIndex = 10;
            // 
            // lblGovernmentID
            // 
            this.lblGovernmentID.AutoSize = true;
            this.lblGovernmentID.Location = new System.Drawing.Point(60, 262);
            this.lblGovernmentID.Name = "lblGovernmentID";
            this.lblGovernmentID.Size = new System.Drawing.Size(118, 20);
            this.lblGovernmentID.TabIndex = 9;
            this.lblGovernmentID.Text = "Government ID";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(218, 328);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(200, 26);
            this.txtPhoneNumber.TabIndex = 12;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(60, 328);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(113, 20);
            this.lblPhoneNumber.TabIndex = 11;
            this.lblPhoneNumber.Text = "Phone number";
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Location = new System.Drawing.Point(60, 472);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(74, 20);
            this.lblBirthdate.TabIndex = 13;
            this.lblBirthdate.Text = "Birthdate";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(60, 548);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(36, 20);
            this.lblSex.TabIndex = 15;
            this.lblSex.Text = "Sex";
            // 
            // cbSex
            // 
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cbSex.Location = new System.Drawing.Point(218, 545);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(200, 28);
            this.cbSex.TabIndex = 16;
            // 
            // dtBirthdate
            // 
            this.dtBirthdate.Location = new System.Drawing.Point(218, 472);
            this.dtBirthdate.Name = "dtBirthdate";
            this.dtBirthdate.Size = new System.Drawing.Size(200, 26);
            this.dtBirthdate.TabIndex = 17;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(218, 393);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 26);
            this.txtEmail.TabIndex = 19;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(60, 399);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(53, 635);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 60);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(60, 62);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(26, 20);
            this.lblID.TabIndex = 21;
            this.lblID.Text = "ID";
            // 
            // lblIDValue
            // 
            this.lblIDValue.AutoSize = true;
            this.lblIDValue.Location = new System.Drawing.Point(214, 62);
            this.lblIDValue.Name = "lblIDValue";
            this.lblIDValue.Size = new System.Drawing.Size(0, 20);
            this.lblIDValue.TabIndex = 22;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(218, 635);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 60);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(390, 635);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(103, 60);
            this.btnEdit.TabIndex = 24;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // UCInfomartion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblIDValue);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.dtBirthdate);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblBirthdate);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtGovernmentID);
            this.Controls.Add(this.lblGovernmentID);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.gvData);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblFullName);
            this.Name = "UCInfomartion";
            this.Size = new System.Drawing.Size(1817, 744);
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gvData;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtGovernmentID;
        private System.Windows.Forms.Label lblGovernmentID;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.DateTimePicker dtBirthdate;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblIDValue;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;

        public DataGridView GvData { get => gvData; set => gvData = value; }
        public TextBox TxtFullName { get => txtFullName; set => txtFullName = value; }
        public Label LblFullName { get => lblFullName; set => lblFullName = value; }
        public TextBox TxtAddress { get => txtAddress; set => txtAddress = value; }
        public Label LblAddress { get => lblAddress; set => lblAddress = value; }
        public TextBox TxtGovernmentID { get => txtGovernmentID; set => txtGovernmentID = value; }
        public Label LblGovernmentID { get => lblGovernmentID; set => lblGovernmentID = value; }
        public TextBox TxtPhoneNumber { get => txtPhoneNumber; set => txtPhoneNumber = value; }
        public Label LblPhoneNumber { get => lblPhoneNumber; set => lblPhoneNumber = value; }
        public Label LblBirthdate { get => lblBirthdate; set => lblBirthdate = value; }
        public Label LblSex { get => lblSex; set => lblSex = value; }
        public ComboBox CbSex { get => cbSex; set => cbSex = value; }
        public DateTimePicker DtBirthdate { get => dtBirthdate; set => dtBirthdate = value; }
        public TextBox TxtEmail { get => txtEmail; set => txtEmail = value; }
        public Label LblEmail { get => lblEmail; set => lblEmail = value; }
        public Button BtnAdd { get => btnAdd; set => btnAdd = value; }
        public Label LblID { get => lblID; set => lblID = value; }
        public Label LblIDValue { get => lblIDValue; set => lblIDValue = value; }
        public Button BtnDelete { get => btnDelete; set => btnDelete = value; }
        public Button BtnEdit { get => btnEdit; set => btnEdit = value; }
    }
}
