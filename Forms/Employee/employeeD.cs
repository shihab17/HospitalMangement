using HospitalMangement.Database;
using HospitalMangement.Entities;
using HospitalMangement.Forms.Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalMangement.Forms.Employee
{
    public partial class Employee : Form
    {
        Form previousForm;
        Users user;
    
        public Employee(Form _previousForm, Users _user)
        {
            InitializeComponent();
            this.previousForm = _previousForm;
            DataAccess dataaccess = new DataAccess();
            string sql = "select * from tblemployeeGenarelInfo where  employeeUserName='" + _user.UserName + "'";
            SqlCommand command = dataaccess.GetCommand(sql);
            DataTable dt = dataaccess.Execute(command);
            //lblDoctorName.Text= dt.Rows[0].Field<string>("doctorFirstName");
            string fname = dt.Rows[0].Field<string>("employeeFirstName");
            string lname = dt.Rows[0].Field<string>("employeeLastName");
            txtEName.Text = fname + " " + lname;
            txtFatherName.Text = dt.Rows[0].Field<string>("employeeFatherName");
            txtMotherName.Text = dt.Rows[0].Field<string>("employeeMotherName");
            txtAddress.Text = dt.Rows[0].Field<string>("employeeAddress");
            txtEmail.Text = dt.Rows[0].Field<string>("employeeEmail");
            txtBloodGroup.Text = dt.Rows[0].Field<string>("employeeBG");
            txtGender.Text = dt.Rows[0].Field<string>("employeeGender");
            txtDoB.Text = Convert.ToString(dt.Rows[0].Field<DateTime>("employeeBirthday"));
            txtPhoneNum.Text = dt.Rows[0].Field<string>("employeePhoneNumber");
            txtProfession.Text = dt.Rows[0].Field<string>("employeeProfessionName");

        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            loginForm obj = new loginForm();
            obj.Show();
            this.Close();
        }
    }
}
