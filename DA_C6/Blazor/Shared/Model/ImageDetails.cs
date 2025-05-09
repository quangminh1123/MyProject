﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blazor.Shared.Model
{
    public class ImageDetails
    {
        [Key]
        public int IDImage { get; set; }

        [ForeignKey("Product")]
        public int IDProduct { get; set; }

        [Column(TypeName ="varchar(150)")]
        public string Image { get; set; }

        public Product Product { get; set; }
    }
}
