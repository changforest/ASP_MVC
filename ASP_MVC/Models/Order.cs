using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel;

namespace ASP_MVC.Models
{
    public class Order
    {
        [DisplayName("訂單編號")]
        public int OrderID { get; set; }
        [DisplayName("客戶名稱")]
        public String CustomerName { get; set; }
        [DisplayName("負責員工")]
        public String EmployeeName { get; set; }
        [DisplayName("訂購日期")]
        public DateTime? OrderDate { get; set; }
        [DisplayName("出貨日期")]
        public DateTime? ShippedDate { get; set; }
        [DisplayName("需要日期")]
        public DateTime? NeedDate { get; set; }
        [DisplayName("出貨公司名稱")]
        public String CompanyName { get; set; }
        [DisplayName("運費")]
        public Decimal? Freight { get; set; }
        [DisplayName("出貨國家")]
        public String ShipCountry { get; set; }
        [DisplayName("出貨城市")]
        public String ShipCity { get; set; }
        [DisplayName("出貨地區")]
        public String ShipRegion { get; set; }
        [DisplayName("郵遞區號")]
        public String ShipPostalCode { get; set; }
        [DisplayName("出貨地址")]
        public String ShipAddress { get; set; }
        [DisplayName("出貨說明")]
        public String ShipText { get; set; }
    }
}