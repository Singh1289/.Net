using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisconnectedArch
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        MySqlConnection CON;
        MySqlDataAdapter SDA;
        DataSet DS;
        MySqlCommandBuilder MSCB;
        int currentIndex = 0;
        private void Form2_Load(object sender, EventArgs e)
        {
            CON = new MySqlConnection("Data Source=192.168.100.80 ;PORT=3306;Database = group038_campus;User Id=group038;password=welcome; ");
            SDA = new MySqlDataAdapter("select * from Employees", CON);
            MSCB = new MySqlCommandBuilder(SDA);
            DS = new DataSet();
            SDA.Fill(DS, "Customers");
            Navigate(currentIndex);
        }
        public void Navigate(int index)
        { 
            if(DS.Tables[0].Rows.Count > 0)
            {
                txtId.Text = DS.Tables[0].Rows[index][0].ToString();
                txtName.Text = DS.Tables[0].Rows[index][1].ToString();
                txtCity.Text= DS.Tables[0].Rows[index][2].ToString();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentIndex < DS.Tables[0].Rows.Count - 1)
            {
                currentIndex++;
                Navigate(currentIndex);
            }
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                Navigate(currentIndex);
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            currentIndex = 0;
            Navigate(currentIndex);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            currentIndex = DS.Tables[0].Rows.Count - 1;
            Navigate(currentIndex);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtName.Text=string.Empty;  
            txtCity.Text=string.Empty;      
            txtId.Text=string.Empty;  
            txtId.Focus();  
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataRow row = DS.Tables[0].NewRow();
            row["EmployeeId"]=txtId.Text;
            row["EmployeeName"] = txtName.Text;
            row["City"] = txtCity.Text;
            DS.Tables[0].Rows.Add(row);
            SDA.Update(DS.Tables[0]);
            currentIndex=0;

            Navigate(currentIndex);
        }

        private void txtModify_Click(object sender, EventArgs e)
        {
            DataRow row = DS.Tables[0].NewRow();
            row["EmployeeId"] = txtId.Text;
            row["EmployeeName"] = txtName.Text;
            row["City"] = txtCity.Text;
            DS.Tables[0].Rows.;
            SDA.Update(DS.Tables[0]);
            currentIndex = 0;

            Navigate(currentIndex);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DS.Tables[0].Rows[currentIndex].Delete();
            SDA.Update(DS.Tables[0]);
            currentIndex--;

            Navigate(currentIndex);
        }
    }
}
