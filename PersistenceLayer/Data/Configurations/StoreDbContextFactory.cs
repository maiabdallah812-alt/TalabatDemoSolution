using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace PersistenceLayer.Data
{
    public class StoreDbContextFactory : IDesignTimeDbContextFactory<StoreDbContext>
    {
        public StoreDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<StoreDbContext>();

            
            optionsBuilder.UseSqlServer("Server=DESKTOP-QRU62LQ;Database=TalabatDemo;Trusted_Connection=True;TrustServerCertificate=True;");

            return new StoreDbContext(optionsBuilder.Options);
        }
    }
}
