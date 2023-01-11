using M4HW3.Configurats;
using M4HW3.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace M4HW3.Configurations
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Project").HasKey(p => p.ProjectId);
            builder.Property(p => p.ProjectId).ValueGeneratedOnAdd();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(50);
            builder.Property(p => p.Budget).IsRequired().HasColumnType("money");
            builder.Property(p => p.StartedDate).IsRequired();
            builder.HasOne(p => p.Client)
                .WithMany(c => c.Projects)
                .HasForeignKey(p => p.ClientId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(new List<Project>()
            {
                new Project() { ProjectId = 1, Name = "ZDGHJ", Budget = 156, StartedDate = DateTime.Today, ClientId = 2 },
                new Project() { ProjectId = 2, Name = "KLHJ", Budget = 965, StartedDate = DateTime.Today, ClientId = 3 },
                new Project() { ProjectId = 3, Name = "NIRY", Budget = 369, StartedDate = DateTime.Today, ClientId = 1 },
                new Project() { ProjectId = 4, Name = "CVMBN", Budget = 846, StartedDate = DateTime.Today, ClientId = 4 },
                new Project() { ProjectId = 5, Name = "VOK", Budget = 777, StartedDate = DateTime.Today, ClientId = 5 },
            });
        }
    }
}
