using HospitalMangement.Database;
using HospitalMangement.Entities;
using HospitalMangement.Forms.Doctor;
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

            DataAccess dataaccess = new DataAccess();
            string userIdentity = "select doctorUserName" + " from tblDoctorLogin where doctorUserName='" + txtDoctorUserName.Text + "'";

            SqlCommand command = dataaccess.GetCommand(userIdentity);

            DataTable dt = dataaccess.Execute(command);
            if (dt.Rows.Count > 0) { MessageBox.Show("Already Saved"); }
            else
            {
                loginTableInsert();
                doctorLoginInsert();
            }
            

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

        private void btnDoctorGanarelInfoSave_Click(object sender, EventArgs e)
        {
            
            DoctorGenarelInfoInsert();

        }
        public void DoctorGenarelInfoInsert()
        {

            DataAccess dataaccess = new DataAccess();
            DateTime dt = dtpDOB.Value;
            var cbval = cbDoctorBloodGroup.SelectedItem;
            var cbIndex = cbDoctorBloodGroup.SelectedIndex;
            string checkedRB;
            if (rbMale.Checked)
            {
                checkedRB = "Male";
            }
            else
            {
                checkedRB = "Female";
            }

            //  string sql1 = string.Format("insert into tblDoctorGenarelInfo (doctorId,doctorFirstName,doctorLastName,doctorFatherName,doctorMotherName,doctorAddress,doctorEmail,doctorBG,doctorGender,doctorBirthday,doctorPhoneNumber,updatedTime) " +
            //      "Values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')", txtDoctorId.Text,txtDoctorFirstName.Text,txtDoctorLastName.Text,txtDoctorFatherName.Text,txtDoctorMotherName.Text,txtDoctorAddress.Text,txtDoctorEmail.Text,cbIndex,checkedRB,dt, System.DateTime.Now.ToString());


            string sql1 = string.Format("insert into tblDoctorGenarelInfo (doctorId,doctorFirstName,doctorLastName,doctorFatherName,doctorMotherName,doctorAddress,doctorEmail,doctorBG,doctorGender,doctorBirthday,doctorPhoneNumber,updatedTime) " +
                 "Values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')", txtDoctorId.Text, txtDoctorFirstName.Text, txtDoctorLastName.Text, txtDoctorFatherName.Text, txtDoctorMotherName.Text, txtDoctorAddress.Text, txtDoctorEmail.Text, cbval, checkedRB, dt, txtDoctorPhoneNumber.Text, System.DateTime.Now.ToString());

            SqlCommand commandd = dataaccess.GetCommand(sql1);
            commandd.Connection.Open();
            int rowsAffected = commandd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Insert Successfully!!");

            }
            else { MessageBox.Show("Something went wrong"); }
            commandd.Connection.Close();
        }

        private void btnViewDoctor_Click(object sender, EventArgs e)
        {
            ViewDoctor vd = new ViewDoctor();
            vd.Show();
            this.Close();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminHome ah = new AdminHome();
            ah.Show();
            this.Close();
           // previousForm.Show();
          //  this.Close();
        }

        private void btnDoctorSave_Click(object sender, EventArgs e)
        {
            DataAccess dataaccess = new DataAccess();
            checkedListBox1.Items.Clear();
            foreach (string s in checkedListBox1.CheckedItems)
            {
                checkedListBox1.Items.Add(s);
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            listBoxItem.Items.Clear();
            foreach (string s in checkedListBox1.CheckedItems)
            {
                listBoxItem.Items.Add(s);
            }
        }
    }
}
