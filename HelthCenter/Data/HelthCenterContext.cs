using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HelthCenter.Models
{
    public class HelthCenterContext : DbContext
    {
        public HelthCenterContext (DbContextOptions<HelthCenterContext> options)
            : base(options)
        {
        }

        public DbSet<HelthCenter.Models.Movie> Movie { get; set; }
    }
}
