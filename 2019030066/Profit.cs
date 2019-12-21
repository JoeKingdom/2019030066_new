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
    public partial class Profit : Form
    {
        public Profit()
        {
            InitializeComponent();
        }
        string strSql;
        SqlConnection sqlConnection1 = new SqlConnection(dbconnection.connection);
        SqlCommand sqlCommand1 = new SqlCommand(); 

        private void Profit_Load(object sender, EventArgs e)
        {
            strSql = "SELECT distinct RoomInfo.RoomID 房屋ID,Renter.RenterName 出租者姓名,Renter.RenterRental 出租者租金," +
                    "RoomInfo.Price 房屋价格," +
                    "(SELECT distinct SUM(Customer.CustomerRental) FROM Customer WHERE Customer.RoomID = Customer.RoomID)" +
                    " as 总房租," +
                    "RoomInfo.Price - Renter.RenterRental AS 参考利润," +
                    "(SELECT distinct SUM(Customer.CustomerRental) FROM Customer WHERE Customer.RoomID = Customer.RoomID)" +
                    "-Renter.RenterRental as 实际利润" +
                    " FROM Customer INNER JOIN" +
                    " RoomInfo ON Customer.RoomID = RoomInfo.RoomID INNER JOIN" +
                    " Renter ON RoomInfo.RenterID = Renter.RenterID";
            FillDataGrid(strSql);
        }

        public void FillDataGrid(string sql)
        {
            if (this.sqlConnection1.State == ConnectionState.Closed)
                this.sqlConnection1.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlConnection1);
            DataSet ds = new DataSet("profit");
            adapter.Fill(ds, "profit");
            this.dataGridView1.DataSource = ds.Tables["profit"];
        }
    }
}
