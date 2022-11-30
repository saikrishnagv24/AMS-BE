using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementSystemAPI.Model
{
    public partial class AmsDBContext: DbContext
    {
        public AmsDBContext() { }
        public AmsDBContext(DbContextOptions<AmsDBContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
            // ...
        }

        public DbSet<Register> Register { get; set; }

        public DbSet<Department> Department { get; set; }
        public DbSet<AssetType> AssetType { get; set; }

        public DbSet<CpuType> CpuType { get; set; }

        public DbSet<RamType> RamType { get; set; }

        public DbSet<HarddiscType> HarddiscType { get; set; }

        public DbSet<AddAsset> AddAsset { get; set; }

        public DbSet<Location> Location { get; set; }

        
    }
}
