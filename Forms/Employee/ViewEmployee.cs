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

namespace HospitalMangement.Forms.Employee
{
    public partial class ViewEmployee : Form
    {
        public ViewEmployee()
        {
            InitializeComponent();
        }
        DataTable dt;

        private void buttonView_Click(object sender, EventArgs e)
        {
            DataAccess dataaccess = new DataAccess();
            String query = "Select * FROM tblemployeeGenarelInfo ";
            SqlCommand commandd = dataaccess.GetCommand(query);
            SqlDataAdapter sda = new SqlDataAdapter(query, commandd.Connection);
            DataTable dt = new DataTable();
            // dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            //  commandd.Connection.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            DataAccess dataaccess = new DataAccess();

            string sql1 = string.Format("Select * FROM tblemployeeGenarelInfo ");
            SqlCommand commandd = dataaccess.GetCommand(sql1);
            commandd.Connection.Open();
            String query = "UPDATE tblDoctorGenarelInfo SET tblemployeeGenarelInfo= '" + txtEmployeeFirstName.Text + "',doctorLastName= '" + txtEmployeeLastName.Text + "',doctorFatherName= '" + txtEmployeeFatherName.Text + "',doctorMotherName= '" + txtEmployeeMotherName.Text + "',doctorAddress= '" + txtEmployeeAddress.Text + "',doctorEmail= '" + txtEmployeeEmail.Text + "',doctorBG= '" + cbEmployeeBloodGroup.Text + "',doctorGender= '" + combogender.Text + "',doctorBirthday= '" + dtpDOB.Text + "',doctorPhoneNumber= '" + txtEmployeePhoneNumber.Text + "' WHERE doctorId ='" + txtEmployeeId.Text + "' ";

            SqlDataAdapter sda = new SqlDataAdapter(query, commandd.Connection);
            sda.SelectCommand.ExecuteNonQuery();


            commandd.Connection.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DataAccess dataaccess = new DataAccess();

            string sql1 = string.Format("Select * FROM tblemployeeGenarelInfo ");
            SqlCommand commandd = dataaccess.GetCommand(sql1);
            commandd.Connection.Open();
            String query = "DELETE FROM tblemployeeGenarelInfo  WHERE employeeId ='" + txtEmployeeId.Text + "' ";

            SqlDataAdapter sda = new SqlDataAdapter(query, commandd.Connection);
            sda.SelectCommand.ExecuteNonQuery();


            commandd.Connection.Close();
            MessageBox.Show("Delete successfully!!!!");
        }

        private void textBoxSharch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = "" + comboBoxOption.Text + " like '%" + textBoxSharch.Text + "%'";
            dataGridView1.DataSource = dv;
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtEmployeeId.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtEmployeeFirstName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtEmployeeLastName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtEmployeeFatherName.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtEmployeeMotherName.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtEmployeeAddress.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtEmployeeEmail.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            cbEmployeeBloodGroup.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            combogender.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            dtpDOB.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            txtEmployeePhoneNumber.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
        }
    }
}
