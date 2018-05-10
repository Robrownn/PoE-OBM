using Microsoft.EntityFrameworkCore;
using PoE_OBM.Models;

namespace PoE_OBM.Data
{
    public class BuildDbContext : DbContext
    {
        public BuildDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<ExileBuild> Builds { get; set; }
        
    }
}