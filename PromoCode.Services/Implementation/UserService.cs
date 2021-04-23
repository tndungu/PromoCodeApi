using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PromoCode.Model.API;
using PromoCode.Model.Request;
using PromoCode.Repository.Helpers;
using PromoCode.Repository.Repository.EF;
using PromoCode.Repository.Repository.EF.User;
using PromoCode.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PromoCode.Services.Implementation
{
    public class UserService : IUserService
    {
        private PromoCodeDBContext _context;
        public readonly AppSettings _appSettings;

        public UserService(PromoCodeDBContext context, IOptions<AppSettings> appSettings)
        {
            _context = context;
            _appSettings = appSettings.Value;
        }

        public async Task<ApiResponse> Authenticate(UserRequest userRequest)
        {
            var user = await _context.Users.Where(x => x.Email == userRequest.Email).FirstOrDefaultAsync();
            bool valid = false;

            if (user == null)
                return new ApiResponse(HttpStatusCode.Unauthorized) { ResponseMessage = "Username or password incorrect" };

            valid = VerifyPasswordHash(userRequest.Password, user.PasswordHash, user.PasswordSalt);

            if (!valid)
                return new ApiResponse(HttpStatusCode.Unauthorized) { ResponseMessage = "Username or password incorrect" };

            var tokenString = new TokenGen().GenerateTokenJWT(user.Id, user.Id, _appSettings.Secret);

            return new ApiResponse(HttpStatusCode.OK)
            {
                ResponseObject = new
                {
                    User = new
                    {
                        Id = user.Id,
                        Name = user.Name,
                        Email = user.Email,
                        Token = tokenString
                    }
                }
            };
        }
        public Users GetById(int id)
        {
            return _context.Users.Find(id);
        }

        #region Private Methods
        private static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            if (password == null) throw new ArgumentNullException("password");
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Value cannot be empty or whitespace only string.", "password");

            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }
        private static bool VerifyPasswordHash(string password, byte[] storedHash, byte[] storedSalt)
        {
            if (password == null) throw new ArgumentNullException("password");
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Value cannot be empty or whitespace only string.", "password");
            if (storedSalt.Length != 128) throw new ArgumentException("Invalid length of password hash (128 bytes expected).", "passwordHash");
            if (storedHash.Length != 64) throw new ArgumentException("Invalid length of password salt (64 bytes expected).", "passwordHash");

            using (var hmac = new System.Security.Cryptography.HMACSHA512(storedSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != storedHash[i]) return false;
                }
            }

            return true;
        }

        #endregion
    }
}
