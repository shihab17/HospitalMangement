namespace HospitalMangement.Forms.patient
{
    partial class ViewPatient
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.txtlabId = new System.Windows.Forms.TextBox();
            this.lbllabId = new System.Windows.Forms.Label();
            this.comboBoxOption = new System.Windows.Forms.ComboBox();
            this.textBoxSharch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblpatientId = new System.Windows.Forms.Label();
            this.txtpatientId = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonView = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtdoctorId = new System.Windows.Forms.TextBox();
            this.lbllbldoctorId = new System.Windows.Forms.Label();
            this.lbldepId = new System.Windows.Forms.Label();
            this.txtpatientAddress = new System.Windows.Forms.TextBox();
            this.txtdepId = new System.Windows.Forms.TextBox();
            this.lblpatientAddress = new System.Windows.Forms.Label();
            this.lblpatientWeight = new System.Windows.Forms.Label();
            this.txtpatientAge = new System.Windows.Forms.TextBox();
            this.txtpatientWeight = new System.Windows.Forms.TextBox();
            this.lblpatientAge = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.txtpatientName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(890, 470);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(95, 49);
            this.buttonBack.TabIndex = 154;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // txtlabId
            // 
            this.txtlabId.Location = new System.Drawing.Point(98, 358);
            this.txtlabId.Name = "txtlabId";
            this.txtlabId.Size = new System.Drawing.Size(200, 20);
            this.txtlabId.TabIndex = 153;
            // 
            // lbllabId
            // 
            this.lbllabId.AutoSize = true;
            this.lbllabId.Location = new System.Drawing.Point(14, 361);
            this.lbllabId.Name = "lbllabId";
            this.lbllabId.Size = new System.Drawing.Size(33, 13);
            this.lbllabId.TabIndex = 152;
            this.lbllabId.Text = "lab Id";
            // 
            // comboBoxOption
            // 
            this.comboBoxOption.FormattingEnabled = true;
            this.comboBoxOption.Items.AddRange(new object[] {
            "patientId",
            "patientName",
            "patientAge",
            "patientWeight",
            "patientAddress",
            "depId",
            "doctorId",
            "labId"});
            this.comboBoxOption.Location = new System.Drawing.Point(437, 62);
            this.comboBoxOption.Name = "comboBoxOption";
            this.comboBoxOption.Size = new System.Drawing.Size(142, 21);
            this.comboBoxOption.TabIndex = 151;
            // 
            // textBoxSharch
            // 
            this.textBoxSharch.Location = new System.Drawing.Point(663, 65);
            this.textBoxSharch.Name = "textBoxSharch";
            this.textBoxSharch.Size = new System.Drawing.Size(167, 20);
            this.textBoxSharch.TabIndex = 150;
            this.textBoxSharch.TextChanged += new System.EventHandler(this.textBoxSharch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(544, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 31);
            this.label2.TabIndex = 149;
            this.label2.Text = "Details Box";
            // 
            // lblpatientId
            // 
            this.lblpatientId.AutoSize = true;
            this.lblpatientId.Location = new System.Drawing.Point(14, 68);
            this.lblpatientId.Name = "lblpatientId";
            this.lblpatientId.Size = new System.Drawing.Size(41, 13);
            this.lblpatientId.TabIndex = 147;
            this.lblpatientId.Text = "User Id";
            // 
            // txtpatientId
            // 
            this.txtpatientId.Location = new System.Drawing.Point(98, 65);
            this.txtpatientId.Name = "txtpatientId";
            this.txtpatientId.Size = new System.Drawing.Size(200, 20);
            this.txtpatientId.TabIndex = 146;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(718, 470);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(85, 33);
            this.buttonDelete.TabIndex = 145;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(575, 470);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(85, 33);
            this.buttonUpdate.TabIndex = 144;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonView
            // 
            this.buttonView.Location = new System.Drawing.Point(428, 470);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(85, 33);
            this.buttonView.TabIndex = 143;
            this.buttonView.Text = "View";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(349, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(626, 367);
            this.dataGridView1.TabIndex = 142;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // txtdoctorId
            // 
            this.txtdoctorId.Location = new System.Drawing.Point(98, 311);
            this.txtdoctorId.Name = "txtdoctorId";
            this.txtdoctorId.Size = new System.Drawing.Size(200, 20);
            this.txtdoctorId.TabIndex = 139;
            // 
            // lbllbldoctorId
            // 
            this.lbllbldoctorId.AutoSize = true;
            this.lbllbldoctorId.Location = new System.Drawing.Point(14, 314);
            this.lbllbldoctorId.Name = "lbllbldoctorId";
            this.lbllbldoctorId.Size = new System.Drawing.Size(48, 13);
            this.lbllbldoctorId.TabIndex = 138;
            this.lbllbldoctorId.Text = "DoctorId";
            // 
            // lbldepId
            // 
            this.lbldepId.AutoSize = true;
            this.lbldepId.Location = new System.Drawing.Point(14, 262);
            this.lbldepId.Name = "lbldepId";
            this.lbldepId.Size = new System.Drawing.Size(36, 13);
            this.lbldepId.TabIndex = 133;
            this.lbldepId.Text = "DepId";
            // 
            // txtpatientAddress
            // 
            this.txtpatientAddress.Location = new System.Drawing.Point(98, 224);
            this.txtpatientAddress.Multiline = true;
            this.txtpatientAddress.Name = "txtpatientAddress";
            this.txtpatientAddress.Size = new System.Drawing.Size(200, 20);
            this.txtpatientAddress.TabIndex = 131;
            // 
            // txtdepId
            // 
            this.txtdepId.Location = new System.Drawing.Point(98, 255);
            this.txtdepId.Name = "txtdepId";
            this.txtdepId.Size = new System.Drawing.Size(200, 20);
            this.txtdepId.TabIndex = 132;
            // 
            // lblpatientAddress
            // 
            this.lblpatientAddress.AutoSize = true;
            this.lblpatientAddress.Location = new System.Drawing.Point(14, 227);
            this.lblpatientAddress.Name = "lblpatientAddress";
            this.lblpatientAddress.Size = new System.Drawing.Size(45, 13);
            this.lblpatientAddress.TabIndex = 134;
            this.lblpatientAddress.Text = "Address";
            // 
            // lblpatientWeight
            // 
            this.lblpatientWeight.AutoSize = true;
            this.lblpatientWeight.Location = new System.Drawing.Point(14, 195);
            this.lblpatientWeight.Name = "lblpatientWeight";
            this.lblpatientWeight.Size = new System.Drawing.Size(41, 13);
            this.lblpatientWeight.TabIndex = 129;
            this.lblpatientWeight.Text = "Weight";
            // 
            // txtpatientAge
            // 
            this.txtpatientAge.Location = new System.Drawing.Point(98, 161);
            this.txtpatientAge.Name = "txtpatientAge";
            this.txtpatientAge.Size = new System.Drawing.Size(200, 20);
            this.txtpatientAge.TabIndex = 127;
            // 
            // txtpatientWeight
            // 
            this.txtpatientWeight.Location = new System.Drawing.Point(98, 192);
            this.txtpatientWeight.Name = "txtpatientWeight";
            this.txtpatientWeight.Size = new System.Drawing.Size(200, 20);
            this.txtpatientWeight.TabIndex = 128;
            // 
            // lblpatientAge
            // 
            this.lblpatientAge.AutoSize = true;
            this.lblpatientAge.Location = new System.Drawing.Point(14, 164);
            this.lblpatientAge.Name = "lblpatientAge";
            this.lblpatientAge.Size = new System.Drawing.Size(26, 13);
            this.lblpatientAge.TabIndex = 130;
            this.lblpatientAge.Text = "Age";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(14, 114);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(35, 13);
            this.lbl.TabIndex = 125;
            this.lbl.Text = "Name";
            // 
            // txtpatientName
            // 
            this.txtpatientName.Location = new System.Drawing.Point(98, 111);
            this.txtpatientName.Name = "txtpatientName";
            this.txtpatientName.Size = new System.Drawing.Size(200, 20);
            this.txtpatientName.TabIndex = 123;
            // 
            // ViewPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 526);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.txtlabId);
            this.Controls.Add(this.lbllabId);
            this.Controls.Add(this.comboBoxOption);
            this.Controls.Add(this.textBoxSharch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblpatientId);
            this.Controls.Add(this.txtpatientId);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtdoctorId);
            this.Controls.Add(this.lbllbldoctorId);
            this.Controls.Add(this.lbldepId);
            this.Controls.Add(this.txtpatientAddress);
            this.Controls.Add(this.txtdepId);
            this.Controls.Add(this.lblpatientAddress);
            this.Controls.Add(this.lblpatientWeight);
            this.Controls.Add(this.txtpatientAge);
            this.Controls.Add(this.txtpatientWeight);
            this.Controls.Add(this.lblpatientAge);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtpatientName);
            this.Name = "ViewPatient";
            this.Text = "ViewPatient";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TextBox txtlabId;
        private System.Windows.Forms.Label lbllabId;
        private System.Windows.Forms.ComboBox comboBoxOption;
        private System.Windows.Forms.TextBox textBoxSharch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblpatientId;
        private System.Windows.Forms.TextBox txtpatientId;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtdoctorId;
        private System.Windows.Forms.Label lbllbldoctorId;
        private System.Windows.Forms.Label lbldepId;
        private System.Windows.Forms.TextBox txtpatientAddress;
        private System.Windows.Forms.TextBox txtdepId;
        private System.Windows.Forms.Label lblpatientAddress;
        private System.Windows.Forms.Label lblpatientWeight;
        private System.Windows.Forms.TextBox txtpatientAge;
        private System.Windows.Forms.TextBox txtpatientWeight;
        private System.Windows.Forms.Label lblpatientAge;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtpatientName;
    }
}