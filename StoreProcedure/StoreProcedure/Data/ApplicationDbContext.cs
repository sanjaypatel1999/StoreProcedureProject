using Microsoft.EntityFrameworkCore;
using StoreProcedure.Models;

namespace StoreProcedure.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Wendor>Wendors { get; set; }
    }
}
