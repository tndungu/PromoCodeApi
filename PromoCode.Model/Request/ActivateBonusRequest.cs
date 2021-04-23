using System;
using System.Collections.Generic;
using System.Text;

namespace PromoCode.Model.Request
{
    public class ActivateBonusRequest
    {
        public int UserId { get; set; }
        public string PromoCode { get; set; }
        public string ProductName { get; set; }
    }
}
