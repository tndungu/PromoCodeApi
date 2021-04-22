using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromoCode.Repository.Repository.EF
{
    class PromoCodeDBContext : DbContext
    {
        public IConfiguration _config;

        public PromoCodeDBContext(DbContextOptions<PromoCodeDBContext> options, IConfiguration config)
            : base(options)
        {
            _config = config;
        }

        public DbSet<User> Users { get; set; }
    }
}
