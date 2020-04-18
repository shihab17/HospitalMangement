using HospitalMangement.Database;
using HospitalMangement.Entities;
using HospitalMangement.RandomNumberSample;
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

namespace HospitalMangement
{
    public partial class DoctorHome : Form
    {
        Form previousForm;
        Users user;
        Form AddDoctor;
        Doctors doctor;
        public DoctorHome()
        {
            InitializeComponent();
            panelAddDoctor.Visible = false;
            
            panelDoctorGenarelInfo.Visible = false;

        }
        public DoctorHome(Form _previousForm, Users _user)
       {
            InitializeComponent();
            this.previousForm = _previousForm;


       }
        public DoctorHome(Form _AddDoctor, Doctors doctor)
        {
            InitializeComponent();
            panelAddDoctor.Enabled = false;
            label2.Visible = false;
            txtDoctorId.Enabled = false;
            txtDoctorId.Text = string.Format("{0}", doctor.doctorId);
            txtDoctorUserName.Text = string.Format("{0}", doctor.doctorUserName);
            txtDoctorPassword.Text = string.Format("{0}", doctor.doctorPassword);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            
            loginTableInsert();
            doctorLoginInsert();

            lblDoctorPassword.Enabled = true;
            //txtDoctorPassword.Enabled = true;

        }
       

        public void loginTableInsert()
        {
            
            DataAccess dataaccess = new DataAccess();
            RandomGenerator generator = new RandomGenerator();
            string pass = generator.RandomPassword();
            txtDoctorPassword.Text = pass;
            string sql1 = string.Format("insert into tblLogin (userName,password,updatedTime,UserType) " +
                 "Values ('{0}','{1}','{2}','{3}')", txtDoctorUserName.Text, pass, System.DateTime.Now.ToString(), 1);
            SqlCommand commandd = dataaccess.GetCommand(sql1);
            commandd.Connection.Open();
            int rowsAffected = commandd.ExecuteNonQuery();
            if(rowsAffected>0)
            {
                MessageBox.Show("Insert Successfully!!"+" Password is "+pass);
                
            }
            else { MessageBox.Show("Something went wrong"); }
            commandd.Connection.Close();

        }
        public void doctorLoginInsert()
        {
            DataAccess dataaccess = new DataAccess();
            
            string sql = string.Format("insert into tblDoctorLogin (doctorUserName, updatedTime,UserType) " +
                 "Values ('{0}','{1}','{2}')", txtDoctorUserName.Text, System.DateTime.Now.ToString(), 1);

            SqlCommand command = dataaccess.GetCommand(sql);

            command.Connection.Open();

            int rowsAffected = command.ExecuteNonQuery();
            
            if (rowsAffected > 0)
            {
                MessageBox.Show("Saved Successfully!!");
                datatrsfr();
                
            }
            else { MessageBox.Show("Something went wrong"); }

            command.Connection.Close();
        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void datatrsfr()
        {
            DataAccess dataaccess = new DataAccess();
            string sql = "select * " +
                " from [dbo].[tblDoctorLogin] where doctorUserName='" + txtDoctorUserName.Text + "'";

            SqlCommand command = dataaccess.GetCommand(sql);

            DataTable dt = dataaccess.Execute(command);
            if (dt.Rows.Count > 0)
            {
                int dId = Convert.ToInt32(dt.Rows[0][0].ToString());
                Doctors doctor = new Doctors(dId, txtDoctorUserName.Text, txtDoctorPassword.Text);
                DoctorHome dh = new DoctorHome(this, doctor);
                dh.Show();
                this.Close();
                

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            panelAddDoctor.Visible = true;
            panelDoctorGenarelInfo.Visible = true;
            panelDoctorGenarelInfo.Enabled = false;
            txtDoctorPassword.Enabled = false;
            lblDoctorPassword.Enabled = false;
            // panel1.Visible = false;
            label2.Visible = false;

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
