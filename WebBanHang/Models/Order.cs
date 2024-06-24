using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebBanHang.Models
{
    public class Order
    {
        public int Id{ get; set; }
        public DateTime OrderDate { get; set; }
        [Required(ErrorMessage = "Chưa nhập tên"), StringLength(200)]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "Chưa nhập địa chỉ"), StringLength(200)]
        public string Address { get; set; }
        [Required(ErrorMessage = "Chưa nhập số điện thoại"), StringLength(200)]
        public string Phone { get; set; }
        public double Total { get; set; }
        public string State { get; set; }

    }
}
