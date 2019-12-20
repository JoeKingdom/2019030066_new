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

namespace _2019030066
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection1 = new SqlConnection();
        SqlCommand sqlCommand1 = null;
        string strSql;
        bool add;
        CustomerManage customerManage = new CustomerManage();
        private void btSave_Click(object sender, EventArgs e)
        {
            add = true;
            if (textContractID.Text == "" || textCustomerID.Text == "" || textCustomerRental.Text == "" || textRoomID.Text == "")
            {
                MessageBox.Show("请输入完整信息！", "提示");
                return;
            }
            int customerID = Convert.ToInt16(textCustomerID.Text);
            string customerName = textName.Text;
            string sex = comSex.Text;
            string nativePlace = textNativePlace.Text;
            string IDCard = textIDCard.Text;
            string roomID = textRoomID.Text;
            DateTime indate = Convert.ToDateTime(dateCheckIn.Text);
            DateTime rentalDate = Convert.ToDateTime(dateRental.Text);
            int contractID = Convert.ToInt32(textContractID.Text);
            float customerRental = Convert.ToSingle(textCustomerRental.Text);
            string remark = textRemark.Text;
            if (add)
            {
                customerManage.Customer_Add(customerID, customerName, sex, nativePlace, IDCard, roomID, indate,rentalDate, contractID, customerRental, remark);
                MessageBox.Show("保存成功！");
                FillDataGrid(strSql);
            }
            else
            {
                MessageBox.Show("保存失败！");
            }
            this.add = false;
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            textContractID.Clear();
            textCustomerID.Clear();
            textCustomerRental.Clear();
            textIDCard.Clear();
            textName.Clear();
            textNativePlace.Clear();
            textRemark.Clear();
            comSex.Text = "";
            dateCheckIn.Text = "";
            dateRental.Text = Convert.ToString(DateTime.Now);
        }
        private void FillDataGrid(string sql)
        {
            if (this.sqlConnection1.State == ConnectionState.Closed)
            {
                this.sqlConnection1.Open();
            }
            SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlConnection1);
            DataSet ds = new DataSet("t_customer");
            adapter.Fill(ds, "t_customer");
            this.dataGridView1.DataSource = ds.Tables["t_customer"];
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            strSql = " select CustomerName 客户姓名,Sex 性别,NativePlace 籍贯,IDCard 身份证号,InDate 入住时间," + "RentalDate 交租时间,CustomerRental 月租,ContractID 合同编号,Remark 备注,CustomerID 客户编号," +"RoomID 房屋编号 from Customer where RoomID = " + "'" + textRoomID.Text + "'";
            FillDataGrid(strSql);
        }
    }
}
