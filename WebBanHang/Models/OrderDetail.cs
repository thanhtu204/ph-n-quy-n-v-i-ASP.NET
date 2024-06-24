using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebBanHang.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        //Mối kết hợp 1-n
        //[ForeignKey("OrderID")]
        public Order Order { get; set; }
        //[ForeignKey("ProductID")]
        public Product Product { get; set; }
    }
}
