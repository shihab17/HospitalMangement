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

namespace HospitalMangement.Forms.BloodMember
{
    public partial class ViewBloodMember : Form
    {
        public ViewBloodMember()
        {
            InitializeComponent();
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            DataAccess dataaccess = new DataAccess();
            String query = "Select * FROM tblBloodMemberGenarelInfo ";
            SqlCommand commandd = dataaccess.GetCommand(query);
            SqlDataAdapter sda = new SqlDataAdapter(query, commandd.Connection);
            DataTable dt = new DataTable();
            
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
          
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtBloodMemberId.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtBloodMemberFirstName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtBloodMemberLastName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtBloodMemberFatherName.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtBloodMemberMotherName.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtBloodMemberAddress.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtBloodMemberEmail.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            cbBloodMemberBloodGroup.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            combogender.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            dtpDOB.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            txtBloodMemberPhoneNumber.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            cbMemberOption.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            cbMemberAnyDisease.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DataAccess dataaccess = new DataAccess();

            string sql1 = string.Format("Select * FROM tblBloodMemberGenarelInfo ");
            SqlCommand commandd = dataaccess.GetCommand(sql1);
            commandd.Connection.Open();
            String query = "DELETE FROM tblBloodMemberGenarelInfo  WHERE bloodMemberId ='" + txtBloodMemberId.Text + "' ";

            SqlDataAdapter sda = new SqlDataAdapter(query, commandd.Connection);
            sda.SelectCommand.ExecuteNonQuery();


            commandd.Connection.Close();
            MessageBox.Show("Delete successfully!!!!");
        }
    }
}
