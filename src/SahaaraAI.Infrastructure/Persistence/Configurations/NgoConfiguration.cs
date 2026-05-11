using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SahaaraAI.Domain.Entities;

namespace SahaaraAI.Infrastructure.Persistence.Configurations;

public class NgoConfiguration : IEntityTypeConfiguration<Ngo>
{
    public void Configure(EntityTypeBuilder<Ngo> builder)
    {
        builder.ToTable("Ngos");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
        builder.Property(x => x.City).IsRequired().HasMaxLength(100);
        builder.Property(x => x.Area).IsRequired().HasMaxLength(100);
        builder.Property(x => x.Status).HasConversion<int>();
        builder.HasIndex(x => new { x.City, x.Area });
        builder.HasIndex(x => x.IsActive);
    }
}
