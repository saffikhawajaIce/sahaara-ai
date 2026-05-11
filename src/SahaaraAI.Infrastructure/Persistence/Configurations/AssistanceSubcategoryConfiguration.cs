using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SahaaraAI.Domain.Entities;

namespace SahaaraAI.Infrastructure.Persistence.Configurations;

public class AssistanceSubcategoryConfiguration : IEntityTypeConfiguration<AssistanceSubcategory>
{
    public void Configure(EntityTypeBuilder<AssistanceSubcategory> builder)
    {
        builder.ToTable("AssistanceSubcategories");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired().HasMaxLength(150);
        builder.Property(x => x.Description).IsRequired();
        builder.HasOne(x => x.AssistanceCategory)
            .WithMany(x => x.Subcategories)
            .HasForeignKey(x => x.AssistanceCategoryId);
    }
}
