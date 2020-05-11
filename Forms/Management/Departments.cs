using HospitalMangement.Database;
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
    public partial class Departments : Form
    {
        public Departments()
        {
            InitializeComponent();
        }

        private void btndepartmentAdd_Click(object sender, EventArgs e)
        {
            insrtMSD();
        }
        public void insrtMSD()
        {
            DataAccess dataaccess = new DataAccess();

            string sql1 = string.Format("insert into tblDep (depName,updatedTime) " +
                 "Values ('{0}','{1}')", txtAddDepartment.Text, System.DateTime.Now.ToString());
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
    }
}
