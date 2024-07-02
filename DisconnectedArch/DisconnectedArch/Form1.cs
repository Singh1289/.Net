using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisconnectedArch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection CON;
        MySqlDataAdapter SDA;
        DataSet DS;
        private void Form1_Load(object sender, EventArgs e)
        {
            CON = new MySqlConnection("Data Source=192.168.100.80 ;PORT=3306;Database = group038_campus;User Id=group038;password=welcome; ");
            SDA = new MySqlDataAdapter("select * from Employees",CON);
            DS = new DataSet();

            SDA.Fill(DS);
            dgv.DataSource = DS.Tables[0];
        }

       
    }
}
