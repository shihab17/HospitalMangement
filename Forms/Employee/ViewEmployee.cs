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
            DateTime dt = dtpDOB.Value;
            string sql1 = string.Format("Select * FROM tblemployeeGenarelInfo  ");
            SqlCommand commandd = dataaccess.GetCommand(sql1);
            commandd.Connection.Open();
            String query = "UPDATE tblemployeeGenarelInfo SET employeeFirstName= '" + txtEmployeeFirstName.Text + "',employeeLastName= '" + txtEmployeeLastName.Text + "',employeeFatherName= '" + txtEmployeeFatherName.Text + "',employeeMotherName= '" + txtEmployeeMotherName.Text + "',employeeAddress= '" + txtEmployeeAddress.Text + "',employeeEmail= '" + txtEmployeeEmail.Text + "',employeeBG= '" + cbEmployeeBloodGroup.Text + "',employeeGender= '" + combogender.Text + "',employeeBirthday= '" + dt + "',employeePhoneNumber= '" + txtEmployeePhoneNumber.Text + "',employeeProfessionName= '" + txtEmployeeProfessionName.Text + "' WHERE employeeId ='" + txtEmployeeId.Text + "' "; 
             // string query = string.Format("UPDATE tblDoctorGenarelInfo SET (doctorId,doctorFirstName,doctorLastName,doctorFatherName,doctorMotherName,doctorAddress,doctorEmail,doctorBG,doctorGender,doctorBirthday,doctorPhoneNumber,updatedTime) " +
             //   "Values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')", txtDoctorId.Text, txtDoctorFirstName.Text, txtDoctorLastName.Text, txtDoctorFatherName.Text, txtDoctorMotherName.Text, txtDoctorAddress.Text, txtDoctorEmail.Text, cbDoctorBloodGroup.Text, combogender.Text, dt, txtDoctorPhoneNumber.Text, System.DateTime.Now.ToString());
             SqlDataAdapter sda = new SqlDataAdapter(query, commandd.Connection);
            sda.SelectCommand.ExecuteNonQuery();
            MessageBox.Show("Updated");

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

        private void buttonBack_Click(object sender, EventArgs e)
        {
            EmployeeHome emp = new EmployeeHome();
            emp.Show();
            this.Close();

        }
    }
}
