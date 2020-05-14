using System;
using HospitalMangement.Entities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalMangement.Forms.Employee
{
    public partial class EmployeeProfile : Form
    {
        Form previousForm;
        User usr;
        string _connectingString;
        private loginForm loginForm;
        private Users usr1;

        public EmployeeProfile(Form _previousForm, User _usr)
        {

            InitializeComponent();
            this.previousForm = _previousForm;
            textBox1.Text = string.Format("{0}", _usr.Id);
            textBox2.Text = string.Format("{0}", _usr.userName);
            textBox4.Text = string.Format("{0}", _usr.password);
        }

        public EmployeeProfile(loginForm loginForm, Users usr1)
        {
            this.loginForm = loginForm;
            this.usr1 = usr1;
        }
    }
}
