namespace HospitalMangement.Forms.Management
{
    partial class Departments
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtAddDepartment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btndepartmentAdd = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel5.Controls.Add(this.txtAddDepartment);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.btndepartmentAdd);
            this.panel5.Location = new System.Drawing.Point(47, 115);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(339, 175);
            this.panel5.TabIndex = 6;
            // 
            // txtAddDepartment
            // 
            this.txtAddDepartment.Location = new System.Drawing.Point(125, 43);
            this.txtAddDepartment.Name = "txtAddDepartment";
            this.txtAddDepartment.Size = new System.Drawing.Size(169, 20);
            this.txtAddDepartment.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Department";
            // 
            // btndepartmentAdd
            // 
            this.btndepartmentAdd.Location = new System.Drawing.Point(139, 105);
            this.btndepartmentAdd.Name = "btndepartmentAdd";
            this.btndepartmentAdd.Size = new System.Drawing.Size(75, 23);
            this.btndepartmentAdd.TabIndex = 1;
            this.btndepartmentAdd.Text = "Add";
            this.btndepartmentAdd.UseVisualStyleBackColor = true;
            this.btndepartmentAdd.Click += new System.EventHandler(this.btndepartmentAdd_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(597, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(72, 33);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // Departments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.panel5);
            this.Name = "Departments";
            this.Text = "Department";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtAddDepartment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btndepartmentAdd;
        private System.Windows.Forms.Button buttonBack;
    }
}