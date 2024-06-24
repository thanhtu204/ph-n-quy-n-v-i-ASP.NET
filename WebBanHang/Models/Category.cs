using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebBanHang.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Chưa nhập dữ liệu"), StringLength(50)]
        public String Name { get; set; }
        [Range(1, 100),Required(ErrorMessage ="Chưa chọn thuộc tính")]
        public int DisplayOrder { get; set; }

    }
}
