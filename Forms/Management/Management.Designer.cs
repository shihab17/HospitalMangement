namespace HospitalMangement.Forms.Management
{
    partial class btnManagement
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblSeviceId = new System.Windows.Forms.Label();
            this.txtMedicalServiceName = new System.Windows.Forms.TextBox();
            this.txtMSInsert = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddMS = new System.Windows.Forms.Button();
            this.panelAddService = new System.Windows.Forms.Panel();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.panelSelectedMS = new System.Windows.Forms.Panel();
            this.cbMS = new System.Windows.Forms.ComboBox();
            this.btnServiceGo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnServiceAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAddService = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDepartment = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelAddService.SuspendLayout();
            this.panelSelectedMS.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panelAddService);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(36, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 509);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel5.Controls.Add(this.lblSeviceId);
            this.panel5.Controls.Add(this.txtMedicalServiceName);
            this.panel5.Controls.Add(this.txtMSInsert);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.btnAddMS);
            this.panel5.Location = new System.Drawing.Point(19, 306);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(375, 175);
            this.panel5.TabIndex = 5;
            // 
            // lblSeviceId
            // 
            this.lblSeviceId.AutoSize = true;
            this.lblSeviceId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeviceId.Location = new System.Drawing.Point(12, 17);
            this.lblSeviceId.Name = "lblSeviceId";
            this.lblSeviceId.Size = new System.Drawing.Size(19, 17);
            this.lblSeviceId.TabIndex = 4;
            this.lblSeviceId.Text = "Id";
            // 
            // txtMedicalServiceName
            // 
            this.txtMedicalServiceName.Location = new System.Drawing.Point(146, 17);
            this.txtMedicalServiceName.Name = "txtMedicalServiceName";
            this.txtMedicalServiceName.Size = new System.Drawing.Size(118, 20);
            this.txtMedicalServiceName.TabIndex = 3;
            // 
            // txtMSInsert
            // 
            this.txtMSInsert.Location = new System.Drawing.Point(125, 43);
            this.txtMSInsert.Name = "txtMSInsert";
            this.txtMSInsert.Size = new System.Drawing.Size(169, 20);
            this.txtMSInsert.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Medical Service";
            // 
            // btnAddMS
            // 
            this.btnAddMS.Location = new System.Drawing.Point(172, 115);
            this.btnAddMS.Name = "btnAddMS";
            this.btnAddMS.Size = new System.Drawing.Size(75, 23);
            this.btnAddMS.TabIndex = 1;
            this.btnAddMS.Text = "Add";
            this.btnAddMS.UseVisualStyleBackColor = true;
            this.btnAddMS.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panelAddService
            // 
            this.panelAddService.Controls.Add(this.txtServiceName);
            this.panelAddService.Controls.Add(this.panelSelectedMS);
            this.panelAddService.Controls.Add(this.label2);
            this.panelAddService.Controls.Add(this.btnServiceAdd);
            this.panelAddService.Location = new System.Drawing.Point(19, 84);
            this.panelAddService.Name = "panelAddService";
            this.panelAddService.Size = new System.Drawing.Size(375, 175);
            this.panelAddService.TabIndex = 4;
            // 
            // txtServiceName
            // 
            this.txtServiceName.Location = new System.Drawing.Point(125, 43);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(169, 20);
            this.txtServiceName.TabIndex = 2;
            // 
            // panelSelectedMS
            // 
            this.panelSelectedMS.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelSelectedMS.Controls.Add(this.cbMS);
            this.panelSelectedMS.Controls.Add(this.btnServiceGo);
            this.panelSelectedMS.Controls.Add(this.label3);
            this.panelSelectedMS.Location = new System.Drawing.Point(3, 11);
            this.panelSelectedMS.Name = "panelSelectedMS";
            this.panelSelectedMS.Size = new System.Drawing.Size(375, 194);
            this.panelSelectedMS.TabIndex = 2;
            // 
            // cbMS
            // 
            this.cbMS.FormattingEnabled = true;
            this.cbMS.Location = new System.Drawing.Point(125, 61);
            this.cbMS.Name = "cbMS";
            this.cbMS.Size = new System.Drawing.Size(169, 21);
            this.cbMS.TabIndex = 2;
            // 
            // btnServiceGo
            // 
            this.btnServiceGo.Location = new System.Drawing.Point(175, 122);
            this.btnServiceGo.Name = "btnServiceGo";
            this.btnServiceGo.Size = new System.Drawing.Size(75, 23);
            this.btnServiceGo.TabIndex = 2;
            this.btnServiceGo.Text = "Go";
            this.btnServiceGo.UseVisualStyleBackColor = true;
            this.btnServiceGo.Click += new System.EventHandler(this.btnServiceGo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Medical Service";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Medical Service";
            // 
            // btnServiceAdd
            // 
            this.btnServiceAdd.Location = new System.Drawing.Point(129, 123);
            this.btnServiceAdd.Name = "btnServiceAdd";
            this.btnServiceAdd.Size = new System.Drawing.Size(75, 23);
            this.btnServiceAdd.TabIndex = 1;
            this.btnServiceAdd.Text = "Add";
            this.btnServiceAdd.UseVisualStyleBackColor = true;
            this.btnServiceAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(19, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(378, 256);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnAddService);
            this.panel4.Location = new System.Drawing.Point(0, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(375, 30);
            this.panel4.TabIndex = 3;
            // 
            // btnAddService
            // 
            this.btnAddService.Location = new System.Drawing.Point(35, 3);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(75, 23);
            this.btnAddService.TabIndex = 1;
            this.btnAddService.Text = "Add";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medical Service";
            // 
            // btnDepartment
            // 
            this.btnDepartment.Location = new System.Drawing.Point(144, 40);
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.Size = new System.Drawing.Size(115, 23);
            this.btnDepartment.TabIndex = 2;
            this.btnDepartment.Text = "Department";
            this.btnDepartment.UseVisualStyleBackColor = true;
            this.btnDepartment.Click += new System.EventHandler(this.btnDepartment_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(447, 35);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(72, 33);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // btnManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 608);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.btnDepartment);
            this.Controls.Add(this.panel1);
            this.Name = "btnManagement";
            this.Text = "Mangement";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panelAddService.ResumeLayout(false);
            this.panelAddService.PerformLayout();
            this.panelSelectedMS.ResumeLayout(false);
            this.panelSelectedMS.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSelectedMS;
        private System.Windows.Forms.Panel panelAddService;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnServiceAdd;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.ComboBox cbMS;
        private System.Windows.Forms.Button btnServiceGo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtMedicalServiceName;
        private System.Windows.Forms.TextBox txtMSInsert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddMS;
        private System.Windows.Forms.Label lblSeviceId;
        private System.Windows.Forms.Button btnDepartment;
        private System.Windows.Forms.Button buttonBack;
    }
}