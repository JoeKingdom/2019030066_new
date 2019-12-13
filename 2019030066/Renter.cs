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
    public partial class Renter : Form
    {
        public Renter()
        {
            InitializeComponent();
        }
        SqlCommand sqlCommand1;
        string strSql;
        bool add;
        RenterManage renterManage = new RenterManage();
        static string SqlStr = "Server=KING-PC\\SQLEXPRESS;User Id=sa;Pwd=476051001;Database=2019030066";
        SqlConnection con = new SqlConnection(SqlStr);

        private void Renter_Load(object sender, EventArgs e)
        {
            this.strSql = "SELECT RenterName 姓名,Contact 联系方式,ContractID 合同编号," + "RenterRental 出租人租金,Remark 备注,RenterID 出租人编号" + " FROM Renter";
            this.FillDataGrid(strSql);
        }
        private void FillDataGrid(string sql)
        {
            string SqlStr = "Server=KING-PC\\SQLEXPRESS;User Id=sa;Pwd=476051001;Database=2019030066";
            SqlConnection con = new SqlConnection(SqlStr);
            con.Open();
            Console.WriteLine(sql);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet("t_renter");
            adapter.Fill(ds, "t_renter");
            this.dataGridView1.DataSource = ds.Tables["t_renter"];
            //this.dataGridView1.DataSource = ds;
            //this.dataGridView1.DataMember = "r_renter";

            //微软datagrid 官方文档：https://docs.microsoft.com/zh-cn/previous-versions/dotnet/netframework-1.1/7d1w6659(v=vs.80)?redirectedfrom=MSDN
            //datagridview :  https://docs.microsoft.com/zh-cn/dotnet/framework/winforms/controls/how-to-bind-data-to-the-windows-forms-datagridview-control?redirectedfrom=MSDN

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string SqlStr = "Server=KING-PC\\SQLEXPRESS;User Id=sa;Pwd=476051001;Database=2019030066";
            SqlConnection con = new SqlConnection(SqlStr);
            con.Open();
            this.add = true;
            if(textContractID.Text == "" || textRenterID.Text == "" || textRenterRental.Text == "")
            {
                MessageBox.Show("请输入完整的信息！", "提示？");
            }
            int renterID = Int16.Parse(this.textRenterID.Text);
            string renterName = this.textRenterName.Text;
            float renterRental = Single.Parse(this.textRenterRental.Text);
            int contractID = Int32.Parse(this.textContractID.Text);
            string contact = this.textContact.Text;
            string remark = this.textRemark.Text;
            if(add)
            {
                this.renterManage.Renter_Add(renterID, renterName, renterRental, contractID, contact, remark);
                MessageBox.Show("保存成功!");
                this.FillDataGrid(this.strSql);
            }
            else
            {
                if(this.renterManage.Renter_Modify(renterID, renterName, renterRental, contractID, contact, remark))
                {
                    MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.FillDataGrid(this.strSql);
                }
                else
                {
                    MessageBox.Show("修改失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            sqlCommand1 = new SqlCommand();
            this.sqlCommand1.CommandText = this.strSql;
            try
            {
                this.con.Open();
                this.sqlCommand1.ExecuteNonQuery();
                this.FillDataGrid(this.strSql);
            }
            catch(System.Exception E)
            {
                MessageBox.Show(E.ToString());
            }
            finally
            {
                this.con.Close();
            }
            this.add = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textContact.Clear();
            this.textContractID.Clear();
            this.textRenterID.Clear();
            this.textRenterName.Clear();
            this.textRenterRental.Clear();
            this.textRemark.Clear();
        }
    }
}
