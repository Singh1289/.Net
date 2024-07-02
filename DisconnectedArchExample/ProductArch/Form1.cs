using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace ProductArch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection CN;
        MySqlDataAdapter DA;
        DataSet DS;

       

        private void Form1_Load(object sender, System.EventArgs e)
        {
            CN = new MySqlConnection("Data Source=localhost; PORT=3306; Database=dotnetdb; User Id=root;Password=@Singh1289;");
            DA = new MySqlDataAdapter("Select * from Products", CN);
            DS = new DataSet();
            DA.Fill(DS, "Products");
            proV.DataSource = DS.Tables["Products"];
        }

       
    }
}
