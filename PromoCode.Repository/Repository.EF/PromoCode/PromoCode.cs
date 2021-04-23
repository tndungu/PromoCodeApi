using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PromoCode.Repository.Repository.EF.PromoCode
{
    public class PromoCodeItem
    {
        public int Id { get; set; }
        [MaxLength(200)]
        public string PromoName { get; set; }
    }
}
