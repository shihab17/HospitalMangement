using HospitalMangement.Database;
using HospitalMangement.Entities;
using HospitalMangement.Forms.Employee;
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
    
        public partial class EmployeeHome : Form
        {
            Form previousForm;
            Users user;
            Form Addemployee;
            Employee employee;
            public EmployeeHome()
            {
                InitializeComponent();
                panelAddEmployee.Visible = false;

                panelEmployeeGenarelInfo.Visible = false;
            }


            public EmployeeHome(Form _previousForm, Users _user)
            {
                InitializeComponent();
                this.previousForm = _previousForm;
            }
            public EmployeeHome(Form _AddEmployee, Employee employee)
            {
                InitializeComponent();
                panelAddEmployee.Enabled = false;
                label2.Visible = false;
                txtEmployeeId.Enabled = false;
                txtEmployeeId.Text = string.Format("{0}", employee.employeeId);
                txtEmployeeUserName.Text = string.Format("{0}", employee.employeeUserName);
                txtEmployeePassword.Text = string.Format("{0}", employee.employeePassword);
            }


            private void button1_Click(object sender, EventArgs e)
        {
            panelAddEmployee.Visible = true;
            panelEmployeeGenarelInfo.Visible = true;
            panelEmployeeGenarelInfo.Enabled = false;
            txtEmployeePassword.Enabled = false;
            lblEmployeePassword.Enabled = false;
            label2.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataAccess dataaccess = new DataAccess();
            string userIdentity = "select employeeUserName" + " from tblemployeeLogin where employeeUserName='" + txtEmployeeUserName.Text + "'";

            SqlCommand command = dataaccess.GetCommand(userIdentity);

            DataTable dt = dataaccess.Execute(command);
            if (dt.Rows.Count > 0) { MessageBox.Show("Already Saved"); }
            else
            {
                loginTableInsert();
                employeeLoginInsert();
            }


            lblEmployeePassword.Enabled = true;
        }
        public void loginTableInsert()
        {

            DataAccess dataaccess = new DataAccess();
            RandomGenerator generator = new RandomGenerator();
            string pass = generator.RandomPassword();
            txtEmployeePassword.Text = pass;
            string sql1 = string.Format("insert into tblLogin (userName,password,updatedTime,UserType) " +
                 "Values ('{0}','{1}','{2}','{3}')", txtEmployeeUserName.Text, pass, System.DateTime.Now.ToString(), cblblEmployeeUserType.Text);
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
        public void employeeLoginInsert()
        {
            DataAccess dataaccess = new DataAccess();

            string sql = string.Format("insert into tblemployeeLogin (employeeUserName, updatedTime,UserType) " +
                 "Values ('{0}','{1}','{2}')", txtEmployeeUserName.Text, System.DateTime.Now.ToString(), cblblEmployeeUserType.Text);

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
                " from [dbo].[tblemployeeLogin] where employeeUserName='" + txtEmployeeUserName.Text + "'";

            SqlCommand command = dataaccess.GetCommand(sql);

            DataTable dt = dataaccess.Execute(command);
            if (dt.Rows.Count > 0)
            {
                int eId = Convert.ToInt32(dt.Rows[0][0].ToString());
                Employee employee = new Employee(eId, txtEmployeeUserName.Text, txtEmployeePassword.Text);
                EmployeeHome eh = new EmployeeHome(this, employee);
                eh.Show();
                this.Close();


            }

        }

        private void btnEmployeeGanarelInfoSave_Click(object sender, EventArgs e)
        {
            EmployeeGenarelInfoInsert();
        }
        public void EmployeeGenarelInfoInsert()
        {

            DataAccess dataaccess = new DataAccess();
            DateTime dt = dtpDOB.Value;
            var cbval = cbEmployeeBloodGroup.SelectedItem;
            var cbIndex = cbEmployeeBloodGroup.SelectedIndex;
            string checkedRB;
            if (rbMale.Checked)
            {
                checkedRB = "Male";
            }
            else
            {
                checkedRB = "Female";
            }

            
            string sql1 = string.Format("insert into tblemployeeGenarelInfo (employeeId,employeeFirstName,employeeLastName,employeeFatherName,employeeMotherName,employeeAddress,employeeEmail,employeeBG,employeeGender,employeeBirthday,employeePhoneNumber,employeeProfessionName,updatedTime) " +
                 "Values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}')", txtEmployeeId.Text, txtEmployeeFirstName.Text, txtEmployeeLastName.Text, txtEmployeeFatherName.Text, txtEmployeeMotherName.Text, txtEmployeeAddress.Text, txtEmployeeEmail.Text, cbval, checkedRB, dt, txtEmployeePhoneNumber.Text, cbEmployeeProfessionName.Text, System.DateTime.Now.ToString());

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

        private void btnViewEmployee_Click(object sender, EventArgs e)
        {
            ViewEmployee vd = new ViewEmployee();
            vd.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminHome ah = new AdminHome();
            ah.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
