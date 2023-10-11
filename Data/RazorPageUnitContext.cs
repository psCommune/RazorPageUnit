using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPageUnit.Models;

namespace RazorPageUnit.Data
{
    public class RazorPageUnitContext : DbContext
    {
        public RazorPageUnitContext (DbContextOptions<RazorPageUnitContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPageUnit.Models.Movie> Movie { get; set; } = default!;
    }
}
