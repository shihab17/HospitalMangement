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

namespace HospitalMangement.Forms.Doctor
{
    public partial class Doctor : Form
    {
        Form previousForm;
        Users user;
        public Doctor(Form _previousForm, Users _user)
        {
            InitializeComponent();
            this.previousForm = _previousForm;
            DataAccess dataaccess = new DataAccess();
            string sql = "select * from tblDoctorGenarelInfo where  doctorUserName='" + _user.UserName + "'";
            SqlCommand command = dataaccess.GetCommand(sql);
            DataTable dt = dataaccess.Execute(command);
            //lblDoctorName.Text= dt.Rows[0].Field<string>("doctorFirstName");
            string fname = dt.Rows[0].Field<string>("doctorFirstName");
            string lname = dt.Rows[0].Field<string>("doctorLastName");
            lblDoctorName.Text = fname +" "+ lname;
            lblDoctorFatherName.Text= dt.Rows[0].Field<string>("doctorFatherName");
            lblDoctorMotherName.Text= dt.Rows[0].Field<string>("doctorMotherName");
            lblDoctorAddress.Text= dt.Rows[0].Field<string>("doctorAddress");
            lblDoctorEmail.Text= dt.Rows[0].Field<string>("doctorEmail");
            lblDoctorBg.Text= dt.Rows[0].Field<string>("doctorBG");
            lblDoctorGender.Text= dt.Rows[0].Field<string>("doctorGender");
            lblDoctorBirthDat.Text= Convert.ToString(dt.Rows[0].Field<DateTime>("doctorBirthday"));
            lblDoctorPhoneNumber.Text= dt.Rows[0].Field<string>("doctorPhoneNumber");

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
