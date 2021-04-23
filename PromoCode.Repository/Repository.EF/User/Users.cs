using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PromoCode.Repository.Repository.EF.User
{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [MaxLength(200)]
        public string Email { get; set; }
        [MaxLength(250)]
        public byte[] PasswordHash { get; set; }
        [MaxLength(250)]
        public byte[] PasswordSalt { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreationTime { get; set; } = DateTime.Now;
    }
}
