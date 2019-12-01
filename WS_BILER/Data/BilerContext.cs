using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WS_BILER.Models
{
    public class BilerContext : DbContext
    {
        public BilerContext (DbContextOptions<BilerContext> options)
            : base(options)
        {
        }

        public DbSet<WS_BILER.Models.CarModel> CarModel { get; set; }
    }
}
