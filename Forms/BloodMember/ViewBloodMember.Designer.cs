namespace HospitalMangement.Forms.BloodMember
{
    partial class ViewBloodMember
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
            this.txtBloodMemberId = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonView = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbBloodMemberBloodGroup = new System.Windows.Forms.ComboBox();
            this.lblDoctorBloodGroup = new System.Windows.Forms.Label();
            this.txtBloodMemberPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblDoctorPhoneNumber = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblDoctorBirthday = new System.Windows.Forms.Label();
            this.lblDoctorGender = new System.Windows.Forms.Label();
            this.lblDoctorEmailAddress = new System.Windows.Forms.Label();
            this.txtBloodMemberAddress = new System.Windows.Forms.TextBox();
            this.txtBloodMemberEmail = new System.Windows.Forms.TextBox();
            this.lblDoctorAddress = new System.Windows.Forms.Label();
            this.lblDoctorMotherName = new System.Windows.Forms.Label();
            this.txtBloodMemberFatherName = new System.Windows.Forms.TextBox();
            this.txtBloodMemberMotherName = new System.Windows.Forms.TextBox();
            this.lblDoctorFatherName = new System.Windows.Forms.Label();
            this.lblDoctorFirstName = new System.Windows.Forms.Label();
            this.txtBloodMemberFirstName = new System.Windows.Forms.TextBox();
            this.txtBloodMemberLastName = new System.Windows.Forms.TextBox();
            this.lblDoctorLastName = new System.Windows.Forms.Label();
            this.lblMemberAnyDisease = new System.Windows.Forms.Label();
            this.cbMemberAnyDisease = new System.Windows.Forms.ComboBox();
            this.cbMemberOption = new System.Windows.Forms.ComboBox();
            this.lblMemberOption = new System.Windows.Forms.Label();
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
            this.comboBoxOption.Location = new System.Drawing.Point(429, 59);
            this.comboBoxOption.Name = "comboBoxOption";
            this.comboBoxOption.Size = new System.Drawing.Size(142, 21);
            this.comboBoxOption.TabIndex = 148;
            // 
            // textBoxSharch
            // 
            this.textBoxSharch.Location = new System.Drawing.Point(655, 62);
            this.textBoxSharch.Name = "textBoxSharch";
            this.textBoxSharch.Size = new System.Drawing.Size(167, 20);
            this.textBoxSharch.TabIndex = 147;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(536, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 31);
            this.label2.TabIndex = 146;
            this.label2.Text = "Details Box";
            // 
            // combogender
            // 
            this.combogender.FormattingEnabled = true;
            this.combogender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.combogender.Location = new System.Drawing.Point(90, 315);
            this.combogender.Name = "combogender";
            this.combogender.Size = new System.Drawing.Size(200, 21);
            this.combogender.TabIndex = 145;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 144;
            this.label1.Text = "User Id";
            // 
            // txtBloodMemberId
            // 
            this.txtBloodMemberId.Location = new System.Drawing.Point(90, 62);
            this.txtBloodMemberId.Name = "txtBloodMemberId";
            this.txtBloodMemberId.Size = new System.Drawing.Size(200, 20);
            this.txtBloodMemberId.TabIndex = 143;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(710, 467);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(85, 33);
            this.buttonDelete.TabIndex = 142;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(567, 467);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(85, 33);
            this.buttonUpdate.TabIndex = 141;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonView
            // 
            this.buttonView.Location = new System.Drawing.Point(420, 467);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(85, 33);
            this.buttonView.TabIndex = 140;
            this.buttonView.Text = "View";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(341, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(626, 367);
            this.dataGridView1.TabIndex = 139;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // cbBloodMemberBloodGroup
            // 
            this.cbBloodMemberBloodGroup.FormattingEnabled = true;
            this.cbBloodMemberBloodGroup.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.cbBloodMemberBloodGroup.Location = new System.Drawing.Point(90, 287);
            this.cbBloodMemberBloodGroup.Name = "cbBloodMemberBloodGroup";
            this.cbBloodMemberBloodGroup.Size = new System.Drawing.Size(200, 21);
            this.cbBloodMemberBloodGroup.TabIndex = 138;
            // 
            // lblDoctorBloodGroup
            // 
            this.lblDoctorBloodGroup.AutoSize = true;
            this.lblDoctorBloodGroup.Location = new System.Drawing.Point(6, 290);
            this.lblDoctorBloodGroup.Name = "lblDoctorBloodGroup";
            this.lblDoctorBloodGroup.Size = new System.Drawing.Size(66, 13);
            this.lblDoctorBloodGroup.TabIndex = 137;
            this.lblDoctorBloodGroup.Text = "Blood Group";
            // 
            // txtBloodMemberPhoneNumber
            // 
            this.txtBloodMemberPhoneNumber.Location = new System.Drawing.Point(90, 377);
            this.txtBloodMemberPhoneNumber.Name = "txtBloodMemberPhoneNumber";
            this.txtBloodMemberPhoneNumber.Size = new System.Drawing.Size(200, 20);
            this.txtBloodMemberPhoneNumber.TabIndex = 136;
            // 
            // lblDoctorPhoneNumber
            // 
            this.lblDoctorPhoneNumber.AutoSize = true;
            this.lblDoctorPhoneNumber.Location = new System.Drawing.Point(6, 380);
            this.lblDoctorPhoneNumber.Name = "lblDoctorPhoneNumber";
            this.lblDoctorPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.lblDoctorPhoneNumber.TabIndex = 135;
            this.lblDoctorPhoneNumber.Text = "Phone Number";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(90, 342);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 20);
            this.dtpDOB.TabIndex = 134;
            // 
            // lblDoctorBirthday
            // 
            this.lblDoctorBirthday.AutoSize = true;
            this.lblDoctorBirthday.Location = new System.Drawing.Point(6, 348);
            this.lblDoctorBirthday.Name = "lblDoctorBirthday";
            this.lblDoctorBirthday.Size = new System.Drawing.Size(45, 13);
            this.lblDoctorBirthday.TabIndex = 133;
            this.lblDoctorBirthday.Text = "Birthday";
            // 
            // lblDoctorGender
            // 
            this.lblDoctorGender.AutoSize = true;
            this.lblDoctorGender.Location = new System.Drawing.Point(6, 315);
            this.lblDoctorGender.Name = "lblDoctorGender";
            this.lblDoctorGender.Size = new System.Drawing.Size(42, 13);
            this.lblDoctorGender.TabIndex = 132;
            this.lblDoctorGender.Text = "Gender";
            // 
            // lblDoctorEmailAddress
            // 
            this.lblDoctorEmailAddress.AutoSize = true;
            this.lblDoctorEmailAddress.Location = new System.Drawing.Point(6, 259);
            this.lblDoctorEmailAddress.Name = "lblDoctorEmailAddress";
            this.lblDoctorEmailAddress.Size = new System.Drawing.Size(32, 13);
            this.lblDoctorEmailAddress.TabIndex = 130;
            this.lblDoctorEmailAddress.Text = "Email";
            // 
            // txtBloodMemberAddress
            // 
            this.txtBloodMemberAddress.Location = new System.Drawing.Point(90, 221);
            this.txtBloodMemberAddress.Multiline = true;
            this.txtBloodMemberAddress.Name = "txtBloodMemberAddress";
            this.txtBloodMemberAddress.Size = new System.Drawing.Size(200, 20);
            this.txtBloodMemberAddress.TabIndex = 128;
            // 
            // txtBloodMemberEmail
            // 
            this.txtBloodMemberEmail.Location = new System.Drawing.Point(90, 252);
            this.txtBloodMemberEmail.Name = "txtBloodMemberEmail";
            this.txtBloodMemberEmail.Size = new System.Drawing.Size(200, 20);
            this.txtBloodMemberEmail.TabIndex = 129;
            // 
            // lblDoctorAddress
            // 
            this.lblDoctorAddress.AutoSize = true;
            this.lblDoctorAddress.Location = new System.Drawing.Point(6, 224);
            this.lblDoctorAddress.Name = "lblDoctorAddress";
            this.lblDoctorAddress.Size = new System.Drawing.Size(45, 13);
            this.lblDoctorAddress.TabIndex = 131;
            this.lblDoctorAddress.Text = "Address";
            // 
            // lblDoctorMotherName
            // 
            this.lblDoctorMotherName.AutoSize = true;
            this.lblDoctorMotherName.Location = new System.Drawing.Point(6, 192);
            this.lblDoctorMotherName.Name = "lblDoctorMotherName";
            this.lblDoctorMotherName.Size = new System.Drawing.Size(71, 13);
            this.lblDoctorMotherName.TabIndex = 126;
            this.lblDoctorMotherName.Text = "Mother Name";
            // 
            // txtBloodMemberFatherName
            // 
            this.txtBloodMemberFatherName.Location = new System.Drawing.Point(90, 158);
            this.txtBloodMemberFatherName.Name = "txtBloodMemberFatherName";
            this.txtBloodMemberFatherName.Size = new System.Drawing.Size(200, 20);
            this.txtBloodMemberFatherName.TabIndex = 124;
            // 
            // txtBloodMemberMotherName
            // 
            this.txtBloodMemberMotherName.Location = new System.Drawing.Point(90, 189);
            this.txtBloodMemberMotherName.Name = "txtBloodMemberMotherName";
            this.txtBloodMemberMotherName.Size = new System.Drawing.Size(200, 20);
            this.txtBloodMemberMotherName.TabIndex = 125;
            // 
            // lblDoctorFatherName
            // 
            this.lblDoctorFatherName.AutoSize = true;
            this.lblDoctorFatherName.Location = new System.Drawing.Point(6, 161);
            this.lblDoctorFatherName.Name = "lblDoctorFatherName";
            this.lblDoctorFatherName.Size = new System.Drawing.Size(68, 13);
            this.lblDoctorFatherName.TabIndex = 127;
            this.lblDoctorFatherName.Text = "Father Name";
            // 
            // lblDoctorFirstName
            // 
            this.lblDoctorFirstName.AutoSize = true;
            this.lblDoctorFirstName.Location = new System.Drawing.Point(6, 98);
            this.lblDoctorFirstName.Name = "lblDoctorFirstName";
            this.lblDoctorFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblDoctorFirstName.TabIndex = 122;
            this.lblDoctorFirstName.Text = "First Name";
            // 
            // txtBloodMemberFirstName
            // 
            this.txtBloodMemberFirstName.Location = new System.Drawing.Point(90, 95);
            this.txtBloodMemberFirstName.Name = "txtBloodMemberFirstName";
            this.txtBloodMemberFirstName.Size = new System.Drawing.Size(200, 20);
            this.txtBloodMemberFirstName.TabIndex = 120;
            // 
            // txtBloodMemberLastName
            // 
            this.txtBloodMemberLastName.Location = new System.Drawing.Point(90, 127);
            this.txtBloodMemberLastName.Name = "txtBloodMemberLastName";
            this.txtBloodMemberLastName.Size = new System.Drawing.Size(200, 20);
            this.txtBloodMemberLastName.TabIndex = 121;
            // 
            // lblDoctorLastName
            // 
            this.lblDoctorLastName.AutoSize = true;
            this.lblDoctorLastName.Location = new System.Drawing.Point(6, 130);
            this.lblDoctorLastName.Name = "lblDoctorLastName";
            this.lblDoctorLastName.Size = new System.Drawing.Size(58, 13);
            this.lblDoctorLastName.TabIndex = 123;
            this.lblDoctorLastName.Text = "Last Name";
            // 
            // lblMemberAnyDisease
            // 
            this.lblMemberAnyDisease.AutoSize = true;
            this.lblMemberAnyDisease.Location = new System.Drawing.Point(9, 449);
            this.lblMemberAnyDisease.Name = "lblMemberAnyDisease";
            this.lblMemberAnyDisease.Size = new System.Drawing.Size(63, 13);
            this.lblMemberAnyDisease.TabIndex = 152;
            this.lblMemberAnyDisease.Text = "AnyDisease";
            // 
            // cbMemberAnyDisease
            // 
            this.cbMemberAnyDisease.FormattingEnabled = true;
            this.cbMemberAnyDisease.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbMemberAnyDisease.Location = new System.Drawing.Point(90, 441);
            this.cbMemberAnyDisease.Name = "cbMemberAnyDisease";
            this.cbMemberAnyDisease.Size = new System.Drawing.Size(202, 21);
            this.cbMemberAnyDisease.TabIndex = 151;
            // 
            // cbMemberOption
            // 
            this.cbMemberOption.FormattingEnabled = true;
            this.cbMemberOption.Items.AddRange(new object[] {
            "Sent",
            "Resive"});
            this.cbMemberOption.Location = new System.Drawing.Point(90, 414);
            this.cbMemberOption.Name = "cbMemberOption";
            this.cbMemberOption.Size = new System.Drawing.Size(200, 21);
            this.cbMemberOption.TabIndex = 150;
            // 
            // lblMemberOption
            // 
            this.lblMemberOption.AutoSize = true;
            this.lblMemberOption.Location = new System.Drawing.Point(6, 417);
            this.lblMemberOption.Name = "lblMemberOption";
            this.lblMemberOption.Size = new System.Drawing.Size(38, 13);
            this.lblMemberOption.TabIndex = 149;
            this.lblMemberOption.Text = "Option";
            // 
            // ViewBloodMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 530);
            this.Controls.Add(this.lblMemberAnyDisease);
            this.Controls.Add(this.cbMemberAnyDisease);
            this.Controls.Add(this.cbMemberOption);
            this.Controls.Add(this.lblMemberOption);
            this.Controls.Add(this.comboBoxOption);
            this.Controls.Add(this.textBoxSharch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combogender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBloodMemberId);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbBloodMemberBloodGroup);
            this.Controls.Add(this.lblDoctorBloodGroup);
            this.Controls.Add(this.txtBloodMemberPhoneNumber);
            this.Controls.Add(this.lblDoctorPhoneNumber);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.lblDoctorBirthday);
            this.Controls.Add(this.lblDoctorGender);
            this.Controls.Add(this.lblDoctorEmailAddress);
            this.Controls.Add(this.txtBloodMemberAddress);
            this.Controls.Add(this.txtBloodMemberEmail);
            this.Controls.Add(this.lblDoctorAddress);
            this.Controls.Add(this.lblDoctorMotherName);
            this.Controls.Add(this.txtBloodMemberFatherName);
            this.Controls.Add(this.txtBloodMemberMotherName);
            this.Controls.Add(this.lblDoctorFatherName);
            this.Controls.Add(this.lblDoctorFirstName);
            this.Controls.Add(this.txtBloodMemberFirstName);
            this.Controls.Add(this.txtBloodMemberLastName);
            this.Controls.Add(this.lblDoctorLastName);
            this.Name = "ViewBloodMember";
            this.Text = "ViewBloodMember";
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
        private System.Windows.Forms.TextBox txtBloodMemberId;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbBloodMemberBloodGroup;
        private System.Windows.Forms.Label lblDoctorBloodGroup;
        private System.Windows.Forms.TextBox txtBloodMemberPhoneNumber;
        private System.Windows.Forms.Label lblDoctorPhoneNumber;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label lblDoctorBirthday;
        private System.Windows.Forms.Label lblDoctorGender;
        private System.Windows.Forms.Label lblDoctorEmailAddress;
        private System.Windows.Forms.TextBox txtBloodMemberAddress;
        private System.Windows.Forms.TextBox txtBloodMemberEmail;
        private System.Windows.Forms.Label lblDoctorAddress;
        private System.Windows.Forms.Label lblDoctorMotherName;
        private System.Windows.Forms.TextBox txtBloodMemberFatherName;
        private System.Windows.Forms.TextBox txtBloodMemberMotherName;
        private System.Windows.Forms.Label lblDoctorFatherName;
        private System.Windows.Forms.Label lblDoctorFirstName;
        private System.Windows.Forms.TextBox txtBloodMemberFirstName;
        private System.Windows.Forms.TextBox txtBloodMemberLastName;
        private System.Windows.Forms.Label lblDoctorLastName;
        private System.Windows.Forms.Label lblMemberAnyDisease;
        private System.Windows.Forms.ComboBox cbMemberAnyDisease;
        private System.Windows.Forms.ComboBox cbMemberOption;
        private System.Windows.Forms.Label lblMemberOption;
    }
}