using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SahaaraAI.Domain.Entities;

namespace SahaaraAI.Infrastructure.Persistence.Configurations;

public class NgoServiceConfiguration : IEntityTypeConfiguration<NgoService>
{
    public void Configure(EntityTypeBuilder<NgoService> builder)
    {
        builder.ToTable("NgoServices");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.NgoId).IsRequired();
        builder.Property(x => x.CategoryId).IsRequired();
        builder.HasIndex(x => new { x.CategoryId, x.SubcategoryId });
        builder.HasOne(x => x.Ngo)
            .WithMany(x => x.Services)
            .HasForeignKey(x => x.NgoId);
        builder.HasOne(x => x.Category)
            .WithMany(x => x.NgoServices)
            .HasForeignKey(x => x.CategoryId);
    }
}
