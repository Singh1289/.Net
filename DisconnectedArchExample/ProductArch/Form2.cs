using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;

namespace ProductArch
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        MySqlConnection CN;
        MySqlDataAdapter DA; // truck
        MySqlCommandBuilder CMD_BLD;  //
        DataSet DS;  // local storage
        int currentIndex = 0;

        private void Form2_Load(object sender, EventArgs e)
        {
            CN = new MySqlConnection("Data Source=localhost; PORT=3306; Database=dotnetdb; User Id=root;Password=@Singh1289;");
            DA = new MySqlDataAdapter("Select * from Products", CN);
            CMD_BLD = new MySqlCommandBuilder(DA);
            DS = new DataSet();
            DA.Fill(DS, "Products");
            Navigation(currentIndex);
            dataGridView_pro.DataSource= DS.Tables[0];
        }

        public void Navigation(int index)
        {
            if (DS.Tables[0].Rows.Count > 0)
            { 
                txtProId.Text = DS.Tables[0].Rows[index][0].ToString();
                txtProName.Text = DS.Tables[0].Rows[index][1].ToString();
                txtProPrice.Text = DS.Tables[0].Rows[index][2].ToString();
            }
        }
        private void btn_first_Click(object sender, EventArgs e)
        {
            currentIndex = 0;
            Navigation(currentIndex);
        }

        private void btn_Prev_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            { 
                currentIndex--;
                Navigation(currentIndex);
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if(currentIndex < DS.Tables[0].Rows.Count-1)
            {
                currentIndex++;
                Navigation(currentIndex);
            }
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            currentIndex = DS.Tables[0].Rows.Count - 1;
            Navigation(currentIndex);
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            txtProId.Text = String.Empty;
            txtProName.Text = String.Empty;
            txtProPrice.Text = String.Empty;
            txtProId.Focus();
            dataGridView_pro.DataSource = DS.Tables[0];
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            DataRow row = DS.Tables[0].NewRow();
            row["productId"]= txtProId.Text;
            row["productName"]=txtProName.Text;
            row["productPrice"]= txtProPrice.Text;

            DS.Tables[0].Rows.Add(row);     // Modify the data table
            DA.Update(DS.Tables[0]);        // Update your database
            MessageBox.Show("Record saved successfully.");
            btn_New_Click(sender, e);
            
        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {

            DS.Tables[0].Rows[currentIndex][0] = txtProId.Text;
            DS.Tables[0].Rows[currentIndex]["productName"] = txtProName.Text;
            DS.Tables[0].Rows[currentIndex]["productPrice"] = txtProPrice.Text;
            DA.Update(DS.Tables[0]);
            MessageBox.Show("Record Updated successfully.");
            btn_New_Click(sender, e);
            //int id = int.Parse(txtProId.Text);
            //DataRow[] row = DS.Tables[0].Select($"productId ='{id}'");

            //if (row.Length > 0)
            //{
            //    DataRow row1 = row[0];

            //    row1["productName"] = txtProName.Text;
            //    row1["productPrice"] = txtProPrice.Text;

            //    DA.Update(DS.Tables[0]);

            //    MessageBox.Show("Record updated successfully.");
            //    btn_New_Click(sender,e);
            //}
            //else
            //{
            //    MessageBox.Show("Record not found to update.");
            //}

        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            DS.Tables[0].Rows[currentIndex].Delete();
            DA.Update(DS.Tables[0]);
            // update => use to insert/update/delete
            MessageBox.Show("Record deleted successfully.");
            btn_New_Click(sender, e);
        }

    }
}
