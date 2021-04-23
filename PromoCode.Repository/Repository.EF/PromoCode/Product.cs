using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PromoCode.Repository.Repository.EF.PromoCode
{
    public class Product
    {
        public int ProductId { get; set; }
        [MaxLength(200)]
        public string ProductName { get; set; }
        [MaxLength(500)]
        public string ProductDescription { get; set; }
    }
}
