using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using ASP_MVC.Models;

namespace ASP_MVC.Models
{
    public class OrderService
    {
        public List<Order> SelectAll()
        {
            //建立Connection物件
            Dao.SqlConnect contect = new Dao.SqlConnect();
            String connStr = contect.GetconnStr();
            SqlConnection conn = new SqlConnection(connStr);
            //撰寫SQL語法
            string sql = "Select * From [Sales].[Orders] As o Join [Sales].[Customers] As c ON o.CustomerID = c.CustomerID";


            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();

            //SqlCommand cmd = new SqlCommand(sql, conn);

            //conn.Open();
            /*
            Models.OrderList orderlist = new Models.OrderList();

            var fakedata = orderlist.GetOrderCondition();

            ViewBag.orderlist = fakedata;
            */
            //ViewBag.orderlist = ds.Tables[0];

            dataAdapter.Fill(ds);
            DataTable DataTable = ds.Tables[0];


            List<Order> list = new List<Order>();
            foreach (DataRow item in DataTable.Rows)
            {
                Order model = new Order
                {
                    OrderID = int.Parse(item["OrderID"].ToString()),
                    CustomerName = item["ContactName"].ToString(),
                    OrderDate = item.Field<DateTime?>("OrderDate"),
                    ShippedDate = item.Field<DateTime?>("ShippedDate"),
                    Freight = Decimal.Parse(item["Freight"].ToString())
                };
                list.Add(model);
            }
            //ViewBag.list = list;
            return list;

        }
    }
}