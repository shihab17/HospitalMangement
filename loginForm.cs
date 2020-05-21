using HospitalMangement.Database;
using HospitalMangement.Entities;

using HospitalMangement.Forms.Doctor;
using HospitalMangement.Forms.Employee;
using HospitalMangement.Forms.Reception;

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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
            //btnExit.Visible = false;
            //txtPassword.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            LogIn();

        }

        private void LogIn()
        {
            DataAccess dataaccess = new DataAccess();
            string sql = "select * " +
                " from [dbo].[tblLogin] where UserName='" + txtUserName.Text
                + "' and Password='" + txtPassword.Text + "'";

            SqlCommand command = dataaccess.GetCommand(sql);

            DataTable dt = dataaccess.Execute(command);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login Success!");
                Entities.Users user = new Users()
                {
                    Id = dt.Rows[0].Field<int>("Id"),//Int32.Parse(dt.Rows[0][0].ToString())
                    UserName = dt.Rows[0].Field<string>("UserName"), //dt.Rows[0][2].ToString(),
                    Password = dt.Rows[0][1].ToString(),

                    ///UpdatedTime = DateTime.Parse(dt.Rows[0][4].ToString()),
                    UserType = dt.Rows[0].Field<int>("UserType")
                };
                var userType = dt.Rows[0].Field<int>("UserType");
                if (userType == (int)Entities.Users.UserTypeEnum.Admin)
                {
                    int  id = Convert.ToInt32( dt.Rows[0][0].ToString());

                    AdminHome admin = new AdminHome();
                    admin.Show();
                    this.Hide();
                }
                if (userType == (int)Entities.Users.UserTypeEnum.Doctor)
                {
                    int id = Convert.ToInt32(dt.Rows[0][0].ToString());
                    int ut= (int)Entities.Users.UserTypeEnum.Doctor;

                    Users usr= new Users(id, txtUserName.Text, txtPassword.Text, ut);

                    Doctor doctor = new Doctor(this,usr);
                    doctor.Show();
                    this.Hide();
                }
                if (userType == (int)Entities.Users.UserTypeEnum.Employee)
                {
                    int id = Convert.ToInt32(dt.Rows[0][0].ToString());
                    int ut = (int)Entities.Users.UserTypeEnum.Employee;

                    Users usr = new Users(id, txtUserName.Text, txtPassword.Text, ut);

                    Forms.Employee.Employee EmployeeDetalis = new Forms.Employee.Employee(this, usr);
                    EmployeeDetalis.Show();
                    this.Hide();
                }



                if (userType == (int)Entities.Users.UserTypeEnum.Reception)
                {
                    int id = Convert.ToInt32(dt.Rows[0][0].ToString());
                    int ut = (int)Entities.Users.UserTypeEnum.Reception;
                    Users usr = new Users(id, txtUserName.Text, txtPassword.Text, ut);

                    Reception reciption = new Reception(this, usr);
                    reciption.Show();

                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Login Failled!");

            }

        }
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                LogIn();
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            var text = (sender as TextBox).Text;
            if (string.IsNullOrWhiteSpace(text))
            {
                e.Cancel = true;
                txtUserName.Focus();
                errorProvider1.SetError(txtUserName, $"Should not be white");
            }
            else {
                e.Cancel = false;
                errorProvider1.SetError(txtUserName, "");

            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            var text = (sender as TextBox).Text;
            if (string.IsNullOrWhiteSpace(text))
            {
                e.Cancel = true;
                txtPassword.Focus();
                errorProvider1.SetError(txtPassword, $"Should not be white");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUserName, "");

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
