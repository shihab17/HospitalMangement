using HospitalMangement.Database;
using HospitalMangement.Entities;
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
                    AdminHome admin = new AdminHome();
                    admin.Show();
                    this.Hide();
                }
                if (userType == (int)Entities.Users.UserTypeEnum.Doctorr)
                {
                    DoctorHome doctor = new DoctorHome();
                    doctor.Show();
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
    }
}
