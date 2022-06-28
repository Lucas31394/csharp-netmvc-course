using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using csharp_net_course.Models;

namespace csharp_net_course.Data
{
    public class Csharp_net_courseContext : DbContext
    {
        public Csharp_net_courseContext (DbContextOptions<Csharp_net_courseContext> options)
            : base(options)
        {
        }

        public DbSet<Department>? Department { get; set; }
        public DbSet<SalesRecord>? SalesRecord { get; set; }
        public DbSet<Seller>? Seller { get; set; }
    }
}
