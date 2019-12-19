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
    public partial class Room : Form
        
    {
        public Room()
        {
            InitializeComponent();
        }
        bool add;
        SqlConnection sqlConnection1 = null;
        SqlCommand sqlCommand1 = null;
        string strSql;
        RoomManage roomManage = new RoomManage();
        private void btSave_Click(object sender, System.EventArgs e)
        {
            this.add = true;
            if(textPrice.Text ==""|| textRenterID.Text ==""|| textRoomID.Text =="")
            {
                MessageBox.Show("请输入完整信息!”,”提示");
                return;
            }
            int roomID = Convert.ToInt16(this.textRoomID.Text);
            int renterID = Convert.ToInt16(this.textRenterID.Text);
            String roomtype = this.textRoomType.Text;
            String location = this.textLocation.Text;
            String floor = this.textFloor.Text;
            int ratingNum = Convert.ToInt16(this.textRatingNum.Text);
            int trueNum = Convert.ToInt16(this.textTrueNum.Text);
            int area = Convert.ToInt16(this.textArea.Text);
            float price = Convert.ToSingle(this.textPrice.Text);
            int airCondition = Convert.ToInt16(this.checkAirCondition.Checked);
            int telephone = Convert.ToInt16(this.checkTelephone.Checked);
            int TV = Convert.ToInt16(this.checkTV.Checked);
            int washRoom = Convert.ToInt16(this.checkWashRoom.Checked);
            int kitchen = Convert.ToInt16(this.checkKitchen.Checked);
            int internet = Convert.ToInt16(this.checkInternet.Checked);
            String remark = this.textRemark.Text;


            if(add)
{
                this.roomManage.room_Add(roomID, renterID, roomtype, location, floor, ratingNum, trueNum, area, price, airCondition, telephone, TV, washRoom, kitchen, internet, remark);
                MessageBox.Show("保存成功!");
                this.FillDataGrid(strSql);
            }
            else
{ }
            this.sqlCommand1.CommandText = this.strSql;
            try
{
                this.sqlConnection1.Open();
                this.sqlCommand1.ExecuteNonQuery();
                this.FillDataGrid(this.strSql);
            }
            catch(System.Exception E)
{
                MessageBox.Show(E.ToString());
            }
            finally
{
                this.sqlConnection1.Close();
            }
            this.add = false;
        }
        private void FillDataGrid(string sql)
        {
            if(this.sqlConnection1.State == ConnectionState.Closed)
            {
                this.sqlConnection1.Open();
            }

            Console.WriteLine(sql);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlConnection1);
            DataSet ds = new DataSet("t_room");
            adapter.Fill(ds,"t_room");
            this.dataGridView1.DataSource = ds.Tables["t_room"];
        }

        private void Room_Load(object sender, EventArgs e)
        {
            sqlConnection1 = new SqlConnection(dbconnection.connection);
            this.strSql = "SELECT RoomType 类型,Location 位置,Floor 楼层," + "RatingNum 额定人数,TrueNum 实住人数,Area 面积,Price 价格" + " FROM RoomInfo";
            this.FillDataGrid(strSql);
        }
        private void btNew_Click(object sender, System.EventArgs e)
        {
            this.textArea.Clear();
            this.textFloor.Clear();
            this.textLocation.Clear();
            this.textPrice.Clear();
            this.textRatingNum.Clear();
            this.textRemark.Clear();
            this.textRenterID.Clear();
            this.textRoomID.Clear();
            this.textRoomType.Clear();
            this.textTrueNum.Clear();
            this.checkAirCondition.Checked = false;
            this.checkInternet.Checked = false;
            this.checkKitchen.Checked = false;
            this.checkTelephone.Checked = false;
            this.checkTV.Checked = false;
            this.checkWashRoom.Checked = false;
        }
    }
}
