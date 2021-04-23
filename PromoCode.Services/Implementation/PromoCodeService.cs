using Microsoft.Extensions.Options;
using PromoCode.Model.API;
using PromoCode.Model.Request;
using PromoCode.Model.Response;
using PromoCode.Repository.Helpers;
using PromoCode.Repository.Repository.EF;
using PromoCode.Repository.Repository.EF.PromoCode;
using PromoCode.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PromoCode.Services.Implementation
{
    public class PromoCodeService : IPromoCodeService
    {
        private PromoCodeDBContext _context;
        public readonly AppSettings _appSettings;

        public PromoCodeService(PromoCodeDBContext context, IOptions<AppSettings> appSettings)
        {
            _context = context;
            _appSettings = appSettings.Value;
        }
        public async Task<ApiResponse> GetPromoCodesAsync()
        {
            var promos =  (from ba in _context.BonusActivated
                          join pp in _context.PromoCodeProduct on ba.ProductId equals pp.ProductId
                          join pcl in _context.PromoCodeList on ba.PromoCodeListId equals pcl.Id

                          select new PromoCodeResponse
                          {
                              Id = ba.Id,
                              PromoCode = pcl.PromoCode,
                              ProductName = pp.ProductName,
                              ProductDescription = pp.ProductDescription,
                              BonusActivated = ba.ActiveFlag
                          }).ToList();

            return new ApiResponse(HttpStatusCode.OK) { ResponseObject = promos };
        }
        public async Task<ApiResponse> ActivateBonusAsync(ActivateBonusRequest model)
        {
            var promoCodeListId = _context.PromoCodeList.Where(x => x.PromoCode == model.PromoCode).FirstOrDefault().Id;
            var productID = _context.PromoCodeProduct.Where(x => x.ProductName == model.ProductName).FirstOrDefault().ProductId;

            BonusActivated bonus = new BonusActivated()
            {
                UserId = model.UserId,
                PromoCodeListId = promoCodeListId,
                ProductId = productID,
                ActiveFlag = true
            };
            _context.BonusActivated.Add(bonus);
            _context.SaveChanges();

            return new ApiResponse(HttpStatusCode.OK) { ResponseObject = "Bonus activated" };
        }
    }
}
