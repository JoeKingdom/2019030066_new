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
    public partial class RoomQuery : Form
    {
        public RoomQuery()
        {
            InitializeComponent();
        }
        string strSql;
        SqlConnection sqlConnection1 = new SqlConnection();
        SqlCommand sqlCommand1 = new SqlCommand();

        private void RoomQuery_Load(object sender, EventArgs e)
        {

        }

        private void btQuery_Click(object sender, EventArgs e)
        {
            bool flag = true;
            this.strSql = " select RoomType 类型,Location 位置,Floor 楼层,RatingNum 额定人数," +
                        "TrueNum 实住人数,Area 面积,Price 价格," +
                        " case AirCondition when 1 then '有' when 0 then '无' end 空调," +
                        " case Telephone when 1 then '有' when 0 then '无' end 电话," +
                        " case TV when 1 then '有' when 0 then '无' end 电视," +
                        " case WashRoom when 1 then '有' when 0 then '无' end 卫生间," +
                        " case Kitchen when 1 then '有' when 0 then '无' end 厨房," +
                        " case Internet when 1 then '有' when 0 then '无' end 宽带," +
                        " Remark 备注,RoomID 房屋编号,RenterID 出租人编号" +
                        " from RoomInfo where ";
            if (this.textRoomID.Text != "")
                this.strSql = this.strSql + " RoomID=" + "'" + this.textRoomID.Text + "'";
            else
            {
                if (this.textRoomType.Text != "")
                {
                    this.strSql = this.strSql + " RoomType like " + "'%" + this.textRoomType.Text + "%'";
                    flag = false;
                }
                if (this.textRatingNum.Text != "")
                {
                    if (flag)
                        this.strSql = this.strSql + " RatingNum=" + "'" + this.textRatingNum.Text + "'";
                    else
                        this.strSql = this.strSql + " and RatingNum=" + "'" + this.textRatingNum.Text + "'";
                    flag = false;
                }
                if (this.textTrueNum.Text != "")
                {
                    if (flag)
                        this.strSql = this.strSql + " TrueNum=" + "'" + this.textTrueNum.Text + "'";
                    else
                        this.strSql = this.strSql + " and TrueNum=" + "'" + this.textTrueNum.Text + "'";
                    flag = false;
                }
                if (this.textMinArea.Text != "")
                {
                    if (flag)
                        this.strSql = this.strSql + " Area>=" + "'" + this.textMinArea.Text + "'";
                    else
                        this.strSql = this.strSql + " and Area>=" + "'" + this.textMinArea.Text + "'";
                    flag = false;
                }
                if (this.textMaxArea.Text != "")
                {
                    if (flag)
                        this.strSql = this.strSql + " Area<=" + "'" + this.textMaxArea.Text + "'";
                    else
                        this.strSql = this.strSql + " and Area<=" + "'" + this.textMaxArea.Text + "'";
                    flag = false;
                }
                if (this.textMinPrice.Text != "")
                {
                    if (flag)
                        this.strSql = this.strSql + " Price>=" + this.textMinPrice.Text + "";
                    else
                        this.strSql = this.strSql + " and Price>=" + this.textMinPrice.Text + "";
                    flag = false;
                }
                if (this.textMaxPrice.Text != "")
                {
                    if (flag)
                        this.strSql = this.strSql + " Price<=" + this.textMaxPrice.Text + "";
                    else
                        this.strSql = this.strSql + " and Price<=" + this.textMaxPrice.Text + "";
                    flag = false;
                }
                if (this.textLocation.Text != "")
                {
                    if (flag)
                        this.strSql = this.strSql + " Location like " + "'%" + this.textLocation.Text + "%'";
                    else
                        this.strSql = this.strSql + " and Location like " + "'%" + this.textLocation.Text + "%'";
                    flag = false;
                }
                if (this.textRemark.Text != "")
                {
                    if (flag)
                        this.strSql = this.strSql + " Remark like " + "'%" + this.textRemark.Text + "%'";
                    else
                        this.strSql = this.strSql + " and Remark like " + "'%" + this.textRemark.Text + "%'";
                }
            }
            this.FillDataGrid(strSql);
        }

        private void btNotfull_Click(object sender, EventArgs e)
        {
            this.strSql = " select RoomType 类型,Location 位置,Floor 楼层,RatingNum 额定人数," +
                        "TrueNum 实住人数,Area 面积,Price 价格," +
                        " case AirCondition when 1 then '有' when 0 then '无' end 空调," +
                        " case Telephone when 1 then '有' when 0 then '无' end 电话," +
                        " case TV when 1 then '有' when 0 then '无' end 电视," +
                        " case WashRoom when 1 then '有' when 0 then '无' end 卫生间," +
                        " case Kitchen when 1 then '有' when 0 then '无' end 厨房," +
                        " case Internet when 1 then '有' when 0 then '无' end 宽带," +
                        " Remark 备注,RoomID 房屋编号,RenterID 出租人编号" +
                        " from RoomInfo where RatingNum > TrueNum";
            this.FillDataGrid(strSql);
        }

        private void btEmpty_Click(object sender, EventArgs e)
        {
            this.strSql = " select RoomType 类型,Location 位置,Floor 楼层,RatingNum 额定人数," +
            "TrueNum 实住人数,Area 面积,Price 价格," +
            " case AirCondition when 1 then '有' when 0 then '无' end 空调," +
            " case Telephone when 1 then '有' when 0 then '无' end 电话," +
            " case TV when 1 then '有' when 0 then '无' end 电视," +
            " case WashRoom when 1 then '有' when 0 then '无' end 卫生间," +
            " case Kitchen when 1 then '有' when 0 then '无' end 厨房," +
            " case Internet when 1 then '有' when 0 then '无' end 宽带," +
            " Remark 备注,RoomID 房屋编号,RenterID 出租人编号" +
            " from RoomInfo where TrueNum=0";
            this.FillDataGrid(strSql);
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            this.textLocation.Clear();
            this.textMaxArea.Clear();
            this.textMinArea.Clear();
            this.textMaxPrice.Clear();
            this.textMinPrice.Clear();
            this.textRatingNum.Clear();
            this.textTrueNum.Clear();
            this.textRemark.Clear();
            this.textRoomID.Clear();
            this.textRoomType.Clear();
        }

        private void btCheckIn_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = new Customer();
                dataGridView1[this.dataGridView1.CurrentCell.ColumnIndex, 14].ToString();
                customer.Show();
            }
            catch
            {
                MessageBox.Show("请先选择房间！", "提示");
            }
        }
        public void FillDataGrid(string sql)
        {
            if (this.sqlConnection1.State == ConnectionState.Closed)
                this.sqlConnection1.Open();
            Console.WriteLine(sql);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlConnection1);
            DataSet ds = new DataSet("t_roomQuery");
            adapter.Fill(ds, "t_roomQuery");
            this.dataGridView1.DataSource = ds.Tables["t_roomQuery"];
        }
    }
}
