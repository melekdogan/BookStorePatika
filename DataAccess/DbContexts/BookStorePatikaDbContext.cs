using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DbContexts
{
    public class BookStorePatikaDbContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public BookStorePatikaDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<Book> Books { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connstr = _configuration.GetConnectionString("ConnectionStr");
            base.OnConfiguring
                (
                optionsBuilder.UseSqlServer(connstr)
                );
        }

    }
}
