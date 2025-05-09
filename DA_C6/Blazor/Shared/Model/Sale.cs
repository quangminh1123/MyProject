﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blazor.Shared.Model
{
    public class Sale
    {
        [Key]
        public int IDSale { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập mã khuyến mã ")]
        [RegularExpression("^[^\\s]+$", ErrorMessage = "Mã khuyến mãi không chứa khoảng trắng")]

        public string Name { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập mô tả")]
        [Column(TypeName = "ntext")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tỉ lệ giảm giá")]

        public int DiscountValue { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập giá trị tối thiểu")]

        public int MinAmount { get; set; }
        public int MaxAmount { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập ngày bắt đầu")]

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập số lượng")]

        public int Quantity { get; set; }

        public ICollection<SaleDetails> Details { get; set; }
    }
}
