using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SahaaraAI.Domain.Entities;

namespace SahaaraAI.Infrastructure.Persistence.Configurations;

public class CaseNgoMatchConfiguration : IEntityTypeConfiguration<CaseNgoMatch>
{
    public void Configure(EntityTypeBuilder<CaseNgoMatch> builder)
    {
        builder.ToTable("CaseNgoMatches");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.MatchReason).IsRequired();
        builder.HasOne(x => x.Case)
            .WithMany(x => x.NgoMatches)
            .HasForeignKey(x => x.CaseId);
        builder.HasOne(x => x.Ngo)
            .WithMany(x => x.CaseMatches)
            .HasForeignKey(x => x.NgoId);
    }
}
