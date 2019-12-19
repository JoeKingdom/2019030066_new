/*
*┌────────────────────────────────┐
*│　描   述：自动生成                                                   
*│　作   者：SunMen                                                                                              
*│　创建时间：2019/12/8 19:44:15                             
*└────────────────────────────────┘
*┌────────────────────────────────┐
*│　命名空间: _2019030066                                   
*│　类   名：RenterManage                                      
*└────────────────────────────────┘
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
    class RenterManage
    {
        private SqlConnection sqlConnection1 = null;
        private SqlCommand sqlCommand1 = null;
        private string strSql = null;
        public RenterManage()
        {
            this.sqlConnection1 = new SqlConnection(dbconnection.connection);
            this.sqlCommand1 = new SqlCommand();
            this.sqlCommand1.CommandType = CommandType.Text;
            this.sqlCommand1.Connection = this.sqlConnection1;
        }
        public void Renter_Add(int renterID, string renterName, float renterRental, int contractID, string contact, string remark)
        {
            this.strSql = "INSERT INTO Renter (RenterID, RenterName, RenterRental, ContractID, Contact,Remark)" + " VALUES('" + renterID + "','" + renterName + "','" + renterRental + "','" + contractID + "','" + contact + "','" + remark + "')";
            this.sqlCommand1.CommandText = this.strSql;
            try
            {
                this.sqlConnection1.Open();
                this.sqlCommand1.ExecuteNonQuery();
            }
            catch (Exception E)
            {
                Console.WriteLine(E.ToString());
            }
            finally
            {
                this.sqlConnection1.Close();
            }
        }
        public bool Renter_Modify(int renterID, string renterName, float renterRental, int contractID, string contact, string remark)
        {
            this.strSql = "UPDATE Renter SET RenterName = " + renterName + "," + "RenterRental = " + renterRental + "," + "ContractID = " + contractID + "," + "Contact = " + contact + "," + "Remark = " + remark + " WHERE RenterID = " + "'" + renterID + "'";
            this.sqlCommand1.CommandText = this.strSql;
            try
            {
                this.sqlConnection1.Open();
                this.sqlCommand1.ExecuteNonQuery();
                return true;
            }
            catch (Exception E)
            {
                Console.WriteLine(E.ToString());
                return false;
            }
            finally
            {
                this.sqlConnection1.Close();
            }
        }
        public void Renter_Del(int renterID)
        {
            this.strSql = "DELETE FROM Renter WHERE RenterID = " + "'" + renterID + "'";
            this.sqlCommand1.CommandText = this.strSql;
            try
            {
                this.sqlConnection1.Open();
                this.sqlCommand1.ExecuteNonQuery();

            }
            catch (Exception E)
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