using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AppStan.Models;

namespace AppStan.Data
{
    public class AppStanContext : DbContext
    {
        public AppStanContext (DbContextOptions<AppStanContext> options)
            : base(options)
        {
        }

        public DbSet<AppStan.Models.Property> Property { get; set; }
    }
}
