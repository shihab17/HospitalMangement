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

namespace HospitalMangement.Forms.Management
{
    public partial class btnManagement : Form
    {
        Form frmMedicalService;
        MedicalServices medicalservice;
        Doctors doctor;
        public btnManagement (Form _frmmedicalservice,MedicalServices medicalservice)
        {
            InitializeComponent();
            panelSelectedMS.Enabled = false;
            txtMedicalServiceName.Text= string.Format("{0}", medicalservice.serviceName);
            lblSeviceId.Text = string.Format("{0}", medicalservice.serviceId);
        }
        
        public btnManagement()
        {
            InitializeComponent();
            panelAddService.Visible = false;
            refreshData();
            panelSelectedMS.Visible = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess dataaccess = new DataAccess();
            
            string sql1 = string.Format("insert into tblService (serviceName) " +
                 "Values ('{0}')", txtServiceName.Text);
            SqlCommand commandd = dataaccess.GetCommand(sql1);
            commandd.Connection.Open();
            int rowsAffected = commandd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Insert Successfully!!");

            }
            else { MessageBox.Show("Something went wrong"); }
            commandd.Connection.Close();
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            panelAddService.Visible = true;
        }
        public void refreshData()
        {
            DataAccess dataaccess = new DataAccess();
            DataRow dr;
            string sql = "select * from tblService";
            SqlCommand command = dataaccess.GetCommand(sql);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            //DataTable dt = dataaccess.Execute(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dr = dt.NewRow();
            dr.ItemArray = new Object[] { 0, "--Select Medecal Service--" };
            dt.Rows.InsertAt(dr, 0);
            cbMS.ValueMember = "serviceId";
            cbMS.DisplayMember = "serviceName";
            cbMS.DataSource = dt;
        }

        private void btnServiceGo_Click(object sender, EventArgs e)
        {
            // var cbval = comboBox1.SelectedItem;
            // var cbIndex = comboBox1.SelectedIndex;
            //  MessageBox.Show(cbIndex);
            
            string message = "Name: " + cbMS.Text;
            message += Environment.NewLine;
            message += "CustomerId: " + cbMS.SelectedValue;
            MessageBox.Show(message);
            int a = Convert.ToInt32(cbMS.SelectedValue);
           if(a>0)
            {
                datatrsfr();
            }
           

        }
        public void datatrsfr()
        {
            DataAccess dataaccess = new DataAccess();
            string sql = "select * " +
                " from [dbo].[tblService] where serviceName='" + cbMS.Text + "'";

            SqlCommand command = dataaccess.GetCommand(sql);

            DataTable dt = dataaccess.Execute(command);
            if (dt.Rows.Count > 0)
            {
                int msId = Convert.ToInt32(dt.Rows[0][0].ToString());
                MedicalServices medicalServices= new MedicalServices(msId, cbMS.Text);
                // DoctorManagHome dh = new DoctorHome(this, doctor);
                btnManagement m = new btnManagement(this, medicalServices);
                m.Show();
                this.Close();



            }
        }
        public void insrtMSD()
        {
            DataAccess dataaccess = new DataAccess();

            string sql1 = string.Format("insert into tblServiceDetails (serviceId,service,updatedTime) " +
                 "Values ('{0}','{1}','{2}')", lblSeviceId.Text,txtMSInsert.Text, System.DateTime.Now.ToString());
            SqlCommand commandd = dataaccess.GetCommand(sql1);
            commandd.Connection.Open();
            int rowsAffected = commandd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Insert Successfully!!");

            }
            else { MessageBox.Show("Something went wrong"); }
            commandd.Connection.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            Departments d = new Departments();
            d.Show();
            this.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            AdminHome ah = new AdminHome();
            ah.Show();
            this.Close();
        }
    }
}
