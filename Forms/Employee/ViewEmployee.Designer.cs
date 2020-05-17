namespace HospitalMangement.Forms.Employee
{
    partial class ViewEmployee
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
            this.comboBoxOption = new System.Windows.Forms.ComboBox();
            this.textBoxSharch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combogender = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonView = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbEmployeeBloodGroup = new System.Windows.Forms.ComboBox();
            this.lblDoctorBloodGroup = new System.Windows.Forms.Label();
            this.txtEmployeePhoneNumber = new System.Windows.Forms.TextBox();
            this.lblDoctorPhoneNumber = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblDoctorBirthday = new System.Windows.Forms.Label();
            this.lblDoctorGender = new System.Windows.Forms.Label();
            this.lblDoctorEmailAddress = new System.Windows.Forms.Label();
            this.txtEmployeeAddress = new System.Windows.Forms.TextBox();
            this.txtEmployeeEmail = new System.Windows.Forms.TextBox();
            this.lblDoctorAddress = new System.Windows.Forms.Label();
            this.lblDoctorMotherName = new System.Windows.Forms.Label();
            this.txtEmployeeFatherName = new System.Windows.Forms.TextBox();
            this.txtEmployeeMotherName = new System.Windows.Forms.TextBox();
            this.lblDoctorFatherName = new System.Windows.Forms.Label();
            this.lblDoctorFirstName = new System.Windows.Forms.Label();
            this.txtEmployeeFirstName = new System.Windows.Forms.TextBox();
            this.txtEmployeeLastName = new System.Windows.Forms.TextBox();
            this.lblDoctorLastName = new System.Windows.Forms.Label();
            this.txtEmployeeProfessionName = new System.Windows.Forms.TextBox();
            this.lblEmployeeProfessionName = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxOption
            // 
            this.comboBoxOption.FormattingEnabled = true;
            this.comboBoxOption.Items.AddRange(new object[] {
            " employeeId",
            " employeeFirstName",
            " employeeLastName",
            " employeeFatherName",
            "employeeMotherName",
            "employeeAddress",
            " employeeEmail",
            "employeeBG",
            "employeeGender",
            "employeeBirthday",
            "employeePhoneNumber",
            "  "});
            this.comboBoxOption.Location = new System.Drawing.Point(441, 66);
            this.comboBoxOption.Name = "comboBoxOption";
            this.comboBoxOption.Size = new System.Drawing.Size(142, 21);
            this.comboBoxOption.TabIndex = 119;
            // 
            // textBoxSharch
            // 
            this.textBoxSharch.Location = new System.Drawing.Point(667, 69);
            this.textBoxSharch.Name = "textBoxSharch";
            this.textBoxSharch.Size = new System.Drawing.Size(167, 20);
            this.textBoxSharch.TabIndex = 118;
            this.textBoxSharch.TextChanged += new System.EventHandler(this.textBoxSharch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(548, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 31);
            this.label2.TabIndex = 117;
            this.label2.Text = "Details Box";
            // 
            // combogender
            // 
            this.combogender.FormattingEnabled = true;
            this.combogender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.combogender.Location = new System.Drawing.Point(102, 322);
            this.combogender.Name = "combogender";
            this.combogender.Size = new System.Drawing.Size(200, 21);
            this.combogender.TabIndex = 116;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 115;
            this.label1.Text = "User Id";
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Location = new System.Drawing.Point(102, 69);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(200, 20);
            this.txtEmployeeId.TabIndex = 114;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(722, 474);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(85, 33);
            this.buttonDelete.TabIndex = 113;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(579, 474);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(85, 33);
            this.buttonUpdate.TabIndex = 112;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonView
            // 
            this.buttonView.Location = new System.Drawing.Point(432, 474);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(85, 33);
            this.buttonView.TabIndex = 111;
            this.buttonView.Text = "View";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(353, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(626, 367);
            this.dataGridView1.TabIndex = 110;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // cbEmployeeBloodGroup
            // 
            this.cbEmployeeBloodGroup.FormattingEnabled = true;
            this.cbEmployeeBloodGroup.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.cbEmployeeBloodGroup.Location = new System.Drawing.Point(102, 294);
            this.cbEmployeeBloodGroup.Name = "cbEmployeeBloodGroup";
            this.cbEmployeeBloodGroup.Size = new System.Drawing.Size(200, 21);
            this.cbEmployeeBloodGroup.TabIndex = 109;
            // 
            // lblDoctorBloodGroup
            // 
            this.lblDoctorBloodGroup.AutoSize = true;
            this.lblDoctorBloodGroup.Location = new System.Drawing.Point(18, 297);
            this.lblDoctorBloodGroup.Name = "lblDoctorBloodGroup";
            this.lblDoctorBloodGroup.Size = new System.Drawing.Size(66, 13);
            this.lblDoctorBloodGroup.TabIndex = 108;
            this.lblDoctorBloodGroup.Text = "Blood Group";
            // 
            // txtEmployeePhoneNumber
            // 
            this.txtEmployeePhoneNumber.Location = new System.Drawing.Point(102, 384);
            this.txtEmployeePhoneNumber.Name = "txtEmployeePhoneNumber";
            this.txtEmployeePhoneNumber.Size = new System.Drawing.Size(200, 20);
            this.txtEmployeePhoneNumber.TabIndex = 107;
            // 
            // lblDoctorPhoneNumber
            // 
            this.lblDoctorPhoneNumber.AutoSize = true;
            this.lblDoctorPhoneNumber.Location = new System.Drawing.Point(18, 387);
            this.lblDoctorPhoneNumber.Name = "lblDoctorPhoneNumber";
            this.lblDoctorPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.lblDoctorPhoneNumber.TabIndex = 106;
            this.lblDoctorPhoneNumber.Text = "Phone Number";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(102, 349);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 20);
            this.dtpDOB.TabIndex = 105;
            // 
            // lblDoctorBirthday
            // 
            this.lblDoctorBirthday.AutoSize = true;
            this.lblDoctorBirthday.Location = new System.Drawing.Point(18, 355);
            this.lblDoctorBirthday.Name = "lblDoctorBirthday";
            this.lblDoctorBirthday.Size = new System.Drawing.Size(45, 13);
            this.lblDoctorBirthday.TabIndex = 104;
            this.lblDoctorBirthday.Text = "Birthday";
            // 
            // lblDoctorGender
            // 
            this.lblDoctorGender.AutoSize = true;
            this.lblDoctorGender.Location = new System.Drawing.Point(18, 322);
            this.lblDoctorGender.Name = "lblDoctorGender";
            this.lblDoctorGender.Size = new System.Drawing.Size(42, 13);
            this.lblDoctorGender.TabIndex = 103;
            this.lblDoctorGender.Text = "Gender";
            // 
            // lblDoctorEmailAddress
            // 
            this.lblDoctorEmailAddress.AutoSize = true;
            this.lblDoctorEmailAddress.Location = new System.Drawing.Point(18, 266);
            this.lblDoctorEmailAddress.Name = "lblDoctorEmailAddress";
            this.lblDoctorEmailAddress.Size = new System.Drawing.Size(32, 13);
            this.lblDoctorEmailAddress.TabIndex = 101;
            this.lblDoctorEmailAddress.Text = "Email";
            // 
            // txtEmployeeAddress
            // 
            this.txtEmployeeAddress.Location = new System.Drawing.Point(102, 228);
            this.txtEmployeeAddress.Multiline = true;
            this.txtEmployeeAddress.Name = "txtEmployeeAddress";
            this.txtEmployeeAddress.Size = new System.Drawing.Size(200, 20);
            this.txtEmployeeAddress.TabIndex = 99;
            // 
            // txtEmployeeEmail
            // 
            this.txtEmployeeEmail.Location = new System.Drawing.Point(102, 259);
            this.txtEmployeeEmail.Name = "txtEmployeeEmail";
            this.txtEmployeeEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmployeeEmail.TabIndex = 100;
            // 
            // lblDoctorAddress
            // 
            this.lblDoctorAddress.AutoSize = true;
            this.lblDoctorAddress.Location = new System.Drawing.Point(18, 231);
            this.lblDoctorAddress.Name = "lblDoctorAddress";
            this.lblDoctorAddress.Size = new System.Drawing.Size(45, 13);
            this.lblDoctorAddress.TabIndex = 102;
            this.lblDoctorAddress.Text = "Address";
            // 
            // lblDoctorMotherName
            // 
            this.lblDoctorMotherName.AutoSize = true;
            this.lblDoctorMotherName.Location = new System.Drawing.Point(18, 199);
            this.lblDoctorMotherName.Name = "lblDoctorMotherName";
            this.lblDoctorMotherName.Size = new System.Drawing.Size(71, 13);
            this.lblDoctorMotherName.TabIndex = 97;
            this.lblDoctorMotherName.Text = "Mother Name";
            // 
            // txtEmployeeFatherName
            // 
            this.txtEmployeeFatherName.Location = new System.Drawing.Point(102, 165);
            this.txtEmployeeFatherName.Name = "txtEmployeeFatherName";
            this.txtEmployeeFatherName.Size = new System.Drawing.Size(200, 20);
            this.txtEmployeeFatherName.TabIndex = 95;
            // 
            // txtEmployeeMotherName
            // 
            this.txtEmployeeMotherName.Location = new System.Drawing.Point(102, 196);
            this.txtEmployeeMotherName.Name = "txtEmployeeMotherName";
            this.txtEmployeeMotherName.Size = new System.Drawing.Size(200, 20);
            this.txtEmployeeMotherName.TabIndex = 96;
            // 
            // lblDoctorFatherName
            // 
            this.lblDoctorFatherName.AutoSize = true;
            this.lblDoctorFatherName.Location = new System.Drawing.Point(18, 168);
            this.lblDoctorFatherName.Name = "lblDoctorFatherName";
            this.lblDoctorFatherName.Size = new System.Drawing.Size(68, 13);
            this.lblDoctorFatherName.TabIndex = 98;
            this.lblDoctorFatherName.Text = "Father Name";
            // 
            // lblDoctorFirstName
            // 
            this.lblDoctorFirstName.AutoSize = true;
            this.lblDoctorFirstName.Location = new System.Drawing.Point(18, 105);
            this.lblDoctorFirstName.Name = "lblDoctorFirstName";
            this.lblDoctorFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblDoctorFirstName.TabIndex = 93;
            this.lblDoctorFirstName.Text = "First Name";
            // 
            // txtEmployeeFirstName
            // 
            this.txtEmployeeFirstName.Location = new System.Drawing.Point(102, 102);
            this.txtEmployeeFirstName.Name = "txtEmployeeFirstName";
            this.txtEmployeeFirstName.Size = new System.Drawing.Size(200, 20);
            this.txtEmployeeFirstName.TabIndex = 91;
            // 
            // txtEmployeeLastName
            // 
            this.txtEmployeeLastName.Location = new System.Drawing.Point(102, 134);
            this.txtEmployeeLastName.Name = "txtEmployeeLastName";
            this.txtEmployeeLastName.Size = new System.Drawing.Size(200, 20);
            this.txtEmployeeLastName.TabIndex = 92;
            // 
            // lblDoctorLastName
            // 
            this.lblDoctorLastName.AutoSize = true;
            this.lblDoctorLastName.Location = new System.Drawing.Point(18, 137);
            this.lblDoctorLastName.Name = "lblDoctorLastName";
            this.lblDoctorLastName.Size = new System.Drawing.Size(58, 13);
            this.lblDoctorLastName.TabIndex = 94;
            this.lblDoctorLastName.Text = "Last Name";
            // 
            // txtEmployeeProfessionName
            // 
            this.txtEmployeeProfessionName.Location = new System.Drawing.Point(102, 431);
            this.txtEmployeeProfessionName.Name = "txtEmployeeProfessionName";
            this.txtEmployeeProfessionName.Size = new System.Drawing.Size(200, 20);
            this.txtEmployeeProfessionName.TabIndex = 121;
            // 
            // lblEmployeeProfessionName
            // 
            this.lblEmployeeProfessionName.AutoSize = true;
            this.lblEmployeeProfessionName.Location = new System.Drawing.Point(18, 434);
            this.lblEmployeeProfessionName.Name = "lblEmployeeProfessionName";
            this.lblEmployeeProfessionName.Size = new System.Drawing.Size(87, 13);
            this.lblEmployeeProfessionName.TabIndex = 120;
            this.lblEmployeeProfessionName.Text = "Profession Name";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(894, 486);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(95, 49);
            this.buttonBack.TabIndex = 122;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // ViewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 602);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.txtEmployeeProfessionName);
            this.Controls.Add(this.lblEmployeeProfessionName);
            this.Controls.Add(this.comboBoxOption);
            this.Controls.Add(this.textBoxSharch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combogender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmployeeId);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbEmployeeBloodGroup);
            this.Controls.Add(this.lblDoctorBloodGroup);
            this.Controls.Add(this.txtEmployeePhoneNumber);
            this.Controls.Add(this.lblDoctorPhoneNumber);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.lblDoctorBirthday);
            this.Controls.Add(this.lblDoctorGender);
            this.Controls.Add(this.lblDoctorEmailAddress);
            this.Controls.Add(this.txtEmployeeAddress);
            this.Controls.Add(this.txtEmployeeEmail);
            this.Controls.Add(this.lblDoctorAddress);
            this.Controls.Add(this.lblDoctorMotherName);
            this.Controls.Add(this.txtEmployeeFatherName);
            this.Controls.Add(this.txtEmployeeMotherName);
            this.Controls.Add(this.lblDoctorFatherName);
            this.Controls.Add(this.lblDoctorFirstName);
            this.Controls.Add(this.txtEmployeeFirstName);
            this.Controls.Add(this.txtEmployeeLastName);
            this.Controls.Add(this.lblDoctorLastName);
            this.Name = "ViewEmployee";
            this.Text = "ViewEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxOption;
        private System.Windows.Forms.TextBox textBoxSharch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combogender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbEmployeeBloodGroup;
        private System.Windows.Forms.Label lblDoctorBloodGroup;
        private System.Windows.Forms.TextBox txtEmployeePhoneNumber;
        private System.Windows.Forms.Label lblDoctorPhoneNumber;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label lblDoctorBirthday;
        private System.Windows.Forms.Label lblDoctorGender;
        private System.Windows.Forms.Label lblDoctorEmailAddress;
        private System.Windows.Forms.TextBox txtEmployeeAddress;
        private System.Windows.Forms.TextBox txtEmployeeEmail;
        private System.Windows.Forms.Label lblDoctorAddress;
        private System.Windows.Forms.Label lblDoctorMotherName;
        private System.Windows.Forms.TextBox txtEmployeeFatherName;
        private System.Windows.Forms.TextBox txtEmployeeMotherName;
        private System.Windows.Forms.Label lblDoctorFatherName;
        private System.Windows.Forms.Label lblDoctorFirstName;
        private System.Windows.Forms.TextBox txtEmployeeFirstName;
        private System.Windows.Forms.TextBox txtEmployeeLastName;
        private System.Windows.Forms.Label lblDoctorLastName;
        private System.Windows.Forms.TextBox txtEmployeeProfessionName;
        private System.Windows.Forms.Label lblEmployeeProfessionName;
        private System.Windows.Forms.Button buttonBack;
    }
}