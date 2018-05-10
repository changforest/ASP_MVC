using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;
using ASP_MVC.Models;

namespace ASP_MVC.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        /// <summary>
        /// 訂單查詢頁面
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 查詢結果頁面
        /// </summary>
        /// <returns>OrderList.cs中的假資料</returns>
        public ActionResult OrderResult()
        {
            Models.OrderService orderservice = new Models.OrderService();
            List<Order> list = orderservice.SelectAll();
            ViewBag.list = list;
            return View();
        }
        /// <summary>
        /// 新增訂單頁面
        /// </summary>
        /// <returns></returns>
        public ActionResult Add()
        {
            List<SelectListItem> CustomerName = new List<SelectListItem>();
            CustomerName.Add(new SelectListItem()
            {
                Value = "CN1",
                Text = "叡揚股份有限公司"
            });
            CustomerName.Add(new SelectListItem()
            {
                Value = "CN2",
                Text = "高雄應用科技大學"
            });

            List<SelectListItem> EmployeeName = new List<SelectListItem>();
            EmployeeName.Add(new SelectListItem()
            {
                Value = "EN1",
                Text = "叡小揚"
            });
            EmployeeName.Add(new SelectListItem()
            {
                Value = "EN2",
                Text = "高小應"
            });

            List<SelectListItem> CompanyName = new List<SelectListItem>();
            CompanyName.Add(new SelectListItem()
            {
                Value = "CN1",
                Text = "叡揚股份有限公司"
            });
            CompanyName.Add(new SelectListItem()
            {
                Value = "CN2",
                Text = "高雄應用科技大學"
            });

            ViewBag.CustomerName = CustomerName;
            ViewBag.EmployeeName = EmployeeName;
            ViewBag.CompanyName = CompanyName;
            return View();
        }
        /// <summary>
        /// 修改訂單頁面
        /// </summary>
        /// <returns></returns>
        public ActionResult Edit()
        {
            List<SelectListItem> CustomerName = new List<SelectListItem>();
            CustomerName.Add(new SelectListItem()
            {
                Value = "CN1",
                Text = "叡揚股份有限公司"
            });
            CustomerName.Add(new SelectListItem()
            {
                Value = "CN2",
                Text = "高雄應用科技大學"
            });

            List<SelectListItem> EmployeeName = new List<SelectListItem>();
            EmployeeName.Add(new SelectListItem()
            {
                Value = "EN1",
                Text = "叡小揚"
            });
            EmployeeName.Add(new SelectListItem()
            {
                Value = "EN2",
                Text = "高小應"
            });

            List<SelectListItem> CompanyName = new List<SelectListItem>();
            CompanyName.Add(new SelectListItem()
            {
                Value = "CN1",
                Text = "叡揚股份有限公司"
            });
            CompanyName.Add(new SelectListItem()
            {
                Value = "CN2",
                Text = "高雄應用科技大學"
            });

            ViewBag.CustomerName = CustomerName;
            ViewBag.EmployeeName = EmployeeName;
            ViewBag.CompanyName = CompanyName;
            return View();
        }
    }
}