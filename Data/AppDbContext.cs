using Microsoft.EntityFrameworkCore;

namespace Minimotest{
    public class AppDbContext : DbContext
    {
        public DbSet<Todo> Todos {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("DataSource=app.db,Cache=Shared");
    }
}