using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace PreferredElementData
{
    public class DesignTimePreferredElementDbContext : IDesignTimeDbContextFactory<PreferredElementDbContext>
    {
        public PreferredElementDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PreferredElementDbContext>();
            optionsBuilder.UseSqlServer("Server=localhost;Database=PreferredElement;Integrated Security=True;",
                a => a.MigrationsHistoryTable("__EFMigrationsHistory"));

            var context = Activator.CreateInstance(typeof(PreferredElementDbContext), optionsBuilder.Options) as PreferredElementDbContext;
            return context;
        }
    }    
}
