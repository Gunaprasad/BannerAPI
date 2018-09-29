using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace DataAccessLayer.BannerDataAccess
{
    public class BannerContext : DbContext
    {
        private static DbContextOptions<BannerContext> _options;
        //public BannerContext(DbContextOptions<BannerContext> context) : base(context)
        //{
        //    var optionsBuilder = new DbContextOptionsBuilder<BannerContext>();
        //    optionsBuilder.UseInMemoryDatabase("BannerDb");
        //    _options = optionsBuilder.Options;
        //}

        public BannerContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<BannerContext>();
            optionsBuilder.UseInMemoryDatabase("BannerDb");
            _options = optionsBuilder.Options;
        }

        public DbSet<Banner> BannerItems { get; set; }

    }
}
