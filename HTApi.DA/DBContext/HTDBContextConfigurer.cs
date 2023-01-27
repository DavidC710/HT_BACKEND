
namespace HTApi.DA.DBContext
{
    public static class HTDBContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<HTDBContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<HTDBContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
