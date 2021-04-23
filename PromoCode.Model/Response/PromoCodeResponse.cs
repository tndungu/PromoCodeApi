using System;
using System.Collections.Generic;
using System.Text;

namespace PromoCode.Model.Response
{
    public class PromoCodeResponse
    {
        public int Id { get; set; }
        public string PromoCode { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public bool BonusActivated { get; set; }
    }
}
