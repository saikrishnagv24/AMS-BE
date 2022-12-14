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
    }
}
