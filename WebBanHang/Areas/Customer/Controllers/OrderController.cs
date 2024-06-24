using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanHang.Helpers;
using WebBanHang.Models;

namespace WebBanHang.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext _db;
        public OrderController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            Cart cart = HttpContext.Session.GetJson<Cart>("CART");
            if (cart == null)
            {
                cart = new Cart();
            }
            ViewBag.CART = cart;
            return View();
        }
        public IActionResult ProcessOrder(Order order)
        {
            Cart cart = HttpContext.Session.GetJson<Cart>("CART");

            //b1. Lưu trữ đơn hàng
            if (ModelState.IsValid) //kiem tra hop le
            {
                //Them order
                order.OrderDate = DateTime.Now;
                order.Total = cart.Total;
                order.State = "Pending";
                _db.Orders.Add(order);
                _db.SaveChanges();
                //Them orderdetail
                foreach(var item in cart.Items)
                {
                    var orderDetail = new OrderDetail
                    {
                        OrderId = order.Id,
                        ProductId = item.Product.Id,
                        Quantity = item.Quantity
                    };
                    _db.OrderDetails.Add(orderDetail);
                    _db.SaveChanges();
                }
                HttpContext.Session.Remove("CART");

                TempData["success"] = "Category inserted success";
                return View("Result");

            }
          
            ViewBag.CART = cart;
            //b2. Xoá giỏ hàng
            //b3. Hiển thị thông báo
            return View("Index",order);

        }
    }
}
