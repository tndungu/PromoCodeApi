using PromoCode.Model.API;
using PromoCode.Model.Request;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PromoCode.Services.Interfaces
{
    public interface IPromoCodeService
    {
        Task<ApiResponse> GetPromoCodesAsync(string query, int pageNumber);
        Task<ApiResponse> ActivateBonusAsync(ActivateBonusRequest model);
    }
}
