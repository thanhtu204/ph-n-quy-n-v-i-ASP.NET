using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebBanHang.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Chưa nhập tên"), StringLength(200)]

        public string Name { get; set; }

        public string Description { get; set; }
        [Range(1, 10000), Required(ErrorMessage = "Chưa nhập giá")]

        public double Price { get; set; }
        [Range(1, 100), Required(ErrorMessage = "Vui lòng chọn dòng sản phẩm")]

        public int CategoryId { get; set; }
        //khai báo mối kết hợp 1-n
        [ForeignKey("CategoryId")]
        public virtual Category Category { set; get; } //khai báo mối kết hợp 1 - nhiều
        public string ImageUrl { get; set; }
    }
}
