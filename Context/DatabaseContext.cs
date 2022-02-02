using appTareas.EntityConfigurations;
using appTareas.Models;
using Microsoft.EntityFrameworkCore;

namespace appTareas.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<Tarea> Tareas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new TareaConfigurations());
                
        }

    }
}
