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

namespace HospitalMangement.Forms
{
    
    public partial class Bloodmemberprofile : Form
    {
        Form previousForm;
        Users user;
        public Bloodmemberprofile(Form _previousForm, Users _user)
        {
            InitializeComponent();
            this.previousForm = _previousForm;
            DataAccess dataaccess = new DataAccess();
            string sql = "select * from tblBloodMemberGenarelInfo where  bloodMemberUserName='" + _user.UserName + "'";
            SqlCommand command = dataaccess.GetCommand(sql);
            DataTable dt = dataaccess.Execute(command);
            //lblDoctorName.Text= dt.Rows[0].Field<string>("doctorFirstName");
            //string fname = dt.Rows[0].Field<string>("doctorFirstName");
            //string lname = dt.Rows[0].Field<string>("doctorLastName");
            //lblDoctorName.Text = fname + " " + lname;

            tetBloodMemberId.Text = dt.Rows[0].Field<string>("bloodMemberId");
            txtBloodMemberFirstName.Text = dt.Rows[0].Field<string>("bloodMemberFirstName");
            txtBloodMemberLastName.Text = dt.Rows[0].Field<string>("bloodMemberLastName");
            txtBloodMemberFatherName.Text = dt.Rows[0].Field<string>("bloodMemberFatherName");
            txtBloodMemberMotherName.Text = dt.Rows[0].Field<string>("bloodMemberMotherName");
            txtBloodMemberAddress.Text = dt.Rows[0].Field<string>("bloodMemberAddress");
            txtBloodMemberEmail.Text = dt.Rows[0].Field<string>("bloodMemberEmail");
            cbBloodMemberBloodGroup.Text = dt.Rows[0].Field<string>("bloodMemberBG");
            txtBloodMemberGendr.Text = dt.Rows[0].Field<string>("bloodMemberGender");
            dtpDOB.Text = Convert.ToString(dt.Rows[0].Field<DateTime>("bloodMemberBirthday"));
            txtBloodMemberPhoneNumber.Text = dt.Rows[0].Field<string>("bloodMemberPhoneNumber");
            cbMemberOption.Text = dt.Rows[0].Field<string>("bloodMemberOption");
            cbMemberAnyDisease.Text = dt.Rows[0].Field<string>("bloodMemberAnyDisease");
          


            
        }

        private void Bloodmemberprofile_Load(object sender, EventArgs e)
        {

        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            loginForm obj = new loginForm();
            obj.Show();
            this.Close();
        }
    }
}
