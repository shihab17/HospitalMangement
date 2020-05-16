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

namespace HospitalMangement.Forms.Reception
{
    public partial class Reception : Form
    {
        Form previousForm;
        Users user;
        
        public Reception(Form _previousForm, Users _user)
        {
            InitializeComponent();
            refreshdata();
            //refreshdataDoctorName();
        }

        private void btnPatientSave_Click(object sender, EventArgs e)
        {
            DataAccess dataaccess = new DataAccess();
            var cbvalDep = cbDepartment.SelectedItem;
            var cbIndexDep = cbDepartment.SelectedIndex;
            var cbvalDoctor = cbDoctorName.SelectedItem;
            var cbIndexDoctor = cbDoctorName.SelectedIndex;
            var cbvalLab = cbLab.SelectedItem;
            var cbIndexLab = cbLab.SelectedIndex;
            string sql = string.Format("insert into tblPatient (patientName,patientAge, patientWeight,patientAddress,depId,doctorId,labId,updatedTime) " +
               "Values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", txtPatientName.Text, txtPatientAge.Text, txtPatientWeight.Text, txtPatientAddress.Text, cbIndexDep, cbvalDoctor, cbvalLab, System.DateTime.Now.ToString());

            SqlCommand command = dataaccess.GetCommand(sql);

            command.Connection.Open();

            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Saved Successfully!!");


            }
            else { MessageBox.Show("Something went wrong"); }

            command.Connection.Close();
        }
        public void refreshdata()
        {
            DataAccess dataaccess = new DataAccess();
            DataRow dr;
            string sql = "select * from tblDep";
            SqlCommand command = dataaccess.GetCommand(sql);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            //DataTable dt = dataaccess.Execute(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dr = dt.NewRow();
            dr.ItemArray = new Object[] { 0, "--Select Department--" };
            dt.Rows.InsertAt(dr, 0);
            cbDepartment.ValueMember = "depId";
            cbDepartment.DisplayMember = "depName";
            cbDepartment.DataSource = dt;
        }
        private void cbDepartment_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbDepartment.SelectedValue.ToString() != null)
            {
                int depId = Convert.ToInt32(cbDepartment.SelectedValue.ToString());
                refreshdataDoctorName(depId);
                refreshlab(depId);
            }
        }

        public void refreshdataDoctorName(int depId)
        {
            DataAccess dataaccess = new DataAccess();
            DataRow dr;
            string sql = "select * " +
                 " from [dbo].[tblDoctorMoreInfo] where depId='"
                 + depId + "'";
            // + "' and Password='" + txtPassword.Text + "'";
            SqlCommand command = dataaccess.GetCommand(sql);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            //DataTable dt = dataaccess.Execute(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dr = dt.NewRow();
            dr.ItemArray = new Object[] { 0, "--Select Doctor--" };
            dt.Rows.InsertAt(dr, 0);
            cbDoctorName.ValueMember = "doctorId";
            cbDoctorName.DisplayMember = "doctorUserName";
            cbDoctorName.DataSource = dt;
        }
        public void refreshlab(int depId)
        {
            DataAccess dataaccess = new DataAccess();
            DataRow dr;
            string sql = "select * from tblLab where depId='" + depId + "'";
            SqlCommand command = dataaccess.GetCommand(sql);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            //DataTable dt = dataaccess.Execute(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dr = dt.NewRow();
            dr.ItemArray = new Object[] { 0, "--Select Lab Room --" };
            dt.Rows.InsertAt(dr, 0);
            cbDepartment.ValueMember = "labId";
            cbDepartment.DisplayMember = "labRoom";
            cbDepartment.DataSource = dt;
        }

        
    }
}