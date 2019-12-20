/*
*┌──────────────────────┐
*│　描   述：自动生成                                                   
*│　作   者：SunMen                                                                                              
*│　创建时间：2019/12/17 8:29:38                             
*└──────────────────────┘
*┌──────────────────────┐
*│　命名空间: _2019030066                                   
*│　类   名：RoomManage                                      
*└──────────────────────┘
* NEVER STOP Coding ！
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using _2019030066.database;

namespace _2019030066
{
    class RoomManage
    {
        private SqlConnection sqlConnection1 = null;
        private SqlCommand sqlCommand1 = null;
        private string strSql = null;
        public RoomManage()
        {
            this.sqlConnection1 = new SqlConnection(dbconnection.connection);
            this.sqlCommand1 = new SqlCommand();
            this.sqlCommand1.CommandType = CommandType.Text;
            this.sqlCommand1.Connection = this.sqlConnection1;
        }
        public void room_Add(int roomID, int renterID,string roomtype, string location, string floor, int ratingNum, int trueNum, int area, float price, int airCondition, int telephone, int TV, int washRoom, int kitchen, int internet, string remark)
        {
            this.strSql = "INSERT INTO RoomInfo( RoomID, RenterID, RoomType, Location, Floor, RatingNum, TrueNum, Area," + " Price, AirCondition, Telephone, TV, WashRoom, Kitchen, Internet, Remark)" + " VALUES ('" + roomID + "','" + renterID + "','" + roomtype + "','" + location + "','" + floor + "','" + ratingNum + "','" + trueNum + "','" + area + "','" + price + "','" + airCondition + "','" + telephone + "','" + TV + "','" + washRoom + "','" + kitchen + "','" + internet + "','" + remark + "')";
            this.sqlCommand1.CommandText = this.strSql;
            try
            {
                this.sqlConnection1.Open();
                this.sqlCommand1.ExecuteNonQuery();
            }
            catch (System.Exception E)
            {
                Console.WriteLine(E.ToString());
            }
            finally
            {
                this.sqlConnection1.Close();
            }
        }
    }
}
