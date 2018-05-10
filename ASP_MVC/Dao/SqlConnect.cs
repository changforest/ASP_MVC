using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace ASP_MVC.Dao
{
    public class SqlConnect
    {
        public string GetconnStr() {
            
            return System.Configuration.ConfigurationManager.ConnectionStrings["Default"].ConnectionString; 
        }
    }
}