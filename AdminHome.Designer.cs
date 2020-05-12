namespace HospitalMangement
{
    partial class AdminHome
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
            this.btnDoctor = new System.Windows.Forms.Button();
            this.btnManagement = new System.Windows.Forms.Button();
            this.btnDepartment = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDoctor
            // 
            this.btnDoctor.Location = new System.Drawing.Point(26, 23);
            this.btnDoctor.Name = "btnDoctor";
            this.btnDoctor.Size = new System.Drawing.Size(75, 23);
            this.btnDoctor.TabIndex = 0;
            this.btnDoctor.Text = "Doctor";
            this.btnDoctor.UseVisualStyleBackColor = true;
            this.btnDoctor.Click += new System.EventHandler(this.btnDoctor_Click);
            // 
            // btnManagement
            // 
            this.btnManagement.Location = new System.Drawing.Point(26, 84);
            this.btnManagement.Name = "btnManagement";
            this.btnManagement.Size = new System.Drawing.Size(95, 40);
            this.btnManagement.TabIndex = 1;
            this.btnManagement.Text = "Management";
            this.btnManagement.UseVisualStyleBackColor = true;
            this.btnManagement.Click += new System.EventHandler(this.btnManagement_Click);
            // 
            // btnDepartment
            // 
            this.btnDepartment.Location = new System.Drawing.Point(26, 150);
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.Size = new System.Drawing.Size(75, 23);
            this.btnDepartment.TabIndex = 2;
            this.btnDepartment.Text = "Department";
            this.btnDepartment.UseVisualStyleBackColor = true;
            this.btnDepartment.Click += new System.EventHandler(this.btnDepartment_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(513, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 170);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnManagement);
            this.panel2.Controls.Add(this.btnDoctor);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.btnDepartment);
            this.panel2.Location = new System.Drawing.Point(49, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(739, 309);
            this.panel2.TabIndex = 4;
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Name = "AdminHome";
            this.Text = "AdminHome";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDoctor;
        private System.Windows.Forms.Button btnManagement;
        private System.Windows.Forms.Button btnDepartment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}