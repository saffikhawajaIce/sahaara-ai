using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SahaaraAI.Domain.Entities;

namespace SahaaraAI.Infrastructure.Persistence.Configurations;

public class AssistanceCaseConfiguration : IEntityTypeConfiguration<AssistanceCase>
{
    public void Configure(EntityTypeBuilder<AssistanceCase> builder)
    {
        builder.ToTable("AssistanceCases");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.ApplicantId).IsRequired();
        builder.Property(x => x.Title).IsRequired().HasMaxLength(200);
        builder.Property(x => x.RawDescription).IsRequired();
        builder.Property(x => x.City).IsRequired().HasMaxLength(100);
        builder.Property(x => x.Area).IsRequired().HasMaxLength(100);
        builder.Property(x => x.Status).HasConversion<int>();
        builder.Property(x => x.Urgency).HasConversion<int>();
        builder.Property(x => x.AiReviewStatus).HasConversion<int>();
        builder.HasIndex(x => x.Status);
        builder.HasIndex(x => x.CategoryId);
        builder.HasIndex(x => x.CreatedAt);
        builder.HasOne(x => x.Applicant)
            .WithMany(x => x.Cases)
            .HasForeignKey(x => x.ApplicantId);
    }
}
