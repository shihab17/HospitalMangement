namespace HospitalMangement
{
    partial class DoctorHome
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
            this.txtDoctorUserName = new System.Windows.Forms.TextBox();
            this.txtDoctorPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDoctorPassword = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDoctorId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelAddDoctor = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMoreInformation = new System.Windows.Forms.Panel();
            this.cbDoctorDepartment = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbDesignation = new System.Windows.Forms.ComboBox();
            this.cbVisitingTime = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cblVisitDay = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDoctorSave = new System.Windows.Forms.Button();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.panelDoctorGenarelInfo = new System.Windows.Forms.Panel();
            this.cbDoctorBloodGroup = new System.Windows.Forms.ComboBox();
            this.lblDoctorBloodGroup = new System.Windows.Forms.Label();
            this.txtDoctorPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblDoctorPhoneNumber = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblDoctorBirthday = new System.Windows.Forms.Label();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.lblDoctorGender = new System.Windows.Forms.Label();
            this.lblDoctorEmailAddress = new System.Windows.Forms.Label();
            this.txtDoctorAddress = new System.Windows.Forms.TextBox();
            this.txtDoctorEmail = new System.Windows.Forms.TextBox();
            this.lblDoctorAddress = new System.Windows.Forms.Label();
            this.lblDoctorMotherName = new System.Windows.Forms.Label();
            this.txtDoctorFatherName = new System.Windows.Forms.TextBox();
            this.txtDoctorMotherName = new System.Windows.Forms.TextBox();
            this.lblDoctorFatherName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDoctorFirstName = new System.Windows.Forms.Label();
            this.txtDoctorFirstName = new System.Windows.Forms.TextBox();
            this.btnDoctorGanarelInfoSave = new System.Windows.Forms.Button();
            this.txtDoctorLastName = new System.Windows.Forms.TextBox();
            this.lblDoctorLastName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnViewDoctor = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtDoctorEdu = new System.Windows.Forms.TextBox();
            this.panelAddDoctor.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelMoreInformation.SuspendLayout();
            this.panelDoctorGenarelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDoctorUserName
            // 
            this.txtDoctorUserName.Location = new System.Drawing.Point(82, 4);
            this.txtDoctorUserName.Name = "txtDoctorUserName";
            this.txtDoctorUserName.Size = new System.Drawing.Size(168, 20);
            this.txtDoctorUserName.TabIndex = 0;
            // 
            // txtDoctorPassword
            // 
            this.txtDoctorPassword.Location = new System.Drawing.Point(82, 34);
            this.txtDoctorPassword.Name = "txtDoctorPassword";
            this.txtDoctorPassword.Size = new System.Drawing.Size(168, 20);
            this.txtDoctorPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Name";
            // 
            // lblDoctorPassword
            // 
            this.lblDoctorPassword.AutoSize = true;
            this.lblDoctorPassword.Location = new System.Drawing.Point(3, 34);
            this.lblDoctorPassword.Name = "lblDoctorPassword";
            this.lblDoctorPassword.Size = new System.Drawing.Size(53, 13);
            this.lblDoctorPassword.TabIndex = 3;
            this.lblDoctorPassword.Text = "Password";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(266, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(54, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDoctorId
            // 
            this.txtDoctorId.Location = new System.Drawing.Point(3, 15);
            this.txtDoctorId.Name = "txtDoctorId";
            this.txtDoctorId.Size = new System.Drawing.Size(85, 20);
            this.txtDoctorId.TabIndex = 5;
            this.txtDoctorId.Text = "Doctor User Id";
            this.txtDoctorId.TextChanged += new System.EventHandler(this.txtDoctorId_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Doctor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelAddDoctor
            // 
            this.panelAddDoctor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelAddDoctor.Controls.Add(this.label1);
            this.panelAddDoctor.Controls.Add(this.txtDoctorUserName);
            this.panelAddDoctor.Controls.Add(this.btnAdd);
            this.panelAddDoctor.Controls.Add(this.txtDoctorPassword);
            this.panelAddDoctor.Controls.Add(this.lblDoctorPassword);
            this.panelAddDoctor.Location = new System.Drawing.Point(3, 3);
            this.panelAddDoctor.Name = "panelAddDoctor";
            this.panelAddDoctor.Size = new System.Drawing.Size(357, 56);
            this.panelAddDoctor.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelMoreInformation);
            this.panel1.Controls.Add(this.panelDoctorGenarelInfo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panelAddDoctor);
            this.panel1.Location = new System.Drawing.Point(18, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 577);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // panelMoreInformation
            // 
            this.panelMoreInformation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelMoreInformation.Controls.Add(this.txtDoctorEdu);
            this.panelMoreInformation.Controls.Add(this.cbDoctorDepartment);
            this.panelMoreInformation.Controls.Add(this.label8);
            this.panelMoreInformation.Controls.Add(this.cbDesignation);
            this.panelMoreInformation.Controls.Add(this.cbVisitingTime);
            this.panelMoreInformation.Controls.Add(this.label7);
            this.panelMoreInformation.Controls.Add(this.label4);
            this.panelMoreInformation.Controls.Add(this.label6);
            this.panelMoreInformation.Controls.Add(this.cblVisitDay);
            this.panelMoreInformation.Controls.Add(this.label3);
            this.panelMoreInformation.Controls.Add(this.btnDoctorSave);
            this.panelMoreInformation.Controls.Add(this.lblDesignation);
            this.panelMoreInformation.Location = new System.Drawing.Point(404, 3);
            this.panelMoreInformation.Name = "panelMoreInformation";
            this.panelMoreInformation.Size = new System.Drawing.Size(357, 361);
            this.panelMoreInformation.TabIndex = 10;
            // 
            // cbDoctorDepartment
            // 
            this.cbDoctorDepartment.FormattingEnabled = true;
            this.cbDoctorDepartment.Location = new System.Drawing.Point(131, 258);
            this.cbDoctorDepartment.Name = "cbDoctorDepartment";
            this.cbDoctorDepartment.Size = new System.Drawing.Size(210, 21);
            this.cbDoctorDepartment.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Select Department Time";
            // 
            // cbDesignation
            // 
            this.cbDesignation.FormattingEnabled = true;
            this.cbDesignation.Items.AddRange(new object[] {
            "4.00 PM - 9.00 PM"});
            this.cbDesignation.Location = new System.Drawing.Point(126, 67);
            this.cbDesignation.Name = "cbDesignation";
            this.cbDesignation.Size = new System.Drawing.Size(215, 21);
            this.cbDesignation.TabIndex = 26;
            // 
            // cbVisitingTime
            // 
            this.cbVisitingTime.FormattingEnabled = true;
            this.cbVisitingTime.Items.AddRange(new object[] {
            "4.00 PM - 9.00 PM"});
            this.cbVisitingTime.Location = new System.Drawing.Point(126, 95);
            this.cbVisitingTime.Name = "cbVisitingTime";
            this.cbVisitingTime.Size = new System.Drawing.Size(215, 21);
            this.cbVisitingTime.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Select Visiting Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Add Visit Day";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(123, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "More Information";
            // 
            // cblVisitDay
            // 
            this.cblVisitDay.FormattingEnabled = true;
            this.cblVisitDay.Items.AddRange(new object[] {
            "Saturday",
            "Sunday",
            "Monday",
            "Tuseday",
            "Wednesday",
            "Thursday"});
            this.cblVisitDay.Location = new System.Drawing.Point(126, 122);
            this.cblVisitDay.Name = "cblVisitDay";
            this.cblVisitDay.Size = new System.Drawing.Size(215, 94);
            this.cblVisitDay.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Educational Qualification";
            // 
            // btnDoctorSave
            // 
            this.btnDoctorSave.Location = new System.Drawing.Point(192, 311);
            this.btnDoctorSave.Name = "btnDoctorSave";
            this.btnDoctorSave.Size = new System.Drawing.Size(54, 23);
            this.btnDoctorSave.TabIndex = 4;
            this.btnDoctorSave.Text = "Save";
            this.btnDoctorSave.UseVisualStyleBackColor = true;
            this.btnDoctorSave.Click += new System.EventHandler(this.btnDoctorSave_Click);
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Location = new System.Drawing.Point(3, 70);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(81, 13);
            this.lblDesignation.TabIndex = 3;
            this.lblDesignation.Text = "DESIGNATION";
            // 
            // panelDoctorGenarelInfo
            // 
            this.panelDoctorGenarelInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelDoctorGenarelInfo.Controls.Add(this.cbDoctorBloodGroup);
            this.panelDoctorGenarelInfo.Controls.Add(this.lblDoctorBloodGroup);
            this.panelDoctorGenarelInfo.Controls.Add(this.txtDoctorPhoneNumber);
            this.panelDoctorGenarelInfo.Controls.Add(this.lblDoctorPhoneNumber);
            this.panelDoctorGenarelInfo.Controls.Add(this.dtpDOB);
            this.panelDoctorGenarelInfo.Controls.Add(this.lblDoctorBirthday);
            this.panelDoctorGenarelInfo.Controls.Add(this.rbFemale);
            this.panelDoctorGenarelInfo.Controls.Add(this.rbMale);
            this.panelDoctorGenarelInfo.Controls.Add(this.lblDoctorGender);
            this.panelDoctorGenarelInfo.Controls.Add(this.lblDoctorEmailAddress);
            this.panelDoctorGenarelInfo.Controls.Add(this.txtDoctorAddress);
            this.panelDoctorGenarelInfo.Controls.Add(this.txtDoctorEmail);
            this.panelDoctorGenarelInfo.Controls.Add(this.lblDoctorAddress);
            this.panelDoctorGenarelInfo.Controls.Add(this.lblDoctorMotherName);
            this.panelDoctorGenarelInfo.Controls.Add(this.txtDoctorFatherName);
            this.panelDoctorGenarelInfo.Controls.Add(this.txtDoctorMotherName);
            this.panelDoctorGenarelInfo.Controls.Add(this.lblDoctorFatherName);
            this.panelDoctorGenarelInfo.Controls.Add(this.label5);
            this.panelDoctorGenarelInfo.Controls.Add(this.lblDoctorFirstName);
            this.panelDoctorGenarelInfo.Controls.Add(this.txtDoctorFirstName);
            this.panelDoctorGenarelInfo.Controls.Add(this.btnDoctorGanarelInfoSave);
            this.panelDoctorGenarelInfo.Controls.Add(this.txtDoctorId);
            this.panelDoctorGenarelInfo.Controls.Add(this.txtDoctorLastName);
            this.panelDoctorGenarelInfo.Controls.Add(this.lblDoctorLastName);
            this.panelDoctorGenarelInfo.Location = new System.Drawing.Point(3, 71);
            this.panelDoctorGenarelInfo.Name = "panelDoctorGenarelInfo";
            this.panelDoctorGenarelInfo.Size = new System.Drawing.Size(357, 421);
            this.panelDoctorGenarelInfo.TabIndex = 9;
            // 
            // cbDoctorBloodGroup
            // 
            this.cbDoctorBloodGroup.FormattingEnabled = true;
            this.cbDoctorBloodGroup.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.cbDoctorBloodGroup.Location = new System.Drawing.Point(91, 240);
            this.cbDoctorBloodGroup.Name = "cbDoctorBloodGroup";
            this.cbDoctorBloodGroup.Size = new System.Drawing.Size(200, 21);
            this.cbDoctorBloodGroup.TabIndex = 23;
            // 
            // lblDoctorBloodGroup
            // 
            this.lblDoctorBloodGroup.AutoSize = true;
            this.lblDoctorBloodGroup.Location = new System.Drawing.Point(7, 243);
            this.lblDoctorBloodGroup.Name = "lblDoctorBloodGroup";
            this.lblDoctorBloodGroup.Size = new System.Drawing.Size(66, 13);
            this.lblDoctorBloodGroup.TabIndex = 22;
            this.lblDoctorBloodGroup.Text = "Blood Group";
            // 
            // txtDoctorPhoneNumber
            // 
            this.txtDoctorPhoneNumber.Location = new System.Drawing.Point(91, 330);
            this.txtDoctorPhoneNumber.Name = "txtDoctorPhoneNumber";
            this.txtDoctorPhoneNumber.Size = new System.Drawing.Size(200, 20);
            this.txtDoctorPhoneNumber.TabIndex = 21;
            // 
            // lblDoctorPhoneNumber
            // 
            this.lblDoctorPhoneNumber.AutoSize = true;
            this.lblDoctorPhoneNumber.Location = new System.Drawing.Point(7, 333);
            this.lblDoctorPhoneNumber.Name = "lblDoctorPhoneNumber";
            this.lblDoctorPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.lblDoctorPhoneNumber.TabIndex = 20;
            this.lblDoctorPhoneNumber.Text = "Phone Number";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(91, 295);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 20);
            this.dtpDOB.TabIndex = 19;
            // 
            // lblDoctorBirthday
            // 
            this.lblDoctorBirthday.AutoSize = true;
            this.lblDoctorBirthday.Location = new System.Drawing.Point(7, 301);
            this.lblDoctorBirthday.Name = "lblDoctorBirthday";
            this.lblDoctorBirthday.Size = new System.Drawing.Size(45, 13);
            this.lblDoctorBirthday.TabIndex = 18;
            this.lblDoctorBirthday.Text = "Birthday";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(169, 264);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 17;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(91, 264);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 16;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // lblDoctorGender
            // 
            this.lblDoctorGender.AutoSize = true;
            this.lblDoctorGender.Location = new System.Drawing.Point(7, 268);
            this.lblDoctorGender.Name = "lblDoctorGender";
            this.lblDoctorGender.Size = new System.Drawing.Size(42, 13);
            this.lblDoctorGender.TabIndex = 15;
            this.lblDoctorGender.Text = "Gender";
            // 
            // lblDoctorEmailAddress
            // 
            this.lblDoctorEmailAddress.AutoSize = true;
            this.lblDoctorEmailAddress.Location = new System.Drawing.Point(7, 212);
            this.lblDoctorEmailAddress.Name = "lblDoctorEmailAddress";
            this.lblDoctorEmailAddress.Size = new System.Drawing.Size(32, 13);
            this.lblDoctorEmailAddress.TabIndex = 13;
            this.lblDoctorEmailAddress.Text = "Email";
            // 
            // txtDoctorAddress
            // 
            this.txtDoctorAddress.Location = new System.Drawing.Point(91, 174);
            this.txtDoctorAddress.Multiline = true;
            this.txtDoctorAddress.Name = "txtDoctorAddress";
            this.txtDoctorAddress.Size = new System.Drawing.Size(200, 20);
            this.txtDoctorAddress.TabIndex = 11;
            // 
            // txtDoctorEmail
            // 
            this.txtDoctorEmail.Location = new System.Drawing.Point(91, 205);
            this.txtDoctorEmail.Name = "txtDoctorEmail";
            this.txtDoctorEmail.Size = new System.Drawing.Size(200, 20);
            this.txtDoctorEmail.TabIndex = 12;
            // 
            // lblDoctorAddress
            // 
            this.lblDoctorAddress.AutoSize = true;
            this.lblDoctorAddress.Location = new System.Drawing.Point(7, 177);
            this.lblDoctorAddress.Name = "lblDoctorAddress";
            this.lblDoctorAddress.Size = new System.Drawing.Size(45, 13);
            this.lblDoctorAddress.TabIndex = 14;
            this.lblDoctorAddress.Text = "Address";
            // 
            // lblDoctorMotherName
            // 
            this.lblDoctorMotherName.AutoSize = true;
            this.lblDoctorMotherName.Location = new System.Drawing.Point(7, 145);
            this.lblDoctorMotherName.Name = "lblDoctorMotherName";
            this.lblDoctorMotherName.Size = new System.Drawing.Size(71, 13);
            this.lblDoctorMotherName.TabIndex = 9;
            this.lblDoctorMotherName.Text = "Mother Name";
            // 
            // txtDoctorFatherName
            // 
            this.txtDoctorFatherName.Location = new System.Drawing.Point(91, 111);
            this.txtDoctorFatherName.Name = "txtDoctorFatherName";
            this.txtDoctorFatherName.Size = new System.Drawing.Size(200, 20);
            this.txtDoctorFatherName.TabIndex = 7;
            // 
            // txtDoctorMotherName
            // 
            this.txtDoctorMotherName.Location = new System.Drawing.Point(91, 142);
            this.txtDoctorMotherName.Name = "txtDoctorMotherName";
            this.txtDoctorMotherName.Size = new System.Drawing.Size(200, 20);
            this.txtDoctorMotherName.TabIndex = 8;
            // 
            // lblDoctorFatherName
            // 
            this.lblDoctorFatherName.AutoSize = true;
            this.lblDoctorFatherName.Location = new System.Drawing.Point(7, 114);
            this.lblDoctorFatherName.Name = "lblDoctorFatherName";
            this.lblDoctorFatherName.Size = new System.Drawing.Size(68, 13);
            this.lblDoctorFatherName.TabIndex = 10;
            this.lblDoctorFatherName.Text = "Father Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(95, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ganarel Information";
            // 
            // lblDoctorFirstName
            // 
            this.lblDoctorFirstName.AutoSize = true;
            this.lblDoctorFirstName.Location = new System.Drawing.Point(7, 51);
            this.lblDoctorFirstName.Name = "lblDoctorFirstName";
            this.lblDoctorFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblDoctorFirstName.TabIndex = 2;
            this.lblDoctorFirstName.Text = "First Name";
            // 
            // txtDoctorFirstName
            // 
            this.txtDoctorFirstName.Location = new System.Drawing.Point(91, 48);
            this.txtDoctorFirstName.Name = "txtDoctorFirstName";
            this.txtDoctorFirstName.Size = new System.Drawing.Size(200, 20);
            this.txtDoctorFirstName.TabIndex = 0;
            // 
            // btnDoctorGanarelInfoSave
            // 
            this.btnDoctorGanarelInfoSave.Location = new System.Drawing.Point(145, 375);
            this.btnDoctorGanarelInfoSave.Name = "btnDoctorGanarelInfoSave";
            this.btnDoctorGanarelInfoSave.Size = new System.Drawing.Size(54, 23);
            this.btnDoctorGanarelInfoSave.TabIndex = 4;
            this.btnDoctorGanarelInfoSave.Text = "Next";
            this.btnDoctorGanarelInfoSave.UseVisualStyleBackColor = true;
            this.btnDoctorGanarelInfoSave.Click += new System.EventHandler(this.btnDoctorGanarelInfoSave_Click);
            // 
            // txtDoctorLastName
            // 
            this.txtDoctorLastName.Location = new System.Drawing.Point(91, 80);
            this.txtDoctorLastName.Name = "txtDoctorLastName";
            this.txtDoctorLastName.Size = new System.Drawing.Size(200, 20);
            this.txtDoctorLastName.TabIndex = 1;
            // 
            // lblDoctorLastName
            // 
            this.lblDoctorLastName.AutoSize = true;
            this.lblDoctorLastName.Location = new System.Drawing.Point(7, 83);
            this.lblDoctorLastName.Name = "lblDoctorLastName";
            this.lblDoctorLastName.Size = new System.Drawing.Size(58, 13);
            this.lblDoctorLastName.TabIndex = 3;
            this.lblDoctorLastName.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(226, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(402, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Welcome To Doctor Home Page";
            // 
            // btnViewDoctor
            // 
            this.btnViewDoctor.Location = new System.Drawing.Point(135, 24);
            this.btnViewDoctor.Name = "btnViewDoctor";
            this.btnViewDoctor.Size = new System.Drawing.Size(79, 23);
            this.btnViewDoctor.TabIndex = 9;
            this.btnViewDoctor.Text = "View Doctor";
            this.btnViewDoctor.UseVisualStyleBackColor = true;
            this.btnViewDoctor.Click += new System.EventHandler(this.btnViewDoctor_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(268, 24);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(79, 23);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtDoctorEdu
            // 
            this.txtDoctorEdu.Location = new System.Drawing.Point(126, 34);
            this.txtDoctorEdu.Name = "txtDoctorEdu";
            this.txtDoctorEdu.Size = new System.Drawing.Size(215, 20);
            this.txtDoctorEdu.TabIndex = 29;
            // 
            // DoctorHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 650);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnViewDoctor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "DoctorHome";
            this.Text = "DoctorHome";
            this.panelAddDoctor.ResumeLayout(false);
            this.panelAddDoctor.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMoreInformation.ResumeLayout(false);
            this.panelMoreInformation.PerformLayout();
            this.panelDoctorGenarelInfo.ResumeLayout(false);
            this.panelDoctorGenarelInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDoctorUserName;
        private System.Windows.Forms.TextBox txtDoctorPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDoctorPassword;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDoctorId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelAddDoctor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelDoctorGenarelInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDoctorFirstName;
        private System.Windows.Forms.TextBox txtDoctorFirstName;
        private System.Windows.Forms.Button btnDoctorGanarelInfoSave;
        private System.Windows.Forms.TextBox txtDoctorLastName;
        private System.Windows.Forms.Label lblDoctorLastName;
        private System.Windows.Forms.Label lblDoctorMotherName;
        private System.Windows.Forms.TextBox txtDoctorFatherName;
        private System.Windows.Forms.TextBox txtDoctorMotherName;
        private System.Windows.Forms.Label lblDoctorFatherName;
        private System.Windows.Forms.Label lblDoctorEmailAddress;
        private System.Windows.Forms.TextBox txtDoctorAddress;
        private System.Windows.Forms.TextBox txtDoctorEmail;
        private System.Windows.Forms.Label lblDoctorAddress;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label lblDoctorBirthday;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label lblDoctorGender;
        private System.Windows.Forms.ComboBox cbDoctorBloodGroup;
        private System.Windows.Forms.Label lblDoctorBloodGroup;
        private System.Windows.Forms.TextBox txtDoctorPhoneNumber;
        private System.Windows.Forms.Label lblDoctorPhoneNumber;
        private System.Windows.Forms.Panel panelMoreInformation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDoctorSave;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbVisitingTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox cblVisitDay;
        private System.Windows.Forms.ComboBox cbDesignation;
        private System.Windows.Forms.Button btnViewDoctor;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cbDoctorDepartment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDoctorEdu;
    }
}