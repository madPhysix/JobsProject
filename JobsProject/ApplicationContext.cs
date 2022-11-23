using Microsoft.EntityFrameworkCore;

namespace JobsProject {
    public class ApplicationContext : DbContext
    {

        public ApplicationContext(DbContextOptions<ApplicationContext> options):base(options)
        {

        }

        public DbSet<Employees> Employee => Set<Employees>();

        public DbSet<Product> Products => Set<Product>();
     
    }
}