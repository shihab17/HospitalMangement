using HospitalMangement.Database;
using HospitalMangement.Entities;
using HospitalMangement.RandomNumberSample;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HospitalMangement
{
    public partial class BloodHome : Form
    {
        Form previousForm;
        Users user;
        Form AddbloodMember;
        BloodMember bloodMember;
        public BloodHome()
        {
            InitializeComponent();
            panelAddBloodMember.Visible = false;

            panelBloodMemberGenarelInfo.Visible = false;
        }
        public BloodHome(Form _previousForm, Users _user)
        {
            InitializeComponent();
            this.previousForm = _previousForm;
        }
        public BloodHome(Form _AddBloodMember, BloodMember bloodMember)
        {
            
            InitializeComponent();
            panelAddBloodMember.Enabled = false;
            label2.Visible = false;
            txtBloodMemberId.Enabled = false;
            txtBloodMemberId.Text = string.Format("{0}", bloodMember.bloodMemberId);
            txtBloodMemberUserName.Text = string.Format("{0}", bloodMember.bloodMemberUserName);
            txtBloodMemberPassword.Text = string.Format("{0}", bloodMember.bloodMemberPassword);
        }

        private void BloodHome_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelAddBloodMember.Visible = true;
            panelBloodMemberGenarelInfo.Visible = true;
            panelBloodMemberGenarelInfo.Enabled = false;
            txtBloodMemberPassword.Enabled = false;
            lblBloodMemberPassword.Enabled = false;
            label2.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataAccess dataaccess = new DataAccess();
            string userIdentity = "select bloodMemberUserName" + " from tblBloodMemberLogin where bloodMemberUserName='" + txtBloodMemberUserName.Text + "'";

            SqlCommand command = dataaccess.GetCommand(userIdentity);

            DataTable dt = dataaccess.Execute(command);
            if (dt.Rows.Count > 0) { MessageBox.Show("Already Saved"); }
            else
            {
                loginTableInsert();
                bloodMemberLoginInsert();
            }


            lblBloodMemberPassword.Enabled = true;
        }
        public void loginTableInsert()
        {

            DataAccess dataaccess = new DataAccess();
            RandomGenerator generator = new RandomGenerator();
            string pass = generator.RandomPassword();
            txtBloodMemberPassword.Text = pass;
            string sql1 = string.Format("insert into tblLogin (userName,password,updatedTime,UserType) " +
                 "Values ('{0}','{1}','{2}','{3}')", txtBloodMemberUserName.Text, pass, System.DateTime.Now.ToString(), 7);
            SqlCommand commandd = dataaccess.GetCommand(sql1);
            commandd.Connection.Open();
            int rowsAffected = commandd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Insert Successfully!!" + " Password is " + pass);

            }
            else { MessageBox.Show("Something went wrong"); }
            commandd.Connection.Close();

        }
        public void bloodMemberLoginInsert()
        {
            DataAccess dataaccess = new DataAccess();

            string sql = string.Format("insert into tblBloodMemberLogin (bloodMemberUserName, updatedTime,UserType) " +
                 "Values ('{0}','{1}','{2}')", txtBloodMemberUserName.Text, System.DateTime.Now.ToString(), 7);

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
        public void datatrsfr()
        {
            DataAccess dataaccess = new DataAccess();
            string sql = "select * " +
                " from [dbo].[tblBloodMemberLogin] where bloodMemberUserName='" + txtBloodMemberUserName.Text + "'";

            SqlCommand command = dataaccess.GetCommand(sql);

            DataTable dt = dataaccess.Execute(command);
            if (dt.Rows.Count > 0)
            {
                int bmId = Convert.ToInt32(dt.Rows[0][0].ToString());
                BloodMember bloodMember = new BloodMember(bmId, txtBloodMemberUserName.Text, txtBloodMemberPassword.Text);
                BloodHome bh = new BloodHome(this, bloodMember);
                bh.Show();
                this.Close();


            }

        }
        private void btnEmployeeGanarelInfoSave_Click(object sender, EventArgs e)
        {
            
        }
       
        private void btnBloodMemberGanarelInfoSave_Click(object sender, EventArgs e)
        {
            BloodMemberGenarelInfoInsert();
        }
        public void BloodMemberGenarelInfoInsert()
        {

            DataAccess dataaccess = new DataAccess();
            DateTime dt = dtpDOB.Value;
            var cbval = cbBloodMemberBloodGroup.SelectedItem;
            var cbIndex = cbBloodMemberBloodGroup.SelectedIndex;
            string checkedRB;
            if (rbMale.Checked)
            {
                checkedRB = "Male";
            }
            else
            {
                checkedRB = "Female";
            }


            string sql1 = string.Format("insert into tblBloodMemberGenarelInfo (bloodMemberId,bloodMemberFirstName,bloodMemberLastName,bloodMemberFatherName,bloodMemberMotherName,bloodMemberAddress,bloodMemberEmail,bloodMemberBG,bloodMemberGender,bloodMemberBirthday,bloodMemberPhoneNumber,bloodMemberOption,bloodMemberAnyDisease,updatedTime) " +
                 "Values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')", txtBloodMemberId.Text, txtBloodMemberFirstName.Text, txtBloodMemberLastName.Text, txtBloodMemberFatherName.Text, txtBloodMemberMotherName.Text, txtBloodMemberAddress.Text, txtBloodMemberEmail.Text, cbval, checkedRB, dt,  txtBloodMemberPhoneNumber.Text, cbMemberOption.Text, cbMemberAnyDisease.Text, System.DateTime.Now.ToString());

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

    }
}
