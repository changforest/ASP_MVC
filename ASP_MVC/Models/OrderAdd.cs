using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ASP_MVC.Models
{
    public class OrderAdd
    {
        [DisplayName("客戶名稱")]
        public String CustomerName { get; set; }
        [DisplayName("負責員工名稱")]
        public String EmployeeName { get; set; }
        [DisplayName("訂單日期")]
        public DateTime OrderDate { get; set; }
        [DisplayName("需要日期")]
        public DateTime RequiredDate { get; set; }
        [DisplayName("出貨日期")]
        public DateTime? ShippedDate { get; set; }
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
    }



}
