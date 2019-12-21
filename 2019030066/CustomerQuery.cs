using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using _2019030066.database;

namespace _2019030066
{
    public partial class CustomerQuery : Form
    {
        public CustomerQuery()
        {
            InitializeComponent();
        }
        string strSql;
        SqlConnection sqlConnection1 = new SqlConnection(dbconnection.connection);
        SqlCommand sqlCommand1 = new SqlCommand();

        private void btQuery_Click(object sender, EventArgs e)
        {
            strSql = " select CustomerName 客户姓名,Sex 性别,NativePlace 籍贯,IDCard 身份证号,InDate 入住时间," + "RentalDate 交租时间,CustomerRental 月租,ContractID 合同编号,Remark 备注,CustomerID 客户编号," + "RoomID 房屋编号 from Customer where ";
            if (textRoomID.Text != "")
                strSql = strSql + "RoomID=" + "'" + textRoomID.Text + "'";
            else if (textCustomerID.Text != "")
                strSql = strSql + "CustomerID=" + "'" + textCustomerID.Text + "'";
            else if (textName.Text != "")
                strSql = strSql + "CustomerName like" + "'%" + textName.Text + "%'";
            else
            {
                MessageBox.Show("请选择查询条件！", "提示");
                return;
            }

            FillDataGrid(strSql);
        }

        private void btAll_Click(object sender, EventArgs e)
        {
            strSql = " select CustomerName 客户姓名,Sex 性别,NativePlace 籍贯,IDCard 身份证号,InDate 入住时间," + "RentalDate 交租时间,CustomerRental 月租,ContractID 合同编号,Remark 备注,CustomerID 客户编号," + "RoomID 房屋编号 from Customer";
            sqlCommand1.CommandText = strSql;
            FillDataGrid(strSql);
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            textCustomerID.Clear();
            textName.Clear();
            textRoomID.Clear();
        }

        public void FillDataGrid(string sql)
        {
            if (sqlConnection1.State == ConnectionState.Closed)
                sqlConnection1.Open();
            DataSet ds = new DataSet("t_customer");
            SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlConnection1);
            adapter.Fill(ds, "t_customer");
            dataGridView1.DataSource = ds.Tables[ "t_customer"];
        }
    }
}
