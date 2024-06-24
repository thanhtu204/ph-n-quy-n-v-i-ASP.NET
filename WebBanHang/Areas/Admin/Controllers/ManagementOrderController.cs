using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanHang.Models;
using WebBanHang.Helpers;

namespace WebBanHang.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ManagementOrderController : Controller
    {

        private readonly ApplicationDbContext _db;
        public ManagementOrderController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SearchPhoneAPI(string Phone)
        {
            var order = _db.Orders.FirstOrDefault(x => x.Phone == Phone);
            if (order != null)
            {
                Order order1 = HttpContext.Session.GetJson<Order>("ORDER");
                if (order1 == null)
                {
                    order1 = new Order();
                }
            
                HttpContext.Session.SetJson("ORDER", order1);
                return Json(new { msg = "Product added to cart" });

            }
            return Json(new { msg = "error" });
        }
    }
}
