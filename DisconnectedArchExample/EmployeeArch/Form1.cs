using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace EmployeeArch
{
    public partial class GetEmployee : Form
    {
        public GetEmployee()
        {
            InitializeComponent();
        }
        MySqlConnection CN;
        MySqlDataAdapter DA;
        DataSet DS;
        private void GetEmployee_Load(object sender, EventArgs e)
        {
            CN = new MySqlConnection("Data Source=localhost; PORT=3306; Database=dotnetdb; User Id=root;Password=@Singh1289;");
            DA = new MySqlDataAdapter("Select * from Employees", CN);
            DS = new DataSet();
            DA.Fill(DS, "EMPs"); // DA.Fill(DS)table will be access by index no.---- same thing "name of table in set" 
            dataGridView_Emp.DataSource = DS.Tables["EMPs"];
        }
    }
}
