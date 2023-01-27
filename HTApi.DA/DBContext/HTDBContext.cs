
namespace HTApi.DA.DBContext
{
    public class HTDBContext : DbContext
    {
        public DbSet<PageConfiguration> PageConfiguration { get; set; }
        public HTDBContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
    }
}
