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

namespace HospitalMangement.Forms.Doctor
{
    public partial class ViewDoctor : Form
    {
        public ViewDoctor()
        {
            InitializeComponent();
        }
        DataTable dt;
        private void buttonView_Click(object sender, EventArgs e)
        {
           // DataAccess dataaccess = new DataAccess();

            //string sql1 = string.Format("Select * FROM tblDoctorGenarelInfo ");
            //SqlCommand commandd = dataaccess.GetCommand(sql1);
            //commandd.Connection.Open();
            //String query = "Select * FROM tblDoctorGenarelInfo ";
            //SqlDataAdapter sda = new SqlDataAdapter(query, commandd.Connection);

            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //dataGridView1.DataSource = dt;

            //commandd.Connection.Close();

            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\AIUB\C#\HospitalMangement\hospital.mdf;Integrated Security=True;Connect Timeout=30");
            // con.Open();
            DataAccess dataaccess = new DataAccess();
            String query = "Select * FROM tblDoctorGenarelInfo ";
            SqlCommand commandd = dataaccess.GetCommand(query);
            SqlDataAdapter sda = new SqlDataAdapter(query,commandd.Connection);
            DataTable dt = new DataTable();
           // dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
          //  commandd.Connection.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            DataAccess dataaccess = new DataAccess();

            string sql1 = string.Format("Select * FROM tblDoctorGenarelInfo ");
            SqlCommand commandd = dataaccess.GetCommand(sql1);
            commandd.Connection.Open();
            //String query = "UPDATE tblDoctorGenarelInfo SET doctorFirstName= '" + txtDoctorFirstName.Text + "',doctorLastName= '" + txtDoctorLastName.Text + "',doctorFatherName= '" + txtDoctorFatherName.Text + "',doctorMotherName= '" + txtDoctorMotherName.Text + "',doctorAddress= '" + txtDoctorAddress.Text + "',doctorEmail= '" + txtDoctorEmail.Text + "',doctorBG= '" + cbDoctorBloodGroup.Text + "',doctorGender= '" + combogender.Text + "',doctorBirthday= '" + dtpDOB.Text + "',doctorPhoneNumber= '" + txtDoctorPhoneNumber.Text + "' WHERE doctorId ='" + txtDoctorId.Text + "' ";
            string query = string.Format("UPDATE tblDoctorGenarelInfo SET (doctorId,doctorFirstName,doctorLastName,doctorFatherName,doctorMotherName,doctorAddress,doctorEmail,doctorBG,doctorGender,doctorBirthday,doctorPhoneNumber,updatedTime) " +
                 "Values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')", txtDoctorId.Text, txtDoctorFirstName.Text, txtDoctorLastName.Text, txtDoctorFatherName.Text, txtDoctorMotherName.Text, txtDoctorAddress.Text, txtDoctorEmail.Text, cbDoctorBloodGroup.Text, combogender.Text, dt, txtDoctorPhoneNumber.Text, System.DateTime.Now.ToString());
            SqlDataAdapter sda = new SqlDataAdapter(query, commandd.Connection);
            sda.SelectCommand.ExecuteNonQuery();


            commandd.Connection.Close();




            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pranto\Documents\hos.mdf;Integrated Security=True;Connect Timeout=30");
            //con.Open();
            //String query = "UPDATE tblDoctorGenarelInfo SET doctorFirstName= '" + txtDoctorFirstName.Text + "',doctorLastName= '" + txtDoctorLastName.Text + "',doctorFatherName= '" + txtDoctorFatherName.Text + "',doctorMotherName= '" + txtDoctorMotherName.Text + "',doctorAddress= '" + txtDoctorAddress.Text + "',doctorEmail= '" + txtDoctorEmail.Text + "',doctorBG= '" + cbDoctorBloodGroup.Text + "',doctorGender= '" + combogender.Text + "',doctorBirthday= '" + dtpDOB.Text + "',doctorPhoneNumber= '" + txtDoctorPhoneNumber.Text + "'  WHERE doctorId ='" + txtDoctorId.Text + "' ";
            //SqlDataAdapter sda = new SqlDataAdapter(query, con);
            //sda.SelectCommand.ExecuteNonQuery();
            //con.Close();
            //MessageBox.Show("Update successfully!!!!");
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            txtDoctorId.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtDoctorFirstName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtDoctorLastName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtDoctorFatherName.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtDoctorMotherName.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtDoctorAddress.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtDoctorEmail.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            cbDoctorBloodGroup.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            combogender.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            dtpDOB.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            txtDoctorPhoneNumber.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            
           
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pranto\Documents\hos.mdf;Integrated Security=True;Connect Timeout=30");
            //    con.Open();
            //    String query = "DELETE FROM tblDoctorGenarelInfo  WHERE doctorId ='" + txtDoctorId.Text + "' ";
            //    SqlDataAdapter sda = new SqlDataAdapter(query, con);
            //    sda.SelectCommand.ExecuteNonQuery();
            //    con.Close();
            //    MessageBox.Show("Delete successfully!!!!");

            DataAccess dataaccess = new DataAccess();

           string sql1 = string.Format("Select * FROM tblDoctorGenarelInfo ");
            SqlCommand commandd = dataaccess.GetCommand(sql1);
            commandd.Connection.Open();
            String query = "DELETE FROM tblDoctorGenarelInfo  WHERE doctorId ='" + txtDoctorId.Text + "' ";

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
    }
}
