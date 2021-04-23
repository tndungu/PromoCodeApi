using PromoCode.Model.API;
using PromoCode.Model.Request;
using PromoCode.Repository.Repository.EF.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PromoCode.Services.Interfaces
{
    public interface IUserService
    {
        Task<ApiResponse> Authenticate(UserRequest userRequest);
        Users GetById(int id);
    }
}
