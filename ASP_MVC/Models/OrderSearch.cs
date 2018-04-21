using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ASP_MVC.Models
{
    public class OrderSearch
    {
        [DisplayName("訂單編號")]
        public int? OrderID { get; set; }
        [DisplayName("客戶名稱")]
        public String CustomerName { get; set; }
        [DisplayName("負責員工")]
        public String EmployeeName { get; set; }
        [DisplayName("公司名稱")]
        public String CompanyName { get; set; }
        [DisplayName("訂購日期")]
        public DateTime? OrderDate { get; set; }
        [DisplayName("出貨日期")]
        public DateTime? ShippedDate { get; set; }
        [DisplayName("需要日期")]
        public DateTime? NeedDate { get; set; } 
    }
}