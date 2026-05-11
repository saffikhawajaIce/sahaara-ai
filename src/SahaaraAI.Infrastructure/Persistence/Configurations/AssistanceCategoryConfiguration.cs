using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SahaaraAI.Domain.Entities;

namespace SahaaraAI.Infrastructure.Persistence.Configurations;

public class AssistanceCategoryConfiguration : IEntityTypeConfiguration<AssistanceCategory>
{
    public void Configure(EntityTypeBuilder<AssistanceCategory> builder)
    {
        builder.ToTable("AssistanceCategories");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired().HasMaxLength(150);
    }
}
