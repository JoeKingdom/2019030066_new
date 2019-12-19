/*
*┌────────────────────────────────────┐
*│　描   述：自动生成                                                   
*│　作   者：SunMen                                                                                              
*│　创建时间：2019/12/4 12:53:43                             
*└────────────────────────────────────┘
*┌────────────────────────────────────┐
*│　命名空间: _2019030066.database                                   
*│　类   名：dbConnection                                      
*└────────────────────────────────────┘
* NEVER STOP Coding ！
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019030066.database
{
    class dbconnection
    {
        public dbconnection()
        {

        }
        public static string connection
        {
            get { return "Server=KING-PC\\SQLEXPRESS;DataBase=2019030066;Integrated Security=SSPI;"; }
        }
        /*
         * public static string connection = "Server=KING - PC\\SQLEXPRESS; User Id=sa; Pwd=476051001; DataBase=2019030066;";
        
        */
    }
}
