using Microsoft.EntityFrameworkCore;
using Univera.Models;

namespace Univera.AppData
{
    public partial class UniveraContext:DbContext
    {
        public UniveraContext() { }
        public UniveraContext(DbContextOptions<UniveraContext> options)
     : base(options)
        {
        }

        public virtual DbSet<AdditionalProductGroup> AdditionalProductGroup { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<AmountType> AmountType { get; set; }
        public virtual DbSet<EnumProductStatus> EnumProductStatus { get; set; }
        public virtual DbSet<EnumProductType> EnumProductType { get; set; }
        public virtual DbSet<EnumProductUnit> EnumProductUnit { get; set; }
        public virtual DbSet<ProductGroup> ProductGroup { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=(localdb)\\univera;Initial Catalog=univera;User ID=burha;Trusted_Connection=True;MultipleActiveResultSets=true");
            base.OnConfiguring(optionsBuilder);
            
        }
    }
}
