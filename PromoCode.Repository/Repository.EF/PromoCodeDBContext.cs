using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PromoCode.Repository.Repository.EF.PromoCode;
using PromoCode.Repository.Repository.EF.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromoCode.Repository.Repository.EF
{
    public class PromoCodeDBContext : DbContext
    {
        public IConfiguration _config;

        public PromoCodeDBContext(DbContextOptions<PromoCodeDBContext> options, IConfiguration config)
            : base(options)
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = GetConnectionString();
            optionsBuilder.UseSqlServer(connectionString);
        }

        private string GetConnectionString()
        {
            return _config.GetConnectionString("PromoCodeContext");
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<BonusActivated> BonusActivated { get; set; }
        public DbSet<Product> PromoCodeProduct { get; set; }
        public DbSet<PromoCodeList> PromoCodeList { get; set; }
    }
}
