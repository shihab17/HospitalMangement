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

namespace HospitalMangement
{
    public partial class Blood : Form
    {
        public Blood()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pranto\Documents\hosn.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string query = "INSERT INTO BloodTable (Name,FatherName,MotherName,Gender,DatheOfBirth,BloodGroup,PhoneNumber,Email,Address,Option,AnyDisease) VALUES( '" + textBoxName.Text + "','" + textBoxFatherName.Text + "','" + textBoxMotherName.Text + "','" + comboBoxGender.Text + "','" + dateTimePickerDatheOfBirth.Text + "','" + comboBoxBloodGroup.Text + "','" + textBoxPhoneNumber.Text + "','" + textBoxEmail.Text + "','" + textBoxAddress.Text + "','" + cbMemberOption.Text + "','" + cbMemberAnyDisease.Text + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Save successfully!!!!");
        }
    }
}
