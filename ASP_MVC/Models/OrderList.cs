using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ASP_MVC.Models
{
    public class OrderList
    {
        [DisplayName("訂單編號")]
        public int OrderID { get; set; }
        [DisplayName("客戶名稱")]
        public String CustomerName { get; set; }
        [DisplayName("負責員工名稱")]
        public String EmployeeName { get; set; }
        [DisplayName("訂購日期")]
        public DateTime OrderDate { get; set; }
        [DisplayName("發貨日期")]
        public DateTime ShippedDate { get; set; }
        [DisplayName("運費")]
        public Decimal Freight { get; set; }

        public List<OrderList> GetOrderCondition()
        {
            var Orders = new List<OrderList>()
            {
                new OrderList
                {
                    OrderID = 1,
                    CustomerName = "王小明",
                    OrderDate = Convert.ToDateTime("2018-04-21"),
                    ShippedDate = Convert.ToDateTime("2018-05-04"),
                    Freight = 500
                },
                new OrderList{
                    OrderID = 2,
                    CustomerName = "陳小美",
                    OrderDate = Convert.ToDateTime("2018-05-01"),
                    ShippedDate = Convert.ToDateTime("2018-06-11"),
                    Freight = 200
                }


            };
            return Orders;
        }
    }
}