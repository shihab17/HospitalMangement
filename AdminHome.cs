using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalMangement.Forms.Management;

namespace HospitalMangement
{
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            

            DoctorHome doctor = new DoctorHome();
            doctor.Show();
            this.Hide();
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            btnManagement m = new btnManagement();
            m.Show();
            this.Close();
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            Departments d = new Departments();
            d.Show();
            this.Close();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {

            EmployeeHome employee = new EmployeeHome();
            employee.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Blood member = new Blood();
            member.Show();
            this.Hide();
        }
    }
}
