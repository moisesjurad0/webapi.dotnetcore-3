using Microsoft.EntityFrameworkCore;

namespace myAPI.Models
{
    public class myContext : DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("your-postgresql-connection-string");
        }

    }
}
