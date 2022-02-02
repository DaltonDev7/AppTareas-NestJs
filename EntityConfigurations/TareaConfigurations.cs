using appTareas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace appTareas.EntityConfigurations
{
    public class TareaConfigurations : IEntityTypeConfiguration<Tarea>
    {
        public void Configure(EntityTypeBuilder<Tarea> builder)
        {
            builder.ToTable("Tareas");
            builder.HasKey(x => x.Id);

        }
    }
}
