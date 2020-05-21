using System;

namespace HospitalMangement.Forms.Reception
{
    partial class Reception
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
            this.btnPatient = new System.Windows.Forms.Button();
            this.btnViewPatient = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPatientSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPatientAddress = new System.Windows.Forms.TextBox();
            this.cbLab = new System.Windows.Forms.ComboBox();
            this.cbDoctorName = new System.Windows.Forms.ComboBox();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.rbPatientFemale = new System.Windows.Forms.RadioButton();
            this.rbPatientMale = new System.Windows.Forms.RadioButton();
            this.txtPatientWeight = new System.Windows.Forms.TextBox();
            this.txtPatientAge = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPatient
            // 
            this.btnPatient.Location = new System.Drawing.Point(35, 27);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(75, 23);
            this.btnPatient.TabIndex = 0;
            this.btnPatient.Text = "Add Patient";
            this.btnPatient.UseVisualStyleBackColor = true;
            // 
            // btnViewPatient
            // 
            this.btnViewPatient.Location = new System.Drawing.Point(151, 27);
            this.btnViewPatient.Name = "btnViewPatient";
            this.btnViewPatient.Size = new System.Drawing.Size(75, 23);
            this.btnViewPatient.TabIndex = 1;
            this.btnViewPatient.Text = "View Patient";
            this.btnViewPatient.UseVisualStyleBackColor = true;
            this.btnViewPatient.Click += new System.EventHandler(this.btnViewPatient_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(261, 27);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 474);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.btnPatientSave);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtPatientAddress);
            this.panel2.Controls.Add(this.cbLab);
            this.panel2.Controls.Add(this.cbDoctorName);
            this.panel2.Controls.Add(this.cbDepartment);
            this.panel2.Controls.Add(this.rbPatientFemale);
            this.panel2.Controls.Add(this.rbPatientMale);
            this.panel2.Controls.Add(this.txtPatientWeight);
            this.panel2.Controls.Add(this.txtPatientAge);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtPatientName);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(187, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(679, 468);
            this.panel2.TabIndex = 0;
            // 
            // btnPatientSave
            // 
            this.btnPatientSave.Location = new System.Drawing.Point(265, 405);
            this.btnPatientSave.Name = "btnPatientSave";
            this.btnPatientSave.Size = new System.Drawing.Size(134, 43);
            this.btnPatientSave.TabIndex = 21;
            this.btnPatientSave.Text = "Save";
            this.btnPatientSave.UseVisualStyleBackColor = true;
            this.btnPatientSave.Click += new System.EventHandler(this.btnPatientSave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(55, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 24);
            this.label8.TabIndex = 20;
            this.label8.Text = "Address";
            // 
            // txtPatientAddress
            // 
            this.txtPatientAddress.Location = new System.Drawing.Point(59, 281);
            this.txtPatientAddress.Name = "txtPatientAddress";
            this.txtPatientAddress.Size = new System.Drawing.Size(203, 29);
            this.txtPatientAddress.TabIndex = 19;
            // 
            // cbLab
            // 
            this.cbLab.FormattingEnabled = true;
            this.cbLab.Items.AddRange(new object[] {
            "a",
            "b",
            "c"});
            this.cbLab.Location = new System.Drawing.Point(403, 358);
            this.cbLab.Name = "cbLab";
            this.cbLab.Size = new System.Drawing.Size(201, 32);
            this.cbLab.TabIndex = 18;
            // 
            // cbDoctorName
            // 
            this.cbDoctorName.FormattingEnabled = true;
            this.cbDoctorName.Location = new System.Drawing.Point(59, 358);
            this.cbDoctorName.Name = "cbDoctorName";
            this.cbDoctorName.Size = new System.Drawing.Size(201, 32);
            this.cbDoctorName.TabIndex = 17;
            // 
            // cbDepartment
            // 
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(403, 281);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(201, 32);
            this.cbDepartment.TabIndex = 16;
            this.cbDepartment.SelectedIndexChanged += new System.EventHandler(this.cbDepartment_SelectedIndexChanged_1);
            // 
            // rbPatientFemale
            // 
            this.rbPatientFemale.AutoSize = true;
            this.rbPatientFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPatientFemale.Location = new System.Drawing.Point(190, 200);
            this.rbPatientFemale.Name = "rbPatientFemale";
            this.rbPatientFemale.Size = new System.Drawing.Size(72, 21);
            this.rbPatientFemale.TabIndex = 15;
            this.rbPatientFemale.TabStop = true;
            this.rbPatientFemale.Text = "Female";
            this.rbPatientFemale.UseVisualStyleBackColor = true;
            // 
            // rbPatientMale
            // 
            this.rbPatientMale.AutoSize = true;
            this.rbPatientMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPatientMale.Location = new System.Drawing.Point(59, 199);
            this.rbPatientMale.Name = "rbPatientMale";
            this.rbPatientMale.Size = new System.Drawing.Size(56, 21);
            this.rbPatientMale.TabIndex = 14;
            this.rbPatientMale.TabStop = true;
            this.rbPatientMale.Text = "Male";
            this.rbPatientMale.UseVisualStyleBackColor = true;
            // 
            // txtPatientWeight
            // 
            this.txtPatientWeight.Location = new System.Drawing.Point(403, 200);
            this.txtPatientWeight.Name = "txtPatientWeight";
            this.txtPatientWeight.Size = new System.Drawing.Size(194, 29);
            this.txtPatientWeight.TabIndex = 10;
            // 
            // txtPatientAge
            // 
            this.txtPatientAge.Location = new System.Drawing.Point(403, 129);
            this.txtPatientAge.Name = "txtPatientAge";
            this.txtPatientAge.Size = new System.Drawing.Size(194, 29);
            this.txtPatientAge.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(399, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Lab ";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(59, 129);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(203, 29);
            this.txtPatientName.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Select Doctor Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(399, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Select Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(399, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Weight";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(399, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // Reception
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 542);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnViewPatient);
            this.Controls.Add(this.btnPatient);
            this.Name = "Reception";
            this.Text = "reception";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPatient;
        private System.Windows.Forms.Button btnViewPatient;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbLab;
        private System.Windows.Forms.ComboBox cbDoctorName;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.RadioButton rbPatientFemale;
        private System.Windows.Forms.RadioButton rbPatientMale;
        private System.Windows.Forms.TextBox txtPatientWeight;
        private System.Windows.Forms.TextBox txtPatientAge;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPatientAddress;
        private System.Windows.Forms.Button btnPatientSave; 
    }
}