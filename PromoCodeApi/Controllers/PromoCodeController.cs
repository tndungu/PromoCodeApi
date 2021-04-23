using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PromoCode.Model.API;
using PromoCode.Model.Request;
using PromoCode.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace PromoCode.Api.Controllers
{
    [AllowAnonymous]
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PromoCodeController : ControllerBase
    {
        private IPromoCodeService _promoCodeService;
        public PromoCodeController(IPromoCodeService promoCodeService)
        {
            _promoCodeService = promoCodeService;
        }
        [HttpGet("GetPromoCodes")]
        public Task<ApiResponse> GetPromoCodes()
        {
            try
            {
                return _promoCodeService.GetPromoCodesAsync();
            }
            catch (Exception ex)
            {
                var response = new ApiResponse(HttpStatusCode.InternalServerError) { ResponseMessage = ex.Message };
                return Task.Run(() => response);
            }
        }

        [HttpPost("ActivateBonus")]
        public Task<ApiResponse> ActivateBonus(ActivateBonusRequest model)
        {
            try
            {
                return _promoCodeService.ActivateBonusAsync(model);
            }
            catch (Exception ex)
            {
                var response = new ApiResponse(HttpStatusCode.InternalServerError) { ResponseMessage = ex.Message };
                return Task.Run(() => response);
            }
        }
    }

}
