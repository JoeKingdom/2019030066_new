/*
*┌──────────────────────┐
*│　描   述：自动生成                                                   
*│　作   者：SunMen                                                                                              
*│　创建时间：2019/12/20 22:32:22                             
*└──────────────────────┘
*┌──────────────────────┐
*│　命名空间: _2019030066                                   
*│　类   名：CustomerManage                                      
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
    class CustomerManage
    {
        private SqlConnection sqlConnection1 = null;
        private SqlCommand sqlCommand1 = null;
        private SqlCommand sqlCommand2 = null;
        private string strSql = null;

        public CustomerManage()
        {
            sqlConnection1 = new SqlConnection(dbconnection.connection);
            sqlCommand1 = new SqlCommand();
            sqlCommand1.CommandType = CommandType.Text;
            sqlCommand1.Connection = sqlConnection1;
            sqlCommand2 = new SqlCommand();
            sqlCommand2.CommandType = CommandType.Text;
            sqlCommand2.Connection = sqlConnection1;
        }
        public void Customer_Add(int customerID, string customerName, string sex, string nativePlace, string IDCard, string roomID,DateTime indate, DateTime rentalDate, int contractID, float customerRental, string remark)
        {
            strSql = "INSERT INTO Customer (CustomerID,CustomerName,Sex,NativePlace,IDCard,RoomID,InDate,RentalDate," + "ContractID,CustomerRental,Remark) values (" + customerID + ",'" + customerName + "','" + sex + "','" + nativePlace + "'," +"" + IDCard + "," + roomID + ",'" + indate + "','" + rentalDate + "'," + contractID + "," + customerRental + ",'" + remark + "')";
            sqlCommand1.CommandText = strSql;
            try
            {
                sqlConnection1.Open();
                sqlCommand1.ExecuteNonQuery();
                trueNum_add(roomID);
            }
            catch (System.Exception E)
            {
                Console.WriteLine(E.ToString());
            }
            finally
            {
                sqlConnection1.Close();
            }
        }
        public void trueNum_add(string roomID)
        {
            strSql = "Update RoomInfo Set TrueNum=TrueNum +1 Where RoomID=" + "'" + roomID + "'";
            sqlCommand2.CommandText = strSql;

            try
            {
                if (sqlConnection1.State == ConnectionState.Closed)
                {
                    sqlConnection1.Open();
                }
                sqlCommand2.ExecuteNonQuery();
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                sqlConnection1.Close();
            }
        }
    }
}
