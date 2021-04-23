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
    [Authorize]
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public Task<ApiResponse> Authenticate([FromBody] UserRequest userRequest)
        {
            try
            {
                return _userService.Authenticate(userRequest);
            }
            catch (Exception ex)
            {
                var response = new ApiResponse(HttpStatusCode.InternalServerError) { ResponseMessage = ex.Message };
                return Task.Run(() => response);
            }
        }
    }
}
