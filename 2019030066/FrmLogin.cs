using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using _2019030066.database;

namespace _2019030066
{
    public partial class FrmLogin : Form
    {
        private SqlConnection sqlConnection1 = null;
        private SqlCommand SqlCommand1=null;
        private SqlDataAdapter SqlDataAdapter1;
        DataSet dataSet1;

        public FrmLogin()
        {
            InitializeComponent();
            /*
            sqlConnection1 = new SqlConnection(dbconnection.connection);
            SqlCommand1 = new SqlCommand();
            SqlCommand1.Connection = sqlConnection1;
            */
            dataSet1 = new DataSet();
        }
        [STAThread]
        static void Main()
        {
            Application.Run(new FrmLogin());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string SqlStr = "Server=KING-PC\\SQLEXPRESS;User Id=sa;Pwd=476051001;Database=2019030066";
            SqlConnection con = new SqlConnection(SqlStr);
            con.Open();
            
            string sqlString = "SELECT * FROM MyUser where username = '" + this.txtName.Text.Trim() + "' AND pwd ='" + txtPass.Text + "'";
            SqlDataAdapter1 = new SqlDataAdapter(sqlString, con); 
            SqlDataAdapter1.Fill(dataSet1, "syuser");
            DataTable mytable = dataSet1.Tables["syuser"];
            
            if (mytable.Rows.Count > 0)
            {
                this.Hide();
                mainform mf = new mainform();
                mf.Show();
            }
            else
            {
                MessageBox.Show("用户名/密码错误！请重试！", "确认", MessageBoxButtons.OK);
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
