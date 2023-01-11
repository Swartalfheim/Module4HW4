using Azure;
using M4HW3.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace M4HW3.Configurations
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Client").HasKey(c => c.ClientId);
            builder.Property(c => c.ClientId).ValueGeneratedOnAdd();
            builder.Property(c => c.Name).IsRequired().HasMaxLength(20);
            builder.Property(c => c.Surname).IsRequired().HasMaxLength(20);
            builder.Property(c => c.Age).IsRequired();
            builder.Property(c => c.Country).IsRequired().HasMaxLength(20);

            builder.HasData(new List<Client>()
            {
                new Client() { ClientId = 1, Name = "Denys", Surname = "Shapka", Age = 22, Country = "Norway" },
                new Client() { ClientId = 2, Name = "Dima", Surname = "Kormyshov", Age = 23, Country = "Uk" },
                new Client() { ClientId = 3, Name = "Nikita", Surname = "Petrov", Age = 21, Country = "Australia" },
                new Client() { ClientId = 4, Name = "Kiril", Surname = "Ivanov", Age = 20, Country = "Germany" },
                new Client() { ClientId = 5, Name = "Artem", Surname = "Shatilo", Age = 24, Country = "Ukraine" },
            });
        }
    }
}
