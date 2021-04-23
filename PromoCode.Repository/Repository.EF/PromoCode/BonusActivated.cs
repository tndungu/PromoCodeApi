using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PromoCode.Repository.Repository.EF.PromoCode
{
    public class BonusActivated
    {
        public int Id { get; set; }
        [MaxLength(200)]
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int PromoCodeListId { get; set; }
        public bool ActiveFlag { get; set; }
    }
}
