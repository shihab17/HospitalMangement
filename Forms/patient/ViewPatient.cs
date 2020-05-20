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

namespace HospitalMangement.Forms.patient
{
    public partial class ViewPatient : Form
    {
        public ViewPatient()
        {
            InitializeComponent();
        }
        DataTable dt;
        private void buttonView_Click(object sender, EventArgs e)
        {
            DataAccess dataaccess = new DataAccess();
            String query = "Select * FROM tblPatient ";
            SqlCommand commandd = dataaccess.GetCommand(query);
            SqlDataAdapter sda = new SqlDataAdapter(query, commandd.Connection);

            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textBoxSharch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = "" + comboBoxOption.Text + " like '%" + textBoxSharch.Text + "%'";
            dataGridView1.DataSource = dv;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DataAccess dataaccess = new DataAccess();

            string sql1 = string.Format("Select * FROM tblPatient ");
            SqlCommand commandd = dataaccess.GetCommand(sql1);
            commandd.Connection.Open();
            String query = "DELETE FROM tblPatient  WHERE patientId ='" + txtpatientId.Text + "' ";

            SqlDataAdapter sda = new SqlDataAdapter(query, commandd.Connection);
            sda.SelectCommand.ExecuteNonQuery();


            commandd.Connection.Close();
            MessageBox.Show("Delete successfully!!!!");
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            DataAccess dataaccess = new DataAccess();
            
            string sql1 = string.Format("Select * FROM tblPatient  ");
            SqlCommand commandd = dataaccess.GetCommand(sql1);
            commandd.Connection.Open();
            String query = "UPDATE tblPatient SET patientName= '" + txtpatientName.Text + "',patientAge= '" + txtpatientAge.Text + "',patientWeight= '" + txtpatientWeight.Text + "',patientAddress= '" + txtpatientAddress.Text + "',depId= '" + txtdepId.Text + "',doctorId= '" + txtdoctorId.Text + "',labId= '" + txtlabId.Text + "' WHERE patientId ='" + txtpatientId.Text + "' ";
            
            SqlDataAdapter sda = new SqlDataAdapter(query, commandd.Connection);
            sda.SelectCommand.ExecuteNonQuery();
            MessageBox.Show("Updated");

            commandd.Connection.Close();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtpatientId.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtpatientName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtpatientAge.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtpatientWeight.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtpatientAddress.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtdepId.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtdoctorId.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txtlabId.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            
        }
    }
    }

