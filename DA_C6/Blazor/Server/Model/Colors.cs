﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Blazor.Model
{
    public class Colors
    {
        [Key]
        public int IDColor { get; set; }

        [Required]
        public string Color { get; set; }

        public ICollection<ProductDetails> ProductDetails { get; set; }
    }
}
